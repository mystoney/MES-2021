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
    public partial class OperatorAdd : txMainFormEnterTab
    {
        public OperatorAdd()
        {
            InitializeComponent();
        }

        private void OperatorAdd_Load(object sender, EventArgs e)
        {
            if (this.Text == "增加操作员" || this.Text == "修改密码")
            {

                 sb = new StationBll();
                DataTable dt = sb.get_line();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("当前系统没有任何生产线，请先添加生产线！");
                    this.Close();
                }
                DataTable dt_ComboLine = sb.get_line();
                for (int i = 0; i < dt_ComboLine.Rows.Count; i++)
                {
                    if (dt_ComboLine.Rows[i]["Eton_Line"].ToString() == "")
                    {
                        dt_ComboLine.Rows[i].Delete();
                    }
                }
                txComboBox1.DataSource = dt_ComboLine;
                txComboBox1.DisplayMember = "Eton_line";
                txComboBox1.Text = lineNum;
                this.txTextBox1.Text = "";
            }
            else
            {
                this.textBox_Line.Text = "";
                this.txTextBox1.Text = "";
            }
        }
    }
}
