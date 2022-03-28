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

namespace MES.form.Operation
{

    public partial class Form1_Load : Form
    {
        public Form1_Load()
        {
            InitializeComponent();
        }


        #region 检查源是否可用
        /// <summary>
        /// 检查源是否可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (RB_SchemeNo.Checked)//参考方案号
            {
                if (txOldSchemeNo.Text.Trim() == "")
                {
                    MessageBox.Show("选择的参考方案号不能为空！", "提示");
                    label8.Text = "不可用";
                    label8.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    string OldSchemeNo = txOldSchemeNo.Text.Trim();
                    string sqlstr = "SELECT [SchemeNo],[CompleteState]  FROM [mes].[dbo].[MES_station_operation_master]  where SchemeNo='" + OldSchemeNo + "'";
                    DataTable dt1 = DBConn.DataAcess.SqlConn.Query(sqlstr).Tables[0];
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("参考方案号不存在！", "提示");
                        label8.Text = "不可用";
                        label8.ForeColor = Color.Red;
                        return;
                    }
                    else
                    {
                        if (Convert.ToInt16(dt1.Rows[0]["CompleteState"].ToString().Trim()) != 1)
                        {
                            MessageBox.Show("参考方案必须是完整的！", "提示");
                            label8.Text = "不可用";
                            label8.ForeColor = Color.Red;
                            return;
                        }
                        else
                        {
                            string sqlstr0 = "SELECT TOP 1 [order_no]  FROM [mes].[dbo].[MES_order_master]  where schemeno=" + OldSchemeNo + "  order by [input_date] desc";
                            DataTable dt = DBConn.DataAcess.SqlConn.Query(sqlstr0).Tables[0];
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("没找到此方案号对应的在用工单，无法复制工序！", "提示");
                                label8.Text = "不可用";
                                label8.ForeColor = Color.Red;
                                return;
                            }
                            else
                            {
                                txOldOrderNo.Text = dt.Rows[0]["order_no"].ToString().Trim();
                                label8.Text = "可用";
                                label8.ForeColor = Color.Green;
                                RB_OrderNo.Enabled = false;
                                RB_SchemeNo.Enabled = false;
                                txOldOrderNo.Enabled = false;
                                txOldSchemeNo.Enabled = false;
                                button3.Visible = true;

                            }
                        }
                    }
                }
            }
            else if (RB_OrderNo.Checked)//参考订单号
            {
                if (txOldOrderNo.Text.Trim() == "")
                {
                    MessageBox.Show("选择的参考工单号不能为空！", "提示");
                    label8.Text = "不可用";
                    label8.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    string sqlstr = "SELECT order_no,[SchemeNo] FROM [mes].[dbo].[MES_order_master]  where order_no='" + txOldOrderNo.Text.Trim() + "'";
                    DataTable dt = DBConn.DataAcess.SqlConn.Query(sqlstr).Tables[0];
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("选择的参考工单不存在！", "提示");
                        label8.Text = "不可用";
                        label8.ForeColor = Color.Red;
                        return;
                    }
                    else
                    {
                        if (dt.Rows[0]["SchemeNo"].ToString().Trim() == "")
                        {
                            MessageBox.Show("选择的参考工单没有可用方案！", "提示");
                            label8.Text = "不可用";
                            label8.ForeColor = Color.Red;
                            return;
                        }
                        else
                        {
                            string OldSchemeNo = dt.Rows[0]["SchemeNo"].ToString().Trim();

                            string sqlstr0 = "SELECT [SchemeNo],[CompleteState]  FROM [mes].[dbo].[MES_station_operation_master]  where SchemeNo='" + OldSchemeNo + "'";
                            DataTable dt1 = DBConn.DataAcess.SqlConn.Query(sqlstr0).Tables[0];
                            if (dt1.Rows.Count == 0)
                            {
                                MessageBox.Show("参考工单对应的方案不存在！", "提示");
                                label8.Text = "不可用";
                                label8.ForeColor = Color.Red;
                                return;
                            }
                            else
                            {
                                if (Convert.ToInt16(dt1.Rows[0]["CompleteState"].ToString().Trim()) != 1)
                                {
                                    MessageBox.Show("参考方案必须是完整的！", "提示");
                                    label8.Text = "不可用";
                                    label8.ForeColor = Color.Red;
                                    return;
                                }
                                else
                                {
                                    txOldSchemeNo.Text = dt1.Rows[0]["SchemeNo"].ToString().Trim();
                                    label8.Text = "可用";
                                    label8.ForeColor = Color.Green;
                                    RB_OrderNo.Enabled = false;
                                    RB_SchemeNo.Enabled = false;
                                    txOldOrderNo.Enabled = false;
                                    txOldSchemeNo.Enabled = false;
                                    button3.Visible = true;

                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion 检查源是否可用
        #region 重新输入参考工单号 或者 方案号
        /// <summary>
        /// 重新输入参考工单号 或者 方案号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            RB_OrderNo.Enabled = true;
            RB_SchemeNo.Enabled = true;
            txOldOrderNo.Enabled = true;
            txOldOrderNo.Text = "";
            txOldSchemeNo.Enabled = true;
            txOldSchemeNo.Text = "";


            label8.Text = "必须点击检查";
            label8.ForeColor = Color.Black;
            button3.Visible = false;
        }
        #endregion 重新输入参考工单号 或者 方案号

        private void RB_OrderNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_OrderNo.Checked)
            {
                txOldSchemeNo.Text = "";
            }
            else { txOldOrderNo.Text = ""; }
        }

        private void RB_SchemeNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SchemeNo.Checked)
            {
                txOldOrderNo.Text = "";
            }
            else { txOldSchemeNo.Text = ""; }
        }


        /// <summary>
        /// 检查新工单是否存在 工单数量大于0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (txorder_qty.Text.Trim() == "")
            {
                MessageBox.Show("工单数量不能为空！", "提示");
                label9.Text = "不可用";
                label9.ForeColor = Color.Red;
                return;
            }
            if (txStyleNo.Text.Trim() == "")
            {
                MessageBox.Show("款号不能为空！", "提示");
                label9.Text = "不可用";
                label9.ForeColor = Color.Red;
                return;
            }
            if (txOrderNo.Text == "")
            {
                MessageBox.Show("工单号不能为空！", "提示");
                label9.Text = "不可用";
                label9.ForeColor = Color.Red;
                return;
            }

            if (Convert.ToInt16(txorder_qty.Text.ToString().Trim()) < 1)
            {
                MessageBox.Show("工单数量不能小于1！", "提示");
                label9.Text = "不可用";
                label9.ForeColor = Color.Red;
                return;
            }

            string sqlstr0 = "SELECT [order_no] FROM [mes].[dbo].[MES_order_master]  where order_no='" + txOrderNo.Text.Trim() + "'";
            DataTable dt = DBConn.DataAcess.SqlConn.Query(sqlstr0).Tables[0];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("工单已存在！", "提示");
                label9.Text = "不可用";
                label9.ForeColor = Color.Red;
                return;
            }

            label9.Text = "可用";
            label9.ForeColor = Color.Green;
            button4.Visible = true;






        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = "请点击检查";
            label9.ForeColor = Color.Red;
            button4.Visible = false;
        }

        private void Button_Commit_Click(object sender, EventArgs e)
        {
            if (label8.Text.Trim() != "可用")
            {
                MessageBox.Show("源需要检查！", "提示");
                return;
            }
            if (label9.Text.Trim() != "可用")
            {
                MessageBox.Show("目标需要检查！", "提示");
                return;
            }
            if (textBox1.Text.Trim() == "")
            {
                if (MessageBox.Show("确认不填写方案说明吗？是否继续？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }


            string OldOrder_no = txOldOrderNo.Text.Trim();
            string OldSchemeNo = txOldSchemeNo.Text.Trim();

            string NewOrder_no = txOrderNo.Text.Trim();
            string order_qty = txorder_qty.Text.Trim();
            string Newstyle_no = txStyleNo.Text.Trim();
            string NewOrder_date = txOrder_date.Value.ToString("yyyy-MM-dd");
            string memo = textBox1.Text;                //方案备注

            try
            {
                //第一步：生成新的工单
                //根据提供的方案号，找到最新录入的工单，取此工单的工序，生成新的工单。


                //主表：[mes].[dbo].[MES_order_master]
                //[order_no]=Neworder_no
                //[order_date]=NewOrder_date
                //[input_date]=DateTime.Now.ToString()
                //[style_no]=Newstyle_no
                //[order_qty]=order_qty

                //子表：MES_order_detail_operation

                //第二步：生成新的方案
                string sql = "select Max(SchemeNo) from MES_station_operation_master";

                DataTable dt = DBConn.DataAcess.SqlConn.Query(sql).Tables[0];
                string SchemeNo_Old1 = dt.Rows[0][0].ToString();//数据库中最后一个方案号
                int SchemeNo_Old = 1123;
                if (SchemeNo_Old1 != "") { SchemeNo_Old = Convert.ToInt32(dt.Rows[0][0].ToString()); }
                string SchemeNo_New = (SchemeNo_Old + 1).ToString();//要生成的新方案的方案号



                //工序类别表
                // insert into MES_operation_detail_type
                //  SELECT 1295 as [SchemeNo]
                //,[OpCodeAlpha1]
                //,[op_type]
                //  FROM[mes].[dbo].[MES_operation_detail_type]
                //  where schemeNo = 1281

                //方案子表
                //insert into MES_station_operation_detail
                //SELECT
                //            1291 as [SchemeNo]
                //            ,[Eton_Line]
                //            ,[Eton_WorkStation]
                //            ,[OpCodeAlpha1]
                //            ,[GST_xh]
                //FROM[mes].[dbo].[MES_station_operation_detail]
                //ere schemeno = 1280





                //第三步：将新方案应用到新工单

    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
