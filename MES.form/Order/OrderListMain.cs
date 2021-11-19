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
    public partial class OrderListMain : Form
    {
        public OrderListMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OrderAdd oa = new OrderAdd();
            oa.ShowDialog();
            GetGrid_OrderMaster();
        }


        private void OrderListMain_Load(object sender, EventArgs e)
        {
            //设置隔行背景色
            this.GridOrder.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue;

            this.GridUPS.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridUPS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridUPS.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridUPS.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue;

            this.GridProduct.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue;

            this.GridOperation.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridOperation.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridOperation.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridOperation.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue;

            GetGrid_OrderMaster();
            ChangeButton();
        }
        private void GetGrid_OrderMaster()
        {
            int customer_state = 2;//2是正式订单
            if (checkBox_customer_state.Checked) { customer_state = 1; }
            OrderBll ob = new OrderBll();
            DataTable dt_OrderInfoMES = ob.nMES_GetOrderList_MES(customer_state);
            GridOrder.DataSource = dt_OrderInfoMES;
            if (this.GridOrder.Columns.Count == 0)
            {
                this.GridOrder.AddColumn("id", "序号", 40, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOrder.AddColumn("order_no", "工单号", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
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

        private void GetGrid_UPS(int SchemeNo)
        {
            SchemeBll sc = new SchemeBll();
            DataTable dt_UPS = sc.GetSchemeList_detail(SchemeNo.ToString());
            if (this.GridUPS.Columns.Count == 0)
            {
                this.GridUPS.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("Eton_WorkStation", "工作站", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("SchemeOperationNo", "工序代码", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("SchemeOperationDes", "描述", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("op_des", "类型描述", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("SchemeNo", "方案号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("Eton_Line", "生产线", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("op_type", "类型代码", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridUPS.Columns[0].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridUPS.AllowUserToResizeRows = false;
            }
            GridUPS.DataSource = dt_UPS;
        }

        private void GetGridOperation(int OpListNo)
        {
            OperationBLL  sb = new OperationBLL();
            DataTable dt_OpListNo = sb.GetOpList(OpListNo);

            if (this.GridOperation.Columns.Count == 0)
            {
                this.GridOperation.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperation.AddColumn("OpListNo", "工序清单号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperation.AddColumn("OperationNo", "工序号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperation.AddColumn("OperationDes", "工序描述", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperation.AddColumn("OperationType", "工序类型", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperation.AddColumn("manhour", "工时", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperation.AddColumn("GST_xh", "工序序号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridOperation.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridOperation.AllowUserToResizeRows = false;
            }
            GridOperation.DataSource = dt_OpListNo;
        }
        private void GetGridProduct(string job_num,int suffix)
        {
            OrderBll  sb = new OrderBll();
            DataTable dt_Product = sb.GetProductListDT(job_num, suffix);

            if (this.GridProduct.Columns.Count == 0)
            {
                this.GridProduct.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProduct.AddColumn("ProductCode", "产品编号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProduct.AddColumn("UPS_prun", "吊挂订单", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProduct.AddColumn("PushState_JINGYUAN", "推送J", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProduct.AddColumn("PushState_CAOBO", "推送C", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);


                // 实现列的锁定功能  
                this.GridProduct.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridProduct.AllowUserToResizeRows = false;
            }
            GridProduct.DataSource = dt_Product;
        }

        private void GridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void checkBox_customer_state_CheckedChanged(object sender, EventArgs e)
        {
            GetGrid_OrderMaster();
        }

 
        private class DateString
        {
            public DateTime beginDate { get; set; }
            public DateTime endDate { get; set; }
        }
        
        /// <summary>
        /// 只获取ZYQ接口提供的工单 不保存到MES订单表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewOrder_Click(object sender, EventArgs e)
        {
            MyContrals.WaitFormService.Show(this);
            MyContrals.WaitFormService.SetLeftText("运行中");
            MyContrals.WaitFormService.SetProgressBarMax(2, "运行中：");
            //MyContrals.WaitFormService.SetRightText("righttext");
            MyContrals.WaitFormService.SetTopText("请稍候......");
            OrderBll.Return_Message rm_Order = new OrderBll.Return_Message();
            DateString ds = new DateString();
            ds.beginDate = DateTime.Parse(DateTime.Now.AddDays(-7).ToShortDateString());
            ds.endDate = DateTime.Parse(DateTime.Now.ToShortDateString());
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
            ob.SaveOrderOpListNo();//将所有未锁定的订单中，有工单选项，没有工序清单的自动绑定工序清单
            ob.SaveProductListAll();
        }



        private void GridOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StyleBll sb = new StyleBll();
            OrderBll ob = new OrderBll();
            string Style_no = GridOrder.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
            string order_no = GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim();
            string job_num = order_no.Substring(0, 7);
            int suffix = Convert.ToInt16(order_no.Substring(order_no.Length - 3, 3).Trim());
            if (GridOrder.CurrentRow.Cells["Combination_no"].Value.ToString().Trim() == "0")
            {
                DataTable dt = sb.GetStyleItemList(Style_no);//获取到此款号必须的选项
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("请先进入款号管理，设置此款式必须的选项", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    ob.UpdateOrderOption(job_num, suffix);
                }
            }
            string CurrentRowID = GridOrder.CurrentRow.Cells["id"].Value.ToString();

            RefreshAndSelect(CurrentRowID);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MyContrals.WaitFormService.Show(this);
            MyContrals.WaitFormService.SetLeftText("运行中");
            MyContrals.WaitFormService.SetProgressBarMax(2, "运行中：");
            MyContrals.WaitFormService.SetTopText("请稍候......");
            OrderBll ob = new OrderBll();
            if (GridOrder.Rows.Count == 0) { return; }
            if (GridOrder.CurrentRow.Cells["Combination_no"].Value.ToString().Trim() == "0")
            { //没有获取工单选项
                ob.UpdateOrderOption();                
            }
            
            if (GridOrder.CurrentRow.Cells["GetProductList"].Value.ToString().Trim() == "0")
            { //没有获取工单产品清单
                string order_no = GridOrder.CurrentRow.Cells["order_no"].Value.ToString().Trim();
                string job_num = order_no.Substring(0, 7);
                int suffix = Convert.ToInt16(order_no.Substring(order_no.Length - 3, 3).Trim());
                GetGridProduct(job_num, suffix);
            }
            ob.SaveOrderOpListNo();
            GetGrid_OrderMaster();
            MyContrals.WaitFormService.Close();
        }

        private void ButtonNewOrder_Click_1(object sender, EventArgs e)
        {
            if (GridOrder.CurrentRow.Cells["OrderLock"].Value.ToString().Trim()=="1")
            {
                return;
            }
            else if (GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim() == "")
            {
                return;
            }
            else if (Convert.ToInt16(GridOrder.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim()) != 0)
            {
                DialogResult keynn = MessageBox.Show("需要更换现在绑定的生产路线吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (keynn == DialogResult.Cancel)
                {
                    return;
                }                
            }
            OrderBll.SelectOrderInfo soi = new OrderBll.SelectOrderInfo();
            soi.job_num = GridOrder.CurrentRow.Cells["job_num"].Value.ToString().Trim();
            soi.suffix =Convert.ToInt16(GridOrder.CurrentRow.Cells["suffix"].Value);
            soi.Style_no= GridOrder.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
            soi.style_des = GridOrder.CurrentRow.Cells["style_des"].Value.ToString().Trim();
            soi.memo_no= GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim();
            soi.memo_name = GridOrder.CurrentRow.Cells["memo_name"].Value.ToString().Trim();
            soi.SchemeNo= Convert.ToInt16(GridOrder.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim());
            soi.job_qty = Convert.ToInt16(GridOrder.CurrentRow.Cells["job_qty"].Value.ToString().Trim());
            soi.Combination_no= Convert.ToInt16(GridOrder.CurrentRow.Cells["Combination_no"].Value.ToString().Trim());
            OrderSelectScheme oss = new OrderSelectScheme(soi);
            DialogResult f1 = oss.ShowDialog();
            if (f1 == DialogResult.OK)
            {
                string CurrentRowID = GridOrder.CurrentRow.Cells["id"].Value.ToString();
                RefreshAndSelect(CurrentRowID);
                oss.Close();
            }
        }
        private void RefreshAndSelect(string CurrentRowID)
        {
            
            GetGrid_OrderMaster();
            // Linq模糊查询 

            IEnumerable<DataGridViewRow> enumerableList = this.GridOrder.Rows.Cast<DataGridViewRow>();
            List<DataGridViewRow> list = (from item in enumerableList
                                          where item.Cells["id"].Value.ToString().IndexOf(CurrentRowID) >= 0
                                          select item).ToList();
            if (list.Count > 0)
            {
                int matchedRowIndex = list[0].Index;
                GridOrder.FirstDisplayedScrollingRowIndex = matchedRowIndex;
                GridOrder.Rows[matchedRowIndex].Selected = true;
                GridOrder.CurrentCell = GridOrder.Rows[matchedRowIndex].Cells["id"];
                GridOrder.CurrentRow.Selected = true;
            }
            int SchemeNo = Convert.ToInt16(GridOrder.CurrentRow.Cells["SchemeNo"].Value);
            GetGrid_UPS(SchemeNo);
            int OpListNo = Convert.ToInt16(GridOrder.CurrentRow.Cells["OpListNo"].Value);
            GetGridOperation(OpListNo);
            string job_num = GridOrder.CurrentRow.Cells["job_num"].Value.ToString().Trim();
            int suffix = Convert.ToInt16(GridOrder.CurrentRow.Cells["suffix"].Value.ToString().Trim());
            GetGridProduct(job_num, suffix);
            ChangeButton();
        }

        private void ButtonToMES_Click(object sender, EventArgs e)
        {
            OrderBll.SelectOrderInfo soi = new OrderBll.SelectOrderInfo();
            soi.job_num = GridOrder.CurrentRow.Cells["job_num"].Value.ToString().Trim();
            soi.suffix = Convert.ToInt16(GridOrder.CurrentRow.Cells["suffix"].Value);
            soi.Style_no = GridOrder.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
            soi.style_des = GridOrder.CurrentRow.Cells["style_des"].Value.ToString().Trim();
            soi.memo_no = GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim();
            soi.memo_name = GridOrder.CurrentRow.Cells["memo_name"].Value.ToString().Trim();
            soi.SchemeNo = Convert.ToInt16(GridOrder.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim());
            soi.job_qty = Convert.ToInt16(GridOrder.CurrentRow.Cells["job_qty"].Value.ToString().Trim());
            soi.Combination_no = Convert.ToInt16(GridOrder.CurrentRow.Cells["Combination_no"].Value.ToString().Trim());
            soi.manhour = Convert.ToInt16(GridOrder.CurrentRow.Cells["manhour"].Value.ToString().Trim());
            soi.OpListNo = Convert.ToInt16(GridOrder.CurrentRow.Cells["OpListNo"].Value.ToString().Trim());
            soi.OrderLock = Convert.ToInt16(GridOrder.CurrentRow.Cells["OrderLock"].Value.ToString().Trim());
            soi.GetProductList = Convert.ToInt16(GridOrder.CurrentRow.Cells["GetProductList"].Value.ToString().Trim());
            OrderBll ob = new OrderBll();
            if (soi.OpListNo == 0)
            {
                MessageBox.Show("请先保存订单对应的工序清单", "请重试", MessageBoxButtons.OK);
                return;
            }
            else
            {           
                //1.1 工序清单：保存到nMES_Order_detail_OperationList
                int R_SaveOrderOperationList = ob.SaveOrderOperationList(soi.job_num, soi.suffix, soi.OpListNo,soi.Combination_no);
                if (R_SaveOrderOperationList == 1)
                {
                    OrderToUPS OA = new OrderToUPS(soi);
                    OA.ShowDialog();
                        string CurrentRowID = GridOrder.CurrentRow.Cells["id"].Value.ToString();
                        RefreshAndSelect(CurrentRowID);
                        OA.Close();                
                }
                else
                {
                    MessageBox.Show("保存订单对应的工序清单没有成功", "请重试", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void ChangeButton()
        {
            //刷新按钮状态
            if (Convert.ToInt16(GridOrder.CurrentRow.Cells["OrderLock"].Value.ToString().Trim()) == 1)
            {
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                ButtonSelectScheme.Enabled = false;
                ButtonToMES.Enabled = true;
                return;
            }
            //没有获得工单选项：
            if (GridOrder.CurrentRow.Cells["memo_no"].Value.ToString().Trim() == "")
            {
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                ButtonSelectScheme.Enabled = false;
                ButtonToMES.Enabled = false;
                return;
            }
            //没有对应的款式和组合：
            else if (Convert.ToInt16(GridOrder.CurrentRow.Cells["Combination_no"].Value.ToString().Trim()) == 0)
            {
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                ButtonSelectScheme.Enabled = false;

                ButtonToMES.Enabled = false;
                return;
            }
            //没有对应的生产路线
            else if (Convert.ToInt16(GridOrder.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim()) == 0)
            {
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                ButtonSelectScheme.Enabled = true;

                ButtonToMES.Enabled = false;
                return;
            }
            //else if()
            //{
            //    toolStripButton1.Enabled = false;
            //    toolStripButton2.Enabled = false;
            //    ButtonSelectScheme.Enabled = false;

            //    ButtonToMES.Enabled = false;

            //}
            else
            {
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                ButtonSelectScheme.Enabled = true;

                ButtonToMES.Enabled = true;
            }


        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
