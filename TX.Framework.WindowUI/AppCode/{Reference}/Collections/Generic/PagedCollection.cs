#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Threading;
using System.Collections;

namespace System.Collections.Generic
{
    /// <summary>
    /// (线程安全)提供一个对指定集合进行分页
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedCollection<T> : Lockable
    {
        private const int DEFAULT_PAGE_SIZE = 20;
        private Dictionary<int, List<T>> _InnerDictionary;
        private List<T> _InnerList;
        private int _PageSize;
        private int _Pages;


        public PagedCollection(IEnumerable<T> collection)
            : this(collection, DEFAULT_PAGE_SIZE)
        {
        }

        public PagedCollection(IEnumerable<T> collection, int pageSize)
        {
            _InnerDictionary = new Dictionary<int, List<T>>();
            _InnerList = new List<T>(collection);
            _PageSize = pageSize;
            RefreshPages();
        }

        private void RefreshPages()
        {
            _Pages = _InnerList.Count % _PageSize == 0 ? _InnerList.Count / _PageSize : (_InnerList.Count / _PageSize) + 1;
        }

        private int GetPageLength(int pageIndex)
        {
            if (pageIndex == _Pages && _InnerList.Count % _PageSize != 0)
            {
                return _InnerList.Count - (_Pages - 1) * _PageSize;
            }
            return _PageSize;
        }


        /// <summary>
        /// 获取指定页码的对象集合(浅拷贝)。
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public List<T> this[int pageIndex]
        {
            get
            {
                if (pageIndex > 0 && pageIndex <= _Pages)
                {
                    AquireLock();
                    {
                        if (!_InnerDictionary.ContainsKey(pageIndex))
                        {
                            T[] destinationArray = new T[GetPageLength(pageIndex)];

                            Array.Copy(_InnerList.ToArray(), (pageIndex - 1) * _PageSize, destinationArray, 0, destinationArray.Length);

                            List<T> list = new List<T>(destinationArray);

                            _InnerDictionary[pageIndex] = list;
                        }
                    }
                    ReleaseLock();

                    return _InnerDictionary[pageIndex];
                }
                return new List<T>();
            }
        }
   

        /// <summary>
        /// 获取指定页码、是否原始状态的分页对象集合(浅拷贝)。
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<T> this[int pageIndex, bool refresh]
        {
            get
            {
                if (refresh)
                {
                    if (_InnerDictionary.ContainsKey(pageIndex))
                    {
                        _InnerDictionary.Remove(pageIndex);
                    }
                }
                return this[pageIndex];
            }
        }


        /// <summary>
        /// 获取总页数
        /// </summary>
        public int Pages
        {
            get { return _Pages; }
        }

        /// <summary>
        /// 获取或设置分页的大小
        /// </summary>
        public int PageSize
        {
            get { return _PageSize; }
            set
            {
                _PageSize = value;
                RefreshPages();
            }
        }
    }
}
