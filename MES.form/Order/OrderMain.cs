using MES.module.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.form.Order
{
    public partial class OrderMain : Form
    {
        OrderBll.SelectOrderInfo soi = new OrderBll.SelectOrderInfo();
        public OrderMain()
        {
            InitializeComponent();
        }

        int HaveChanged = 0;
        private void OrderMain_Load(object sender, EventArgs e)
        {
            //设置隔行背景色

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


            lb_Combination_no.Text = "";
            lb_customer_state.Text = "";
            lb_customer_state_des.Text = "";
            lb_job_qty.Text = "";
            lb_manhour.Text = "";
            lb_memo_name.Text = "";
            lb_memo_no.Text = "";
            lb_OpListNo.Text = "";
            lb_order_no.Text = "";
            lb_SchemeNo.Text = "";
            lb_style_des.Text = "";
            lb_style_num.Text = "";

            GetGrid_UPS(0);
            GetGridOperation(0);
            GetGridProduct("NoOrder", 0);
            HaveChanged = 0;
            ChangeButton();

        }

        List<string> lst = new List<string>();

        /// <summary>
        /// 保存工单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (GridUPS.Rows.Count == 0 || GridOperation.Rows.Count == 0)
            {
                MessageBox.Show("必须为工单选择生产路线和工序清单", "提示", MessageBoxButtons.OK);
                return;
            }
            OrderBll ob = new OrderBll();


            //这里要先保存nMES_order_master表的Combination_no,memo_no,memo_name 保存工单子表nMES_Order_detail_OptionList
            int R_SaveOrderOption = ob.SaveOrderOption(soi, lst);
            if (R_SaveOrderOption != 1) { MessageBox.Show("保存工单选项时失败！", "没有成功", MessageBoxButtons.OK); return; }

            //1.1 工序清单：保存到nMES_Order_detail_OperationList
            int R_SaveOrderOperationList = ob.SaveOrderOperationList(soi.job_num, soi.suffix, soi.OpListNo,soi.Combination_no );
            if (R_SaveOrderOperationList != 1) { MessageBox.Show("保存工序列表失败！", "没有成功", MessageBoxButtons.OK); return; }

            //2.1 保存到nMES_Order_detail_SchemeList
            int R_SaveOrderSchemeList = ob.SaveOrderSchemeList(soi.job_num, soi.suffix, soi.SchemeNo);
            if (R_SaveOrderSchemeList != 1) { MessageBox.Show("保存生产路线失败！", "没有成功", MessageBoxButtons.OK); return; }

            else
            { 
                MessageBox.Show("完成", "成功", MessageBoxButtons.OK);
            }
            HaveChanged = 0;
            ChangeButton();
        }

        #region 加载GridUPS
        /// <summary>
        /// 加载GridUPS
        /// </summary>
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
        #endregion

        private void GetGridOperation(int OpListNo)
        {
            lb_OpListNo.Text = OpListNo.ToString().Trim();
            OperationBLL sb = new OperationBLL();
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
        private void GetGridProduct(string job_num, int suffix)
        {
            OrderBll sb = new OrderBll();
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



        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void GridUPSList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (GridUPSList.Rows.Count == 0) { return; }
            //string SchemeNo = GridUPSList.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim();
            //lb_SchemeNo.Text = SchemeNo;
            //GetGridUPS(SchemeNo);
        }

        private void ButtonSelectOrder_Click(object sender, EventArgs e)
        {
            OrderSelect OA = new OrderSelect(1);
            DialogResult f1 = OA.ShowDialog();
            if (f1 == DialogResult.OK)
            {
                soi = OA.soi;
                lb_order_no.Text = soi.job_num + "-" + soi.suffix.ToString().PadLeft(3, '0');
                lb_job_qty.Text = soi.job_qty.ToString().Trim();
                lb_style_num.Text = soi.Style_no;
                lb_style_des.Text = soi.style_des;
                lb_memo_no.Text = soi.memo_no;
                lb_memo_name.Text = soi.memo_name;
                lb_customer_state.Text = soi.customer_state.ToString();
                lb_customer_state_des.Text = soi.customer_state_des;
                lb_manhour.Text = soi.manhour.ToString();
                lb_Combination_no.Text = soi.Combination_no.ToString();

                lb_SchemeNo.Text = soi.SchemeNo.ToString();

                lst = OA.lst;
                GetGrid_UPS(soi.SchemeNo);
                OperationBLL ob = new OperationBLL();
                soi.OpListNo = ob.GetOpListNo(soi.Combination_no);
                GetGridOperation(soi.OpListNo);
                GetGridProduct(soi.job_num,soi.suffix);
                OA.Close();
            }
            else
            {
                lb_order_no.Text = "";
                lb_job_qty.Text = "";
                lb_style_num.Text = "";
                lb_style_des.Text = "";
                lb_memo_no.Text = "";
                lb_memo_name.Text = "";
                lb_customer_state.Text = "";
                lb_customer_state_des.Text = "";
                lb_manhour.Text = "";
                lb_Combination_no.Text = "";
                lb_OpListNo.Text = "";

                lb_SchemeNo.Text = "";
                lst = new List<string>();
                GetGrid_UPS(0);
                GetGridOperation(0);
                GetGridProduct("NoOrder", 0);
                OA.Close();
            }
            HaveChanged = 0;//界面没有发生更改
            ChangeButton();

         }

        private void ButtonToMES_Click(object sender, EventArgs e)
        {
            if (GridUPS.Rows.Count == 0 || GridOperation.Rows.Count == 0)
            {
                MessageBox.Show("必须为工单选择生产路线和工序清单", "提示", MessageBoxButtons.OK);
                return;
            }
            OrderBll ob = new OrderBll();

            if (soi.OrderLock == 0)
            {
                //这里要先保存nMES_order_master表的Combination_no,memo_no,memo_name 保存工单子表nMES_Order_detail_OptionList
                int R_SaveOrderOption = ob.SaveOrderOption(soi, lst);
                if (R_SaveOrderOption != 1) { MessageBox.Show("保存工单选项时失败！", "没有成功", MessageBoxButtons.OK); return; }

                //1.1 工序清单：保存到nMES_Order_detail_OperationList
                int R_SaveOrderOperationList = ob.SaveOrderOperationList(soi.job_num, soi.suffix, soi.OpListNo, soi.Combination_no);
                if (R_SaveOrderOperationList != 1) { MessageBox.Show("保存工序列表失败！", "没有成功", MessageBoxButtons.OK); return; }

                //2.1 保存到nMES_Order_detail_SchemeList
                int R_SaveOrderSchemeList = ob.SaveOrderSchemeList(soi.job_num, soi.suffix, soi.SchemeNo);
                if (R_SaveOrderSchemeList != 1) { MessageBox.Show("保存生产路线失败！", "没有成功", MessageBoxButtons.OK); return; }

                //else
                //{
                //    MessageBox.Show("保存完成，即将推送到吊挂", "成功", MessageBoxButtons.OK);
                //}
                //HaveChanged = 0;

            }



            OrderToUPS OA = new OrderToUPS(soi);
            DialogResult f1 = OA.ShowDialog();

            if (f1 == DialogResult.OK)
            {
                OA.Close();
            }
            ChangeButton();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ButtonNewOrder_Click(object sender, EventArgs e)
        {
            OrderSelectScheme oss = new OrderSelectScheme(soi);
            DialogResult f1 = oss.ShowDialog();
            if (f1 == DialogResult.OK)
            {
                soi.SchemeNo = oss.SchemeNo;
                HaveChanged = 1;//页面有调整
                oss.Close();
            }
            
            lb_SchemeNo.Text = soi.SchemeNo.ToString().Trim();
            GetGrid_UPS(soi.SchemeNo);
            ChangeButton();
        }

        private void ChangeButton()
        {

            //刷新按钮状态
            if (soi.OrderLock==1)//订单为锁定状态
            {
                ButtonChangeScheme.Enabled = false;
                ButtonSave.Enabled = false;
                ButtonToMES.Enabled = true;
                return;
            }
            //没有对应的款式和组合：
            if (soi.Combination_no == 0)
            {
                ButtonSave.Enabled = false;
                ButtonToMES.Enabled = false;
                ButtonChangeScheme.Enabled = false;
                return;
            }
            //没有对应的生产路线
            else if (soi.SchemeNo == 0 || soi.OpListNo == 0)
            {
                ButtonChangeScheme.Enabled = true;
                ButtonSave.Enabled = false;
                ButtonToMES.Enabled = false;
                return;
            }
            else
            {
                if (HaveChanged == 0) { ButtonSave.Enabled = false; }
                else { ButtonSave.Enabled = true; }
                ButtonToMES.Enabled = true;
                ButtonChangeScheme.Enabled = true;
                return;
            }


        }

        private void ButtonGetOpList_Click(object sender, EventArgs e)
        {
            if (soi.Combination_no == 0) { return; }            
            OperationBLL ob = new OperationBLL();
            soi.OpListNo = ob.GetOpListNo(soi.Combination_no);
            lb_OpListNo.Text = soi.OpListNo.ToString().Trim();
            GetGridOperation(soi.OpListNo);
        }
    }
}
