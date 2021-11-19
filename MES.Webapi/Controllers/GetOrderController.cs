using MES.module.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static MES.module.BLL.OrderBll;

namespace MES.Webapi.Controllers
{
    public class GetOrderController : ApiController
    {
        // GET: api/GetOrder
        public Return_Message Get()
        {
            Return_Message return_Message = new Return_Message();
            try
            {
                GetOrder();
                
                return_Message.State= Return_Message.Return_State.OK;
                
            }
            catch (Exception ex)
            {

                return_Message.State = Return_Message.Return_State.Error;
                return_Message.Message = ex.Message;
                
            }
            return return_Message;
        }

        // GET: api/GetOrder/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GetOrder
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetOrder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GetOrder/5
        public void Delete(int id)
        {
        }



        /// <summary>
        /// 记录到指定路径：D:\log.txt
        /// </summary>
        /// <param name="message"></param>
        private static void log(string message)
        {
            using (FileStream stream = new FileStream($@"D:\MES_WebApi\MES.GetOrder\log.txt", FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
            }
        }
        private class DateString
        {
            public DateTime beginDate { get; set; }
            public DateTime endDate { get; set; }
        }
        private void GetOrder()
        {
            //EventLog eventLog1;
            //int eventId = 1;

            //eventLog1 = new System.Diagnostics.EventLog();
            //if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            //{
            //    System.Diagnostics.EventLog.CreateEventSource(
            //        "MySource", "MyNewLog");
            //}
            //eventLog1.Source = "MySource";
            //eventLog1.Log = "MyNewLog";

            //eventLog1.WriteEntry("In GetOrder-准备开始.");
            //log("In GetOrder-准备开始.");
            OrderBll.Return_Message rm_Order = new OrderBll.Return_Message();
            DateString ds = new DateString();
            ds.beginDate = DateTime.Parse(DateTime.Now.AddDays(-30).ToShortDateString());
            ds.endDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            string getordermodel = $@"http://172.16.1.16:9999/api/GetJobNumFromDate?DS={Helper.Json.JsonHelper.SerializeObject(ds)}";
            rm_Order = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
            if (rm_Order.State == OrderBll.Return_Message.Return_State.Error)
            {
                //eventLog1.WriteEntry("In GetOrder-获取ZYQ工单失败.");
                //log("In GetOrder-获取ZYQ工单失败.");
                throw new Exception(rm_Order.Message);
            }
            //eventLog1.WriteEntry("In GetOrder-获取ZYQ工单成功.");
            //log("In GetOrder-获取ZYQ工单成功.");
            DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm_Order.Return_Value);

            OrderBll ob = new OrderBll();
            int a = ob.SaveOrderZYQ(dt);//调用ZYQ接口，获取到所有工单
            //if (a == 1)
            //{
                //eventLog1.WriteEntry("In GetOrder-保存MES工单.");
                //log("In GetOrder-保存MES工单.");
                //ob.InsertOrderMaster();//将获取到的工单信息保存到MES_ORDER_MASTER,如果款号已维护，同时保存选项
            //}
            //ob.SaveOrderOpListNo();//将所有未锁定的订单中，有工单选项，没有工序清单的自动绑定工序清单
            //eventLog1.WriteEntry("In GetOrder-保存工单OpListNo.");
            //log("In GetOrder-保存工单OpListNo.");
            //ob.SaveProductListAll();
            //eventLog1.WriteEntry("In GetOrder-保存工单ProductList.");
            //log("In GetOrder-保存工单ProductList.");
            //eventLog1.WriteEntry("In GetOrder-成功");
            //log("In GetOrder-成功");
        }
    }
}
