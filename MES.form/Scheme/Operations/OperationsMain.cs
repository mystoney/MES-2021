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
    public partial class OperationsMain : txMainFormEnterTab
    {
        public OperationsMain()
        {
            InitializeComponent();
        }

        private void OperationsMain_Load(object sender, EventArgs e)
        {
            GetGridStation();
            button_YES.Enabled = false;
        }
        DataTable dt_OperationList = new DataTable();
        #region 
        private void GetGridStation()
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
                this.GridOPList.AddColumn("PushState_CAOBO", "状态值", 70, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("PushState", "状态", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOPList.AddColumn("apptime", "时间", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridOPList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridOPList.AllowUserToResizeRows = false;
            }
        }
        #endregion 加载Grid

        private void button3_Click(object sender, EventArgs e)
        {
            OperationBLL ob = new OperationBLL();
            if (GridOPList.Rows.Count == 0) { return; }
            int OplistNo = Convert.ToInt32(GridOPList.CurrentRow.Cells["OpListNo"].Value.ToString().Trim());
            string s = ob.OperationToCaobo(OplistNo);
            if (s == "1")
            {
                MessageBox.Show("完成");
                GetGridStation();
            }
            else
            {
                MessageBox.Show("推送至生产线PAD错误：" + s);
                GetGridStation();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridOPList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridOPList.CurrentRow.Cells["PushState_CAOBO"].Value.ToString().Trim() == "1")
            {
                button_YES.Enabled = false;
            }
            else
            {
                button_YES.Enabled = true;
            }
        }
    }
}
