using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MES.module.BLL;
using System.Collections;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Text;

namespace MES.form.Operation
{
    public partial class OperationMain : Form
    {
        //--------------窗体加载------------------//

        #region OperationMain()    
        /// <summary>
        /// 
        /// </summary>
        public OperationMain()
        {
            InitializeComponent();
            //this.CaptionHeight = 0;
        }
        #endregion

        #region OperationMain(int v)    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">0为查询 1为编辑 2为清空GRID</param>
        public OperationMain(int v)
        {

            InitializeComponent();

            //this.CaptionHeight = 0;
            //Operation.Select s1 = new Operation.Select();

            if (v == 0)
            {
                this.Text = "查询排产表";
                this.splitContainer2.Panel1.Hide();
                this.splitContainer2.SplitterDistance = 0;
                this.splitContainer2.Panel1MinSize = 0;
                this.ButtonAdd.Hide();
                this.BottonMinus.Hide();
                this.ButtonOpType.Hide();
                this.ButtonSave.Visible = false;
                this.ButtonToMES.Visible = false;
                if (GridUPS.Rows.Count > 0) { GridUPS.Rows.Clear(); }
                if (GridStation.Rows.Count > 0) { GridStation.Rows.Clear(); }
                if (GridGST.Rows.Count > 0) { GridGST.Rows.Clear(); }
            }
            else if (v == 1)
            {
                this.Text = "编辑排产表";
                this.ButtonSave.Enabled = false;
                this.ButtonToMES.Enabled = false;
            }
            else if (v == 2)
            {
                this.Text = "编辑排产表";
                this.ButtonSave.Enabled = false;
                this.ButtonToMES.Enabled = false;
                Order_Num="";
                SchemeNo = "";
                Line_Num = "";

            }
        }
        #endregion

        #region 公用变量
        DataTable dt_UPS = new DataTable(); //临时存储工序工位对照表
        string Style_Num = "";
        string Line_Num = "";
        string Order_Num = "";
        string SchemeNo = "";
        //string op_type = "";
        int Change = 0;//记录调用或保存方案后，是否有过更改 0表示没改过 1表示改过
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        const int WM_ACTIVATE = 0x06;
        IntPtr maindHwnd = GetForegroundWindow();
        #endregion

        #region OperationMain_Load
        /// <summary>
        /// OperationMain_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationMain_Load(object sender, EventArgs e)
        {




            //设置隔行背景色
            this.GridUPS.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridUPS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridUPS.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

            this.GridStation.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridStation.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridStation.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;


            this.GridGST.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridGST.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridGST.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;


            StationBll sb = new StationBll();
            //如果用了combo_Line_SelectedIndexChanged,必须DisplayMember在DataSource之前,否则加载时会被赋值System.Data.DataRowView导致执行SQL语句报错
            combo_Line.DisplayMember = "Eton_line";//Combobox加载现有生产线
            combo_Line.DataSource = sb.get_line();
            GetGridStation();//加载Station
            GetGridGstOP();//加载排序前的工序
            #region
            //dt_UPS 工序工位对照表对应的列：
            //DataColumn column1 = new DataColumn("Eton_Line", typeof(System.Int32));
            //DataColumn column2 = new DataColumn("Eton_WorkStation", typeof(System.Int32));
            //DataColumn column3 = new DataColumn("order_no", typeof(System.String));
            //DataColumn column4 = new DataColumn("style_no", typeof(System.String));
            //DataColumn column5 = new DataColumn("OpCodeAlpha1", typeof(System.String));
            //DataColumn column6 = new DataColumn("GST_GZDM", typeof(System.String));
            //DataColumn column7 = new DataColumn("operation_addr", typeof(System.String));
            //DataColumn column8 = new DataColumn("operation_des", typeof(System.String));
            //DataColumn column9 = new DataColumn("standard_time", typeof(System.Decimal));
            //DataColumn column10 = new DataColumn("EQ_ID", typeof(System.String));
            //DataColumn column11 = new DataColumn("EQ_des", typeof(System.String));
            //DataColumn column12 = new DataColumn("GST_gxDJ", typeof(System.String));
            //DataColumn column13 = new DataColumn("GST_xh", typeof(System.String));
            //DataColumn column14 = new DataColumn("GST_ID", typeof(System.Int32));
            //DataColumn column15 = new DataColumn("UPS_ID", typeof(System.Int32));
            //DataColumn column16 = new DataColumn("Station_ID", typeof(System.Int32));
            //DataColumn column17 = new DataColumn("op_type", typeof(System.String));
            //DataColumn column18 = new DataColumn("op_des", typeof(System.String));
            //DataColumn column19 = new DataColumn("SchemeNo", typeof(System.String));


            //dt_UPS.Columns.Add(column1);
            //dt_UPS.Columns.Add(column2);
            //dt_UPS.Columns.Add(column3);
            //dt_UPS.Columns.Add(column4);
            //dt_UPS.Columns.Add(column5);
            //dt_UPS.Columns.Add(column6);
            //dt_UPS.Columns.Add(column7);
            //dt_UPS.Columns.Add(column8);
            //dt_UPS.Columns.Add(column9);
            //dt_UPS.Columns.Add(column10);
            //dt_UPS.Columns.Add(column11);
            //dt_UPS.Columns.Add(column12);
            //dt_UPS.Columns.Add(column13);
            //dt_UPS.Columns.Add(column14);
            //dt_UPS.Columns.Add(column15);
            //dt_UPS.Columns.Add(column16);
            //dt_UPS.Columns.Add(column17);
            //dt_UPS.Columns.Add(column18);
            //dt_UPS.Columns.Add(column19);
            #endregion

            GridUPS.DataSource = dt_UPS; //工序工位对照表对应的DataGridView名为GridUPS
            GetGridUPS(); //加载GridUPS对应显示的列
            GetWorkHours();
            ChangeButtonStatus();
        }
        #endregion

        //--------DataGridView加载并设置样式-------//
        //--------DataGridView加载并设置样式-------//
        //--------DataGridView加载并设置样式-------//

