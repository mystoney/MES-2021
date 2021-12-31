using MES.module.BLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MES.module.BLL.StyleFromZYQ;


namespace MES.form.Order
{
    public partial class OrderSelect : txMainFormEnterTab
    {
        public OrderSelect()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 订单新建或选择
        /// </summary>
        /// <param name="i">0新建订单(FromZYQ) 1查看订单(FromMES)</param>
        public OrderSelect(int i)
        {
            FromZYQorMES = i;
            InitializeComponent();
        }

        int customer_state = 2;//默认2 = 生产订单 1=测试工单
        bool ContainUPSDone = false; //默认false = 不包含已推送工单 true=包含已推送工单
        int FromZYQorMES = 0;
        //选中工单的所有信息
        public OrderBll.SelectOrderInfo soi = new OrderBll.SelectOrderInfo();

        //Grid数据源
        DataTable dt_OrderInfoMES = new DataTable();
        

        //用来存放选项清单 I003=1
        public List<string> lst = new List<string>();
        

        private void button1_Click(object sender, EventArgs e)
        { 
            if (GridOrder.Rows.Count == 0){return;}

            if (GridOrder.CurrentRow.Cells["memo_no"].Value.ToString() == "") { return; }

            
            soi.job_num = GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim().Substring(0,7);
            soi.suffix = Convert.ToInt32( GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Substring(GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim().Length - 3));
            soi.Style_no = GridOrder.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
            soi.style_des = GridOrder.CurrentRow.Cells["style_des"].Value.ToString().Trim();
            soi.job_qty = Convert.ToInt32(GridOrder.CurrentRow.Cells["job_qty"].Value.ToString().Trim());
            soi.memo_no = GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim();
            soi.memo_name = GridOrder.CurrentRow.Cells["memo_name"].Value.ToString().Trim();
            soi.customer_state = Convert.ToInt32(GridOrder.CurrentRow.Cells["customer_state"].Value.ToString().Trim());
            soi.customer_state_des = GridOrder.CurrentRow.Cells["customer_state_des"].Value.ToString().Trim();
            soi.manhour = Convert.ToInt32(GridOrder.CurrentRow.Cells["manhour"].Value.ToString().Trim());
            soi.SchemeNo = Convert.ToInt32(GridOrder.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim());
            soi.OpListNo = Convert.ToInt32(GridOrder.CurrentRow.Cells["OpListNo"].Value.ToString().Trim());
            soi.Combination_no = Convert.ToInt32(GridOrder.CurrentRow.Cells["Combination_no"].Value.ToString().Trim());
            soi.GetProductList = Convert.ToInt32(GridOrder.CurrentRow.Cells["GetProductList"].Value.ToString().Trim());
            soi.OrderLock= Convert.ToInt32(GridOrder.CurrentRow.Cells["OrderLock"].Value.ToString().Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void OrderAdd_Load(object sender, EventArgs e)
        {
            GetGridOrderInfo();//customer_state默认2 = 生产订单 1=测试工单
        }    
        private void button4_Click(object sender, EventArgs e)
        {
            OrderAdd oa = new OrderAdd();
            oa.ShowDialog();
        }

        private void ChangeButtonStatus()
        {
            if (GridOrder.Rows.Count == 0)
            {
                button6.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                if (FromZYQorMES == 1){button6.Enabled = false;}
                else{ button6.Enabled = true; }
           }
        }



        private void GetGridOrderInfo()
        {
            if (cb_customer_state.Checked) { customer_state = 1; } else { customer_state = 2; }//customer_state默认2 = 生产订单 1=测试工单
            if (CB_ContainUPSDone.Checked) { ContainUPSDone = true; } else { ContainUPSDone = false; }//ContainUPSDone默认false=不显示已推送工单 true=显示已推送工单
            OrderBll ob = new OrderBll();
            if (dt_OrderInfoMES.Rows.Count > 0) { dt_OrderInfoMES=new DataTable(); }
            dt_OrderInfoMES = ob.nMES_GetOrderList_MES(customer_state, ContainUPSDone);//customer_state默认2 = 生产订单 1=测试工单
            GridOrder.DataSource = dt_OrderInfoMES;
            if (this.GridOrder.Columns.Count == 0)
            {
                this.GridOrder.AddColumn("id", "序号", 40, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOrder.AddColumn("order_no", "工单号", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("Style_no", "款号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("style_des", "款式", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("job_qty", "数量", 60, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("memo_no", "选项号", 180, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("memo_name", "选项说明", 180, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("customer_state", "工单类型", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOrder.AddColumn("customer_state_des", "工单类型说明", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("manhour", "总工时", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("SchemeNo", "生产路线", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("OpListNo", "工序清单", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("Combination_no", "选项组合号", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("GetProductList", "产品清单", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("OrderLock", "锁定", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOrder.AddColumn("job_num", "工单", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOrder.AddColumn("suffix", "行", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);


                // 实现列的锁定功能  
                this.GridOrder.Columns[1].Frozen = true;
            }

            if (GridOrder.Rows.Count != 0)
            {
                this.GridOrder.MultiSelect = false;
                GridOrder.CurrentCell = GridOrder.Rows[0].Cells["order_no"];
            }
        }





        private void button5_Click(object sender, EventArgs e)
        {
            GetGridOrderInfo() ;//customer_state默认2 = 生产订单 1=测试工单
            ChangeButtonStatus();
        }

        private void cb_customer_state_CheckedChanged(object sender, EventArgs e)
        {
            //默认2 = 生产订单 1=测试工单
            if (cb_customer_state.Checked == true)
            {
                customer_state = 1;//测试订单
            }
            else { customer_state = 2; }
            GetGridOrderInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order_no"></param>
        private int nMES_GetOrderInfo(string order_no, string Style_no)
        {
            StyleBll sb = new StyleBll();
            DataTable dt = sb.GetStyleItemList(Style_no);//获取到此款号必须的选项
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请先进入款号管理，设置此款式必须的选项", "提示", MessageBoxButtons.OK);
                return 0;
            }
            else
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
                string memo_name= "";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                        string item_no = dt.Rows[i][0].ToString();
                        string option_no = ol.Find(x => x.Item_No == item_no).Option_No;
                        memo_no = memo_no+item_no + "=" + option_no + " ";
                        string item_name = ol.Find(x => x.Item_No == item_no).Item_Name;
                        string option_name = ol.Find(x => x.Item_No == item_no).Option_Name;
                        memo_name = memo_name + item_name + "=" + option_name + " ";
                        //选项值组合    
                        lst.Add(item_no + "=" + option_no);
                }
                //获取到选项符合的组合号
                int Combination_no = sb.GetOrderCombination(Style_no, memo_no);

                for (int i = 0; i < dt_OrderInfoMES.Rows.Count; i++)
                {
                    if (dt_OrderInfoMES.Rows[i]["order_no"].ToString().Trim()== order_no)
                    {
                        dt_OrderInfoMES.Rows[i]["memo_no"]=memo_no ;
                        dt_OrderInfoMES.Rows[i]["memo_name"] = memo_name;
                        dt_OrderInfoMES.Rows[i]["Combination_no"] = Combination_no;
                    }
                }
                return 1;
            }
        }

        private void nMES_GetProductList(string order_no)
        {
                OrderBll.Return_Message rm = new OrderBll.Return_Message();
                string getordermodel = $@"http://172.16.1.83:7041/ProductionOrderProductListGet?JobNo=" + order_no;
                rm = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpGet(getordermodel));
                if (rm.State == OrderBll.Return_Message.Return_State.Error)
                {
                     MessageBox.Show(rm.Message, "错误", MessageBoxButtons.OK);
                        return;                
                }
             DataTable dt = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(rm.Return_Value);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("获取产品清单时报错", "错误", MessageBoxButtons.OK);
                return;
            }
            else
            {
                string job_num = GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim().Substring(0, 7);
                int suffix = Convert.ToInt32(GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Substring(GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim().Length - 3));
                int job_qty = Convert.ToInt32(GridOrder.CurrentRow.Cells["job_qty"].Value.ToString());

                OrderBll ob = new OrderBll();
                int SaveResult = ob.SaveProductList(job_num,suffix, job_qty,dt);


                if (SaveResult == 1)
                {
                    GridOrder.CurrentRow.Cells["GetProductList"].Value = "1";
 
                    for (int c = 0; c < dt_OrderInfoMES.Rows.Count;c++)
                    {
                        if (dt_OrderInfoMES.Rows[c]["order_no"].ToString().Trim() == order_no)
                        {
                            dt_OrderInfoMES.Rows[c]["GetProductList"] = 1;
                        }
                    }

                    soi.GetProductList = 1;

                }
                else { MessageBox.Show("获取产品清单时报错", "错误", MessageBoxButtons.OK); }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string order_no = GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim();
            string Style_no = GridOrder.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
            if (GridOrder.Rows.Count == 0 || GridOrder.CurrentRow is null) { return; }
            if (GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim() != "" && GridOrder.CurrentRow.Cells["GetProductList"].Value.ToString().Trim() != "0")
            {
                return;
            }
            else
            {
                if (GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim() == "")
                {
                    if (nMES_GetOrderInfo(order_no, Style_no) == 0) { return; }
                }
                if (GridOrder.CurrentRow.Cells["GetProductList"].Value.ToString().Trim() == "0")
                {
                    nMES_GetProductList(order_no);
                }
            }
        }

        private void GridOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string order_no = GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim();
            string Style_no = GridOrder.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
            if (GridOrder.Rows.Count == 0|| GridOrder.CurrentRow is null) { return; }
            if (GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim() != "" && GridOrder.CurrentRow.Cells["GetProductList"].Value.ToString().Trim() != "0")
            { 
                return; 
            }
            else
            {
                if (GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim() == "")
                {
                    if (nMES_GetOrderInfo(order_no, Style_no) == 0) { return; }
                    
                }
              
            }
            if (GridOrder.CurrentRow.Cells["GetProductList"].Value.ToString().Trim() == "0")
            {
                nMES_GetProductList(order_no);
            }
        }

        private void CB_ContainUPSDone_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ContainUPSDone.Checked)
            {
                ContainUPSDone = true;
            }
            else
            {
                ContainUPSDone = false;
            }
            GetGridOrderInfo();
        }
    }
}






