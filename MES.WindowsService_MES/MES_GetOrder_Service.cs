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

namespace MES.WindowsService_MES
{
    public partial class MES_GetOrder_Service : ServiceBase
    {
        public MES_GetOrder_Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {            
            //服务开启执行代码
            StartDoSomething();
        }
        private void StartDoSomething()
        {
            System.Timers.Timer timer = new System.Timers.Timer(14400000); //间隔1小时

            timer.AutoReset = true;

            timer.Enabled = false;  //执行一次

            timer.Elapsed += new ElapsedEventHandler(GetOrderInfo);

            timer.Start();

        }
        private void GetOrderInfo(object source, System.Timers.ElapsedEventArgs e)

        {

            try

            {
                DateTime beginDate= DateTime.Now.AddDays(-7);
                DateTime endDate = DateTime.Now;
                nMES_GetOrderInfo(beginDate, endDate);




            }

            catch

            {

            }

            finally

            {

               

            }

        }

    



        protected override void OnStop()
        {
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
            if (a == 1)
            {
                //成功导入
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                }


            }
            else
            {
                //MessageBox.Show("没有成功，请重试", "导入工单结果", MessageBoxButtons.OK);
            }

        }
        private class DateString
        {
            public DateTime beginDate { get; set; }
            public DateTime endDate { get; set; }
        }
        #endregion

        //用来存放选项清单 I003=1
        public List<string> lst = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order_no"></param>
        private void nMES_GetOrderInfo(string order_no, string Style_no)
        {
            StyleBll sb = new StyleBll();
            DataTable dt = sb.GetStyleItemList(Style_no);//获取到此款号必须的选项
            if (dt.Rows.Count > 0)
            {
                if (lst.Count > 0) { lst.Clear(); }
                //string order_no= job_num+"-"+ suffix.ToString().PadLeft(3, '0');
                OrderBll.Return_Message rm = new OrderBll.Return_Message();
                string getordermodel = $@"http://172.16.1.83:8024/api/CpOrderSubDetailByJobNum/" + order_no;
                rm = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
                if (rm.State == OrderBll.Return_Message.Return_State.Error)
                {
                    throw new Exception(rm.Message);
                }
                //DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm.Return_Value);
                OrderBll.OrderItemOptionZYQ o = new OrderBll.OrderItemOptionZYQ();
                List<OrderBll.OrderItemOptionZYQ> ol = new List<OrderBll.OrderItemOptionZYQ>();
                ol = Helper.Json.JsonHelper.DeserializeJsonToObject<List<OrderBll.OrderItemOptionZYQ>>(rm.Return_Value);
                string memo_no = "";
                string memo_name = "";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string item_no = dt.Rows[i][0].ToString();
                    string option_no = ol.Find(x => x.Item_No == item_no).Option_No;
                    memo_no = memo_no + item_no + "=" + option_no + " ";
                    string item_name = ol.Find(x => x.Item_No == item_no).Item_Name;
                    string option_name = ol.Find(x => x.Item_No == item_no).Option_Name;
                    memo_name = memo_name + item_name + "=" + option_name + " ";
                    //选项值组合    
                    lst.Add(item_no + "=" + option_no);
                }
                //获取到选项符合的组合号
                int Combination_no = sb.GetOrderCombination(Style_no, memo_no);

                //for (int i = 0; i < dt_OrderInfoZYQ.Rows.Count; i++)
                //{
                //    if (dt_OrderInfoZYQ.Rows[i]["order_no"].ToString().Trim() == order_no)
                //    {
                //        dt_OrderInfoZYQ.Rows[i]["memo_no"] = memo_no;
                //        dt_OrderInfoZYQ.Rows[i]["memo_name"] = memo_name;
                //        dt_OrderInfoZYQ.Rows[i]["Combination_no"] = Combination_no;
                //    }
                //}
            }
        }

        private void nMES_GetProductList(string order_no)
        {
            OrderBll.Return_Message rm = new OrderBll.Return_Message();
            string getordermodel = $@"http://172.16.1.83:7041/ProductionOrderProductListGet?JobNo=" + order_no;
            rm = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
            if (rm.State == OrderBll.Return_Message.Return_State.Error)
            {
                throw new Exception(rm.Message);
            }
            DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm.Return_Value);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            else
            {
                //string job_num = GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim().Substring(0, 7);
                //int suffix = Convert.ToInt32(GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Substring(GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim().Length - 3));

                //OrderBll ob = new OrderBll();
                //int SaveResult = ob.SaveProductList(job_num, suffix, dt);


                //if (SaveResult == 1)
                //{
                //    GridOrder.CurrentRow.Cells["GetProductList"].Value = "1";
                //    for (int c = 0; c < dt_OrderInfoZYQ.Rows.Count; c++)
                //    {
                //        if (dt_OrderInfoZYQ.Rows[c]["order_no"].ToString().Trim() == order_no)
                //        {
                //            dt_OrderInfoZYQ.Rows[c]["GetProductList"] = 1;
                //        }
                //    }
                //    for (int c = 0; c < dt_OrderInfoMES.Rows.Count; c++)
                //    {
                //        if (dt_OrderInfoMES.Rows[c]["order_no"].ToString().Trim() == order_no)
                //        {
                //            dt_OrderInfoMES.Rows[c]["GetProductList"] = 1;
                //        }
                //    }

                //    soi.GetProductList = 1;

                //}
                //else { MessageBox.Show("获取产品清单时报错", "错误", MessageBoxButtons.OK); }
            }
        }




    }
}
