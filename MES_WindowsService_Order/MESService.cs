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

namespace MES_WindowsService_Order
{
    public partial class MESService : ServiceBase
    {
        public MESService()
        {
            InitializeComponent();
        }
        string filePath = @"D:\MyServiceLog.txt";
        protected override void OnStart(string[] args)
        {
            //服务开启执行代码
            StartDoSomething();
        }
        private void StartDoSomething()
        {
            System.Timers.Timer timer = new System.Timers.Timer(30000); //间隔5分钟

            timer.AutoReset = true;

            timer.Enabled = false;  //执行一次

            timer.Elapsed += new ElapsedEventHandler(GetOrderInfo);

            timer.Start();

        }
        private void GetOrderInfo(object source, System.Timers.ElapsedEventArgs e)
        {
            DateTime beginDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;
            nMES_GetOrderInfo(beginDate, endDate);
        }
        protected override void OnPause()

        {

            //服务暂停执行代码

            base.OnPause();

        }

        protected override void OnContinue()

        {

            //服务恢复执行代码

            base.OnContinue();

        }

        protected override void OnShutdown()

        {

            //系统即将关闭执行代码

            base.OnShutdown();

        }

        #region 从ZYQ处获取工单对应的信息
        /// <summary>
        /// 获取到工单号清单 并存入数据库表 nMES_Order_zyq_master
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        private void nMES_GetOrderInfo(DateTime beginDate, DateTime endDate)
        {

            OrderBll.Return_Message rm = new OrderBll.Return_Message();

            DateString ds = new DateString();
            ds.beginDate = DateTime.Parse(beginDate.ToShortDateString());
            ds.endDate = DateTime.Parse(endDate.ToShortDateString());
            string getordermodel = $@"http://172.16.1.16:9999/api/GetJobNumFromDate?DS={Helper.Json.JsonHelper.SerializeObject(ds)}";
            rm = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
            if (rm.State == OrderBll.Return_Message.Return_State.Error)
            {
                throw new Exception(rm.Message);
            }
            DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm.Return_Value);

            OrderBll ob = new OrderBll();
            int a = ob.SaveOrderZYQ(dt);
            ob.SaveOrderMaster();//将获取到的工单信息保存到MES_ORDER_MASTER,如果款号已维护，同时保存选项
            ob.SaveProductListAll();
        }
        private class DateString
        {
            public DateTime beginDate { get; set; }
            public DateTime endDate { get; set; }
        }
        #endregion
        protected override void OnStop()
        {

        }   

    }
}
