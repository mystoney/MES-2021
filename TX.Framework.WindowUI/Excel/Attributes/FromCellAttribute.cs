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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Office.Excel
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FromCellAttribute : Attribute
    {
        private Category _Category = Category.Formatted;
        private string _CellAddress;

        public FromCellAttribute(string cellAddress)
        {
            _CellAddress = cellAddress;
        }

        public FromCellAttribute(string cellAddress, Category category)
        {
            _CellAddress = cellAddress;
            _Category = category;
        }

        public Category Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        public string CellAddress
        {
            get { return _CellAddress; }
        }
    }
}

