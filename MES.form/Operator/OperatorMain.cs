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

namespace MES.form.Operator
{
    public partial class OperatorMain : Form
    {
        public OperatorMain()
        {
            InitializeComponent();
        }

        private void OperatorMain_Load(object sender, EventArgs e)
        {
            this.GridOperatorMaster.AutoGenerateColumns = false; //不给GridView增加扩展列
            //设置隔行背景色
            this.GridOperatorMaster.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridOperatorMaster.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridOperatorMaster.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridOperatorMaster.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;

            GetGridMaster();




        }
        private void GetGridMaster()
        {
            OperatorBll ob = new OperatorBll();
            DataTable dt = ob.GetOperatorDT();

            GridOperatorMaster.DataSource = dt;
            if (this.GridOperatorMaster.Columns.Count == 0)
            {
                //this.GridOperatorMaster.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridOperatorMaster.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorID", "员工账号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorName", "员工姓名", 80, true, null, DataGridViewContentAlignment.MiddleLeft, "#0.00", true);
                this.GridOperatorMaster.AddColumn("OperatorPassword", "密码", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("OperatorType", "工种", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("OperatorState", "员工状态值", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("员工状态", "员工状态", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorType", "工种代码", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("工种", "工种", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridOperatorMaster.Columns[2].Frozen = true;
            }


        }
        private void GetGridMaster(OperatorAdd.OperatorInfo oi)
        {
            OperatorBll ob = new OperatorBll();
            DataTable dt = ob.GetOperatorDT();

            GridOperatorMaster.DataSource = dt;
            if (this.GridOperatorMaster.Columns.Count == 0)
            {
                //this.GridOperatorMaster.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridOperatorMaster.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorID", "员工账号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorName", "员工姓名", 80, true, null, DataGridViewContentAlignment.MiddleLeft, "#0.00", true);
                this.GridOperatorMaster.AddColumn("OperatorPassword", "密码", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("OperatorType", "工种", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("OperatorState", "员工状态值", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("员工状态", "员工状态", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorType", "工种代码", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("工种", "工种", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridOperatorMaster.Columns[2].Frozen = true;
            }

            for (int j = 0; j < GridOperatorMaster.Rows.Count; j++)
            {
                string strIDValue = GridOperatorMaster.Rows[j].Cells["OperatorID"].Value.ToString();
                if (strIDValue == oi.OperatorID)//值判断
                {
                    GridOperatorMaster.Rows[j].Selected = true;
                    GridOperatorMaster.CurrentCell = GridOperatorMaster[0, j]; //会导致多选消失。
                }
            }


        }

        private void GetGridMaster(OperatorBll.OperatorInfo oi)
        {
            OperatorBll ob = new OperatorBll();
            DataTable dt = ob.GetOperatorDT();

            GridOperatorMaster.DataSource = dt;
            if (this.GridOperatorMaster.Columns.Count == 0)
            {
                //this.GridOperatorMaster.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridOperatorMaster.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorID", "员工账号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorName", "员工姓名", 80, true, null, DataGridViewContentAlignment.MiddleLeft, "#0.00", true);
                this.GridOperatorMaster.AddColumn("OperatorPassword", "密码", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("OperatorType", "工种", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("OperatorState", "员工状态值", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("员工状态", "员工状态", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOperatorMaster.AddColumn("OperatorType", "工种代码", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridOperatorMaster.AddColumn("工种", "工种", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridOperatorMaster.Columns[2].Frozen = true;
            }


            for (int j = 0; j < GridOperatorMaster.Rows.Count; j++)
            {
                string strIDValue = GridOperatorMaster.Rows[j].Cells["OperatorID"].Value.ToString();
                if (strIDValue == oi.OperatorID)//值判断
                {
                    GridOperatorMaster.Rows[j].Selected = true;
                    GridOperatorMaster.CurrentCell = GridOperatorMaster[0, j]; //会导致多选消失。
                }
            }

        }



        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void ButtonOperatorAdd_Click(object sender, EventArgs e)
        {
            OperatorAdd Operatoradd = new OperatorAdd();
            Operatoradd.ShowDialog();
            
            GetGridMaster();

        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            OperatorAdd.OperatorInfo oi = new OperatorAdd.OperatorInfo();
            oi.id =Convert.ToInt16( GridOperatorMaster.CurrentRow.Cells["id"].Value.ToString().Trim());
            oi.OperatorID = GridOperatorMaster.CurrentRow.Cells["OperatorID"].Value.ToString().Trim();
            oi.OperatorName= GridOperatorMaster.CurrentRow.Cells["OperatorName"].Value.ToString().Trim();
            oi.OperatorPassword= GridOperatorMaster.CurrentRow.Cells["OperatorPassword"].Value.ToString().Trim();
            oi.OperatorState = Convert.ToInt16(GridOperatorMaster.CurrentRow.Cells["OperatorState"].Value.ToString().Trim());
            oi.OperatorType = GridOperatorMaster.CurrentRow.Cells["OperatorType"].Value.ToString().Trim();
            OperatorAdd Operatoradd = new OperatorAdd(oi,"重置密码");
            Operatoradd.ShowDialog();
            GetGridMaster(oi);
        }

        private void ButtonOperatorState_Click(object sender, EventArgs e)
        {

            
            OperatorBll.OperatorInfo oi = new OperatorBll.OperatorInfo();
            oi.id = Convert.ToInt16(GridOperatorMaster.CurrentRow.Cells["id"].Value.ToString().Trim());
            oi.OperatorID = GridOperatorMaster.CurrentRow.Cells["OperatorID"].Value.ToString().Trim();
            oi.OperatorName = GridOperatorMaster.CurrentRow.Cells["OperatorName"].Value.ToString().Trim();
            oi.OperatorPassword = GridOperatorMaster.CurrentRow.Cells["OperatorPassword"].Value.ToString().Trim();
            int i = Convert.ToInt16(GridOperatorMaster.CurrentRow.Cells["OperatorState"].Value.ToString().Trim());
            oi.OperatorPassword = GridOperatorMaster.CurrentRow.Cells["OperatorType"].Value.ToString().Trim();
            if (i == Convert.ToInt16(OperatorBll.OperatorState.启用))
            {
                if (MessageBox.Show(this, "您确定要停用选中的员工账号么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    oi.OperatorState = Convert.ToInt16(OperatorBll.OperatorState.停用);
                }                
            }
            else if (i == Convert.ToInt16(OperatorBll.OperatorState.停用))
            {
                if (GridOperatorMaster.CurrentRow.Cells["OperatorType"].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("工种为空的用户不可启用！", "提示", MessageBoxButtons.OK);
                    return;
                }
                else if (MessageBox.Show(this, "您确定要启用选中的员工账号么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    oi.OperatorState = Convert.ToInt16(OperatorBll.OperatorState.启用);
                }                
            }

            OperatorBll ob = new OperatorBll();
            OperatorBll.Return_Message rm = new OperatorBll.Return_Message();

            rm = ob.OperatorUpdateOperatorState(oi);
            if (rm.State == OperatorBll.Return_Message.Return_State.Error)
            {
                MessageBox.Show(rm.Message, "提示", MessageBoxButtons.OK);                
                return;
            }
            else
            {
                MessageBox.Show("完成", "提示", MessageBoxButtons.OK);
            }
            GetGridMaster(oi);

        }

        private void ButtonOperatorType_Click(object sender, EventArgs e)
        {
            OperatorAdd.OperatorInfo oi = new OperatorAdd.OperatorInfo();
            oi.id = Convert.ToInt16(GridOperatorMaster.CurrentRow.Cells["id"].Value.ToString().Trim());
            oi.OperatorID = GridOperatorMaster.CurrentRow.Cells["OperatorID"].Value.ToString().Trim();
            oi.OperatorName = GridOperatorMaster.CurrentRow.Cells["OperatorName"].Value.ToString().Trim();
            oi.OperatorPassword = GridOperatorMaster.CurrentRow.Cells["OperatorPassword"].Value.ToString().Trim();
            oi.OperatorState = Convert.ToInt16(GridOperatorMaster.CurrentRow.Cells["OperatorState"].Value.ToString().Trim());
            oi.OperatorType = GridOperatorMaster.CurrentRow.Cells["OperatorType"].Value.ToString().Trim();
            OperatorAdd Operatoradd = new OperatorAdd(oi, "更改工种");
            Operatoradd.ShowDialog();
            GetGridMaster(oi);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            GetGridMaster();
        }
    }
}
