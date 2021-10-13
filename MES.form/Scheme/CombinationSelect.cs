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

namespace MES.form.Scheme
{
    public partial class CombinationSelect : Form
    {
        public CombinationSelect()
        {
            InitializeComponent();
        }


        public DataTable dt_Combination = new DataTable();



        private void SchemeSelect_Load(object sender, EventArgs e)
        {
            if (dt_Combination.Rows.Count > 0)
            {
                dt_Combination.Rows.Clear();
            }

            StyleBll sb_style = new StyleBll();
            tb_StyleList.DisplayMember = "style_no";
            tb_StyleList.DataSource = sb_style.Style_SelectStyleAll();
        }



        private void tb_StyleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_StyleList.Text.Trim() != "")
            {
                GridItemCombination(tb_StyleList.Text.Trim());
            }

        }
        private void GridItemCombination(string Style_no)
        {
            StyleBll ob = new StyleBll();
            DataTable dt = ob.getCombinationList(Style_no,1);
            GridCombinationList.DataSource = dt;

            if (this.GridCombinationList.Columns.Count == 0)
            {
                this.GridCombinationList.AddColumn("Style_no", "款号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCombinationList.AddColumn("Combination_no", "选项组合", 30, true, null, DataGridViewContentAlignment.MiddleLeft, null, false); 
                this.GridCombinationList.AddColumn("memo_no", "选项", 30, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCombinationList.AddColumn("memo_name", "说明", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCombinationList.AddColumn("app_time", "保存时间", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridCombinationList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridCombinationList.AllowUserToResizeRows = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GridCombinationList.Rows.Count == 0)
            {
                MessageBox.Show("请从表格中选择选项");
                return;
            }
            else
            {
                    if (dt_Combination.Rows.Count > 0)
                    {
                        dt_Combination.Rows.Clear();
                    }

                    dt_Combination.Columns.Add("style_no");
                    dt_Combination.Columns.Add("Combination_no");
                    dt_Combination.Columns.Add("memo_name");
                    dt_Combination.Columns.Add("memo_no");
                    DataRow dr = dt_Combination.NewRow();
                    dr["style_no"] = GridCombinationList.CurrentRow.Cells["style_no"].Value.ToString();
                    dr["Combination_no"] = GridCombinationList.CurrentRow.Cells["Combination_no"].Value.ToString();
                    dr["memo_name"] = GridCombinationList.CurrentRow.Cells["memo_name"].Value.ToString();
                    dr["memo_no"] = GridCombinationList.CurrentRow.Cells["memo_no"].Value.ToString();
                    dt_Combination.Rows.Add(dr);

                DialogResult = DialogResult.OK;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
