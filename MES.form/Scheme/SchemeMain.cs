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
    public partial class SchemeMain : Form
    {
        public SchemeMain()
        {
            InitializeComponent();
        }

        int c = 0;//i=-1为查询 1为新增
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">i=-1为查询 1为新增</param>
        public SchemeMain(int i)
        {
            InitializeComponent();
            c = i;           
        }


        int Change = 0;//记录调用或保存方案后，是否有过更改 0表示没改过 1表示改过

        string Line_Num = "";
        DataTable dt_UPS = new DataTable(); //临时存储工位对照表
        int SchemeNo = 0;
        DataTable dt_StyleItem = new DataTable();//
        private void SchemeMain_Load(object sender, EventArgs e)
        {
            StationBll sb_Station = new StationBll();
            //如果用了combo_Line_SelectedIndexChanged,必须DisplayMember在DataSource之前,否则加载时会被赋值System.Data.DataRowView导致执行SQL语句报错
            combo_Line.DisplayMember = "Eton_line";//Combobox加载现有生产线
            combo_Line.DataSource = sb_Station.get_line();


              

               

                lb_Styleno.Text = "";
                lb_Combination.Text = "";
                lb_com_memo.Text = "";
                lb_SchemeNo.Text = "";

            GetGridUPS();
            GetGridStation();
            ChangeButtonStatus();

            //设置隔行背景色
            this.GridUPS.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridUPS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridUPS.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }

       
        #region 加载GridUPS
        /// <summary>
        /// 加载GridUPS
        /// </summary>
        private void GetGridUPS()
        {
            if (this.GridUPS.Rows.Count>0)
            {
                this.GridUPS.Rows.Clear();
                dt_UPS.Rows.Clear();
            }

            SchemeBll sc = new SchemeBll();


            dt_UPS = sc.GetSchemeList_detail(SchemeNo.ToString());


            if (this.GridUPS.Columns.Count == 0)
            {
                this.GridUPS.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("Eton_Line", "生产线", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("Eton_WorkStation", "工作站", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true); 
                this.GridUPS.AddColumn("SchemeOperationNo", "工序代码", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("SchemeOperationDes", "描述", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("op_type", "工序类型代码", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("op_des", "工序类型", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridUPS.Columns[0].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridUPS.AllowUserToResizeRows = false;
            }

            if (dt_UPS.Rows.Count > 0)
            {

                for (int i = 0; i < dt_UPS.Rows.Count; i++)
                {
                    TaskViewEditHelper_OnAddStep(dt_UPS.Rows[i]["Eton_Line"].ToString().Trim(), dt_UPS.Rows[i]["Eton_WorkStation"].ToString().Trim(), dt_UPS.Rows[i]["SchemeOperationNo"].ToString().Trim(), dt_UPS.Rows[i]["SchemeOperationDes"].ToString().Trim(), dt_UPS.Rows[i]["op_type"].ToString().Trim(), dt_UPS.Rows[i]["op_des"].ToString().Trim(), dt_UPS.Rows[i]["SchemeNo"].ToString().Trim());
         
                }
            }

            Change = 0;
        }
        #endregion
        #region 加载GridStation
        /// <summary>
        /// 加载GridStation
        /// </summary>
        private void GetGridStation()
        {

            if (Line_Num == "")
            {
                string strsql = "SELECT id,Eton_Line,Eton_WorkStation FROM MES_Station where Eton_Line=-1 ";

                DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                GridStation.DataSource = dt_Station;
            }
            if (Line_Num != "")
            {
                string strsql = "SELECT id,Eton_Line,Eton_WorkStation FROM MES_Station where Eton_Line = " + combo_Line.Text + " order by Eton_WorkStation ";
                DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                GridStation.DataSource = dt_Station;
                combo_Line.Text = Line_Num;
            }
            else
            {
                string strsql = "SELECT id,Eton_Line,Eton_WorkStation FROM MES_Station where Eton_Line = -1";
                DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                GridStation.DataSource = dt_Station;

            }
            if (this.GridStation.Columns.Count == 0)
            {
                this.GridStation.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridStation.AddColumn("Eton_Line", "生产线号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridStation.AddColumn("Eton_WorkStation", "工作站号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridStation.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridStation.AllowUserToResizeRows = false;
            }
        }
        #endregion
        #region 选择生产线
        /// <summary>
        /// 选择生产线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combo_Line_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchemeBll sb = new SchemeBll();
            int schemeline = sb.GetSchemeLineNum(SchemeNo.ToString());

            if (combo_Line.Text.ToString().Trim() != schemeline.ToString().Trim())
            {
                GetGridUPS();
            }
            if (combo_Line.Text.ToString().Trim() != Line_Num.Trim())
            {
                Line_Num = combo_Line.Text.ToString().Trim();
                GetGridStation();
                GetGridUPS();
                ChangeButtonStatus();
            }
            else { return; }

        }
        #endregion
        #region 编辑Datagridview


        private void TaskViewEditHelper_OnAddStep(string Eton_Line, string Eton_WorkStation, string SchemeOperationNo, string SchemeOperationDes, string op_type, string op_des, string SchemeNo)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(this.GridUPS);
            dr.Cells[0].Value = "";
            dr.Cells[1].Value = Eton_Line;
            dr.Cells[2].Value = Eton_WorkStation;
            dr.Cells[3].Value = SchemeOperationNo;
            dr.Cells[4].Value = SchemeOperationDes;
            dr.Cells[5].Value = op_type;
            dr.Cells[6].Value = op_des;
            






            //this.GridUPS.Rows.Insert(0, dr); //添加的行作为第一行
            this.GridUPS.Rows.Add(dr);//添加的行作为最后一行
        }

        private void TaskViewEditHelper_OnRemoveStep()
        {
            if (this.GridUPS.SelectedRows == null || this.GridUPS.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择删除步，单击第一列以选中行");
            }
            else
            {
                if (MessageBox.Show("确定要删除选中步吗？") == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataGridViewRow dr in this.GridUPS.SelectedRows)
                    {
                        if (dr.IsNewRow == false)
                        {
                            //如果不是已提交的行，默认情况下在添加一行数据成功后，DataGridView为新建一行作为新数据的插入位置
                            this.GridUPS.Rows.Remove(dr);
                        }
                    }
                }
            }
        }



        private void TaskViewEditHelper_OnUpStep()
        {
            if (this.GridUPS.SelectedRows == null || this.GridUPS.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行，单击第一列以选中行");
            }
            else
            {
                if (this.GridUPS.SelectedRows[0].Index <= 0)
                {
                    MessageBox.Show("此行已在顶端，不能再上移！");
                }
                else
                {
                    //注意：这里是非绑定数据情况的上移行
                    // 选择的行号
                    int selectedRowIndex = GetSelectedRowIndex(this.GridUPS);
                    if (selectedRowIndex >= 1)
                    {
                        // 拷贝选中的行
                        DataGridViewRow newRow = GridUPS.Rows[selectedRowIndex];
                        // 删除选中的行
                        GridUPS.Rows.Remove(GridUPS.Rows[selectedRowIndex]);
                        // 将拷贝的行，插入到选中的上一行位置
                        GridUPS.Rows.Insert(selectedRowIndex - 1, newRow);
                        GridUPS.ClearSelection();
                        // 选中最初选中的行
                        GridUPS.Rows[selectedRowIndex - 1].Selected = true;
                    }
                }
            }
        }
        private int GetSelectedRowIndex(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                return 0;
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Selected)
                {
                    return row.Index;
                }
            }
            return 0;
        }



        private void TaskViewEditHelper_OnDownStep()
        {
            if (this.GridUPS.SelectedRows == null || this.GridUPS.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行，单击第一列以选中行");
            }
            else
            {
                if (this.GridUPS.SelectedRows[0].Index >= this.GridUPS.Rows.Count - 1)
                {
                    MessageBox.Show("此行已在底端，不能再下移！");
                }
                else
                {
                    int selectedRowIndex = GetSelectedRowIndex(this.GridUPS);
                    if (selectedRowIndex < GridUPS.Rows.Count - 1)
                    {
                        // 拷贝选中的行
                        DataGridViewRow newRow = GridUPS.Rows[selectedRowIndex];
                        // 删除选中的行 
                        GridUPS.Rows.Remove(GridUPS.Rows[selectedRowIndex]);
                        // 将拷贝的行，插入到选中的下一行位置
                        GridUPS.Rows.Insert(selectedRowIndex + 1, newRow);
                        GridUPS.ClearSelection();
                        // 选中最初选中的行
                        GridUPS.Rows[selectedRowIndex + 1].Selected = true;
                    }
                }
            }
        }
        #endregion
        #region 按钮-增加
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.GridStation.SelectedRows == null || this.GridStation.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行，单击第一列以选中行");

            }
            else
            {
                TaskViewEditHelper_OnAddStep(combo_Line.Text.Trim(), GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString(), "MESOP0" + GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString(), GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString() + "工序", "2", "普通工序", "");
                Change = Change + 1;
                ChangeButtonStatus();
            }

        }
        #endregion
        #region 按钮-删除
        private void button4_Click(object sender, EventArgs e)
        {
            TaskViewEditHelper_OnRemoveStep();
            Change = Change + 1;
            ChangeButtonStatus();
        }
        #endregion
        #region 按钮-上移
        private void button5_Click(object sender, EventArgs e)
        {
            TaskViewEditHelper_OnUpStep();
            Change = Change + 1;
            ChangeButtonStatus();
        }
        #endregion
        #region 按钮-下移
        private void button6_Click(object sender, EventArgs e)
        {
            TaskViewEditHelper_OnDownStep();
            Change = Change + 1;
            ChangeButtonStatus();
        }
        #endregion
        #region 按钮-更改工作位的工序类型
        private void button7_Click(object sender, EventArgs e)
        {
            ChangeOperationDes("上架");
            Change = Change + 1;
            ChangeButtonStatus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeOperationDes("下架");
            Change = Change + 1;
            ChangeButtonStatus();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ChangeOperationDes("检查");
            Change = Change + 1;
            ChangeButtonStatus();
        }        
        private void button2_Click(object sender, EventArgs e)
        {
            ChangeOperationDes("普通");
            Change = Change + 1;
            ChangeButtonStatus();
        }
        #endregion
        #region 更改工作位的工序类型
        private void ChangeOperationDes(string OpTypeDes)
        {
            if (this.GridUPS.SelectedRows == null || this.GridUPS.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行，单击第一列以选中行");
                return;
            }
            else
            {
                int selectedRowIndex = GetSelectedRowIndex(this.GridUPS);
                if (OpTypeDes == "上架")
                { 
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationNo"].Value = "10000";
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationDes"].Value = OpTypeDes;
                    GridUPS.Rows[selectedRowIndex].Cells["op_type"].Value = 1;
                    GridUPS.Rows[selectedRowIndex].Cells["op_des"].Value = OpTypeDes;
                }            
                else if (OpTypeDes == "下架")
                {
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationNo"].Value = "10001";
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationDes"].Value = OpTypeDes;
                    GridUPS.Rows[selectedRowIndex].Cells["op_type"].Value = 8;
                    GridUPS.Rows[selectedRowIndex].Cells["op_des"].Value = OpTypeDes;
                }
                else if (OpTypeDes == "检查") 
                {
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationNo"].Value = "2160";
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationDes"].Value = OpTypeDes;
                    GridUPS.Rows[selectedRowIndex].Cells["op_type"].Value = 4;
                    GridUPS.Rows[selectedRowIndex].Cells["op_des"].Value = OpTypeDes;
                }
                else 
                {                    
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationNo"].Value = "MESOP0"+GridUPS.Rows[selectedRowIndex].Cells["Eton_WorkStation"].Value.ToString();
                    GridUPS.Rows[selectedRowIndex].Cells["SchemeOperationDes"].Value = GridUPS.Rows[selectedRowIndex].Cells["Eton_WorkStation"].Value.ToString()+"工序";
                    GridUPS.Rows[selectedRowIndex].Cells["op_type"].Value = 2;
                    GridUPS.Rows[selectedRowIndex].Cells["op_des"].Value = "普通工序"; 
                }

            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            CombinationSelect cs = new CombinationSelect();
            DialogResult f1 = cs.ShowDialog();
            if (f1 == DialogResult.OK)
            {
                lb_Styleno.Text = cs.dt_Combination.Rows[0]["style_no"].ToString().Trim();
                lb_Combination.Text = cs.dt_Combination.Rows[0]["Combination_no"].ToString().Trim();
                lb_com_memo.Text = cs.dt_Combination.Rows[0]["memo_name"].ToString().Trim();
                cs.Close();
            }
            else
            {
                lb_Styleno.Text = "";
                lb_Combination.Text = "";
                lb_com_memo.Text = "";
                cs.Close();
            }
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.GridUPS.Rows.Count == 0)
            {
                return;
            }
            if (this.GridUPS.Rows[0].Cells["SchemeOperationDes"].Value.ToString().Trim() != "上架")
            {
                MessageBox.Show("上架站必须在第一行");
                return;
            }
            if (this.GridUPS.Rows[GridUPS.Rows.Count - 1].Cells["SchemeOperationDes"].Value.ToString().Trim() != "下架")
            {
                MessageBox.Show("下架站必须在最后一行");
                return;
            }
            if (lb_Styleno.Text.Trim() == "" || lb_Combination.Text.Trim() == "" || lb_com_memo.Text.Trim() == "")
            {
                MessageBox.Show("请选择款号及选项");
                return;
            }

            DialogResult key = MessageBox.Show("点击'确定'将生成新的方案 点击'取消'返回修改", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                //新方案是否为默认方案 0默认 1备用 新方案备注
                int state = 0;
                string memo = "";
                Line_Num = combo_Line.Text;


                //打开新窗体 用于确认是否为最佳方案和填写备注
                SchemeSave s1 = new SchemeSave();
                DialogResult f1 = s1.ShowDialog();
                //s1.ShowDialog.DialogResult=
                //返回结果 新方案是否为默认方案 新方案备注
                if (f1 == DialogResult.OK)
                {
                    state = SchemeSave.state_new;
                    memo = SchemeSave.memo;
                    try
                    {
                        SchemeBll sb = new SchemeBll();
                        SchemeNo = sb.Scheme_Station_Add(Convert.ToInt32(lb_Combination.Text.Trim()), GridUPS, state, memo);
                        if (SchemeNo != 0)
                        {
                            lb_SchemeNo.Text = SchemeNo.ToString();
                            Change = 0;
                            MessageBox.Show("完成");
                            ChangeButtonStatus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("没有保存成功");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
    }

    private void ChangeButtonStatus()
        {
            if (GridUPS.Rows.Count == 0)
            {
                button7.Enabled = false;
                button2.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
                ButtonSave.Enabled = false;
                button10.Enabled = false;
            }
            else 
            {
                button7.Enabled = true;
                button2.Enabled = true;
                button9.Enabled = true;
                button8.Enabled = true;
                button10.Enabled = true;



                if (Change >0)
                {
                    ButtonSave.Enabled = true;//保存按钮
                }
                else
                {
                    ButtonSave.Enabled = false;
                }


            }
        
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSelectScheme_Click(object sender, EventArgs e)
        {
            if (GridUPS.Rows.Count > 0)
            {   //如果工位工序表格有内容 提示是否要选择新订单号 选择新订单号将丢失未保存的排产表
                if (MessageBox.Show("'OK'当前内容将被清空 'Cancel'返回", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
            }
            dt_UPS.Clear();
            SchemeSelect ss = new SchemeSelect();
            ss.ShowDialog();
            DialogResult dr = ss.DialogResult;
            if (dr == DialogResult.OK)
            {
                lb_Styleno.Text = SchemeSelect.Styleno;
                lb_Combination.Text = SchemeSelect.Combination_no.ToString();
                lb_com_memo.Text = SchemeSelect.memo_name;
                lb_SchemeNo.Text = SchemeSelect.SchemeNo.ToString();
                SchemeNo = SchemeSelect.SchemeNo;
                Line_Num = SchemeSelect.Eton_Line.ToString();
                ss.Close();
            }
            else
            {
                lb_Styleno.Text = "";
                lb_Combination.Text = "";
                lb_com_memo.Text = "";
                lb_SchemeNo.Text = "";
                SchemeNo = 0;
                Line_Num ="";

                ss.Close();
            }

            if (Line_Num == "")
            {
                combo_Line.Text = "";

            }
            else
            {
                combo_Line.Text = Line_Num;

            }
            Change = 0;//记录调用或保存方案后，是否有过更改 0表示没改过 1表示改过

            GetGridStation();
            GetGridUPS();
            ChangeButtonStatus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (GridUPS.Rows.Count > 0)
            { 
                GridUPS.Rows.Clear();
                SchemeNo = 0;
                Line_Num = "";
                Change = 0;
                lb_SchemeNo.Text = "";
                ChangeButtonStatus();
            }            
        }
    }
}
