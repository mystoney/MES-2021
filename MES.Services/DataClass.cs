using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Services
{
    class DataClass
    {
        ///<summary>
        ///得到ETON数据库连接
        ///</summary>
        ///<param name="EtonServer">ETON服务器的IP地址</param>
        ///<param name="EtonDB">ETON数据库的服务器上的位置</param>
        ///<returns>返回ETON数据库连接</returns>
        ///<remarks></remarks>
        public static System.Data.Odbc.OdbcConnection GetEtonConnect(string EtonServer, string EtonDB)
        {


            System.Data.Odbc.OdbcConnection odbcconn = new System.Data.Odbc.OdbcConnection();


            odbcconn.ConnectionString = ("Driver={INTERSOLV InterBase ODBC Driver (*.gdb)};server=" + EtonServer + ";database=" + EtonServer + ":" + EtonDB + ";uid=eton0;pwd=eton0");
            //odbcconn.ConnectionString = ("Driver={INTERSOLV InterBase ODBC Driver (*.gdb)};server=" + EtonServer + ";database=" + EtonServer + ":" + EtonDB + ";uid=SYSDBA;pwd=masterkey");
            //odbcconn.ConnectionString = ("Driver={INTERSOLV InterBase ODBC Driver (*.gdb)};server=localhost;database=localhost:d:/interbase/ETONDB.gdb;uid=SYSDBA;pwd=masterkey");

            try
            {
                odbcconn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("数据库连接出现错误！" + ex.Message);

            }


            return odbcconn;

        }
    }
}
