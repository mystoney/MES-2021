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
    public partial class SchemeSelect : txMainFormEnterTab
    {
        public SchemeSelect()
        {
            InitializeComponent();
        }
        public DataTable dt_Combination = new DataTable();

        public static string Styleno = "";
        public static int Combination_no = 0;
        public static string memo_name = "";
        public static int SchemeNo = 0;
        public static int Eton_Line = 0;
        private void SchemeSelect_Load(object sender, EventArgs e)
        {
            if (dt_Combination.Rows.Count > 0)
            {
                dt_Combination.Rows.Clear();
            }

            StyleBll sb_style = new StyleBll();
            tb_StyleList.DisplayMember = "style_no";
            tb_StyleList.DataSource = sb_style.Style_SelectStyleAll();

            //设置隔行背景色
            this.GridCombinationList.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridCombinationList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridCombinationList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridSchemeList.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridSchemeList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridSchemeList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }


        private void GetGridCombinationList()
        {
            if (tb_StyleList.Text.Trim() == "")
            {
                return;
            }
            StyleBll sb = new StyleBll();
            DataTable dt = sb.getCombinationList(tb_StyleList.Text.Trim(),1);
            GridCombinationList.DataSource = dt;

            if (this.GridCombinationList.Columns.Count == 0)
            {
                this.GridCombinationList.AddColumn("Style_no", "款号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCombinationList.AddColumn("Combination_no", "选项组合", 30, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCombinationList.AddColumn("memo_no", "选项值", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCombinationList.AddColumn("memo_name", "说明", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCombinationList.AddColumn("app_time", "保存时间", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridCombinationList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridCombinationList.AllowUserToResizeRows = false;
            }





        }
        private void GetGridSchemeList()
        {
            Styleno = GridCombinationList.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
            Combination_no = Convert.ToInt32( GridCombinationList.CurrentRow.Cells["Combination_no"].Value.ToString().Trim());
            SchemeBll sb = new SchemeBll();
            DataTable dt = sb.GetSchemeList_master(Styleno, Combination_no);
            GridSchemeList.DataSource = dt;

            if (this.GridSchemeList.Columns.Count == 0)
            {
                this.GridSchemeList.AddColumn("SchemeNo", "方案号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("SchemeMemo", "方案备注", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("SchemeState", "状态", 60, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("app_time", "应用时间", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("Eton_Line", "生产线", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("Combination_no", "选项组", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("memo_no", "选项", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("Style_no", "款号", 60, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridSchemeList.AddColumn("memo_name", "选项说明", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridSchemeList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridSchemeList.AllowUserToResizeRows = false;
            }




        }

        private void tb_StyleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGridCombinationList();
        }

        private void GridCombinationList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (GridCombinationList.Rows.Count == 0 || GridCombinationList.CurrentRow is null)
            {
                return;
            }
            else
            {
                Combination_no = Convert.ToInt32(GridCombinationList.CurrentRow.Cells["Combination_no"].Value);
                GetGridSchemeList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GridSchemeList.Rows.Count == 0)
            {
                return;
            }
            else if (GridSchemeList.CurrentRow is null)
            {
                return;
            }
            else
            {
                Styleno = GridSchemeList.CurrentRow.Cells["Style_no"].Value.ToString().Trim();
                Combination_no = Convert.ToInt32(GridSchemeList.CurrentRow.Cells["Combination_no"].Value.ToString().Trim());
                memo_name = GridSchemeList.CurrentRow.Cells["memo_name"].Value.ToString().Trim();
                SchemeNo = Convert.ToInt32(GridSchemeList.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim());
                Eton_Line = Convert.ToInt32(GridSchemeList.CurrentRow.Cells["Eton_Line"].Value.ToString().Trim());
                this.DialogResult = DialogResult.OK;
                Close();
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void bt_EditMemo_Click(object sender, EventArgs e)
        {
            if (GridSchemeList.Rows.Count == 0)
            {
                return;
            }
            else if (GridSchemeList.CurrentRow is null)
            {
                return;
            }
            else
            {
                SchemeNo = Convert.ToInt32(GridSchemeList.CurrentRow.Cells["SchemeNo"].Value.ToString().Trim());
                //打开新窗体 用于确认是否为最佳方案和填写备注
                SchemeSave s1 = new SchemeSave(SchemeNo);
                DialogResult f1 = s1.ShowDialog();
                //s1.ShowDialog.DialogResult=
                //返回结果 新方案是否为默认方案 新方案备注
                if (f1 == DialogResult.OK)
                {
                    GetGridSchemeList();
                }
            }            
         }
    }
}
