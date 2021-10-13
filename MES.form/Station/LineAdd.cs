using MES.module.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;

namespace MES.form.Station
{
    public partial class LineAdd : txMainFormEnterTab
    {
        public LineAdd()
        {
            InitializeComponent();
        }

        public LineAdd(string v)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (v == "AddLine")
            {
                this.Text = "增加生产线";
            }

        }

        #region 按钮：确定
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txTextBoxLine.Text = int.Parse(txTextBoxLine.Text).ToString();
            txTextBoxStation.Text = int.Parse(txTextBoxStation.Text).ToString();
            this.txTextBoxLineCapacity.Text = (decimal.Parse(txTextBoxLineCapacity.Text)*3600).ToString();
            StationBll sb = new StationBll();
            DataTable dt = sb.get_line();
            if (txTextBoxLine.Text == "" || txTextBoxStation.Text == "" || txTextBoxLineCapacity.Text == "")
            {
                MessageBox.Show("必须填写所有内容！", "提示"); return;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Eton_line"].ToString() != "" && (Convert.ToInt16(dt.Rows[i]["Eton_line"]) == Convert.ToInt16(this.txTextBoxLine.Text)))
                {
                    MessageBox.Show("已经存在此生产线号", "提示");
                    return;
                }
            }
            if (Convert.ToDecimal(this.txTextBoxLineCapacity.Text) > (24*3600))
            {
                MessageBox.Show("生产线日产能不能大于24小时", "提示");
                return;
            }
            else
            {

                int l = Convert.ToInt32(this.txTextBoxLine.Text);//生产线
                int s = Convert.ToInt32(this.txTextBoxStation.Text);//工作站
                decimal c = Convert.ToDecimal(this.txTextBoxLineCapacity.Text);//将小时转换为秒}//产线日产能  
                ArrayList SQLList = new ArrayList();
                SQLList.Add("INSERT INTO [dbo].[MES_station]([Eton_WorkStation],[Eton_Line],[state]) VALUES(" + s + "," + l + ",0)");//state=-1表示未启用
                SQLList.Add("INSERT INTO [dbo].[MES_line]([eton_line],[design_capacity]) VALUES(" + l + "," + c + ")");
                //DBConn.DataAcess.SqlConn.LogInfo("保存排产表", "xulixia", "保存");
                DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                MessageBox.Show("已保存新的生产线", "提示");
                this.Close();
            }
        }
        #endregion

        #region 按钮：取消
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void txTextBoxLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            //   if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar == 46)
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txTextBoxLineCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txTextBoxLineCapacity.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txTextBoxLineCapacity.Text.Length; i++)
                {
                    if (txTextBoxLineCapacity.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txTextBoxLineCapacity.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txTextBoxLineCapacity.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txTextBoxLineCapacity.Text.Length - txTextBoxLineCapacity.SelectionStart < 3)
                            {
                                if (txTextBoxLineCapacity.SelectedText != txTextBoxLineCapacity.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}








