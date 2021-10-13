using MES.module.BLL;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;

namespace MES.form.Station
{
    public partial class StationAdd : txMainFormEnterTab
    {
        public StationAdd()
        {
            InitializeComponent();
        }
        string lineNum;
        public StationAdd(string s, string l)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (s == "StationAdd")
            {
                this.Text = "增加工作站";
                this.textBox_Line.Visible = false;
                this.txComboBox1.Visible = true;
                label2.Text = "工作站:";
            }
            else if (s == "LineAdd")
            {
                this.Text = "增加生产线";
                this.textBox_Line.Visible = true;
                this.txComboBox1.Visible = false;
                label2.Text = "产能（小时）:";
            }
            else if (s == "Edit_design_capacity")
            {
                this.Text = "编辑产能";
                this.textBox_Line.Visible = false;
                this.txComboBox1.Visible = true;
                label2.Text = "产能(小时)";
            }

            lineNum = l;
        }

        #region 窗体加载  //加载现有生产线
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationAdd_Load(object sender, EventArgs e)
        {

            if (this.Text == "增加工作站" || this.Text == "编辑产能")
            {

                StationBll sb = new StationBll();
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
        #endregion

        #region 按钮：确定
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonYes_Click(object sender, EventArgs e)
        {
            if (this.Text == "增加工作站")
            {
                if (txComboBox1.Text == "")
                { MessageBox.Show("请选择生产线", "提示"); return; }
                else if (txTextBox1.Text == "")
                { MessageBox.Show(txTextBox1.Text + "不能为空", "提示"); return; }

                    int l = Convert.ToInt16(int.Parse(txComboBox1.Text).ToString());
                    int s = Convert.ToInt16(int.Parse(txTextBox1.Text).ToString());
                    string strsql = "SELECT id,Eton_Line,Eton_WorkStation FROM MES_Station where Eton_Line=" + l + " and Eton_WorkStation =" + s;
                    DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                    if (dt_Station.Rows.Count > 0) { MessageBox.Show("此工作站已存在"); return; }

                    ArrayList SQLList = new ArrayList();
                    SQLList.Add("INSERT INTO [dbo].[MES_station]([Eton_WorkStation],[Eton_Line],[state]) VALUES(" + s + "," + l + ",0)");//state=-1表示未启用
                                                                                                                                         //DBConn.DataAcess.SqlConn.LogInfo("增加工作站", "xulixia", "保存");
                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    MessageBox.Show("新工作站已添加成功", "提示");

                this.Close();
            }
            else if (this.Text == "增加生产线")
            {
                StationBll sb = new StationBll();
                DataTable dt = sb.get_line();
                if (textBox_Line.Text == "" || txTextBox1.Text == "")
                {
                    MessageBox.Show("必须填写所有内容！", "提示"); return;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Eton_line"].ToString() != "" && (Convert.ToInt16(dt.Rows[i]["Eton_line"]) == Convert.ToInt16(int.Parse(textBox_Line.Text).ToString())))
                    {
                        MessageBox.Show("已经存在此生产线号", "提示");
                        return;
                    }
                }
                if (Convert.ToDecimal(this.txTextBox1.Text) > 24)
                {
                    MessageBox.Show("生产线日产能不能大于24小时", "提示");
                    return;
                }
                else
                {

                    int l = Convert.ToInt32(int.Parse(textBox_Line.Text).ToString());//生产线
                    decimal c = Convert.ToDecimal((decimal.Parse(txTextBox1.Text) * 3600).ToString());//将小时转换为秒}//产线日产能  
                    ArrayList SQLList = new ArrayList();
                    //SQLList.Add("INSERT INTO [dbo].[MES_station]([Eton_WorkStation],[Eton_Line],[state]) VALUES(" + s + "," + l + ",0)");//state=-1表示未启用
                    SQLList.Add("INSERT INTO [dbo].[MES_line]([eton_line],[design_capacity]) VALUES(" + l + "," + c + ")");
                    //DBConn.DataAcess.SqlConn.LogInfo("保存排产表", "xulixia", "保存");
                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    MessageBox.Show("已保存新的生产线", "提示");
                    this.Close();
                }
            }
            else if (this.Text == "编辑产能")
            {
                if (this.txComboBox1.Text == "" || txTextBox1.Text == "")
                {
                    MessageBox.Show("必须填写所有内容！", "提示"); return;
                }
                if (Convert.ToDecimal(this.txTextBox1.Text) > 24)
                {
                    MessageBox.Show("生产线日产能不能大于24小时", "提示");
                    return;
                }
                if (txComboBox1.Text == "")
                { MessageBox.Show("请选择生产线", "提示"); return; }
                else if (txTextBox1.Text == "")
                { MessageBox.Show(txTextBox1.Text + "不能为空", "提示"); return; }                
                //txComboBox1.Text = lineNum;
                int l = Convert.ToInt16(txComboBox1.Text);
                Decimal c = Convert.ToDecimal((decimal.Parse(txTextBox1.Text) * 3600).ToString()); //小时转换为秒
                ArrayList SQLList = new ArrayList();
                SQLList.Add("UPDATE [dbo].[MES_line] SET [design_capacity] = " + c + " WHERE [eton_line] = " + l);
                //DBConn.DataAcess.SqlConn.LogInfo("编辑生产线产能", "xulixia", "保存");
                DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                MessageBox.Show("设计产能已修改", "提示");
                this.Close();
            }

        }


        #endregion

        #region 按钮： 取消
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region PressKey事件 限制TEXTBOX输入内容的类型
        /// <summary>
        /// PressKey事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Text == "增加生产线")
            #region
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;       //让操作生效  
                    int j = 0;
                    int k = 0;
                    bool flag = false;
                    if (txTextBox1.Text.Length == 0)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    for (int i = 0; i < txTextBox1.Text.Length; i++)
                    {
                        if (txTextBox1.Text[i] == '.')
                        {
                            j++;
                            flag = true;
                        }
                        if (flag)
                        {
                            if (char.IsNumber(txTextBox1.Text[i]) && e.KeyChar != (char)Keys.Back)
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
                            if (char.IsNumber(txTextBox1.Text[i]) && e.KeyChar != (char)Keys.Back)
                            {
                                if (txTextBox1.Text.Length - txTextBox1.SelectionStart < 3)
                                {
                                    if (txTextBox1.SelectedText != txTextBox1.Text)
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

            #endregion

            if (this.Text == "增加工作站")
            #region
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
                else {  e.Handled = true;  }
            }
            #endregion

            if (this.Text == "编辑产能")
            #region
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;       //让操作生效  
                    int j = 0;
                    int k = 0;
                    bool flag = false;
                    if (txTextBox1.Text.Length == 0)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    for (int i = 0; i < txTextBox1.Text.Length; i++)
                    {
                        if (txTextBox1.Text[i] == '.')
                        {
                            j++;
                            flag = true;
                        }
                        if (flag)
                        {
                            if (char.IsNumber(txTextBox1.Text[i]) && e.KeyChar != (char)Keys.Back)
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
                            if (char.IsNumber(txTextBox1.Text[i]) && e.KeyChar != (char)Keys.Back)
                            {
                                if (txTextBox1.Text.Length - txTextBox1.SelectionStart < 3)
                                {
                                    if (txTextBox1.SelectedText != txTextBox1.Text)
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
            #endregion
        }
        #endregion

        private void txComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lineNum = txComboBox1.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
