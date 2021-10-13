using MES.module.Base.PublicClass;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;


namespace WebApplication_Test
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public string getjson(string jsonText1, string jsonText2)
        {            
            JSON js = new JSON();
            string Text = js.jsonstr_onekey(jsonText1, jsonText2);
            return Text;
        }

        //[WebMethod]
        public string DtToJson(DataTable dt)
        {
            JSON js = new JSON();            
            string a=js.DataTableToJson(dt);
            return a;
        }
        //[WebMethod]
        public DataTable JsonToDt(string Json)
        {

            JSON js = new JSON();
           
            DataTable dt=  js.ToDataTableOne(Json);
            dt.TableName = "dtA";
            return dt;
        }


        [WebMethod]
        public string GetStyleItemOption(string JSON)
        {
            return JSON;
        }


        /// <summary>
        /// [{"order_no":"Z210702-002","style_no":"ULM3004","order_qty":"3","StageProduct":"1"}]
        /// </summary>
        /// <param name="OrderList">Json</param>
        /// <returns>成功写入的工单数量</returns>
        [WebMethod]
        public int Insert_Order_TO_MES(string OrderList)
        {
            //2021.6.21
            int OrderlistNum = 0;
            DataTable dt_json = new DataTable();
            DataTable dt_sql = new DataTable();
            try
            {

                dt_sql = DBConn.DataAcess.SqlConn.Query("select order_no from MES_GetOrder").Tables[0];
                
                dt_json = JsonToDt(OrderList);
                DateTime inputdate = DateTime.Now; 
                dt_json.Columns.Add("input_date");
                for (int i = 0; i < dt_json.Rows.Count; i++)
                {
                    dt_json.Rows[i]["input_date"] = inputdate.ToString();

                }
                var normalReceive = from r in dt_json.AsEnumerable()
                                    where
                                    !(from rr in dt_sql.AsEnumerable() select rr.Field<string>("order_no")).Contains(
                                    r.Field<string>("order_no"))
                                    select r;

                if (normalReceive.Count()>0 )
                {
                    DataTable dt = new DataTable();
                    DataTable dt_OrderNo = normalReceive.CopyToDataTable();
                    ArrayList ArraySQL = new ArrayList();
                    ArraySQL = DataTableTOArrayList.DtToArrayList(dt_OrderNo, "MES_GetOrder");
                    string con = DBConn.DataAcess.SqlConn.connectionString;
                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(ArraySQL);
                    OrderlistNum = dt_OrderNo.Rows.Count;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }
            return OrderlistNum;
        }





        /// <summary> /// 将JSON解析成DataSet只限标准的JSON数据 
        /// 例如：Json＝{t1:[{name:'数据name',type:'数据type'}]} 
        /// 或 Json＝{t1:[{name:'数据name',type:'数据type'}],t2:[{id:'数据id',gx:'数据gx',val:'数据val'}]} 
        /// </summary> 
        /// <param name="Json">Json字符串</param> 
        ///  <returns>DataSet</returns> 
        public static DataSet JsonToDataSet(string Json)
        { 
            try 
            {
                DataSet ds = new DataSet(); JavaScriptSerializer JSS = new JavaScriptSerializer();
                object obj = JSS.DeserializeObject(Json);
                Dictionary<string, object> datajson = (Dictionary<string, object>)obj;


                foreach (var item in datajson)
                {
                    DataTable dt = new DataTable(item.Key);
                    object[] rows = (object[])item.Value;
                    foreach (var row in rows)
                    {
                        Dictionary<string, object> val = (Dictionary<string, object>)row;
                        DataRow dr = dt.NewRow();
                        foreach (KeyValuePair<string, object> sss in val)
                        {
                            if (!dt.Columns.Contains(sss.Key))
                            {
                                dt.Columns.Add(sss.Key.ToString());
                                dr[sss.Key] = sss.Value;
                            }
                            else
                                dr[sss.Key] = sss.Value;
                        }
                        dt.Rows.Add(dr);
                    }
                    ds.Tables.Add(dt);
                }
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
