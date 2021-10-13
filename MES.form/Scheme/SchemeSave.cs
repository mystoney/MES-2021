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
    public partial class SchemeSave : txMainFormEnterTab
    {
        public SchemeSave()
        {
            InitializeComponent();
        }
        public static int state_new = 0;// 0默认 1备用
        public static string memo = "";

        private void SchemeSave_Load(object sender, EventArgs e)
        {

        }

        private void Button_Commit_Click(object sender, EventArgs e)
        {
            try
            {
                //是否设置为最佳方案 1为最佳 -1为非最佳方案
                if (checkBox_State.CheckState == CheckState.Checked)
                {
                    state_new = 1;
                }
                else { state_new = 0; }

                //方案备注
                memo = textBox3.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
