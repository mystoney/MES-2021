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
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ToRangeAttribute : Attribute
    {
        private string _StartCellAddress;
        private string _EndCellAddress;

        public ToRangeAttribute(string startCellAddress, string endCellAddress)
        {
            _StartCellAddress = startCellAddress;
            _EndCellAddress = endCellAddress;
        }

        public string StartCellAddress
        {
            get { return _StartCellAddress; }
        }

        public string EndCellAddress
        {
            get { return _EndCellAddress; }
        }
    }
}
