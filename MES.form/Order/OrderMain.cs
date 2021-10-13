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

        private void OrderMain_Load(object sender, EventArgs e)
        {
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
            GetGridUPSList();
            GetGridOperationList();
        }
        List<string> lst = new List<string>();
        DataTable dt_CombinationList = new DataTable();

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (GridUPSList.Rows.Count==0||GridOperationList.Rows.Count==0|| GridUPS.Rows.Count == 0 || GridOperation.Rows.Count == 0)
            {
                MessageBox.Show("必须为工单选择生产路线和工序清单", "提示", MessageBoxButtons.OK);
                return;
            }
            if (GridUPSList.CurrentRow is null || GridOperationList.CurrentRow is null)
            {                
                    MessageBox.Show("必须为工单选择生产路线和工序清单", "提示", MessageBoxButtons.OK);
                    return;
            }


            soi.OpListNo =Convert.ToInt32( GridOperationList.CurrentRow.Cells["OpListNo"].Value.ToString().Trim());
            lb_OpListNo.Text = soi.OpListNo.ToString().Trim();
            soi.SchemeNo = Convert.ToInt32(GridUPSList.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim());
            lb_SchemeNo.Text = soi.SchemeNo.ToString().Trim();

            OrderBll ob = new OrderBll();
            //1.1 工序清单：保存到nMES_Order_detail_OperationList
            int R_SaveOrderOperationList = ob.SaveOrderOperationList(soi.job_num, soi.suffix, soi.OpListNo);

            //2.1 保存到nMES_Order_detail_SchemeList
            int R_SaveOrderSchemeList = ob.SaveOrderSchemeList(soi.job_num, soi.suffix, soi.SchemeNo);

            if (R_SaveOrderOperationList == 1 && R_SaveOrderSchemeList == 1 )
            {
                MessageBox.Show("完成", "成功", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("没有成功", "没有成功", MessageBoxButtons.OK);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OrderSelect OA = new OrderSelect(0);
            DialogResult f1 = OA.ShowDialog();
            if (f1 == DialogResult.OK)
            {
                soi = OA.soi;
                lb_order_no.Text = soi.job_num + "-" + soi.suffix.ToString().PadLeft(3, '0');
                lb_job_qty.Text  = soi.job_qty.ToString().Trim();
                lb_style_num.Text = soi.Style_no;
                lb_style_des.Text = soi.style_des;
                lb_memo_no.Text = soi.memo_no;
                lb_memo_name.Text = soi.memo_name;
                lb_customer_state.Text = soi.customer_state.ToString() ;
                lb_customer_state_des.Text = soi.customer_state_des;
                lb_manhour.Text = soi.manhour.ToString() ;
                lb_Combination_no.Text = soi.Combination_no.ToString();
                lb_OpListNo.Text = soi.OpListNo.ToString();
                lb_SchemeNo.Text = soi.SchemeNo.ToString();
                lst = OA.lst;
                GetGridUPSList();
                GetGridOperationList();
                OA.Close();
            }
            else
            {
                
                lb_order_no.Text = "";
                lb_job_qty.Text = "";
                lb_style_num.Text = "";
                lb_style_num.Text = "";
                lb_memo_no.Text = "";
                lb_memo_name.Text = "";
                lb_customer_state.Text = "";
                lb_customer_state_des.Text = "";
                lb_manhour.Text = "";
                lb_Combination_no.Text = "";
                lb_OpListNo.Text = "";
                lb_SchemeNo.Text = "";
                lb_style_des.Text = "";
                lst = new List<string>();
                while (this.GridUPSList.Rows.Count != 0)
                {
                    this.GridUPSList.Rows.RemoveAt(0);
                }
                while (this.GridUPS.Rows.Count != 0)
                {
                    this.GridUPS.Rows.RemoveAt(0);
                }
                while (this.GridOperationList.Rows.Count != 0)
                {
                    this.GridOperationList.Rows.RemoveAt(0);
                }
                while (this.GridOperation.Rows.Count != 0)
                {
                    this.GridOperation.Rows.RemoveAt(0);
                }
                OA.Close();

            }
        }
        private void GetGridUPSList()
        {
            if(soi.Combination_no==0 )
            {
                return;
            }
            string strsql = " SELECT id,SchemeNo ,Combination_no ,app_time ,state ,memo FROM nMES_Scheme_master where Combination_no=" + soi.Combination_no +" order by state ";
            DataTable dt_UPSList = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
            GridUPSList.DataSource = dt_UPSList;
        
            if (this.GridUPSList.Columns.Count == 0)
            {
            this.GridUPSList.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
            this.GridUPSList.AddColumn("SchemeNo", "方案号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
            this.GridUPSList.AddColumn("Combination_no", "组合号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPSList.AddColumn("app_time", "保存时间", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPSList.AddColumn("state", "默认", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);//0默认 1备用
                // 实现列的锁定功能  
                this.GridUPSList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridUPSList.AllowUserToResizeRows = false;
            }

            if (dt_UPSList.Rows.Count >0)
            {
                GetGridUPS(dt_UPSList.Rows[0]["SchemeNo"].ToString().Trim());
                lb_SchemeNo.Text = dt_UPSList.Rows[0]["SchemeNo"].ToString().Trim();
                soi.SchemeNo = Convert.ToInt32(dt_UPSList.Rows[0]["SchemeNo"].ToString().Trim());
            }
        }
        private void GridUPSList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region 加载GridUPS
        /// <summary>
        /// 加载GridUPS
        /// </summary>
        private void GetGridUPS(string SchemeNo)
        {
            SchemeBll sc = new SchemeBll();
            DataTable dt_UPS = sc.GetSchemeList_detail(SchemeNo);
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
        private void GetGridOperationList()
        {
            if (soi.Combination_no == 0)
            {
                return;
            }
            string strsql = "  SELECT top 1  id,OpListNo ,Combination_no ,memo ,apptime FROM nMES_OperationList_master  where Combination_no=" + soi.Combination_no + " order by OpListNo desc";
            DataTable dt_OperationList = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
            GridOperationList.DataSource = dt_OperationList;
            if (dt_OperationList.Rows.Count == 0)
            {
                MessageBox.Show("没有找到可用的工序清单", "提示", MessageBoxButtons.OK);
            }
            else
            {
                lb_OpListNo.Text = dt_OperationList.Rows[0]["OpListNo"].ToString().Trim();
                soi.OpListNo = Convert.ToInt32(dt_OperationList.Rows[0]["OpListNo"].ToString().Trim());
            }

            if (this.GridOperationList.Columns.Count == 0)
            {
                this.GridOperationList.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperationList.AddColumn("OpListNo", "工序清单号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperationList.AddColumn("Combination_no", "选项组合号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperationList.AddColumn("memo", "备注", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperationList.AddColumn("apptime", "保存时间", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridOperationList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridOperationList.AllowUserToResizeRows = false;
            }

            if (dt_OperationList.Rows.Count > 0)
            {
                string strsql_detail = "SELECT id,OpListNo,OperationNo,OperationDes,OperationType,manhour,GST_xh FROM nMES_OperationList_detail where OpListNo='" + dt_OperationList.Rows[0]["OpListNo"].ToString().Trim() + "' ";
                DataTable dt_Operation = DBConn.DataAcess.SqlConn.Query(strsql_detail).Tables[0];
                GridOperation.DataSource = dt_Operation;
            }


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
        }












        ///// <summary>
        ///// 筛选符合选项条件的组合 此功能暂时不用 可以模糊查询方案
        ///// </summary>
        ///// <param name="lst"></param>
        //private void GetGridCombination(List<string> lst)
        //{
        //    if (lst.Count == 0)
        //    {
        //        MessageBox.Show("没有找到符合条件的选项组合", "提示", MessageBoxButtons.OK);
        //        return;
        //    }
        //    StyleBll sb = new StyleBll();
        //    dt_CombinationList = sb.GetOrderCombination(soi.Style_no, lst);

        //    if (this.GridCombination.Columns.Count == 0)
        //    {
        //        this.GridCombination.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
        //        this.GridCombination.AddColumn("Combination_no", "组合号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
        //        this.GridCombination.AddColumn("memo_no", "选项值", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
        //        this.GridCombination.AddColumn("memo_name", "选项说明", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
        //        // 实现列的锁定功能  
        //        this.GridCombination.Columns[0].Frozen = true;
        //        //禁止用户改变DataGridView1所有行的行高
        //        GridCombination.AllowUserToResizeRows = false;
        //    }
        //    GridCombination.DataSource = dt_CombinationList;
        //}


        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void GridUPSList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUPSList.Rows.Count == 0) { return; }
            string SchemeNo = GridUPSList.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim();
            lb_SchemeNo.Text = SchemeNo;
            GetGridUPS(SchemeNo);
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
                lb_OpListNo.Text = soi.OpListNo.ToString();
                lb_SchemeNo.Text = soi.SchemeNo.ToString();
                lst = OA.lst;
                GetGridUPSList();
                GetGridOperationList();
                OA.Close();
            }
            else
            {
                lb_order_no.Text = "";
                lb_job_qty.Text = "";
                lb_style_num.Text = "";
                lb_style_num.Text = "";
                lb_memo_no.Text = "";
                lb_memo_name.Text = "";
                lb_customer_state.Text = "";
                lb_customer_state_des.Text = "";
                lb_manhour.Text = "";
                lb_Combination_no.Text = "";
                lb_OpListNo.Text = "";
                lb_SchemeNo.Text = "";
                lst = new List<string>();
                while (this.GridUPSList.Rows.Count != 0)
                {
                    this.GridUPSList.Rows.RemoveAt(0);
                }
                while (this.GridUPS.Rows.Count != 0)
                {
                    this.GridUPS.Rows.RemoveAt(0);
                }
                while (this.GridOperationList.Rows.Count != 0)
                {
                    this.GridOperationList.Rows.RemoveAt(0);
                }
                while (this.GridOperation.Rows.Count != 0)
                {
                    this.GridOperation.Rows.RemoveAt(0);
                }
                OA.Close();
            }
            OrderBll ob = new OrderBll();
            List<OrderBll.ProductUPS> ProductList = new List<OrderBll.ProductUPS>();
            ProductList = ob.GetProductList(soi.job_num, soi.suffix);
            for (int k = 0; k < ProductList.Count; k++)
            {
                if (ProductList[k].UPS_prun != 0) 
                {
                    ButtonSave.Enabled = false;
                    return;
                }
            }
         }

        private void ButtonToMES_Click(object sender, EventArgs e)
        {

            OrderToUPS OA = new OrderToUPS(soi);
            DialogResult f1 = OA.ShowDialog();

            if (f1 == DialogResult.OK)
            {
                OA.Close();
            }

        }

    }
}