        #region 加载GridStation
        /// <summary>
        /// 加载GridStation
        /// </summary>
        private void GetGridStation()
        {
            //StationBll stationBll = new StationBll();
            //GridStation.DataSource = stationBll.Station_SelectAll();
            //DataTable dt_Station = stationBll.Station_SelectAll().Clone();
            if (Line_Num == "")
            {
                string strsql = "SELECT id,Eton_Line,Eton_WorkStation, '0' as Selected,'0.000000' as workhours FROM MES_Station where Eton_Line=-1 ";

                DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                GridStation.DataSource = dt_Station;
            }
            if (Line_Num != "")
            {
                string strsql = "SELECT id,Eton_Line,Eton_WorkStation, '0' as Selected,'0.000000' as workhours FROM MES_Station where Eton_Line = " + combo_Line.Text + " order by Eton_WorkStation ";
                DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                GridStation.DataSource = dt_Station;
                combo_Line.Text = Line_Num;
            }
            else
            {
                string strsql = "SELECT id,Eton_Line,Eton_WorkStation, '0' as Selected,'0.000000' as workhours FROM MES_Station where Eton_Line = -1";
                DataTable dt_Station = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                GridStation.DataSource = dt_Station;

            }
            if (this.GridStation.Columns.Count == 0)
            {
                this.GridStation.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridStation.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridStation.AddColumn("Eton_Line", "生产线号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridStation.AddColumn("Eton_WorkStation", "工作站号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridStation.AddColumn("workhours", "工时", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridStation.AddColumn("Selected", "工序数量", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);


                // 实现列的锁定功能  
                this.GridStation.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridStation.AllowUserToResizeRows = false;
            }
        }
        #endregion 加载Grid

        #region 加载GST工序GridGST
        /// <summary>
        /// 加载GST工序
        /// </summary>
        private void GetGridGstOP()
        {
            string strsql1 = "";

            string strsql = "";
            // A : 没有排产方案，提交Order_Num和Line_Num //如果没有排产方案，则根据最新此款的订单号(根据订单计划开始日期)由订单子表中加载GST工序
            //if (SchemeNo != "")
            //{
            //    strsql1 = strsql1 + " and a.SchemeNo = '" + SchemeNo + "'";
            //}
            strsql1 = strsql1 + " and a.order_no = '" + Order_Num + "'";
            //strsql = " select y.id,'" + Order_Num + "'as order_no, '" + Style_Num + "' as Style_no ,	y.OpCodeAlpha1,y.GST_GZDM,y.operation_addr,y.operation_des,y.standard_time,	y.EQ_ID,y.EQ_des,y.GST_gxDJ,y.GST_xh,y.GST_XCBJ,0 as Selected,case when z.op_type is not null then z.op_type   else 2  end op_type,case when zd.op_des is not null then zd.op_des else '普通工序'  end op_des from MES_order_detail_operation y left join 	mes_order_master a on y.order_no=a.order_no left join MES_operation_detail_type z on z.SchemeNo=a.SchemeNo and y.OpCodeAlpha1=z.opcodealpha1 left join MES_OPERTYPE zd on z.op_type=zd.op_type where 1=1 " + strsql1 + " order by y.GST_xh";
            //2019.9.12以前：strsql = " select y.id,'" + Order_Num + "'as order_no, '" + Style_Num + "' as Style_no ,	y.OpCodeAlpha1,y.GST_GZDM,y.operation_addr,y.operation_des,y.standard_time,	y.EQ_ID,y.EQ_des,y.GST_gxDJ,y.GST_xh,y.GST_XCBJ,0 as Selected,case when z.op_type is not null then z.op_type   else 2  end op_type,case when zd.op_des is not null then zd.op_des else '普通工序'  end op_des from MES_order_detail_operation y left join 	mes_order_master a on y.order_no=a.order_no left join MES_operation_detail_type z on z.SchemeNo=a.SchemeNo and y.OpCodeAlpha1=z.opcodealpha1 left join MES_OPERTYPE zd on z.op_type=zd.op_type where 1=1 " + strsql1 + " order by y.id";
            strsql = " select distinct y.id,'" + Order_Num + "'as order_no, '" + Style_Num + "' as Style_no ,	y.OpCodeAlpha1,y.GST_GZDM,y.operation_addr,y.operation_des,y.standard_time,	y.EQ_ID,y.EQ_des,y.GST_gxDJ,y.GST_xh,y.GST_XCBJ,0 as Selected,zd.op_type, case when zd.op_des is not null then zd.op_des else '普通工序'  end op_des  from MES_order_detail_operation y left join 	mes_order_master a on y.order_no=a.order_no left join MES_OPERTYPE zd on y.OpCodeAlpha1=zd.op_type_id where 1=1 " + strsql1 + " order by y.id";

            DataTable dt_GST = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
            GridGST.DataSource = dt_GST;
            if (this.GridGST.Columns.Count == 0)
            {
                this.GridGST.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridGST.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("order_no", "订单编号", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("style_no", "款式编号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("OpCodeAlpha1", "PLM工序代码", 110, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("GST_xh", "工序序号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("op_type", "工序类型序号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("op_des", "工序类型", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("operation_addr", "工序简称", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("operation_des", "工序描述", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                this.GridGST.AddColumn("standard_time", "标准工时", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("EQ_ID", "机器编码", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("EQ_des", "机器描述", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("GST_gxDJ", "工序等级", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("GST_GZDM", "GST工种", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridGST.AddColumn("Selected", "已选择", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);//已添加标记 0未添加 大于1已添加

                this.GridGST.AddColumn("price", "价格", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("Time_unit", "时间单位", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("OpQualityRequirement", "常规工艺要求", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("StyleQualityRequirement", "款式工艺要求", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("Technology_picture", "发布的工艺图路径", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridGST.AddColumn("GST_XCBJ", "生产部件", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
            }
            // 实现列的锁定功能  
            this.GridGST.Columns[1].Frozen = true;
            //禁止用户改变DataGridView1所有行的行高
            GridGST.AllowUserToResizeRows = false;
            //禁止用户排序
            for (int i = 0; i < this.GridGST.Columns.Count; i++)
            {
                this.GridGST.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        #endregion

        #region 加载工位工序表GridUPS
        /// <summary>
        /// 加载工位工序表GridUPS
        /// </summary>
        private void GetGridUPS()
        {
            
            if (SchemeNo != "")
            {
                //string strsql = "";

                if (Order_Num != "")
                {
                    StringBuilder sqlstr = new StringBuilder();
                    sqlstr.Clear();
                    sqlstr.AppendLine(" select distinct RANK() over(order by b.id ) as UPS_ID,b.id as GST_ID , c.id as Station_ID,'" + Order_Num + "' AS order_no, f.order_date,f.input_date  ");
                    sqlstr.AppendLine(" ,f.style_no,a.SchemeNo,b.OpCodeAlpha1,b.operation_addr,b.operation_des,b.EQ_des,b.EQ_ID,b.GST_gxDJ,b.GST_GZDM,b.GST_XCBJ ");
                    sqlstr.AppendLine(" ,b.standard_time,b.GST_xh,d.SchemeDate,d.memo,d.state,a.Eton_Line,a.Eton_WorkStation,e.op_type,g.op_des,0 as Selected  ");
                    sqlstr.AppendLine(" ,b.price,b.Time_unit,b.OpQualityRequirement,b.StyleQualityRequirement,b.Technology_picture,b.GST_XCBJ ");
                    sqlstr.AppendLine(" from MES_station_operation_detail a left join MES_order_detail_operation b on a.GST_xh = b.GST_xh  ");
                    sqlstr.AppendLine(" left join MES_station c on a.Eton_Line =c.Eton_Line and a.Eton_WorkStation=c.Eton_WorkStation  ");
                    sqlstr.AppendLine(" left join MES_station_operation_master d on a.SchemeNo = d.SchemeNo  ");
                    sqlstr.AppendLine(" left join MES_operation_detail_type e on e.SchemeNo=a.SchemeNo and e.OpCodeAlpha1=a.OpCodeAlpha1  ");
                    sqlstr.AppendLine(" left join MES_order_master f on f.order_no=b.order_no left join MES_OPERTYPE g on g.op_type=e.op_type  ");
                    sqlstr.AppendLine(" where b.order_no='" + Order_Num + "' and a.SchemeNo='" + SchemeNo + "' and a.Eton_line='" + Line_Num + "' ");


                    //strsql = "select RANK() over(order by b.id ) as UPS_ID,b.id as GST_ID , c.id as Station_ID,'" + Order_Num + "' AS order_no, f.order_date,f.input_date ,f.style_no,a.SchemeNo,b.OpCodeAlpha1,b.operation_addr,b.operation_des,b.EQ_des,b.EQ_ID,b.GST_gxDJ,b.GST_GZDM,b.GST_XCBJ,b.standard_time,b.GST_xh,d.SchemeDate,d.memo,d.state,a.Eton_Line,a.Eton_WorkStation,e.op_type,g.op_des,0 as Selected from MES_station_operation_detail a left join MES_order_detail_operation b on a.GST_xh = b.GST_xh left join MES_station c on a.Eton_Line =c.Eton_Line and a.Eton_WorkStation=c.Eton_WorkStation left join MES_station_operation_master d on a.SchemeNo = d.SchemeNo left join MES_operation_detail_type e on e.SchemeNo=a.SchemeNo and e.OpCodeAlpha1=a.OpCodeAlpha1 left join MES_order_master f on f.order_no=b.order_no left join MES_OPERTYPE g on g.op_type=e.op_type where b.order_no='" + Order_Num + "' and a.SchemeNo='" + SchemeNo + "' and a.Eton_line='"+ Line_Num +"'";
                    //strsql = "select RANK() over(order by b.id ) as UPS_ID,b.id as GST_ID,g.id as Station_ID, '" + Order_Num + "' AS order_no, a.order_date,a.input_date ,a.style_no,a.SchemeNo , b.OpCodeAlpha1,b.operation_addr,b.operation_des,b.EQ_des,b.EQ_ID,b.GST_gxDJ,b.GST_GZDM,b.GST_XCBJ,b.standard_time,b.GST_xh,c.SchemeDate,c.memo,c.state, d.Eton_Line,d.Eton_WorkStation,e.op_type,f.op_des from MES_order_master as a left join MES_order_detail_operation as b on a.order_no = b.order_no left join MES_station_operation_master as c on a.SchemeNo=c.SchemeNo left join MES_station_operation_detail as d on c.SchemeNo=d.SchemeNo and b.OpCodeAlpha1=d.OpCodeAlpha1 left join MES_operation_detail_type as e on c.SchemeNo=e.SchemeNo and b.OpCodeAlpha1=e.OpCodeAlpha1 left join MES_OPERTYPE as f on e.op_type=f.op_type left join MES_Station as g on d.Eton_Line=g.Eton_Line and d.Eton_WorkStation=g.Eton_WorkStation where c.SchemeNo='" + SchemeNo + "' and d.Eton_WorkStation IS NOT NULL  order by d.Eton_WorkStation , b.GST_xh";
                    //strsql = "select RANK() over(order by b.id ) as UPS_ID,b.id as GST_ID,g.id as Station_ID,a.order_no, a.order_date,a.input_date ,a.style_no,a.SchemeNo , b.OpCodeAlpha1,b.operation_addr,b.operation_des,b.EQ_des,b.EQ_ID,b.GST_gxDJ,b.GST_GZDM,b.GST_XCBJ,b.standard_time,b.GST_xh,c.SchemeDate,c.memo,c.state, d.Eton_Line,d.Eton_WorkStation,e.op_type,f.op_des from MES_order_master as a left join MES_order_detail_operation as b on a.order_no = b.order_no left join MES_station_operation_master as c on a.SchemeNo=c.SchemeNo left join MES_station_operation_detail as d on c.SchemeNo=d.SchemeNo and b.OpCodeAlpha1=d.OpCodeAlpha1 left join MES_operation_detail_type as e on c.SchemeNo=e.SchemeNo and b.OpCodeAlpha1=e.OpCodeAlpha1 left join MES_OPERTYPE as f on e.op_type=f.op_type left join MES_Station as g on d.Eton_Line=g.Eton_Line and d.Eton_WorkStation=g.Eton_WorkStation where a.order_no ='" + Order_Num + "' order by b.GST_xh";
                    dt_UPS = DBConn.DataAcess.SqlConn.Query(sqlstr.ToString()).Tables[0];

                    for (int i = 0; i < dt_UPS.Rows.Count; i++)
                    {
                        int z = 0;
                        for (int j = 0; j < GridGST.Rows.Count; j++)
                        {   //判断订单工序表与排产表工序行是否被选择过
                            //int ss = Convert.ToInt32(GridGST.Rows[j].Cells["Selected"].Value);
                            if (Convert.ToInt32(dt_UPS.Rows[i]["GST_xh"].ToString()) == Convert.ToInt32(GridGST.Rows[j].Cells["GST_xh"].Value.ToString()))
                            {
                                z = z + 1;
                                this.GridGST.Rows[j].Cells["Selected"].Value = Convert.ToInt32(GridGST.Rows[j].Cells["selected"].Value) + 1;
                                // abcde                              
                                this.dt_UPS.Rows[i]["Selected"] = Convert.ToInt32(dt_UPS.Rows[i]["Selected"]) + 1;
                                this.GridGST.Rows[j].Cells["op_type"].Value = dt_UPS.Rows[i]["op_type"].ToString();
                                this.GridGST.Rows[j].Cells["op_des"].Value = dt_UPS.Rows[i]["op_des"].ToString();
                            }
                        }
                        for (int j = 0; j < GridStation.Rows.Count; j++)
                        {
                            if (dt_UPS.Rows[i]["Station_ID"].ToString() != "")
                            {
                                if (Convert.ToInt32(dt_UPS.Rows[i]["Station_ID"].ToString()) == Convert.ToInt32(GridStation.Rows[j].Cells["ID"].Value.ToString()))
                                {
                                    this.GridStation.Rows[j].Cells["Selected"].Value = Convert.ToInt32(GridStation.Rows[j].Cells["selected"].Value) + 1;
                                }
                            }
                        }
                        if (z == 0) { dt_UPS.Rows[i].Delete(); }
                    }
                }
            }
            else if (SchemeNo == "")
            {
                //string strsql1 = "";
                //strsql1 = "select RANK() over(order by b.id ) as UPS_ID,b.id as GST_ID,g.id as Station_ID,a.order_no, a.order_date,a.input_date ,a.style_no,a.SchemeNo , b.OpCodeAlpha1,b.operation_addr,b.operation_des,b.EQ_des,b.EQ_ID,b.GST_gxDJ,b.GST_GZDM,b.GST_XCBJ,b.standard_time,b.GST_xh,c.SchemeDate,c.memo,c.state, d.Eton_Line,d.Eton_WorkStation,e.op_type,f.op_des,0 as Selected from MES_order_master as a left join MES_order_detail_operation as b on a.order_no = b.order_no left join MES_station_operation_master as c on a.SchemeNo=c.SchemeNo left join MES_station_operation_detail as d on c.SchemeNo=d.SchemeNo and b.OpCodeAlpha1=d.OpCodeAlpha1 left join MES_operation_detail_type as e on c.SchemeNo=e.SchemeNo and b.OpCodeAlpha1=e.OpCodeAlpha1 left join MES_OPERTYPE as f on e.op_type=f.op_type left join MES_Station as g on d.Eton_Line=g.Eton_Line and d.Eton_WorkStation=g.Eton_WorkStation where a.SchemeNo =-1";




                StringBuilder sqlstr = new StringBuilder();
                sqlstr.Clear();
                sqlstr.AppendLine(" select RANK() over(order by b.id ) as UPS_ID,b.id as GST_ID,g.id as Station_ID,a.order_no, a.order_date,a.input_date  ");
                sqlstr.AppendLine(" ,a.style_no,a.SchemeNo , d.OpCodeAlpha1,d.operation_addr,d.operation_des,d.EQ_des,d.EQ_ID,d.GST_gxDJ,d.GST_GZDM,d.GST_XCBJ ");
                sqlstr.AppendLine(" ,d.standard_time,d.GST_xh,c.SchemeDate,c.memo,c.state, d.Eton_Line,d.Eton_WorkStation,e.op_type,f.op_des,0 as Selected  ");
                sqlstr.AppendLine(" ,d.price,d.Time_unit,d.OpQualityRequirement,d.StyleQualityRequirement,d.Technology_picture,d.GST_XCBJ ");
                sqlstr.AppendLine(" from MES_order_master as a  ");
                sqlstr.AppendLine(" left join MES_order_detail_operation as b on a.order_no = b.order_no  ");
                sqlstr.AppendLine(" left join MES_station_operation_master as c on a.SchemeNo=c.SchemeNo  ");
                sqlstr.AppendLine(" left join MES_station_operation_detail as d on c.SchemeNo=d.SchemeNo and b.OpCodeAlpha1=d.OpCodeAlpha1  ");
                sqlstr.AppendLine(" left join MES_operation_detail_type as e on c.SchemeNo=e.SchemeNo and b.OpCodeAlpha1=e.OpCodeAlpha1  ");
                sqlstr.AppendLine(" left join MES_OPERTYPE as f on e.op_type=f.op_type  ");
                sqlstr.AppendLine(" left join MES_Station as g on d.Eton_Line=g.Eton_Line and d.Eton_WorkStation=g.Eton_WorkStation  ");
                sqlstr.AppendLine(" where a.SchemeNo =-1 ");


                dt_UPS = DBConn.DataAcess.SqlConn.Query(sqlstr.ToString()).Tables[0];
                //if (GridUPS.Rows.Count > 0) { dt_UPS = null; } //如果方案号为空，GridUPS有内容时，清空。          
            }
            GridUPS.DataSource = dt_UPS;
            if (this.GridUPS.Columns.Count == 0)
            {
                this.GridUPS.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridUPS.AddColumn("Eton_Line", "生产线号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("Eton_WorkStation", "工作站号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("order_no", "订单编号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("style_no", "款式编号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("OpCodeAlpha1", "PLM工序代码", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("GST_xh", "工序序号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("GST_GZDM", "GST工序代码", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("operation_addr", "GST工序简称", 110, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("operation_des", "GST工序描述", 130, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("standard_time", "工序节拍", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("EQ_ID", "设备编号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("EQ_des", "设备描述", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("GST_gxDJ", "工序等级", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("op_type", "工序类型序号", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("op_des", "工序类型", 85, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("GST_ID", "GST_ID", 60, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("UPS_ID", "UPS_ID", 60, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("Station_ID", "Station_ID", 60, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("SchemeNo", "方案号", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridUPS.AddColumn("Selected", "已选择", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);



                this.GridUPS.AddColumn("price", "价格", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("Time_unit", "时间单位", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("OpQualityRequirement", "常规工艺要求", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("StyleQualityRequirement", "款式工艺要求", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("Technology_picture", "发布的工艺图路径", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridUPS.AddColumn("GST_XCBJ", "生产部件", 120, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);



                //this.GridUPS.Columns[1].Frozen = true;// 实现列的锁定功能 
                //禁止用户改变DataGridView1所有行的行高
                GridUPS.AllowUserToResizeRows = false;
                //dt_UPS默认按照工作站号升序排序
                dt_UPS.DefaultView.Sort = "GST_ID,Eton_WorkStation ASC";
            }
        }
        #endregion

        #region 计算工作站工时GetStationWorkHours()
        /// <summary>
        /// 计算工作站工时GetStationWorkHours()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetWorkHours()
        {
            if (GridUPS.Rows.Count < 1)
            {
                for (int s = 0; s < GridStation.Rows.Count; s++)
                {
                    GridStation.Rows[s].Cells["workhours"].Value = 0;
                }
            }
            else if (GridUPS.Rows.Count > 0)
            {
                for (int u = 0; u < GridUPS.Rows.Count; u++)
                {
                    for (int g = 0; g < GridGST.Rows.Count; g++)
                    {
                        if (GridUPS.Rows[u].Cells["GST_ID"].Value.ToString() == GridGST.Rows[g].Cells["ID"].Value.ToString())
                        {
                            Decimal time1 = Convert.ToDecimal(GridGST.Rows[g].Cells["standard_time"].Value);
                            int GSTselectednum = Convert.ToInt32(GridGST.Rows[g].Cells["Selected"].Value.ToString());
                            if (GSTselectednum > 0)
                            {
                                GridUPS.Rows[u].Cells["standard_time"].Value = (time1 / GSTselectednum).ToString();
                            }
                            else
                            {
                                GridUPS.Rows[u].Cells["standard_time"].Value = time1.ToString();
                            }
                        }
                    }
                }
                for (int s = 0; s < GridStation.Rows.Count; s++)
                {
                    GridStation.Rows[s].Cells["workhours"].Value = 0.000000;
                }
                for (int u = 0; u < dt_UPS.Rows.Count; u++)
                {
                    for (int s = 0; s < GridStation.Rows.Count; s++)
                    {
                        if (dt_UPS.Rows[u]["Station_ID"].ToString() == GridStation.Rows[s].Cells["ID"].Value.ToString())
                        {
                            decimal time1 = Convert.ToDecimal(GridStation.Rows[s].Cells["workhours"].Value);
                            GridStation.Rows[s].Cells["workhours"].Value = time1 + Convert.ToDecimal(dt_UPS.Rows[u]["standard_time"]);
                        }
                    }
                }
            }

        }
        #endregion

        //----------------按钮----------------------//
        //----------------按钮----------------------//
        //----------------按钮----------------------//

        #region 按钮：工具栏 按订单查询 新窗体SelectScheme()
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectOrder_Click(object sender, EventArgs e)
        {
            if (GridUPS.Rows.Count > 0)
            {   //如果工位工序表格有内容 提示是否要选择新订单号 选择新订单号将丢失未保存的排产表
                if (MessageBox.Show("‘OK’选择新订单号 ‘Cancel’返回", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
            }
            dt_UPS.Clear();
            SelectOrder f2 = new SelectOrder(1); //参数为1时 代表选择订单
            if (f2.ShowDialog() == DialogResult.OK)
            {

                Style_Num = f2.Style_Num;
                Line_Num = f2.Line_Num;

                Order_Num = f2.Order_Num;
                SchemeNo = f2.Scheme_Num;
                this.LableStyleNum.Text = Style_Num;
                this.LableOrderNum.Text = Order_Num;
                f2.Close();
            }
            if (Line_Num == "")
            {
                combo_Line.Text = "";

            }
            else
            {
                combo_Line.Text = Line_Num;
               
            }
            Change = 0;//新加载或新建的方案，被修改标记为0

            GetGridGstOP();//加载订单对应的GST工序
            GetGridStation();//加载订单方案对应或者选择的生产线
            GetGridUPS();//如果有对应方案则加载工位工序表
            //StationBll sb = new StationBll();
            ////如果用了combo_Line_SelectedIndexChanged,必须DisplayMember在DataSource之前,否则加载时会被赋值System.Data.DataRowView导致执行SQL语句报错
            //combo_Line.DisplayMember = "Eton_line";//Combobox加载现有生产线
            //combo_Line.DataSource = sb.get_line();
            GetWorkHours();
            ChangeButtonStatus();
        }
        #endregion

        #region 按钮：添加工序
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddToUPS();
            ChangeSchemeNo();
            ChangeButtonStatus();
        }
        #endregion

        #region 按钮：删除工序
        private void BottonMinus_Click(object sender, EventArgs e)
        {
            DelOperation();
            ChangeSchemeNo();
            ChangeButtonStatus();
        }
        #endregion

        #region 按钮：改变工序类型
        /// <summary>
        /// 按钮：改变工序类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpType_Click(object sender, EventArgs e)
        {
            ////---- 更改为添加特殊工序 2018.4.9 ---
            //if (Line_Num == "")
            //{
            //    MessageBox.Show("请选择生产线！", "提示");
            //    return;
            //}
            //else
            //{
            //    Selectoptype s1 = new Selectoptype(Line_Num);
            //    DialogResult f1 = s1.ShowDialog();
            //    if (f1 == DialogResult.OK)
            //    {
            //        try
            //        {
            //            string op_type = s1.op_type;

            //            string op_des = s1.op_des;

            //            string op_type_id = s1.op_type_id;

            //            string op_type_Line_Num = s1.op_type_Line_Num;

            //            string op_type_Station = s1.op_type_Station;

            //            AddOPTypeToUPS(op_type_Line_Num, op_type_Station, op_type_id, op_type, op_des);

            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //        Change = Change + 1;

            //        ChangeSchemeNo();
            //        ChangeButtonStatus();

            //    }


            //}


            //----更改工序类型----
            #region GridGST中CheckBox选择的情况
            string GSTxh = "";//如果没有选择CHECKBOX，则指定为当前选中的行，此字段用来记录选中行的工序序号
            ArrayList OpList = new ArrayList();
            for (int i = 0; i < GridGST.RowCount; i++)
            {
                if (GridGST.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True") //如果复选框被选中
                {
                    OpList.Add(GridGST.Rows[i].Cells["GST_xh"].Value);
                }
            }
            if (OpList.Count == 0)//如果没有工序被选择 将弹出提示并返回
            {
                if (GridGST.CurrentRow.Cells["GST_xh"].Value.ToString() != "") { GSTxh = GridGST.CurrentRow.Cells["GST_xh"].Value.ToString(); }
                else
                {
                    MessageBox.Show("请至少选择一个工序！", "提示");
                    return;
                }
            }
            #endregion

            //Selectoptype s1 = new Selectoptype();
            //DialogResult f1 = s1.ShowDialog();
            //if (f1 == DialogResult.OK)
            //{
            //    try
            //    {
            //        op_type = s1.op_type;
            //        string sqlstring = "SELECT op_des FROM MES_OPERTYPE where op_type ='" + op_type + "'";
            //        string op_des = DBConn.DataAcess.SqlConn.GetSingle(sqlstring).ToString();

            //        if (OpList.Count == 0)
            //        {
            //            for (int g = 0; g < GridGST.Rows.Count; g++)
            //            {
            //                if (GridGST.Rows[g].Cells["GST_xh"].Value.ToString() == GSTxh)
            //                {
            //                    GridGST.Rows[g].Cells["op_type"].Value = op_type.ToString();
            //                    GridGST.Rows[g].Cells["op_des"].Value = op_des.ToString();

            //                }
            //            }
            //            for (int u = 0; u < GridUPS.Rows.Count; u++)
            //            {
            //                if (GridUPS.Rows[u].Cells["GST_xh"].Value.ToString() == GSTxh)
            //                {
            //                    GridUPS.Rows[u].Cells["op_type"].Value = op_type.ToString();
            //                    GridUPS.Rows[u].Cells["op_des"].Value = op_des.ToString();
            //                }
            //            }

            //        }

            //        else
            //        {
            //            for (int i = 0; i < OpList.Count; i++)
            //            {
            //                for (int g = 0; g < GridGST.Rows.Count; g++)
            //                {
            //                    if (GridGST.Rows[g].Cells["GST_xh"].Value.ToString() == OpList[i].ToString())
            //                    {
            //                        GridGST.Rows[g].Cells["op_type"].Value = op_type.ToString();
            //                        GridGST.Rows[g].Cells["op_des"].Value = op_des.ToString();

            //                    }
            //                }
            //                for (int u = 0; u < GridUPS.Rows.Count; u++)
            //                {
            //                    if (GridUPS.Rows[u].Cells["GST_xh"].Value.ToString() == OpList[i].ToString())
            //                    {
            //                        GridUPS.Rows[u].Cells["op_type"].Value = op_type.ToString();
            //                        GridUPS.Rows[u].Cells["op_des"].Value = op_des.ToString();
            //                    }
            //                }
            //            }
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    Change = Change + 1;
            //    UnCheck(GridGST);
            //    ChangeSchemeNo();
            //    ChangeButtonStatus();
            //}
        }
        #endregion

        #region 按钮：工具栏 保存工序表
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckSchemeComplete("Save") == true)
                {
                    if (CheckStationNum() == true)
                    {
                        ToSaveScheme(1);
                        ChangeButtonStatus();
                    }
                }
                else if (CheckSchemeComplete("Save") == false)
                {
                    DialogResult keynn = MessageBox.Show("有工序未排序，要保存不完整的方案吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (keynn == DialogResult.OK)
                    {
                        if (CheckStationNum() == true)
                        {
                            ToSaveScheme(0);
                            ChangeButtonStatus();
                        }
                    }
                    else { return; }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        #endregion

        #region 按钮：工具栏 推送到生产线
        /// <summary>
        /// 按钮：推送到生产线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToMES_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt_UPS.Rows[0]["SchemeNo"].ToString().Trim() != "-1")
                {
                    //推生产线前检查是否将方案号保存到订单
                    string sqlstr = "UPDATE [MES_order_master]   SET [SchemeNo] = "+ dt_UPS.Rows[0]["SchemeNo"].ToString().Trim() + " WHERE [order_no] = '"+ Order_Num+"'";
                    DBConn.DataAcess.SqlConn.ExecuteSql(sqlstr);
                }


                if (CheckSchemeComplete("Push"))
                {
                    //aaaaa
                    if (CheckOpTypeNum())
                    {
                        //bbbbb
                        if (CheckOpType())
                        {
                            PushToMES();
                            ChangeButtonStatus();
                        }
                        else
                        {
                            MessageBox.Show("第一道工序必须为上架工序，最后一道工序必须为下架工序");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        #endregion

        #region 按钮：工具栏 退出
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        //-------------------------------------------//
        //-------------------------------------------//
        //-------------------------------------------//

        #region DataGridView 双击行
        private void GridStation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //双击左键：将GridStation双击的行对应的Checkbox选中
            this.GridStation.Rows[e.RowIndex].Cells["check"].Value = this.GridStation.Rows[e.RowIndex].Cells["check"].Value == null ? true : !Convert.ToBoolean(this.GridStation.Rows[e.RowIndex].Cells["check"].Value);

            //if (this.exDataGridView3.Rows[e.RowIndex].Cells["check"].Value == null)
            //{
            //    this.exDataGridView3.Rows[e.RowIndex].Cells["check"].Value = true;
            //}
            //else
            //{
            //    this.exDataGridView3.Rows[e.RowIndex].Cells["check"].Value = !Convert.ToBoolean(this.exDataGridView3.Rows[e.RowIndex].Cells["check"].Value);
            //}

        }
        private void GridGST_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //双击左键：将GridGST双击的行对应的Checkbox选中
            this.GridGST.Rows[e.RowIndex].Cells["check"].Value = this.GridGST.Rows[e.RowIndex].Cells["check"].Value == null ? true : !Convert.ToBoolean(this.GridGST.Rows[e.RowIndex].Cells["check"].Value);

        }
        private void GridUPS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //双击左键：将GridUPS双击的行对应的Checkbox选中
            this.GridUPS.Rows[e.RowIndex].Cells["check"].Value = this.GridUPS.Rows[e.RowIndex].Cells["check"].Value == null ? true : !Convert.ToBoolean(this.GridUPS.Rows[e.RowIndex].Cells["check"].Value);

        }
        #endregion
        /// <summary>
        /// 添加特殊工序到UPS表
        /// </summary>
        /// <param name="Eton_Line">生产线编号</param>
        /// <param name="Eton_WorkStation">工作站编号</param>
        /// <param name="op_type_id">特殊工序序号</param>
        private void AddOPTypeToUPS(string Eton_Line, string Eton_WorkStation, string op_type_id, string op_type, string op_des)
        {
            try
            {
                int t = dt_UPS.Rows.Count;
                DataRow dr = dt_UPS.NewRow();
                dr["Eton_Line"] = Eton_Line;
                dr["Eton_WorkStation"] = Eton_WorkStation;
                dr["GST_xh"] = op_type_id;
                dr["OpCodeAlpha1"] = op_type_id;
                dr["op_type"] = op_type;
                dr["op_des"] = op_des;
                dr["UPS_ID"] = t + 1;
                dr["standard_time"] = "0";
                dt_UPS.Rows.Add(dr);


                //dt_UPS默认按照工作站号升序排序
                dt_UPS.DefaultView.Sort = "GST_ID,Eton_WorkStation ASC";
                Change = Change + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region 添加工位工序对照的行
        /// <summary>
        /// 
        /// </summary>

        private void AddToUPS()
        {
            try
            {
                #region 判断GridStation中CheckBox选择的情况
                int countStation = 0;//用于保存选择GridStation复选框的数量
                for (int j = 0; j < GridStation.RowCount; j++)
                {
                    if (GridStation.Rows[j].Cells[0].EditedFormattedValue.ToString() == "True")
                    //这里判断复选框是否选中
                    {
                        countStation++; //如果选中，则countStation+1                        
                    }
                }
                if (countStation == 0)
                {

                    MessageBox.Show("请至少选择一个工作站！", "提示");
                    return;//如果没有没有选择工作站，提示并退出
                }
                if (countStation > 8)
                {
                    MessageBox.Show("同一个工序最多只能添加到八个工作站！", "提示");//如果选择的工作站多余1个，提示并退出
                    for (int i = 0; i < GridStation.RowCount; i++)
                    {
                        GridStation.Rows[i].Cells[0].Value = false;//将所有GridStation的CheckBox置为未选择状态
                    }
                    return;
                }
                #endregion

                #region GridGST中CheckBox选择的情况
                int countGST = 0; //用于保存GridGST选中的checkbox数量
                int ss = 0; //用于保存GridGST选中checkbox并且同时已添加过的工序的数量
                for (int i = 0; i < GridGST.RowCount; i++)
                {
                    if (GridGST.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True") //如果复选框被选中
                    {
                        countGST++;
                        if (Convert.ToInt32(GridGST.Rows[i].Cells["Selected"].Value.ToString()) > 0) //如果复选框被选中并且已经添加过
                        {
                            ss++; //增加SS数量
                            if (MessageBox.Show("工序代码" + GridGST.Rows[i].Cells["GST_GZDM"].Value.ToString() + "已经添加过,确定需要重复添加吗？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                GridGST.Rows[i].Cells[0].Value = true; //如果选择确定，将重复添加工序到工作站
                            }
                            else
                            {
                                GridGST.Rows[i].Cells[0].Value = false; //如果选择取消，将Checkbox状态置为未选择，将不添加
                                ss = ss - 1;//减少一个SS数量
                            }
                        }
                    }
                }
                if (countGST == 0) //如果没有工序被选择 将弹出提示并返回
                {
                    if (ss == 0) //如果所有工序都没有选择的原因是将所有重复添加的工序都取消添加，将不弹出提示直接返回
                    {
                        return;
                    }
                    MessageBox.Show("请至少选择一个工序！", "提示");
                    return;
                }
                #endregion

                #region 将选择的工序和工作站添加到GridUPS：
                for (int i = 0; i < GridGST.RowCount; i++)
                {


                    if (GridGST.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True") //如果遇到GridGST中CheckBox被选中
                    {
                        for (int j = 0; j < GridStation.RowCount; j++)
                        {
                            if (GridStation.Rows[j].Cells[0].EditedFormattedValue.ToString() == "True") //如果遇到GridGST中CheckBox和GridStation中CheckBox同时被选中
                            {
                                for (int k = 0; k < GridUPS.Rows.Count; k++)
                                {
                                    if (GridUPS.Rows[k].Cells["Eton_Line"].Value.ToString() == GridStation.Rows[j].Cells["Eton_Line"].Value.ToString() && GridUPS.Rows[k].Cells["Eton_WorkStation"].Value.ToString() == GridStation.Rows[j].Cells["Eton_WorkStation"].Value.ToString() && GridUPS.Rows[k].Cells["GST_ID"].Value.ToString() == GridGST.Rows[i].Cells["ID"].Value.ToString())
                                    {
                                        MessageBox.Show("工序序号" + GridGST.Rows[i].Cells["GST_xh"].Value.ToString() + "已经在工作站" + GridUPS.Rows[k].Cells["Eton_WorkStation"].Value.ToString() + "添加过，不可以在同一个工作站重复添加相同工序", "提示");
                                        return;
                                    }
                                }
                                int t = dt_UPS.Rows.Count;
                                DataRow dr = dt_UPS.NewRow();
                                dr["Eton_Line"] = GridStation.Rows[j].Cells["Eton_Line"].Value.ToString();
                                dr["Eton_WorkStation"] = GridStation.Rows[j].Cells["Eton_WorkStation"].Value.ToString();
                                dr["order_no"] = GridGST.Rows[i].Cells["order_no"].Value.ToString();
                                dr["style_no"] = GridGST.Rows[i].Cells["style_no"].Value.ToString();
                                dr["OpCodeAlpha1"] = GridGST.Rows[i].Cells["OpCodeAlpha1"].Value.ToString();
                                dr["GST_GZDM"] = GridGST.Rows[i].Cells["GST_GZDM"].Value.ToString();
                                dr["operation_addr"] = GridGST.Rows[i].Cells["operation_addr"].Value.ToString();
                                dr["operation_des"] = GridGST.Rows[i].Cells["operation_des"].Value.ToString();
                                dr["EQ_ID"] = GridGST.Rows[i].Cells["EQ_ID"].Value.ToString();
                                dr["EQ_des"] = GridGST.Rows[i].Cells["EQ_des"].Value.ToString();
                                dr["GST_gxDJ"] = GridGST.Rows[i].Cells["GST_gxDJ"].Value.ToString();
                                dr["GST_xh"] = GridGST.Rows[i].Cells["GST_xh"].Value.ToString();
                                dr["op_type"] = GridGST.Rows[i].Cells["op_type"].Value.ToString();
                                dr["op_des"] = GridGST.Rows[i].Cells["op_des"].Value.ToString();
                                dr["GST_ID"] = GridGST.Rows[i].Cells["id"].Value.ToString();
                                dr["Station_ID"] = GridStation.Rows[j].Cells["ID"].Value.ToString();
                                dr["UPS_ID"] = t + 1;
                                dr["standard_time"] = "0";
                                dt_UPS.Rows.Add(dr);
                                this.GridGST.Rows[i].Cells["Selected"].Value = Convert.ToInt32(GridGST.Rows[i].Cells["selected"].Value) + 1; //将添加状态置为已添加
                                this.GridStation.Rows[j].Cells["Selected"].Value = Convert.ToInt32(GridStation.Rows[j].Cells["selected"].Value) + 1; //将添加状态置为已添加
                            }
                        }
                    }



                }
                #endregion

                //dt_UPS默认按照工作站号升序排序
                dt_UPS.DefaultView.Sort = "GST_ID,Eton_WorkStation ASC";
                //取消所有GridView的CHECKBOX
                GetWorkHours();
                UnCheck(GridGST); UnCheck(GridStation); UnCheck(GridUPS);
                Change = Change + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 删除工位工序对照表的行
        private void DelOperation()
        {
            try
            {

                #region 记录要删除的内容
                List<int> listupsid = new List<int>();//记录要删除的UPS_ID
                List<int> listgstid = new List<int>();//记录要删除的GST_ID
                List<int> liststationid = new List<int>();//记录要删除的Station_ID
                foreach (DataGridViewRow row in GridUPS.Rows)
                {
                    bool check = Convert.ToBoolean(row.Cells[0].EditedFormattedValue.ToString());
                    if (check == true) //如果checkbox被选中 则删除dt_UPS中对应的行
                    {
                        listupsid.Add(Convert.ToInt32(row.Cells["UPS_ID"].Value));
                        listgstid.Add(Convert.ToInt32(row.Cells["GST_ID"].Value));
                        liststationid.Add(Convert.ToInt32(row.Cells["Station_ID"].Value));
                    }
                }
                #endregion
                if (listupsid.Count < 1)
                {
                    MessageBox.Show("请至少选择一个工序！", "提示");
                    return;
                }
                #region 删除选中的GridUPS的行
                for (int n = listupsid.Count - 1; n >= 0; n--)
                {
                    for (int x = dt_UPS.Rows.Count - 1; x >= 0; x--)
                    {
                        if (listupsid[n] == Convert.ToInt32(dt_UPS.Rows[x]["UPS_ID"].ToString())) //找到dt_UPS中UPS_ID等于GridUPS中UPS_ID的行
                        {   //从dt_UPS删除
                            //dt_UPS.Rows[x].Delete(); dt_UPS.AcceptChanges();
                            dt_UPS.Rows.RemoveAt(x);
                        }
                    }//以下代码用来更改GridGST中对应行的SELECTED标记 如果被添加标记大于1，SELECTED减一，不更改显示样式
                }
                #endregion
                #region GridGST的Selected字段减1
                for (int n = listgstid.Count - 1; n >= 0; n--)
                {
                    for (int m = this.GridGST.Rows.Count - 1; m >= 0; m--)
                    {
                        if (listgstid[n] == Convert.ToInt32(GridGST.Rows[m].Cells["ID"].Value.ToString()))
                        {
                            GridGST.Rows[m].Cells["Selected"].Value = Convert.ToInt32(GridGST.Rows[m].Cells["selected"].Value) - 1;
                        }
                    }
                }
                #endregion
                #region GridStation的Selected字段减1
                for (int n = liststationid.Count - 1; n >= 0; n--)
                {
                    for (int m = this.GridStation.Rows.Count - 1; m >= 0; m--)
                    {
                        if (liststationid[n] == Convert.ToInt32(GridStation.Rows[m].Cells["ID"].Value.ToString()))
                        {
                            GridStation.Rows[m].Cells["Selected"].Value = Convert.ToInt32(GridStation.Rows[m].Cells["selected"].Value) - 1;
                        }
                    }
                }
                Change = Change + 1;//标记已修改过方案
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GridPaint(GridGST);
            //GridPaint(GridUPS);
            GridPaint(GridStation);
            GetWorkHours();
            UnCheck(GridUPS);

        }
        #endregion

        #region 判断方案是否完整
        /// <summary>
        /// 判断方案是否完整
        /// </summary>
        /// <param name="SaveOrPush">保存方案Save 推送方案Push</param>
        private bool CheckSchemeComplete(string SaveOrPush)
        {
            if (dt_UPS.Rows.Count < 1)
            {
                throw new Exception("不能保存空的方案！");

            }

            int v = 0;
            for (int i = 0; i < GridGST.Rows.Count; i++)
            {
                if (Convert.ToInt32(GridGST.Rows[i].Cells["Selected"].Value.ToString()) < 1)
                {
                    v = v + 1;
                }
            }
            if (v > 0)
            {

                if (SaveOrPush == "Save")
                {
                    return false;
                    //DialogResult keynn = MessageBox.Show("有工序未排序，要保存不完整的方案吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    //if (keynn == DialogResult.OK)
                    //{
                    //    return false;
                    //}
                }
                else if (SaveOrPush == "Push")
                {
                    throw new Exception("当前方案有未排产工序，不能推送到生产线，请返回修改！");
                    //MessageBox.Show("当前方案有未排产工序，不能推送到生产线，请返回修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }



        }
        #endregion



        #region 检查上架或下架工序的数量是否只有一个
        /// <summary>
        /// 检查上架或下架工序的数量是否只有一个
        /// </summary>
        /// <returns></returns>
        private bool CheckOpTypeNum()
        {
            bool Bmax = false;
            bool Bmin = false;
            for (int i = 0; i < GridUPS.Rows.Count; i++)
            {
    //            if (Convert.ToInt32(GridUPS.Rows[i].Cells["op_type"].Value.ToString()) == 8 || Convert.ToInt32(GridUPS.Rows[i].Cells["op_type"].Value.ToString()) == 12 ||
    //Convert.ToInt32(GridUPS.Rows[i].Cells["op_type"].Value.ToString()) == 24 || Convert.ToInt32(GridUPS.Rows[i].Cells["op_type"].Value.ToString()) == 28)

                    if (Convert.ToInt32(GridUPS.Rows[i].Cells["GST_xh"].Value.ToString())==10001)
                {
                    if (Bmax == false)
                    {
                        Bmax = true;
                    }
                    else
                    {
                        throw new Exception("只能有一个下架站");
                    }
                }

                // if (Convert.ToInt32(GridUPS.Rows[i].Cells["op_type"].Value.ToString()) == 1 || Convert.ToInt32(GridUPS.Rows[i].Cells["op_type"].Value.ToString()) == 5 || Convert.ToInt32(GridUPS.Rows[i].Cells["op_type"].Value.ToString()) == 17)
                if (Convert.ToInt32(GridUPS.Rows[i].Cells["GST_xh"].Value.ToString()) == 10000)
                {
                    if (Bmin == false)
                    {
                        Bmin = true;
                    }
                    else
                    {
                        throw new Exception("只能有一个上架站");
                    }
                }
            }
            return true;
        }
        #endregion

        #region Eton生产线同一工序最多只能排在8个工作站
        private bool CheckStationNum()
        {

            for (int i = 0; i < GridGST.Rows.Count; i++)
            {
                string opnum = "";
                DataTable dt11 = new DataTable();
                DataColumn columnA = new DataColumn("Eton_WorkStation", typeof(System.Int16));
                dt11.Columns.Add(columnA);
                opnum = GridGST.Rows[i].Cells["OpCodeAlpha1"].Value.ToString();
                for (int u = 0; u < GridUPS.Rows.Count; u++)
                {
                    if (GridUPS.Rows[u].Cells["OpCodeAlpha1"].Value.ToString() == opnum)
                    {
                        DataRow dr11 = dt11.NewRow();
                        dr11["Eton_WorkStation"] = GridUPS.Rows[u].Cells["Eton_WorkStation"].Value.ToString();
                        dt11.Rows.Add(dr11);
                    }
                }
                if (dt11.Rows.Count > 8)
                {
                    throw new Exception("工序" + opnum + "最多只能安排到8个工作站！");
                }
            }
            return true;


        }
        #endregion

        #region 提交到生产线时 检查是否第一工序是否为上架和最后工序是否为下架工序 
        /// <summary>
        /// 提交到生产线时 检查是否第一工序是否为上架和最后工序是否为下架工序 
        /// </summary>
        /// <returns></returns>
        private bool CheckOpType()
        {
            bool B10000 = false;
            bool B10001 = false;

            for (int i = 0; i < GridUPS.Rows.Count; i++)
            {
                if (Convert.ToInt32(GridUPS.Rows[i].Cells["GST_xh"].Value.ToString())==10000)
                {
                    B10000 = true;
                }
                if (Convert.ToInt32(GridUPS.Rows[i].Cells["GST_xh"].Value.ToString()) == 10001)
                {
                    B10001 = true;
                }

            }
            return B10000 && B10001;

            //Int32 max = 0;
            //Int32 min = 0;
            //bool Bmax = false;
            //bool Bmin = false;
            //max = Convert.ToInt32(GridGST.Rows[0].Cells["GST_xh"].Value.ToString());
            //min = Convert.ToInt32(GridGST.Rows[0].Cells["GST_xh"].Value.ToString());
            //for (int i = 0; i < GridGST.Rows.Count; i++)
            //{
            //    if (Convert.ToInt32(GridGST.Rows[i].Cells["GST_xh"].Value.ToString()) >= max)
            //    {
            //        max = Convert.ToInt32(GridGST.Rows[i].Cells["GST_xh"].Value.ToString());
            //        if (Convert.ToInt32(GridGST.Rows[i].Cells["op_type"].Value.ToString()) == 8 || Convert.ToInt32(GridGST.Rows[i].Cells["op_type"].Value.ToString()) == 12 ||
            //            Convert.ToInt32(GridGST.Rows[i].Cells["op_type"].Value.ToString()) == 24 || Convert.ToInt32(GridGST.Rows[i].Cells["op_type"].Value.ToString()) == 28)
            //        {
            //            Bmax = true;
            //        }
            //        else
            //        {
            //            Bmax = false;
            //        }
            //    }
            //    if (Convert.ToInt32(GridGST.Rows[i].Cells["GST_xh"].Value.ToString()) <= min)
            //    {
            //        min = Convert.ToInt32(GridGST.Rows[i].Cells["GST_xh"].Value.ToString());
            //        if (Convert.ToInt32(GridGST.Rows[i].Cells["op_type"].Value.ToString()) == 1 || Convert.ToInt32(GridGST.Rows[i].Cells["op_type"].Value.ToString()) == 5 || Convert.ToInt32(GridGST.Rows[i].Cells["op_type"].Value.ToString()) == 17)
            //        {
            //            Bmin = true;
            //        }
            //        else
            //        {
            //            Bmin = false;
            //        }
            //    }
            //}
            //return Bmax && Bmin;
        }
        #endregion

        #region 保存排产表
        /// <summary>
        /// 保存排产表
        /// </summary>
        private void ToSaveScheme(int c)
        {
            int CompleteState = c;

            DialogResult key = MessageBox.Show("点击'确定'将生成新的方案 点击'取消'返回修改", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                //新方案号 新方案是否为最佳方案1为最佳 新方案备注
                string SchemeNo_New = "";
                int state_new = 1;
                string memo = "";
                Line_Num = combo_Line.Text;
                //打开新窗体 用于确认是否为最佳方案和填写备注
                SaveScheme s1 = new SaveScheme();
                DialogResult f1 = s1.ShowDialog();
                //s1.ShowDialog.DialogResult=
                //返回结果 返回新方案号 新方案是否为最佳方案 新方案备注
                if (f1 == DialogResult.OK)
                {
                    this.Enabled = false;
                    MyContrals.WaitFormService.Show(this);
                    MyContrals.WaitFormService.SetLeftText("lefttext");
                    MyContrals.WaitFormService.SetProgressBarMax(3, "正在提交：");
                    MyContrals.WaitFormService.SetRightText("righttext");
                    MyContrals.WaitFormService.SetTopText("toptext");
                    dt_UPS.DefaultView.Sort = "GST_ID,Eton_WorkStation ASC";
                    try
                    {
                        SchemeNo_New = SaveScheme.SchemeNo_New;//新的方案号
                        for (int u = 0; u < GridUPS.Rows.Count; u++)
                        {
                            GridUPS.Rows[u].Cells["SchemeNo"].Value = SchemeNo_New.ToString();
                        }
                        //MyContrals.WaitFormService.ProgressBarGrow();
                        state_new = SaveScheme.state_new;//是否设置为最佳方案 1是 -1不是
                        memo = SaveScheme.memo; //方案备注 长描述
                        //定义一个ArrayList用来存储将要执行的SQL语句
                        ArrayList SQLList = new ArrayList();
                        SQLList.Add("UPDATE [dbo].[MES_order_master] SET [SchemeNo] = '" + SchemeNo_New + "' WHERE order_no='" + Order_Num + "'");
                        //如果新方案是此款号对应的最佳方案，则将此此款原有的所有方案的最佳方案标识都置为-1
                        if (state_new == 1) { SQLList.Add("UPDATE [dbo].[MES_station_operation_master] SET [state] = -1 where style_no = '" + Style_Num + "'"); }
    
                        //将GridUPS中的所有行写入到数据库
                        SQLList.Add("INSERT INTO [MES_station_operation_master] ([style_no],[SchemeDate],[SchemeNo],[memo],[state],CompleteState) VALUES( '" + Style_Num + "',getdate(),'" + SchemeNo_New + "','" + memo + "','" + state_new + "','" + CompleteState + "' )");

                        UpdateDataTable(dt_UPS);
                        //GetGridUPS();


                        for (int i = 0; i < GridUPS.Rows.Count; i++)
                        {
                            int Eton_WorkStation = Convert.ToInt32(GridUPS.Rows[i].Cells["Eton_WorkStation"].Value.ToString());
                            string OpCodeAlpha1 = GridUPS.Rows[i].Cells["OpCodeAlpha1"].Value.ToString();
                            string GST_xh = GridUPS.Rows[i].Cells["GST_xh"].Value.ToString();
                            string operation_des = GridUPS.Rows[i].Cells["operation_des"].Value.ToString();
                            string operation_addr = GridUPS.Rows[i].Cells["operation_addr"].Value.ToString();
                            string price = GridUPS.Rows[i].Cells["price"].Value.ToString();
                            string Time_unit = GridUPS.Rows[i].Cells["Time_unit"].Value.ToString();
                            string OpQualityRequirement = GridUPS.Rows[i].Cells["OpQualityRequirement"].Value.ToString();
                            string StyleQualityRequirement = GridUPS.Rows[i].Cells["StyleQualityRequirement"].Value.ToString();
                            string Technology_picture = GridUPS.Rows[i].Cells["Technology_picture"].Value.ToString();
                            string standard_time = GridUPS.Rows[i].Cells["standard_time"].Value.ToString();
                            string EQ_ID = GridUPS.Rows[i].Cells["EQ_ID"].Value.ToString();
                            string EQ_des = GridUPS.Rows[i].Cells["EQ_des"].Value.ToString();
                            string GST_gxDJ = GridUPS.Rows[i].Cells["GST_gxDJ"].Value.ToString();
                            string GST_XCBJ = GridUPS.Rows[i].Cells["GST_XCBJ"].Value.ToString();
                            string GST_GZDM = GridUPS.Rows[i].Cells["GST_GZDM"].Value.ToString();


                            //2021.4.15 op_type
                            string op_type = "";
                            if (GridGST.Rows[i].Cells["OpCodeAlpha1"].Value.ToString() == "10000")
                            {
                                op_type = "1";
                            }
                            else if (GridGST.Rows[i].Cells["OpCodeAlpha1"].Value.ToString() == "10001")
                            {
                                op_type = "8";
                            }
                            else if (GridGST.Rows[i].Cells["OpCodeAlpha1"].Value.ToString() == "2160")
                            {
                                op_type = "4";
                            }
                            else
                            {
                                op_type = "2";
                            }


                            SQLList.Add("INSERT INTO[dbo].[MES_station_operation_detail] ([SchemeNo],[Eton_Line],[Eton_WorkStation],[OpCodeAlpha1],[GST_xh],[operation_addr],[operation_des],[price],[Time_unit],[OpQualityRequirement],[StyleQualityRequirement],[Technology_picture],[standard_time],[EQ_ID],[EQ_des],[GST_gxDJ],[GST_XCBJ],[GST_GZDM],[op_type])     VALUES('" + SchemeNo_New + "', '" + combo_Line.Text + "', '" + Eton_WorkStation + "', '" + OpCodeAlpha1 + "', '" + GST_xh + "', '" + operation_addr + "', '" + operation_des + "', '" + price + "', '" + Time_unit + "', '" + OpQualityRequirement + "', '" + StyleQualityRequirement + "', '" + Technology_picture + "', '" + standard_time + "', '" + EQ_ID + "', '" + EQ_des + "', '" + GST_gxDJ + "', '" + GST_XCBJ + "', '" + GST_GZDM + "', '" + op_type + "')");

                            //2021.4.15
                            //SQLList.Add("INSERT INTO [MES_station_operation_detail] ([SchemeNo],[Eton_Line],[Eton_WorkStation],[OpCodeAlpha1],[GST_xh]) VALUES ('" + SchemeNo_New + "','" + combo_Line.Text + "','" + Eton_WorkStation + "','" + OpCodeAlpha1 + "','" + GST_xh + "')");
                            SQLList.Add("INSERT INTO [dbo].[MES_operation_detail_type] ([SchemeNo] ,[OpCodeAlpha1] ,[op_type]) VALUES('" + SchemeNo_New + "' ,'" + OpCodeAlpha1 + " ','" + op_type + "')");


                            //int ws = Convert.ToInt32(GridUPS.Rows[i].Cells["Eton_WorkStation"].Value.ToString());
                            //string OpCodeAlpha1 = GridUPS.Rows[i].Cells["OpCodeAlpha1"].Value.ToString();
                            //string GST_xh = GridUPS.Rows[i].Cells["GST_xh"].Value.ToString();
                            //SQLList.Add("INSERT INTO [MES_station_operation_detail] ([SchemeNo],[Eton_Line],[Eton_WorkStation],[OpCodeAlpha1],[GST_xh]) VALUES ('" + SchemeNo_New + "','" + combo_Line.Text + "','" + ws + "','" + OpCodeAlpha1 + "','" + GST_xh + "')");
                        }
                        //for (int g = 0; g < GridGST.Rows.Count; g++)
                        //{
                        //    string op_type = "";
                        //    string OpCodeAlpha1 = "";
                        //    if (GridGST.Rows[g].Cells["OpCodeAlpha1"].Value.ToString() == "10000")
                        //    {
                        //        op_type = "1";

                        //    }
                        //    else if (GridGST.Rows[g].Cells["OpCodeAlpha1"].Value.ToString() == "10001")
                        //    {
                        //        op_type = "8";

                        //    }
                        //    else if (GridGST.Rows[g].Cells["OpCodeAlpha1"].Value.ToString() == "2160")
                        //    {
                        //        op_type = "4";

                        //    }
                        //    else
                        //    {
                        //        op_type = "2";
                        //    }
                        //    OpCodeAlpha1 = GridGST.Rows[g].Cells["OpCodeAlpha1"].Value.ToString();
                        //    //Console.WriteLine( "INSERT INTO [dbo].[MES_operation_detail_type] ([SchemeNo] ,[OpCodeAlpha1] ,[op_type]) VALUES('" + SchemeNo_New + "' ,'" + OpCodeAlpha1 + " ','" + op_type + "'");

                        //    SQLList.Add("INSERT INTO [dbo].[MES_operation_detail_type] ([SchemeNo] ,[OpCodeAlpha1] ,[op_type]) VALUES('" + SchemeNo_New + "' ,'" + OpCodeAlpha1 + " ','" + op_type + "')");


                        //}
                        MyContrals.WaitFormService.ProgressBarGrow();
                        //DBConn.DataAcess.SqlConn.LogInfo("保存排产表", "xulixia", "保存");
                        DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                        this.SchemeNo = SchemeNo_New;
                        Change = 0;
                        MyContrals.WaitFormService.ProgressBarGrow();
                        MyContrals.WaitFormService.Close();
                        SendMessage(maindHwnd, WM_ACTIVATE, 0, 0);
                        MessageBox.Show(this, "方案已保存，方案号为" + SchemeNo, "提示");
                    }
                    catch (Exception ex)
                    {
                        MyContrals.WaitFormService.Close();
                        SendMessage(maindHwnd, WM_ACTIVATE, 0, 0);
                        MessageBox.Show(ex.Message);
                    }
                    MyContrals.WaitFormService.Close();
                    SendMessage(maindHwnd, WM_ACTIVATE, 0, 0);
                }
            }
            else { return; }
        }
        #endregion
        /// <summary>
        /// 修改数据表DataTable某一列的类型和记录值(正确步骤：1.克隆表结构，2.修改列类型，3.修改记录值，4.返回希望的结果)
        /// 将工序序号为10000的放在第一行，将工序序号为10001的放在最后一行
        /// </summary>
        /// <param name="argDataTable">数据表DataTable</param>
        /// <returns>数据表DataTable</returns>  

        private DataTable UpdateDataTable(DataTable argDataTable)
        {
            DataTable dtResultTemp = new DataTable();
            //克隆表结构
            dtResultTemp = argDataTable.Clone();
            foreach (DataColumn col in dtResultTemp.Columns)
            {
                if (col.ColumnName == "工序序号")
                {
                    //修改列类型
                    col.DataType = typeof(Int16);
                }
            }

            foreach (DataRow row in argDataTable.Rows)
            {
                DataRow rowNew = dtResultTemp.NewRow();

                rowNew["GST_xh"] = row["GST_xh"];
                //修改记录值
                //rowNew["工序代码"] = Convert.ToDateTime(row["RQ"]).ToString("yyyy-MM-dd").ToString();
                rowNew["Eton_Line"] = row["Eton_Line"];
                rowNew["Eton_WorkStation"] = row["Eton_WorkStation"];
                rowNew["order_no"] = row["order_no"];
                rowNew["style_no"] = row["style_no"];
                rowNew["OpCodeAlpha1"] = row["OpCodeAlpha1"];
                rowNew["GST_GZDM"] = row["GST_GZDM"];
                rowNew["operation_addr"] = row["operation_addr"];
                rowNew["operation_des"] = row["operation_des"];
                rowNew["standard_time"] = row["standard_time"];
                rowNew["EQ_ID"] = row["EQ_ID"];
                rowNew["EQ_des"] = row["EQ_des"];
                rowNew["GST_gxDJ"] = row["GST_gxDJ"];
                rowNew["op_type"] = row["op_type"];
                rowNew["op_des"] = row["op_des"];
                rowNew["GST_ID"] = row["GST_ID"];

                rowNew["UPS_ID"] = row["UPS_ID"];
                rowNew["Station_ID"] = row["Station_ID"];
                rowNew["SchemeNo"] = row["SchemeNo"];
                dtResultTemp.Rows.Add(rowNew);
            }
            dtResultTemp.DefaultView.Sort = "GST_xh";
            dtResultTemp = dtResultTemp.DefaultView.ToTable();


            DataTable dtResult = new DataTable();
            dtResult = dtResultTemp.Clone();
            for (int i = 0; i < dtResultTemp.Rows.Count; i++)
            {
                if (dtResultTemp.Rows[i]["GST_xh"].ToString() == "10000")
                {
                    dtResult.ImportRow(dtResultTemp.Rows[i]);
                }
            }
            for (int i = 0; i < dtResultTemp.Rows.Count; i++)
            {
                if (dtResultTemp.Rows[i]["GST_xh"].ToString() != "10000" && dtResultTemp.Rows[i]["GST_xh"].ToString() != "10000")
                {
                    dtResult.ImportRow(dtResultTemp.Rows[i]);
                }
            }
            return dtResult;
        }

        #region 推送到生产线
        /// <summary>
        /// 推送到生产线
        /// </summary>
        private void PushToMES()
        {
            this.Enabled = false;
            MyContrals.WaitFormService.Show(this);
            MyContrals.WaitFormService.SetLeftText("lefttext");
            MyContrals.WaitFormService.SetProgressBarMax(5, "正在提交：");
            //MyContrals.WaitFormService.SetRightText("righttext");
            MyContrals.WaitFormService.SetTopText("toptext");



            if (Change != 0)
            {
                MyContrals.WaitFormService.Close();
                MessageBox.Show("请先保存方案", "提示");
                return;
            }
            else
            {

                try
                {
                    MyContrals.WaitFormService.ProgressBarGrow();
                    WebSaveScheme.PService ss = new WebSaveScheme.PService();

                    bool stoGX = ss.ToGX(Order_Num);
                    MyContrals.WaitFormService.ProgressBarGrow();

                    string PRUNID = ss.ToMes(Order_Num);
                    MyContrals.WaitFormService.ProgressBarGrow();
                    if (stoGX == false || PRUNID.Length == 0)
                    {
                        this.Enabled = true;
                        MyContrals.WaitFormService.Close();
                        MessageBox.Show("提交失败，请重新选择订单并提交", "提示");
                    }
                    else
                    {
                        MyContrals.WaitFormService.ProgressBarGrow();
                        ArrayList SQLList = new ArrayList();
                        SQLList.Add("UPDATE [dbo].[MES_order_master] SET [UPS_prun] = " + PRUNID + " WHERE order_no='" + Order_Num + "'");
                        DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                        MyContrals.WaitFormService.ProgressBarGrow();
                        this.Enabled = true;
                        MyContrals.WaitFormService.Close();
                        SendMessage(maindHwnd, WM_ACTIVATE, 0, 0);
                        MessageBox.Show("成功！订单号：" + Order_Num + "，方案号：" + SchemeNo + ",生产线系统订单号：" + PRUNID, "提示");
                    }
                }
                catch (Exception ex)
                {
                    MyContrals.WaitFormService.Close();
                    SendMessage(maindHwnd, WM_ACTIVATE, 0, 0);
                    throw ex;
                }
            }
            MyContrals.WaitFormService.Close();
            SendMessage(maindHwnd, WM_ACTIVATE, 0, 0);
        }
        #endregion

        #region GridUPS方案号更新 -1未保存方案
        private void ChangeSchemeNo()
        {
            if (Change != 0)
            {
                for (int u = 0; u < dt_UPS.Rows.Count; u++)
                {
                    int New_SchemeNo1 = -1;
                    dt_UPS.Rows[u]["SchemeNo"] = New_SchemeNo1;
                }
            }
        }
        #endregion

        #region 改变按钮状态：保存排产表/推送到生产线 
        /// <summary>
        /// 改变按钮状态：保存排产表/推送到生产线 
        /// </summary>
        private void ChangeButtonStatus()
        {

            string sqlstring = "SELECT UPS_prun FROM [dbo].[MES_order_master] WHERE order_no='" + Order_Num + "'";
            object SchemeToMES = DBConn.DataAcess.SqlConn.GetSingle(sqlstring);

            if (dt_UPS.Rows.Count == 0)
            {
                this.ButtonToMES.Enabled = false;
                this.ButtonToMES.Enabled = false;
                this.BottonMinus.Enabled = false;
            }
            else if (SchemeToMES != null)
            {
                this.ButtonSave.Enabled = false;
                this.ButtonToMES.Enabled = false;
            }//如果已经推送到生产线的订单，不支持更改方案及重新推送
            else
            {
                if (Change == 0) //新载入的订单方案，没有任何改动
                {
                    this.ButtonSave.Enabled = false;
                    this.ButtonToMES.Enabled = true;
                }
                else if (Change > 0) //方案有变动 未保存
                {
                    this.ButtonSave.Enabled = true;
                    this.ButtonToMES.Enabled = false;
                }
                this.BottonMinus.Enabled = true;
            }

            if (GridGST.Rows.Count == 0)
            {
                this.ButtonAdd.Enabled = false;
                this.ButtonOpType.Enabled = false;
            }
            else
            {
                if (GridStation.Rows.Count == 0) { this.ButtonAdd.Enabled = false; }
                else
                {
                    this.ButtonAdd.Enabled = true;
                }
                this.ButtonOpType.Enabled = true;
            }


        }
        #endregion

        #region  取消所有的CheckBox选择状态
        /// <summary>
        /// 取消所有的CheckBox选择状态
        /// </summary>
        private void UnCheck(MyContrals.ExDataGridView Grid)
        {
            for (int i = 0; i < Grid.RowCount; i++)
            {
                Grid.Rows[i].Cells[0].Value = false;
            }
        }
        #endregion

        #region ComboBox:combo_Line_SelectedIndexChanged 选择的值发生变化时 重新加载GridStation
        /// <summary>
        /// combo_Line选择的值发生变化时 重新加载GridStation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combo_Line_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd = "SELECT top 1 b.Eton_Line  FROM MES_order_master a  left join MES_station_operation_detail b  on a.SchemeNo=b.SchemeNo where a.order_no='" + Order_Num + "'";
            int SchemeLine = DBConn.DataAcess.SqlConn.ExecuteSql(cmd);

            if (combo_Line.Text.ToString().Trim() != SchemeLine.ToString().Trim())
            {

                GetGridUPS();
            }
            if (combo_Line.Text.ToString().Trim() != Line_Num.Trim())
            {


                string sqlstr = "";
                sqlstr = "SELECT [SchemeNo]  FROM [mes].[dbo].[MES_order_master]  where order_no='" + Order_Num + "'";
                DataTable dt = DBConn.DataAcess.SqlConn.Query(sqlstr).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    SchemeNo = dt.Rows[0]["SchemeNo"].ToString().Trim();
                }
                //sqlstr = "SELECT top 1 [Eton_Line]   FROM [mes].[dbo].[MES_station_operation_detail]  where schemeno='" + SchemeNo + "'";
                //dt = DBConn.DataAcess.SqlConn.Query(sqlstr).Tables[0];
                //string l = dt.Rows[0]["Eton_Line"].ToString().Trim() ;
                //if(l= combo_Line.Text;)
                //{

                //}
                Line_Num = combo_Line.Text;

                GetGridStation();


                GetGridUPS();
                




                //for (int j = 0; j < GridStation.Rows.Count; j++)
                //{
                //    for (int i = 0; i < dt_UPS.Rows.Count; i++)
                //    {
                //        if (dt_UPS.Rows[i]["Station_ID"].ToString() != "")
                //        {
                //            if (Convert.ToInt32(dt_UPS.Rows[i]["Station_ID"].ToString()) == Convert.ToInt32(GridStation.Rows[j].Cells["ID"].Value.ToString()))
                //            {
                //                this.GridStation.Rows[j].Cells["Selected"].Value = Convert.ToInt32(GridStation.Rows[j].Cells["selected"].Value) + 1;
                //            }
                //        }

                //    }
                //}

                GetWorkHours();
                GridPaint(GridGST);
                GridPaint(GridStation);
                //GridPaint(GridUPS);
                ChangeButtonStatus();
            }
            else { return; }
        }

        #endregion

        #region ComboBox:combo_Line_DropDownClosed 工位工序表有内容时更改生产线
        /// <summary>
        /// combo_Line_DropDownClosed 工位工序表有内容时更改生产线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combo_Line_DropDownClosed(object sender, EventArgs e)
        {
            if (Line_Num != combo_Line.Text.ToString().Trim())
            {
                if (GridUPS.Rows.Count > 0)
                {   //如果工位工序表格有内容 提示是否切换生产线 是则返回 否则重置dt_ups
                    if (Change > 0)
                    {
                        if (MessageBox.Show("确定要重新选择生产线？将不保存当前方案", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        {
                            combo_Line.Text = GridUPS.Rows[0].Cells["Eton_Line"].Value.ToString();
                            return;
                        }
                        else
                        {
                            dt_UPS.Clear();
                            for (int i = 0; i < GridStation.Rows.Count; i++)
                            {
                                GridStation.Rows[i].Cells["Selected"].Value = 0;
                            }
                            for (int i = 0; i < GridGST.Rows.Count; i++)
                            {
                                GridGST.Rows[i].Cells["Selected"].Value = 0;
                            }
                            GridPaint(GridGST);
                            //GridPaint(GridUPS);
                            GridPaint(GridStation);
                            //取消所有GridView的CHECKBOX
                            GetWorkHours();
                            UnCheck(GridStation);
                            Change = Change + 1;
                            ChangeButtonStatus();

                        }
                    }

                }
            }
            else
            { return; }
        }

        #endregion

        #region GridPaint
        private void GridPaint(MyContrals.ExDataGridView Grid)
        {
            if (Grid.Rows.Count > 0)
            {
                for (int i = 0; i < Grid.Rows.Count; i++)
                {
                    int ss = Convert.ToInt32(Grid.Rows[i].Cells["Selected"].Value);
                    if (ss > 0)
                    {
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.Blue; //添加过的行字体颜色
                        Grid.Rows[i].DefaultCellStyle.Font = new Font("宋体", 9F, FontStyle.Bold);  //添加过的行字体加粗
                        Grid.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Blue; //添加过的行被选中时的字体颜色
                    }
                    else
                    {
                        Grid.Rows[i].DefaultCellStyle.ForeColor = DefaultForeColor;
                        Grid.Rows[i].DefaultCellStyle.Font = DefaultFont;
                        Grid.Rows[i].DefaultCellStyle.SelectionForeColor = DefaultForeColor;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Grid.Rows.Count; i++)
                {
                    Grid.Rows[i].DefaultCellStyle.ForeColor = DefaultForeColor; //添加过的行字体颜色
                    Grid.Rows[i].DefaultCellStyle.Font = DefaultFont;  //添加过的行字体加粗
                    Grid.Rows[i].DefaultCellStyle.SelectionForeColor = DefaultForeColor; //添加过的行被选中时的字体颜色}
                }
            }
        }
        #endregion

        #region GridStation_Paint
        /// <summary>
        /// GridStation_Paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridStation_Paint(object sender, PaintEventArgs e)
        {
            GridPaint(GridStation);
        }
        #endregion GridStation_Paint

        #region  GridGST_Paint
        /// <summary>
        /// GridGST_Paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridGST_Paint(object sender, PaintEventArgs e)
        {
            GridPaint(GridGST);
        }
        #endregion GridGST_Paint
        #region  GridUPS_Paint
        /// <summary>
        /// GridGST_Paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridUPS_Paint(object sender, PaintEventArgs e)
        {
           // GridPaint(GridUPS);
        }
        #endregion GridGST_Paint



        //-----------------右键------------------//
        //-----------------右键------------------//
        //-----------------右键------------------//

        #region 右键：DataGridView鼠标右键动作
        private void GridUPS_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (GridUPS.Rows[e.RowIndex].Selected == false)
                    {
                        GridUPS.ClearSelection();
                        GridUPS.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (GridUPS.SelectedRows.Count == 1)
                    {
                        GridUPS.CurrentCell = GridUPS.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    txContextMenuStripUPS.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        private void GridGST_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (GridGST.Rows[e.RowIndex].Selected == false)
                    {
                        GridGST.ClearSelection();
                        GridGST.Rows[e.RowIndex].Selected = true;
                    }

                    //只选中一行时设置活动单元格
                    if (GridGST.SelectedRows.Count == 1)
                    {
                        GridGST.CurrentCell = GridGST.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    txContextMenuStripGST.Show(MousePosition.X, MousePosition.Y);
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
                        GridStation.CurrentCell = GridStation.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    txContextMenuStripStation.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        #endregion

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

        #region GridUPS右键
        private void 选中行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridUPS, Selected.选择);
        }

        private void 所有行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridUPS, Selected.全选);
        }

        private void 选中行ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridUPS, Selected.取消选择);
        }

        private void 所有行ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridUPS, Selected.取消全选);
        }
        private void 导出到EXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyContrals.ToExcel.ExDataGridViewToExcel(this.GridUPS);
        }

        #endregion

        #region GridGST右键
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridGST, Selected.选择);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridGST, Selected.全选);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridGST, Selected.取消选择);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridGST, Selected.取消全选);
        }
        #endregion

        #region GridStation右键
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.选择);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.全选);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.取消选择);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            MouseRightSelect(GridStation, Selected.取消全选);
        }










        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            int g = GridGST.Rows.Count;
            int u = GridUPS.Rows.Count;
            label5.Text = g.ToString();
            label6.Text = u.ToString();
        }

        private void ButtonImportOrder_Click(object sender, EventArgs e)
        {
            ExcelImport e1 = new ExcelImport();
            if (e1.ShowDialog() == DialogResult.OK)
            {
                Order_Num = e1.Order_Num;
                LableOrderNum.Text= e1.Order_Num;
                Style_Num = e1.Style_Num;
                LableStyleNum.Text = e1.Style_Num;
                e1.Close();
            }
            Change = 0;//新加载或新建的方案，被修改标记为0
            SchemeNo = "";
            Line_Num = "";
            combo_Line.Text = "";
            GetGridGstOP();//加载订单对应的GST工序


            GetGridStation();//加载订单方案对应或者选择的生产线
            GetGridUPS();//如果有对应方案则加载工位工序表
            //StationBll sb = new StationBll();
            ////如果用了combo_Line_SelectedIndexChanged,必须DisplayMember在DataSource之前,否则加载时会被赋值System.Data.DataRowView导致执行SQL语句报错
            //combo_Line.DisplayMember = "Eton_line";//Combobox加载现有生产线
            //combo_Line.DataSource = sb.get_line();
            //GetWorkHours();
            ChangeButtonStatus();
        }

        DataTable dt_ups_current = new DataTable();

        /// <summary>
        /// 记录打开下拉菜单时的当前值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combo_Line_DropDown(object sender, EventArgs e)
        {
            //if (GridUPS.Rows.Count > 0 && Change!=0)
            //{
                
            //    LineNum_current = combo_Line.Text.ToString();
            //        foreach (DataGridViewColumn headerCell in GridUPS.Columns)

            //        {

            //            dt_ups_current.Columns.Add(headerCell.HeaderText);

            //        }

            //        foreach (DataGridViewRow item in GridUPS.Rows)

            //        {

            //            DataRow dr = dt_ups_current.NewRow();

            //            for (int i = 0; i < dt_ups_current.Columns.Count; i++)

            //            {

            //                dr[i] = item.Cells[i].Value.ToString();

            //            }

            //            dt_ups_current.Rows.Add(dr);

            //        }
            //}


        }

        /// <summary>
        /// 按钮 导入方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonImportScheme_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNewOrder_Click(object sender, EventArgs e)
        {
            if (GridUPS.Rows.Count > 0)
            {   //如果工位工序表格有内容 提示是否要选择新订单号 选择新订单号将丢失未保存的排产表
                if (MessageBox.Show("‘OK’选择新订单号 ‘Cancel’返回", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
            }
            dt_UPS.Clear();
            NewOrder e1 = new NewOrder(); ; //参数为1时 代表选择订单
            if (e1.ShowDialog() == DialogResult.OK)
            {

                Style_Num = e1.Style_Num;
                Line_Num = e1.Line_Num;

                Order_Num = e1.Order_Num;
                SchemeNo = e1.Scheme_Num;
                this.LableStyleNum.Text = Style_Num;
                this.LableOrderNum.Text = Order_Num;
                e1.Close();
            }
            if (Line_Num == "")
            {
                combo_Line.Text = "";

            }
            else
            {
                combo_Line.Text = Line_Num;

            }
            Change = 0;//新加载或新建的方案，被修改标记为0

            GetGridGstOP();//加载订单对应的GST工序
            GetGridStation();//加载订单方案对应或者选择的生产线
            GetGridUPS();//如果有对应方案则加载工位工序表
            //StationBll sb = new StationBll();
            ////如果用了combo_Line_SelectedIndexChanged,必须DisplayMember在DataSource之前,否则加载时会被赋值System.Data.DataRowView导致执行SQL语句报错
            //combo_Line.DisplayMember = "Eton_line";//Combobox加载现有生产线
            //combo_Line.DataSource = sb.get_line();
            GetWorkHours();
            ChangeButtonStatus();
        }
    }
}


