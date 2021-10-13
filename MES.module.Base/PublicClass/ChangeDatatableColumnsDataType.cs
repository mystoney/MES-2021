using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace MES.module.Base.PublicClass
{
    public static class ChangeDatatableColumnsDataType
    {
        /// <summary>
        /// 修改数据表DataTable某一列的类型和记录值(正确步骤：1.克隆表结构，2.修改列类型，3.修改记录值，4.返回希望的结果)
        /// </summary>
        /// <param name="argDataTable">数据表DataTable</param>
        /// <returns>数据表DataTable</returns>  

        public static DataTable ChangeColumnsDataType(DataTable argDataTable,List<UColumnData> ColumnData=null)
        {

          
            DataTable dtResult = new DataTable();
            //克隆表结构
            dtResult = argDataTable.Clone();

            //foreach (DataColumn col in dtResult.Columns)
            //{
            //    Column Cdata = new Column();

            //    Cdata = ColumnData.Find(delegate (Column C)
            //                          {
            //                              return C.ColumnName == col.ColumnName;
            //                          });
            //    if (Cdata!=null)
            //    {
            //        col.DataType = Cdata.ColumnType;
            //    }           
            //}

            
         

            for (int i = 0; i < ColumnData.Count; i++)
            {
                dtResult.Columns[ColumnData[i].ColumnName].DataType = ColumnData[i].ColumnType;
            }

            foreach (DataRow row in argDataTable.Rows)
            {
                DataRow rowNew = dtResult.NewRow();

                foreach (UColumnData C in ColumnData)
                {
                    rowNew[C.ColumnName.ToString()] = Convert.ChangeType(row[C.ColumnName.ToString()], C.ColumnType);
                }

                foreach (DataColumn col in argDataTable.Columns)
                {
                    if (rowNew[col.ColumnName.ToString()]==DBNull.Value)
                    {
                        rowNew[col.ColumnName.ToString()] = row[col.ColumnName.ToString()];
                    }
                }

                dtResult.Rows.Add(rowNew);

            }



            //    foreach (DataRow row in argDataTable.Rows)
            //{
            //    DataRow rowNew = dtResult.NewRow();
            //  rowNew["aa"]=  row[ColumnData[0].ColumnName.ToString()];

              
            //    rowNew["DTBM"] = row["DTBM"];
            //    //修改记录值
            //    rowNew["RQ"] = Convert.ToDateTime(row["RQ"]).ToString("yyyy-MM-dd").ToString();
            //    rowNew["DWBM"] = row["DWBM"];
            //    rowNew["DWMC"] = row["DWMC"];
            //    rowNew["YYID"] = row["YYID"];
            //    rowNew["YYMC"] = row["YYMC"];
            //    rowNew["YXCL"] = row["YXCL"];
            //    dtResult.Rows.Add(rowNew);


            //    Convert.ChangeType(row[ColumnData[0].ColumnName.ToString()], ColumnData[0].ColumnType);
            //}

           
            
            return dtResult;
        }



     


        /// <summary>
        /// 修改数据表DataTable某一列的类型和记录值(正确步骤：1.克隆表结构，2.修改列类型，3.修改记录值，4.返回希望的结果)
        /// </summary>
        /// <param name="argDataTable">数据表DataTable</param>
        /// <returns>数据表DataTable</returns>  

        public static DataTable ChangeColumnsDataType<T>(DataTable argDataTable)
        {


            DataTable dtResult = new DataTable();
            //克隆表结构
            dtResult = argDataTable.Clone();

           

            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties();  //获取泛型的属性

            foreach (PropertyInfo a in propertyInfos)
            {
                try
                {
                    dtResult.Columns[a.Name].DataType = a.PropertyType;
                }
                catch (Exception)
                {
                }
            }

            

          

            foreach (DataRow row in argDataTable.Rows)
            {
                DataRow rowNew = dtResult.NewRow();

                foreach (PropertyInfo a in propertyInfos)
                {
                    try
                    {
                        rowNew[a.Name] = Convert.ChangeType(row[a.Name], a.PropertyType);
                    }
                    catch (Exception )
                    {

                        
                    }
                    
                }

                foreach (DataColumn col in argDataTable.Columns)
                {
                    if (rowNew[col.ColumnName.ToString()] == DBNull.Value)
                    {
                        rowNew[col.ColumnName.ToString()] = row[col.ColumnName.ToString()];
                    }
                }

                dtResult.Rows.Add(rowNew);

            }



            //    foreach (DataRow row in argDataTable.Rows)
            //{
            //    DataRow rowNew = dtResult.NewRow();
            //  rowNew["aa"]=  row[ColumnData[0].ColumnName.ToString()];


            //    rowNew["DTBM"] = row["DTBM"];
            //    //修改记录值
            //    rowNew["RQ"] = Convert.ToDateTime(row["RQ"]).ToString("yyyy-MM-dd").ToString();
            //    rowNew["DWBM"] = row["DWBM"];
            //    rowNew["DWMC"] = row["DWMC"];
            //    rowNew["YYID"] = row["YYID"];
            //    rowNew["YYMC"] = row["YYMC"];
            //    rowNew["YXCL"] = row["YXCL"];
            //    dtResult.Rows.Add(rowNew);


            //    Convert.ChangeType(row[ColumnData[0].ColumnName.ToString()], ColumnData[0].ColumnType);
            //}



            return dtResult;
        }
    }

    public class UColumnData
    {
        public string ColumnName { get; set; }
        public Type ColumnType { get; set; }
        
        // public TypeCode TC { get; set; }
        
        
    }





   
}
