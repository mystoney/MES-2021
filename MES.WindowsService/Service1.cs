using MES.module.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MES.WindowsService
{        
    public partial class Service1 : ServiceBase
    {//记录到event log中，地址是 C:\Windows\System32\winevt\Logs (双击查看即可，文件名为MyNewLog)
        private static EventLog eventLog1;
        private int eventId = 1;
        System.Timers.Timer _Timer;  //计时器
        private static object _LockSMS_Send = new object();
        public Service1()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }
        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart.");
            log("In OnStart.");
            // TODO: 在此处添加代码以启动服务。 
            int minute = 5; 
            this._Timer = new System.Timers.Timer(); 
            this._Timer.Interval = minute * 60 * 1000; //设置计时器事件间隔执行时间 
            this._Timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed); 
            this._Timer.Enabled = true;
        }
        /// <summary>
        /// 停止服务
        /// </summary>
        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            eventLog1.WriteEntry("In OnStop.");

            log("In OnStop.");
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            GetOrder();
            eventLog1.WriteEntry("In GetOrder.");
            log("In GetOrder.");

        }




        /// <summary>
        /// 继续服务
        /// </summary>
        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue.");
            log("In OnContinue.");
        }
        private class DateString
        {
            public DateTime beginDate { get; set; }
            public DateTime endDate { get; set; }
        }
        private void GetOrder()
        {
            eventLog1.WriteEntry("In GetOrder-准备开始.");
            log("In GetOrder-准备开始.");
            OrderBll.Return_Message rm_Order = new OrderBll.Return_Message();
            DateString ds = new DateString();
            ds.beginDate = DateTime.Parse(DateTime.Now.AddDays(-30).ToShortDateString());
            ds.endDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            string getordermodel = $@"http://172.16.1.16:9999/api/GetJobNumFromDate?DS={Helper.Json.JsonHelper.SerializeObject(ds)}";
            rm_Order = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
            if (rm_Order.State == OrderBll.Return_Message.Return_State.Error)
            {
                eventLog1.WriteEntry("In GetOrder-获取工单失败.");
                log("In GetOrder-获取工单失败.");
                throw new Exception(rm_Order.Message);
            }
            eventLog1.WriteEntry("In GetOrder-获取工单.");
            log("In GetOrder-获取工单.");
            DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm_Order.Return_Value);

            OrderBll ob = new OrderBll();
            int a = ob.SaveOrderZYQ(dt);//调用ZYQ接口，获取到所有工单
            if (a == 1)
            {
                eventLog1.WriteEntry("In GetOrder-保存工单.");
                log("In GetOrder-保存工单.");
                ob.InsertOrderMaster();//将获取到的工单信息保存到MES_ORDER_MASTER,如果款号已维护，同时保存选项
            }
            ob.SaveOrderOpListNo();//将所有未锁定的订单中，有工单选项，没有工序清单的自动绑定工序清单
            eventLog1.WriteEntry("In GetOrder-保存工单OpListNo.");
            log("In GetOrder-保存工单OpListNo.");
            ob.SaveProductListAll();
            eventLog1.WriteEntry("In GetOrder-保存工单ProductList.");
            log("In GetOrder-保存工单ProductList.");
            eventLog1.WriteEntry("In GetOrder-成功");
            log("In GetOrder-成功");
        }
        /// <summary>
        /// 定时器中定时执行的任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
            log("the timer");
        }
        /// <summary>
        /// 记录到指定路径：D:\log.txt
        /// </summary>
        /// <param name="message"></param>
        private static void log(string message)
        {
            using (FileStream stream = new FileStream("c:\\log.txt", FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
            }
        }
    }
}
