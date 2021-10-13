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
using MES.module.model;
using TX.Framework.WindowUI.Forms;
using System.Collections;

namespace MES.form.Station
{
    public partial class StationMain : Form
    {

        #region StationMain()
        /// <summary>
        /// StationMain()
        /// </summary>
        public StationMain()
        {
            InitializeComponent();
        }
        #endregion

        #region StationMain(int v)
        /// <summary>
        /// StationMain(int v)
        /// </summary>
        /// <param name="t">1为更改状态，2为更改数量</param>
        public StationMain(int v)
        {
            InitializeComponent();
                this.Text = "编辑生产线工作站";
                this.toolStripState.Visible = true;            
        }
        #endregion

        #region StationMain_Load
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationMain_Load(object sender, EventArgs e)
        {
            this.GridStation.AutoGenerateColumns = false; //不给GridView增加扩展列
                                                          //设置隔行背景色

            this.GridStation.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridStation.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridStation.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridStation.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;

            this.GridLine.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridLine.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridLine.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            this.GridLine.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;

            GetGridLine();
            if (GridLine.Rows.Count > 0)
            {
                GridLine.CurrentCell = GridLine.Rows[0].Cells["Eton_Line"];
                Line_Num = GridLine.CurrentRow.Cells["Eton_Line"].Value.ToString();
            }
            
            if (Line_Num != "") { GetGridStation(); }


        }
        #endregion

        string Line_Num = "";

