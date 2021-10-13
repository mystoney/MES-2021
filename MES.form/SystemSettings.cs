using System;
using System.Data;
using System.Windows.Forms;


using MES.module.BLL;

namespace MES.form.Operation
{
    public partial class SystemSettings : Form
    {

        public SystemSettings()
        {
            InitializeComponent();
        }

        #region SystemSettings_Load
            /// <summary>
            /// 加载GRID
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void SystemSettings_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region 按钮：确定
        /// <summary>
        /// 按钮：确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string ip1 = IP1.Text;
            string ip2 = IP2.Text;
            string ip3 = IP3.Text;
            string ip4 = IP4.Text;
            string database = DataBase.Text;
            string user = UserName.Text;
            string password = PW.Text;
            string connectstring = "server=" + ip1 + "." + ip2 + "." + ip3 + "." + ip4 + ";User ID=" + user + ";Password=" + password + ";database=" + database;
            MessageBox.Show(connectstring);
        }
        #endregion

        #region 按钮：退出
        /// <summary>
        /// 按钮：退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }
}
