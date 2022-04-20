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
        OperatorInfo oi_this = new OperatorInfo();
        public OperatorAdd()
        {
            InitializeComponent();
            this.Text = "增加操作员";
        }
        public OperatorAdd(OperatorInfo oi, string EditOperator)
        {
            InitializeComponent();
            this.Text = EditOperator;
            oi_this = oi;
        }


        private void OperatorAdd_Load(object sender, EventArgs e)
        {
            OperatorBll ob = new OperatorBll();

            if (this.Text == "增加操作员")
            {
                textBox_OperatorID.Text = "";
                TextBox_OperatorName.Text = "";
                textBox_OperatorPassword.PasswordChar = '*';
                textBox_OperatorPassword.Text = "";
            }
            if (this.Text == "重置密码")
            {
                textBox_OperatorID.Text = oi_this.OperatorID;
                textBox_OperatorID.Enabled = false;
                TextBox_OperatorName.Text = oi_this.OperatorName;
                TextBox_OperatorName.Enabled = false;
                textBox_OperatorPassword.PasswordChar = '*';
                textBox_OperatorPassword.Text = "";
                if (oi_this.OperatorType == "PF")
                {
                    cb_OperatorType.Text = "平缝";
                }
                if (oi_this.OperatorType == "FZ")
                {
                    cb_OperatorType.Text = "辅助";
                }
                else
                {
                    cb_OperatorType.Text = oi_this.OperatorType;
                }
                cb_OperatorType.Enabled = false;
            }
            if (this.Text == "更改工种")
            {
                textBox_OperatorID.Text = oi_this.OperatorID;
                textBox_OperatorID.Enabled = false;
                TextBox_OperatorName.Text = oi_this.OperatorName;
                TextBox_OperatorName.Enabled = false;
                textBox_OperatorPassword.PasswordChar = '*';
                textBox_OperatorPassword.Text = oi_this.OperatorPassword;
                textBox_OperatorPassword.Enabled = false;
                if (oi_this.OperatorType == "PF")
                {
                    cb_OperatorType.Text = "平缝";
                }
                if (oi_this.OperatorType == "FZ")
                {
                    cb_OperatorType.Text = "辅助";
                }
                else
                {
                    cb_OperatorType.Text = oi_this.OperatorType;
                }
                cb_OperatorType.Enabled = true;
            }
        }
 

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            if (this.Text == "增加操作员")
            {
                if (textBox_OperatorID.Text.Trim() == "" || TextBox_OperatorName.Text.Trim() == "")
                {
                    MessageBox.Show("必须输入用户ID及姓名", "提示", MessageBoxButtons.OK);
                    textBox_OperatorPassword.Text = "";
                    return;
                }
                else if (cb_OperatorType.Text.Trim() == "")
                {
                    MessageBox.Show("必须选择工作类型 PF/FZ", "提示", MessageBoxButtons.OK);
                    textBox_OperatorPassword.Text = "";
                    return;
                }
                else if (cb_OperatorType.Text.Trim() != "辅助" && cb_OperatorType.Text.Trim() != "平缝")
                {
                    MessageBox.Show("工作类型只能包含“辅助”和“平缝”", "提示", MessageBoxButtons.OK);
                    textBox_OperatorPassword.Text = "";
                    return;
                }
            }
            
            OperatorBll ob = new OperatorBll();
            OperatorBll.OperatorInfo oi = new OperatorBll.OperatorInfo();
            oi.OperatorID = textBox_OperatorID.Text.Trim();
            oi.OperatorName = TextBox_OperatorName.Text.Trim();
            oi.OperatorPassword = textBox_OperatorPassword.Text;
            if (cb_OperatorType.Text.Trim() == "平缝")
            {
                oi.OperatorType = "PF";
            }
            else if (cb_OperatorType.Text.Trim() == "辅助")
            {
                oi.OperatorType = "FZ";
            }
            if (this.Text == "增加操作员")
            {
                OperatorBll.Return_Message rm = new OperatorBll.Return_Message();

                rm = ob.OperatorInsert(oi);
                if (rm.State == OperatorBll.Return_Message.Return_State.Error)
                {
                    MessageBox.Show(rm.Message, "提示", MessageBoxButtons.OK);
                    textBox_OperatorPassword.Text = "";
                    return;
                    //throw new Exception(rm.Message);
                    
                }
                else
                {
                    this.Close();
                }
               
            }
            if (this.Text == "重置密码")
            {
                OperatorBll.Return_Message rm = new OperatorBll.Return_Message();

                rm = ob.OperatorUpdatePassword(oi);
                if (rm.State == OperatorBll.Return_Message.Return_State.Error)
                {
                    MessageBox.Show(rm.Message, "提示", MessageBoxButtons.OK);
                    textBox_OperatorPassword.Text = "";
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            if (this.Text == "更改工种")
            {
                OperatorBll.Return_Message rm = new OperatorBll.Return_Message();

                rm = ob.OperatorUpdateType(oi);
                if (rm.State == OperatorBll.Return_Message.Return_State.Error)
                {
                    MessageBox.Show(rm.Message, "提示", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    this.Close();
                }

            }
            
        }
        public class OperatorInfo
        {
            /// <summary>
            /// id
            /// </summary>
            public int id { get; set; }
            public string OperatorID { get; set; }
            public string OperatorName { get; set; }
            public string OperatorPassword { get; set; }
            public int OperatorState { get; set; }
            public string OperatorType { get; set; }
        }      
    }
}