        #region 加载GridLine
        /// <summary>
        /// 加载Grid
        /// </summary>
        private void GetGridLine()
        {
            string strsql = "SELECT [id],[eton_line],[design_capacity]/3600.00 as DC  FROM [dbo].[MES_line] order by eton_line ";
            DataTable dt_Line = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
            GridLine.DataSource = dt_Line;
            if (this.GridLine.Columns.Count == 0)
            {
                this.GridLine.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridLine.AddColumn("Eton_Line", "生产线编号", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridLine.AddColumn("DC", "设计产能(小时)", 120, true, null, DataGridViewContentAlignment.MiddleLeft, "#0.00", true);
                this.GridLine.AddColumn("id", "ID", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                // 实现列的锁定功能  
                this.GridLine.Columns[1].Frozen = true;
            }
        }
        #endregion 加载Grid

        #region 加载GridStation
        private void GetGridStation()
        {
            string strsql = "SELECT [id],[Eton_WorkStation],[Eton_Line],[binding_no],[state],0 as Edit,CASE WHEN state = '0' then '停用' else '启用' end  ZT   FROM MES_station where [Eton_Line]= '" + Line_Num + "'";
            DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
            GridStation.DataSource = dt_Station;
            if (this.GridStation.Columns.Count == 0)
            {
                this.GridStation.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridStation.AddColumn("Eton_WorkStation", "工作站编号", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridStation.AddColumn("ZT", "状态", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridStation.AddColumn("Eton_Line", "生产线编号", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridStation.AddColumn("id", "ID", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                // 实现列的锁定功能  
                this.GridStation.Columns[1].Frozen = true;
            }
        }
        #endregion

        #region 绘制GridStation行背景色
        /// <summary>
        /// 绘制GRID行背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.GridStation.Rows[e.RowIndex].Cells["ZT"].Value.ToString() == "启用")
            {
                this.GridStation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else if (this.GridStation.Rows[e.RowIndex].Cells["ZT"].Value.ToString() == "停用")
            {
                this.GridStation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }

        }
        #endregion

        //--------------------------工具栏按钮--------------------------//

        #region 按钮：工具栏 增加生产线 弹出窗体LineAdd
        /// <summary>
        /// 增加生产线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddLine_Click_1(object sender, EventArgs e)
        {
            Station.StationAdd s1 = new Station.StationAdd("LineAdd","");
            s1.ShowDialog();
            GetGridLine();
            GridLine_CurrentCell();
        }
        #endregion

        #region 按钮：工具栏 删除生产线 弹出窗体LineEdit("LineDel")
        private void ButtonDELLine_Click_1(object sender, EventArgs e)
        {
            Del("Line");
            GetGridLine();
            GridLine_CurrentCell();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏 启用生产线 弹出窗体LineEdit("LineStart")
        /// <summary>
        /// 删除工作站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStartLine_Click(object sender, EventArgs e)
        {
           Start("Line");
            GetGridLine();
            GridLine_CurrentCell();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏 停用生产线 弹出窗体LineEdit("LineStart")
        /// <summary>
        /// 删除工作站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStopLine_Click(object sender, EventArgs e)
        {
          Stop("Line");
            GetGridLine();
            GridLine_CurrentCell();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏  编辑产能
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string line = "";
            int count = 0;
            //用于保存选中的checkbox数量
            for (int i = 0; i < GridLine.RowCount; i++)
            {
                if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                //这里判断复选框是否选中
                {
                    count++;
                }
            }

            if (count == 0)
            {
                if (GridLine.Rows.Count > 0) { line = GridLine.CurrentRow.Cells["Eton_Line"].Value.ToString(); }


                //MessageBox.Show("请选择生产线！", "提示");
                // return;
            }
            else if (count > 1)
            {
                MessageBox.Show("每次只能选择一条生产线！", "提示");
                return;
            }
            else
            {
                for (int i = 0; i < GridLine.RowCount; i++)
                {
                    if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                    //这里判断复选框是否选中
                    {
                        line = GridLine.Rows[i].Cells["Eton_Line"].Value.ToString();
                    }
                }
            }

            Station.StationAdd s1 = new Station.StationAdd("Edit_design_capacity", line);
            s1.ShowDialog();
            GetGridLine();
            GridLine_CurrentCell();

        }
        #endregion

        #region 按钮：工具栏 增加工作站 弹出窗体StationAdd
        /// <summary>
        /// 增加工作站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddStation_Click_1(object sender, EventArgs e)
        {
            StationAdd stationadd = new Station.StationAdd("StationAdd", Line_Num);
            stationadd.ShowDialog();
            GetGridLine();
            GridLine_CurrentCell();
            GetGridStation();

        }
        #endregion

        #region 按钮：工具栏 删除工作站 DelStation()
        /// <summary>
        /// 删除工作站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDELStation_Click(object sender, EventArgs e)
        {
            Del("Station");
            GetGridLine();
            GridLine_CurrentCell();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏 启用工作站 Start()
        /// <summary>
        /// 删除工作站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStartStation_Click(object sender, EventArgs e)
        {

            Start("Station");
            GetGridLine();
            GridLine_CurrentCell();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏 停用工作站 Stop()
        /// <summary>
        /// 删除工作站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStopStation_Click(object sender, EventArgs e)
        {

            Stop("Station");
            GetGridLine();
            GridLine_CurrentCell();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏 刷新
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStateRefresh_Click(object sender, EventArgs e)
        {
            GetGridLine();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏 刷新
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNumRefresh_Click(object sender, EventArgs e)
        {
            GetGridLine();
            GetGridStation();
        }
        #endregion

        #region 按钮：工具栏 退出
        private void ToolsNumExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 按钮：工具栏 退出
        private void ToolStateExit_Click(object sender, EventArgs e)
        {
            Close();

        }
        #endregion

        #region  删除 Del(string v)
        /// <summary>
        /// 删除工作站
        /// </summary>
        private void Del(string v)
        {
            #region v == "Station"
            if (v == "Station")
            {
                try
                {
                    int l = -1;
                    int s = -1;
                    int count = 0;
                    //用于保存选中的checkbox数量
                    for (int i = 0; i < GridStation.RowCount; i++)
                    {
                        if (GridStation.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                        //这里判断复选框是否选中
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        if (GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString() != "")
                        {
                            if (MessageBox.Show(this, "您要删除选中的工作站么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                            {
                                return;
                            }
                            ArrayList SQLList = new ArrayList();
                            l = Convert.ToInt16(GridStation.CurrentRow.Cells["Eton_Line"].Value.ToString());
                            s = Convert.ToInt16(GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString());
                            SQLList.Add("DELETE FROM [dbo].[MES_station] WHERE Eton_Line=" + l + " and  Eton_WorkStation =" + s);
                            DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                        }
                        else
                        {
                            MessageBox.Show("请至少选择一条数据！", "提示");
                            return;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(this, "您要删除选中的工作站么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            return;
                        }
                        ArrayList SQLList = new ArrayList();
                        for (int i = 0; i < GridStation.RowCount; i++)
                        {
                            if (GridStation.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                            //这里判断复选框是否选中
                            {
                                l = Convert.ToInt16(GridStation.Rows[i].Cells["Eton_Line"].Value.ToString());
                                s = Convert.ToInt16(GridStation.Rows[i].Cells["Eton_WorkStation"].Value.ToString());
                                SQLList.Add("DELETE FROM [dbo].[MES_station] WHERE Eton_Line=" + l + " and  Eton_WorkStation =" + s);
                            }
                            DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                        }
                    }

                    MessageBox.Show(this, "删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion
            #region v == "Line"
            if (v == "Line")
            {
                Line_Num = "";
                try
                {
                    int l = -1;
                    int count = 0;
                    //用于保存选中的checkbox数量
                    for (int i = 0; i < GridLine.RowCount; i++)
                    {
                        if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                        //这里判断复选框是否选中
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        if (GridLine.Rows.Count > 0) { Line_Num = GridLine.CurrentRow.Cells["Eton_Line"].Value.ToString(); }
                        if (Line_Num == "")
                        {
                            MessageBox.Show("请至少选择一条数据！", "提示");
                            return;
                        }
                        else { l = Convert.ToInt32(Line_Num); }

                    }

                    if (MessageBox.Show(this, "您要删除选中的生产线么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }
                    ArrayList SQLList = new ArrayList();
                    if (count > 0)
                    {

                        for (int i = 0; i < GridLine.RowCount; i++)
                        {
                            if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                            //这里判断复选框是否选中
                            {
                                l = Convert.ToInt16(GridLine.Rows[i].Cells["Eton_Line"].Value.ToString());
                                SQLList.Add("DELETE FROM [dbo].[MES_station] WHERE Eton_Line=" + l);
                                SQLList.Add("DELETE FROM[dbo].[MES_line]WHERE Eton_Line=" + l);
                            }
                        }
                    }
                    else
                    {
                        SQLList.Add("DELETE FROM[dbo].[MES_line] WHERE Eton_Line=" + l);
                        SQLList.Add("DELETE FROM [dbo].[MES_station] WHERE Eton_Line=" + l);
                    }
                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    MessageBox.Show(this, "删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion
        }
        #endregion

        #region 启用 Start()
        /// <summary>
        /// 删除工作站
        /// </summary>
        private void Start(string v)
        {
            #region v == "Station"
            if (v == "Station")
            {
                try
                {
                    int count = 0;
                    //用于保存选中的checkbox数量
                    for (int i = 0; i < GridStation.RowCount; i++)
                    {
                        if (GridStation.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                        //这里判断复选框是否选中
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        if (GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString() != "")
                        {
                            if (MessageBox.Show(this, "您要启用选中的工作站么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                            {
                                return;
                            }
                            ArrayList SQLList = new ArrayList();
                            int l = Convert.ToInt16(GridStation.CurrentRow.Cells["Eton_Line"].Value.ToString());
                            int s = Convert.ToInt16(GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString());
                            SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 1 WHERE Eton_Line=" + l + " and  Eton_WorkStation =" + s);
                            DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                        }
                        else
                        {
                            MessageBox.Show("请至少选择一条数据！", "提示");
                            return;
                        }

                    }
                    else
                    {
                        if (MessageBox.Show(this, "您要启用选中的工作站么？(请注意当前工作站所在生产线)", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            return;
                        }

                        ArrayList SQLList = new ArrayList();
                        for (int i = 0; i < GridStation.RowCount; i++)
                        {
                            if (GridStation.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                            //这里判断复选框是否选中
                            {
                                int l = Convert.ToInt16(GridStation.Rows[i].Cells["Eton_Line"].Value.ToString());
                                int s = Convert.ToInt16(GridStation.Rows[i].Cells["Eton_WorkStation"].Value.ToString());
                                SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 1 WHERE Eton_Line=" + l + " and  Eton_WorkStation =" + s);
                            }
                        }
                        DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    }

                    MessageBox.Show(this, "成功启用工作站！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion

            #region v == "Line"
            if (v == "Line")
            {
                try
                {
                    int l = -1;
                    int count = 0;
                    //用于保存选中的checkbox数量
                    for (int i = 0; i < GridLine.RowCount; i++)
                    {
                        if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                        //这里判断复选框是否选中
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        if (GridLine.Rows.Count > 0) { Line_Num = GridLine.CurrentRow.Cells["Eton_Line"].Value.ToString(); }
                        if (Line_Num == "")
                        {
                            MessageBox.Show("请至少选择一条数据！", "提示");
                            return;
                        }
                        else { l = Convert.ToInt32(Line_Num); }
                    }

                    if (MessageBox.Show(this, "您要启用选中生产线的所有工作么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }

                    ArrayList SQLList = new ArrayList();
                    if (count > 0)
                    {

                        for (int i = 0; i < GridLine.RowCount; i++)
                        {
                            if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                            //这里判断复选框是否选中
                            {
                                l = Convert.ToInt16(GridLine.Rows[i].Cells["Eton_Line"].Value.ToString());
                                SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 1 WHERE Eton_Line=" + l);
                            }
                        }
                    }
                    else
                    {

                        SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 1 WHERE Eton_Line=" + l);
                    }
                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    MessageBox.Show(this, "成功启用工作站！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion
        }
        #endregion

        #region 停用 Stop(string v)
        /// <summary>
        /// 删除工作站
        /// </summary>
        private void Stop(string v)
        {
            #region
            if (v == "Station")
            {
                try
                {
                    int count = 0;
                    //用于保存选中的checkbox数量
                    for (int i = 0; i < GridStation.RowCount; i++)
                    {
                        if (GridStation.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                        //这里判断复选框是否选中
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        if (GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString() != "")
                        {
                            if (MessageBox.Show(this, "您要停用选中的工作站么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                            {
                                return;
                            }
                            ArrayList SQLList = new ArrayList();
                            int l = Convert.ToInt16(GridStation.CurrentRow.Cells["Eton_Line"].Value.ToString());
                            int s = Convert.ToInt16(GridStation.CurrentRow.Cells["Eton_WorkStation"].Value.ToString());
                            SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 0 WHERE Eton_Line=" + l + " and  Eton_WorkStation =" + s);
                            DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                        }
                        else
                        {
                            MessageBox.Show("请至少选择一条数据！", "提示");
                            return;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(this, "您要停用选中的工作站么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            return;
                        }

                        ArrayList SQLList = new ArrayList();
                        for (int i = 0; i < GridStation.RowCount; i++)
                        {
                            if (GridStation.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                            //这里判断复选框是否选中
                            {
                                int l = Convert.ToInt16(GridStation.Rows[i].Cells["Eton_Line"].Value.ToString());
                                int s = Convert.ToInt16(GridStation.Rows[i].Cells["Eton_WorkStation"].Value.ToString());
                                SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 0 WHERE Eton_Line=" + l + " and  Eton_WorkStation =" + s);
                            }
                        }
                        DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    }

                    MessageBox.Show(this, "成功停用工作站！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion

            #region
            if (v == "Line")
            {
                try
                {
                    int l = -1;
                    int count = 0;
                    //用于保存选中的checkbox数量
                    for (int i = 0; i < GridLine.RowCount; i++)
                    {
                        if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                        //这里判断复选框是否选中
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        if (GridLine.Rows.Count > 0) { Line_Num = GridLine.CurrentRow.Cells["Eton_Line"].Value.ToString(); }
                        if (Line_Num == "")
                        {
                            MessageBox.Show("请至少选择一条数据！", "提示");
                            return;
                        }
                        else { l = Convert.ToInt32(Line_Num); }
                    }

                    if (MessageBox.Show(this, "您要停用选中的工作站么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }

                    ArrayList SQLList = new ArrayList();
                    if (count > 0)
                    {

                        for (int i = 0; i < GridLine.RowCount; i++)
                        {
                            if (GridLine.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                            //这里判断复选框是否选中
                            {
                                l = Convert.ToInt16(GridLine.Rows[i].Cells["Eton_Line"].Value.ToString());
                                SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 0 WHERE Eton_Line=" + l);
                            }
                        }
                    }
                    else
                    {

                        SQLList.Add("UPDATE [dbo].[MES_station] SET [state] = 0 WHERE Eton_Line=" + l);
                    }
                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    MessageBox.Show(this, "成功停用工作站！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion
        }

        #endregion

        #region 获取GridLine当前行
        private void GridLine_CurrentCell()
        {
            int rowIndex = 0;

            if (GridLine.Rows.Count != 0)
            {
                for (int i = 0; i < GridLine.Rows.Count; i++)
                {
                    if (GridLine.Rows[i].Cells["Eton_Line"].Value.ToString() == Line_Num.ToString())
                    {
                        rowIndex = i;
                    }
                }
                this.GridLine.CurrentCell = this.GridLine.Rows[rowIndex].Cells[0];
            }
        }
        #endregion

        #region 单击GridLine行 加载工作站
        private void GridLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Line_Num = GridLine.CurrentRow.Cells["Eton_Line"].Value.ToString();
            if (Line_Num != "") { GetGridStation(); }
        }
        #endregion

        #region 双击GridLine行
        private void GridLine_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //双击左键：将GridGST双击的行对应的Checkbox选中
            this.GridLine.Rows[e.RowIndex].Cells["check"].Value = this.GridLine.Rows[e.RowIndex].Cells["check"].Value == null ? true : !Convert.ToBoolean(this.GridLine.Rows[e.RowIndex].Cells["check"].Value);
        }
        #endregion

        #region 双击GridStation行
        private void GridStation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //双击左键：将GridGST双击的行对应的Checkbox选中
            this.GridStation.Rows[e.RowIndex].Cells["check"].Value = this.GridStation.Rows[e.RowIndex].Cells["check"].Value == null ? true : !Convert.ToBoolean(this.GridStation.Rows[e.RowIndex].Cells["check"].Value);
        }
        #endregion

        //-------------------------------右键------------------------//

        #region 右键：菜单-选择
        /// <summary>
        /// 右键菜单-选择
        /// </summary>
        /// <param name="Grid">ExDataGridView的名称</param>
        /// <param name="S">选择项</param>
        private void MouseRightSelect(MyContrals.ExDataGridView Grid, Selected S)
        {
            if (Grid.Rows.Count > 0)
            {
                switch (S)
                {
                    case Selected.选择:
                        for (int g = 0; g < Grid.SelectedRows.Count; g++)
                        {
                            Grid.SelectedRows[g].Cells["check"].Value = true;
                        }
                        break;
                    case Selected.取消选择:
                        for (int g = 0; g < Grid.SelectedRows.Count; g++)
                        {
                            Grid.SelectedRows[g].Cells["check"].Value = false;
                        }
                        break;
                    case Selected.全选:
                        for (int g = 0; g < Grid.Rows.Count; g++)
                        {
                            Grid.Rows[g].Cells["check"].Value = true;
                        }
                        break;
                    case Selected.取消全选:
                        for (int g = 0; g < Grid.Rows.Count; g++)
                        {
                            Grid.Rows[g].Cells["check"].Value = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 右键：Selected枚举类型
        enum Selected
        {
            选择,
            取消选择,
            全选,
            取消全选
        }
        #endregion

        #region 右键：DataGridView鼠标右键动作
        private void GridLine_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (GridLine.Rows[e.RowIndex].Selected == false)
                    {
                        GridLine.ClearSelection();
                        GridLine.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (GridLine.SelectedRows.Count == 1)
                    {
                        GridLine.CurrentCell = GridLine.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    txContextMenuStripLine.Show(MousePosition.X, MousePosition.Y);
                }
            }

        }

        private void GridStation_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (GridStation.Rows[e.RowIndex].Selected == false)
                    {
                        GridStation.ClearSelection();
                        GridStation.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (GridStation.SelectedRows.Count == 1)
                    {
                        GridStation.CurrentCell = GridStation.SelectedRows[0].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    txContextMenuStripStation.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        #endregion

        #region GridLine右键
        private void 选中行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridLine, Selected.选择);
        }
        private void 所有行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridLine, Selected.全选);
        }

        private void 选中行ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridLine, Selected.取消选择);
        }

        private void 所有行ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridLine, Selected.取消全选);
        }

        #endregion

        #region GridStation右键
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.选择);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.全选);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.取消选择);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.取消全选);
        }

        #endregion


    }
}

