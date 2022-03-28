using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MES.module.BLL;

namespace MES.form.Scheme.Operations
{
    public partial class OperationsMain : Form
    {
        public OperationsMain()
        {
            InitializeComponent();
        }

        private void OperationsMain_Load(object sender, EventArgs e)
        {
            this.GridOPList.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridOPList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridOPList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridOPList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue;

            this.GridOPListDetail.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridOPListDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridOPListDetail.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridOPListDetail.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue;

            GetGridOPList();
            button_ToCAOBO.Enabled = false;
            button_ToJingYuan.Enabled = false;
        }
        DataTable dt_OperationList = new DataTable();
        #region 
        private void GetGridOPList()
        {
            OperationBLL ob = new OperationBLL();
            dt_OperationList = ob.GetAllOperationList();
            GridOPList.DataSource = dt_OperationList;

            if (this.GridOPList.Columns.Count == 0)
            {
                this.GridOPList.AddColumn("id", "ID", 30, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOPList.AddColumn("OpListNo", "清单", 40, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("Style_no", "款号", 70, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("Combination_no", "组合", 40, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("memo_name", "选项", 150, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("memo", "选项", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("PushState_CAOBO", "推送1", 70, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("PushState_JingYuan", "推送2", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("apptime", "时间", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridOPList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                this.GridOPList.AllowUserToResizeRows = false;
            }
        }
        #endregion 加载Grid
        private void GetGridOPListDetail(int OpListNo)
        {
            OperationBLL sb = new OperationBLL();
            DataTable dt_OpListNo = sb.GetOpList(OpListNo);

            if (this.GridOPListDetail.Columns.Count == 0)
            {
                this.GridOPListDetail.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPListDetail.AddColumn("OpListNo", "工序清单号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPListDetail.AddColumn("OperationNo", "工序号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPListDetail.AddColumn("OperationDes", "工序描述", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPListDetail.AddColumn("OperationType", "工序类型", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPListDetail.AddColumn("manhour", "工时", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPListDetail.AddColumn("GST_xh", "工序序号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridOPListDetail.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridOPListDetail.AllowUserToResizeRows = false;
            }
            GridOPListDetail.DataSource = dt_OpListNo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OperationBLL ob = new OperationBLL();
            if (GridOPList.Rows.Count == 0) { return; }
            int OplistNo = Convert.ToInt32(GridOPList.CurrentRow.Cells["OpListNo"].Value.ToString().Trim());
            string s = ob.OperationToCaobo(OplistNo);
            if (s == "1")
            {
                MessageBox.Show("完成");
                GetGridOPList();
            }
            else
            {
                MessageBox.Show("推送至生产线PAD错误：" + s);
                GetGridOPList();
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridOPList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GridOPList.CurrentRow.Cells["PushState_CAOBO"].Value.ToString().Trim() == "已推送1")
            {
                button_ToCAOBO.Enabled = false;
            }
            else
            {
                button_ToCAOBO.Enabled = true;
            }
            

            if (GridOPList.CurrentRow.Cells["PushState_JingYuan"].Value.ToString().Trim() == "已推送2")
            {
                button_ToJingYuan.Enabled = false;
            }
            else
            {
                button_ToJingYuan.Enabled = true;
            }
            int OplistNo = Convert.ToInt32(GridOPList.CurrentRow.Cells["OpListNo"].Value.ToString().Trim());
            GetGridOPListDetail(OplistNo);
        }


        private void button_ToJingYuan_Click(object sender, EventArgs e)
        {
            OperationBLL ob = new OperationBLL();
            if (GridOPList.Rows.Count == 0) { return; }
            int OplistNo = Convert.ToInt32(GridOPList.CurrentRow.Cells["OpListNo"].Value.ToString().Trim());
            string s_ToJingYuan = ob.OperationToJingYuan(OplistNo);
            if (s_ToJingYuan == "1")
            {
                MessageBox.Show("完成");
                GetGridOPList();
            }
            else
            {
                MessageBox.Show("推送错误：" + s_ToJingYuan);
                GetGridOPList();
            }
        }

    }
}
