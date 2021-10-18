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
            int a = ob.SaveOrderZYQ(dt);
            if (a == 1)
            {
                ob.SaveOrderMaster();
                MyContrals.WaitFormService.Close();
                MessageBox.Show("成功", "导入工单结果", MessageBoxButtons.OK);
                
                //for (int j = 0; j < dt.Rows.Count; j++)
                //{

                //    OrderBll.SelectOrderInfo soi = new OrderBll.SelectOrderInfo();
                //    soi.job_num = dt.Rows[j]["job_num"].ToString().Trim();
                //    soi.suffix =Convert.ToInt16( dt.Rows[j]["suffix"].ToString());
                //    soi.customer_state= Convert.ToInt16(dt.Rows[j]["customer_state"].ToString().Trim());
                //    soi.customer_state_des = dt.Rows[j]["customer_state_des"].ToString().Trim();
                //    soi.job_qty= Convert.ToInt16(dt.Rows[j]["job_qty"].ToString());
                //    soi.manhour= Convert.ToInt16(dt.Rows[j]["manhour"].ToString());
                //    soi.Style_no = dt.Rows[j]["Style_num"].ToString().Trim();
                //    soi.style_des = dt.Rows[j]["style_des"].ToString().Trim();

                //    StyleBll sb = new StyleBll();
                //    DataTable dt_StyleOptionList = sb.GetStyleItemList(dt.Rows[j]["style_num"].ToString().Trim());//获取到此款号必须的选项
                //    if (dt_StyleOptionList.Rows.Count != 0)
                //    {
                //        string order_no = dt.Rows[j]["job_num"].ToString().Trim() + "-" + dt.Rows[j]["suffix"].ToString().Trim().PadLeft(3, '0');
                //        OrderBll.Return_Message rm_Option = new OrderBll.Return_Message();
                //        string getorderOption = $@"http://172.16.1.83:8024/api/CpOrderSubDetailByJobNum/" + order_no;
                //        rm_Option = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getorderOption));
                //        if (rm_Option.State == OrderBll.Return_Message.Return_State.Error)
                //        {
                //            throw new Exception(rm_Option.Message);
                //        }
                //        DataTable dt_Option = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm_Option.Return_Value);
                //        OrderBll.OrderItemOptionZYQ o = new OrderBll.OrderItemOptionZYQ();
                //        List<OrderBll.OrderItemOptionZYQ> ol = new List<OrderBll.OrderItemOptionZYQ>();
                //        ol = Helper.Json.JsonHelper.DeserializeJsonToObject<List<OrderBll.OrderItemOptionZYQ>>(rm_Option.Return_Value);
                //        string memo_no = "";
                //        string memo_name = "";
                //        List<string> lst = new List<string>();//用于保存nMES_Order_detail_OptionList
                //        for (int i = 0; i < dt_Option.Rows.Count; i++)
                //        {
                //            string item_no = dt_Option.Rows[i][0].ToString();
                //            string option_no = ol.Find(x => x.Item_No == item_no).Option_No;
                //            memo_no = memo_no + item_no + "=" + option_no + " ";
                //            string item_name = ol.Find(x => x.Item_No == item_no).Item_Name;
                //            string option_name = ol.Find(x => x.Item_No == item_no).Option_Name;
                //            memo_name = memo_name + item_name + "=" + option_name + " ";
                //            //选项值组合    
                //            lst.Add(item_no + "=" + option_no);
                //        }
                //        soi.memo_no = memo_no;
                //        soi.memo_name = memo_name;
                //        //获取到选项符合的组合号
                //        soi.Combination_no = sb.GetOrderCombination(soi.Style_no, memo_no);
                //    }
                //    ob.SaveOrderMaster(soi);
                //}
                
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
