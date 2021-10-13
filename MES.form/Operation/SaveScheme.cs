using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MES.form.Operation
{
    public partial class SaveScheme : Form
    {
        public SaveScheme()
        {
            InitializeComponent();
        }
        private void SaveScheme_Load(object sender, EventArgs e)
        {

        }
        private void Button_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string SchemeNo_New = "";
        public static int state_new = 1;
        public static string memo = "";
        private void Button_Commit_Click(object sender, EventArgs e)
        {
            try
            {
                //获取目前方案号的最大值，生成新的方案号
                string sql = "select Max(SchemeNo) from MES_station_operation_master";
                
                DataTable dt = DBConn.DataAcess.SqlConn.Query(sql).Tables[0];
                string SchemeNo_Old1 = dt.Rows[0][0].ToString();
                int SchemeNo_Old = 1123;
                if (SchemeNo_Old1 != "") { SchemeNo_Old = Convert.ToInt32(dt.Rows[0][0].ToString()); }

                SchemeNo_New = (SchemeNo_Old + 1).ToString();

                //是否设置为最佳方案 1为最佳 -1为非最佳方案

                if (checkBox_State.CheckState == CheckState.Checked)
                {
                    state_new = -1;
                }
                else { state_new = 1; }

                //方案备注
                memo = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
