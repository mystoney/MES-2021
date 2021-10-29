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
    public partial class OrderSelectScheme : txMainFormEnterTab
    {
        OrderBll.SelectOrderInfo soi = new OrderBll.SelectOrderInfo();
        public int SchemeNo = 0;
        public OrderSelectScheme()
        {
            InitializeComponent();
        }
        public OrderSelectScheme(OrderBll.SelectOrderInfo SOI)
        {
            InitializeComponent();
            soi = SOI;
        }

        private void OrderSelectScheme_Load(object sender, EventArgs e)
        {
            lb_order_no.Text= soi.job_num + "-" + soi.suffix.ToString().PadLeft(3, '0');
            lb_job_qty.Text = soi.job_qty.ToString().Trim();
            lb_style_num.Text = soi.Style_no;
            lb_style_des.Text = soi.style_des;
            lb_memo_no.Text = soi.memo_no;
            lb_memo_name.Text = soi.memo_name;
            lb_Combination_no.Text = soi.Combination_no.ToString().Trim();
            GetGridMaster();

        }
        private void GetGridMaster()
        {
            SchemeBll sb = new SchemeBll();
            DataTable dt_Master = sb.GetSchemeList_master(soi.Style_no, soi.Combination_no);

            if (this.GridSchemeMaster.Columns.Count == 0)
            {
                this.GridSchemeMaster.AddColumn("SchemeNo", "编号", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeMaster.AddColumn("memo_no", "选项", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeMaster.AddColumn("memo_name", "选项说明", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeMaster.AddColumn("SchemeState", "状态", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeMaster.AddColumn("SchemeMemo", "方案说明", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeMaster.AddColumn("app_time", "时间", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeMaster.AddColumn("Eton_Line", "生产线", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridSchemeMaster.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridSchemeMaster.AllowUserToResizeRows = false;
            }
            GridSchemeMaster.DataSource = dt_Master;
        }

        private void GetGridDetail(string SchemeNo)
        {
            
            SchemeBll sb = new SchemeBll();
            DataTable dt_Detail = sb.GetSchemeList_detail(SchemeNo);

            if (this.GridSchemeDetail.Columns.Count == 0)
            {
                this.GridSchemeDetail.AddColumn("SchemeNo", "编号", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeDetail.AddColumn("Eton_Line", "生产线", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeDetail.AddColumn("Eton_WorkStation", "工作站", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeDetail.AddColumn("SchemeOperationNo", "序号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeDetail.AddColumn("SchemeOperationDes", "描述", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeDetail.AddColumn("op_type", "工序类型", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeDetail.AddColumn("op_des", "类型描述", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridSchemeDetail.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridSchemeDetail.AllowUserToResizeRows = false;
            }
            GridSchemeDetail.DataSource = dt_Detail;
        }

        private void GridSchemeMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SchemeNo =Convert.ToInt16( GridSchemeMaster.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim());
            GetGridDetail(SchemeNo.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SchemeNo != 0)
            {
                OrderBll ob = new OrderBll();
                int R_SaveOrderSchemeList = ob.SaveOrderSchemeList(soi.job_num, soi.suffix, SchemeNo);
                if (R_SaveOrderSchemeList == 1)
                { this.DialogResult = DialogResult.OK; }
                else
                {
                    MessageBox.Show("保存失败，请重新操作", "出错了", MessageBoxButtons.OK);
                    return;
                }
            }
            
        }
    }
}
