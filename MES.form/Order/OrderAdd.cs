using MES.module.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.form.Order
{
    public partial class OrderAdd : Form
    {
        public OrderAdd()
        {
            InitializeComponent();
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            nMES_GetOrderInfo(dtp_beginDate.Value, dtp_endDate.Value);

        }

        #region 从ZYQ处获取工单对应的信息

 

        /// <summary>
        /// 获取到工单号清单 并存入数据库表 nMES_Order_zyq_master
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        private void nMES_GetOrderInfo(DateTime beginDate, DateTime endDate)
        {
            MyContrals.WaitFormService.Show(this);
            MyContrals.WaitFormService.SetLeftText("运行中");
            MyContrals.WaitFormService.SetProgressBarMax(2, "运行中：");
            //MyContrals.WaitFormService.SetRightText("righttext");
            MyContrals.WaitFormService.SetTopText("请稍候......");
            OrderBll.Return_Message rm_Order = new OrderBll.Return_Message();
            DateString ds = new DateString();
            ds.beginDate = DateTime.Parse(beginDate.ToShortDateString());
            ds.endDate = DateTime.Parse(endDate.ToShortDateString());
            string getordermodel = $@"http://172.16.1.16:9999/api/GetJobNumFromDate?DS={Helper.Json.JsonHelper.SerializeObject(ds)}";
            rm_Order = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
            if (rm_Order.State == OrderBll.Return_Message.Return_State.Error)
            {
                throw new Exception(rm_Order.Message);
            }
            DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm_Order.Return_Value);

            OrderBll ob = new OrderBll();
            int a = ob.SaveOrderZYQ(dt);//调用ZYQ接口，获取到所有工单
            if (a == 1)
            {
                ob.InsertOrderMaster();//将获取到的工单信息保存到MES_ORDER_MASTER,如果款号已维护，同时保存选项
                MyContrals.WaitFormService.Close();
                MessageBox.Show("成功", "导入工单结果", MessageBoxButtons.OK);                
            }
            else
            {
                MyContrals.WaitFormService.Close();
                MessageBox.Show("没有成功，请重试", "导入工单结果", MessageBoxButtons.OK);
            }
            this.Close();
        }
        private class DateString
        {
            public DateTime beginDate { get; set; }
            public DateTime endDate { get; set; }
        }
        #endregion
    }
}
