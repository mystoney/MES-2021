using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.Base.PublicClass
{
    public static class DataTableTOArrayList
    {
        /// <summary>
        /// 将传入的数据表中的数据转换存储SQL语句的ArrayList
        /// </summary>
        /// <param name="dt">传入的数据表</param>
        /// <param name="DestinationTableName">要插入目的库的表名</param>
        /// <returns>返回一个ArrayList，其中是已经转换好的SQL语句</returns>
        public static ArrayList DtToArrayList(DataTable dt,string DestinationTableName)
        {
          

            ArrayList ArraySQL = new ArrayList();

            try
            {
               

                string header = string.Empty;
                string query = string.Empty;
                header = "insert into [" + DestinationTableName + "] (";
                foreach (DataColumn item in dt.Columns)
                {
                    header += "[" + item.ColumnName + "],";
                }
                header = header.Remove(header.Length - 1) + ") values (";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string values = string.Empty;
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (Convert.IsDBNull(dt.Rows[i][j]))
                        {
                            values += "null,";

                        }
                        else
                        { values += "'" + dt.Rows[i][j].ToString() + "',"; }

                    }

                    ArraySQL.Add(header + values.Remove(values.Length - 1) + ")");
                }

                return ArraySQL;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        //Private Function DsTOMes(ByVal dt As DataTable, ByVal DestinationTableName As String) As DataTable

                //    Dim i As Int16 = 0
        //    Dim j As Int16 = 0
     


        //    Dim dt_Sql As New DataTable
        //    Dim Row As DataRow
        //    Try

        //        dt_Sql.Columns.Add("Sql", GetType(String))

        

        //        Return dt_Sql


        //    Catch ex As Exception


        //        Throw New Exception("发生错误！" & ex.Message)

        //    End Try
        //End Function
    }
}
