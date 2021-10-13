using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;



namespace MES.module.Base.PublicClass
{
    /// <summary>
    /// Function: 数据扩展类
    /// (
    ///    使用前引用该命名空间，使用：
    ///    DataRow dr = new BUser().GetUser();  
    ///    MO_user mo_user = dr.ToModel<MO_user>();
    ///    DataTable dt = new BUser().GetUsers();
    ///    List<MO_user> list = dt.ToList<Mo_user>();
    /// )
    /// Author:、
    /// Date:   2009-9-25
    /// </summary>
    public static class DataToClass
    {

        /// <summary>
        /// 修改数据表DataTable某一列的类型和记录值(正确步骤：1.克隆表结构，2.修改列类型，3.修改记录值，4.返回希望的结果)
        /// </summary>
        /// <param name="argDataTable">数据表DataTable</param>
        /// <returns>数据表DataTable</returns>  

        public static List<T> DataToList<T>(DataTable argDataTable) where T : new()
        {


            Type type = typeof(T);

            List<PropertyInfo> propertyInfos = new List<PropertyInfo>();

            propertyInfos = type.GetProperties().ToList<PropertyInfo>();

            List<T> t = new List<T>();

            foreach (DataRow row in argDataTable.Rows)
            {
                T model = new T();
            
                propertyInfos.ForEach(p =>
                {
                    try
                    {
                        if (row[p.Name].GetType() != null)
                        {

                            object tempValue = row[p.Name];
                            tempValue = Convert.ChangeType(tempValue, p.PropertyType);

                            p.SetValue(model, tempValue, null);
                        }
                    }
                    catch (Exception )
                    { }
                });

                t.Add(model);

            }


            return t;
          
        }

        /// <summary>
        /// DataRow扩展方法：将DataRow类型转化为指定类型的实体
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns></returns>
        public static T CDataRowToClass<T>(this DataRow dr) where T : class, new()
        {
            return CDataRowToClass<T>(dr, true);
        }


        /// <summary>
        /// DataRow扩展方法：将DataRow类型转化为指定类型的实体
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="dateTimeToString">是否需要将日期转换为字符串，默认为转换,值为true</param>
        /// <returns></returns>
        /// <summary>
        public static T CDataRowToClass<T>(this DataRow dr, bool dateTimeToString) where T : class, new()
        {
            if (dr != null)
                return CDataTableToClass<T>(dr.Table, dateTimeToString).First();
            return null;
        }


        /// <summary>
        /// DataTable扩展方法：将DataTable类型转化为指定类型的实体集合
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns></returns>
        public static List<T> CDataTableToClass<T>(this DataTable dt) where T : class, new()
        {
            return CDataTableToClass<T>(dt, true);
        }


        /// <summary>
        /// DataTable扩展方法：将DataTable类型转化为指定类型的实体集合
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="dateTimeToString">是否需要将日期转换为字符串，默认为转换,值为true</param>
        /// <returns></returns>
        public static List<T> CDataTableToClass<T>(this DataTable dt, bool dateTimeToString) where T : class, new()
        {
            List<T> list = new List<T>();
            
            if (dt != null)
            {
                List<PropertyInfo> infos = new List<PropertyInfo>();
                Array.ForEach<PropertyInfo>(typeof(T).GetProperties(), p =>
                {
                    if (dt.Columns.Contains(p.Name) == true)
                    {
                        infos.Add(p);
                    }
                });
                SetList<T>(list, infos, dt, dateTimeToString);
            }
            return list;
        }

        #region 私有方法
        private static void SetList<T>(List<T> list, List<PropertyInfo> infos, DataTable dt, bool dateTimeToString) where T : class, new()
        {
            foreach (DataRow dr in dt.Rows)
            {
                T model = new T();
                infos.ForEach(p =>
                {
                    if (dr[p.Name] != DBNull.Value)
                    {
                        object tempValue = dr[p.Name];
                        if (dr[p.Name].GetType() == typeof(DateTime) && dateTimeToString == true)
                        {
                            tempValue = dr[p.Name].ToString();
                        }
                        try
                        {
                            p.SetValue(model, tempValue, null);
                            
                        }
                        catch { }
                    }
                });
                list.Add(model);
            }
        }
        #endregion


        
    }
}
