using System;
using System.Collections.Generic;
using System.Data;

using System.Reflection;


namespace MES.module.Base.PublicClass
{
    public static class ClassToTable
    {

        /// <summary>
        /// 将实体类转换为DataTable表
        /// </summary>
        /// <typeparam name="T">实体类的类型</typeparam>
        /// <param name="objlist">要转的实体类</param>
        /// <returns>返回根据实体类生成的数据表</returns>
        public static DataTable ClassToDataTable<T>(IList<T> objlist)
        {
            if (objlist == null || objlist.Count <= 0)
            {
                return null;
            }
            DataTable dt = new DataTable(typeof(T).Name);
            DataColumn column;
            DataRow row;

            System.Reflection.PropertyInfo[] myPropertyInfo = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (T t in objlist)
            {
                if (t == null)
                {
                    continue;
                }

                row = dt.NewRow();

                for (int i = 0, j = myPropertyInfo.Length; i < j; i++)
                {
                    System.Reflection.PropertyInfo pi = myPropertyInfo[i];

                    string name = pi.Name;

                    if (dt.Columns[name] == null)
                    {
                        column = new DataColumn(name, pi.PropertyType);
                        dt.Columns.Add(column);
                    }

                    row[name] = pi.GetValue(t, null);
                }

                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
