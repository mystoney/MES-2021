using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Text;
using System.Drawing;

namespace MES.form.Operation
{
    public partial class SelectOrder : Form
    {
        public string Style_Num = "";
        public string Line_Num = "";
        public string Order_Num = "";
        public string Scheme_Num = "";
        public string UPS_prun = "";
        public string Edit = "";

        #region 初始化
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">0为款号 1为订单 2为方案</param>
        public SelectOrder(int v)
        {
            InitializeComponent();
            if (v == 1 ) { Edit = "Order"; this.label1.Text = "由下面列表中选择系统中已有订单号："; }
            if (v == -1)//为-1时，是用来清空数据界面，选择订单号的
            {
                Edit = "Order";
                this.label1.Text = "由下面列表中选择系统中已有订单号：";
                this.button1.Text = "确定";
                this.Button_A.Visible = false;
                this.Button_M.Visible = false;
                this.Button_NoScheme.Visible = false;
            }
        }
        #endregion

        #region SelectScheme_Load
        /// <summary>
        /// 加载GRID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectScheme_Load(object sender, EventArgs e)
        {


            //设置隔行背景色
            this.exDataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.exDataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.exDataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;


            GetexDataGridview1();
            ChangeButtonStatus();
        }
        #endregion

        #region 加载GetexDataGridview1 显示所有款号
        /// <summary>
        /// 加载GetexDataGridview1 显示所有款号
        /// </summary>
        private void GetexDataGridview1()
        {
            #region 加载订单
            if (Edit == "Order")
            {
                //2019年9月17日 改为加载2019年9月开始的订单，老订单不显示。

                //string strsql = "SELECT distinct OM.id, OM.order_no,OM.order_qty, OM.order_date, OM.input_date, OM.style_no, OM.SchemeNo,OM.UPS_prun,CASE WHEN OM.SchemeNo<>'' THEN convert(nvarchar,sod.Eton_Line) ELSE '' END AS Eton_Line,SOM.memo FROM MES_order_master OM left join MES_station_operation_detail SOD on OM.SchemeNo=SOD.SchemeNo where input_date> '2019-08-31' ORDER BY input_date DESC";
                StringBuilder strsql = new StringBuilder();
                strsql.Clear();
                strsql.AppendLine(" SELECT distinct OM.id ");
                strsql.AppendLine(" 		,OM.order_no ");
                strsql.AppendLine(" 		,OM.order_qty ");
                strsql.AppendLine(" 		,OM.order_date ");
                strsql.AppendLine(" 		,OM.input_date ");
                strsql.AppendLine(" 		,OM.style_no ");
                strsql.AppendLine(" 		,OM.SchemeNo,OM.UPS_prun ");
                strsql.AppendLine(" 		,CASE WHEN OM.SchemeNo<>'' THEN convert(nvarchar,sod.Eton_Line) ELSE '' END AS Eton_Line ");
                strsql.AppendLine(" 		,SOM.memo ");
                strsql.AppendLine(" 		,SOM.SchemeDate ");
                strsql.AppendLine(" FROM MES_order_master OM  ");
                strsql.AppendLine(" 	left join MES_station_operation_detail SOD  ");
                strsql.AppendLine(" 	on OM.SchemeNo=SOD.SchemeNo  ");
                strsql.AppendLine(" 	left join MES_station_operation_master SOM ");
                strsql.AppendLine(" 	on OM.schemeNo=SOM.schemeNo  ");
                strsql.AppendLine(" where input_date> '2019-10-31'  ");
                strsql.AppendLine(" ORDER BY id DESC ");

                DataTable dt_Order = DBConn.DataAcess.SqlConn.Query(strsql.ToString()).Tables[0];
                if (this.exDataGridView1.Columns.Count == 0)
                {
                    this.exDataGridView1.AddColumn("id", "序号", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                    this.exDataGridView1.AddColumn("order_no", "订单号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("order_date", "订单日期", 80, true, null, DataGridViewContentAlignment.MiddleLeft, "yyyy-MM-dd", true);
                    this.exDataGridView1.AddColumn("input_date", "录入日期", 80, true, null, DataGridViewContentAlignment.MiddleLeft, "yyyy-MM-dd", true);
                    this.exDataGridView1.AddColumn("style_no", "款号", 70, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("order_qty", "数量", 60, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("SchemeNo", "方案号", 70, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("Eton_Line", "生产线编号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("UPS_prun", "吊挂订单号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("memo", "方案描述", 150, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("SchemeDate", "方案时间", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    // 实现列的锁定功能  
                    this.exDataGridView1.Columns[1].Frozen = true;
                }//加载所有款号
                exDataGridView1.DataSource = dt_Order;
            }
            #endregion
            this.exDataGridView1.MultiSelect = false;
            if (exDataGridView1.Rows.Count != 0)
            {
                exDataGridView1.CurrentCell = exDataGridView1.Rows[0].Cells["order_no"];
            }
            

        }
        #endregion

        #region 提交选择的款号/订单号/方案号
        /// <summary>
        ///  提交选择的款号/订单号/方案号
        /// </summary>
        /// <param name="v">0为自动匹配 1为手动匹配 2为不使用历史方案</param>
        private void CommitSchemeNum(int v)
        {
            if (v != 3)//v==2时，表示查看历史方案，不需要判断是否已经推送到生产线
            {
                if (exDataGridView1.CurrentRow.Cells["UPS_prun"].Value.ToString() != "")
                {
                    MessageBox.Show("已经推送到生产线的订单不可以做任何修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (v == 0)                
                {
                    #region 0为自动匹配
                    try
                    {
                        Order_Num = exDataGridView1.CurrentRow.Cells["order_no"].Value.ToString();
                        Style_Num = exDataGridView1.CurrentRow.Cells["style_no"].Value.ToString();
                        string strsql = "select [SchemeNo] from MES_order_master where order_no =(select TOP 1 border_no from (select a.order_no aorder_no,a.cont acont,b.order_no border_no, count(*) over (partition by b.order_no) as bcont from (select row_number() over(order by GST_xh) as LISTINDEX, count(*) over (partition by order_no) cont ,* from MES_order_detail_operation where order_no ='" + Order_Num + "'  ) a left join (select row_number() over( partition by order_no order by GST_xh) as LISTINDEX, count(*) over (partition by order_no) cont ,* from MES_order_detail_operation where order_no <>'" + Order_Num + "') b ON a.listindex=b.listindex and a.cont=b.cont and a.opcodealpha1=b.opcodealpha1 where b.OpCodeAlpha1 is not null ) aa where acont=bcont group by border_no) ";
                        DataTable dt_Scheme = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                        if (dt_Scheme.Rows.Count==0 || dt_Scheme.Rows[0]["SchemeNo"].ToString() == "")
                        {
                            Scheme_Num = "";
                            Line_Num = "";
                            MessageBox.Show("没有找到可用方案，请生成新方案或选择其他同款号的历史方案", "提示");
                            return;
                        }
                        else
                        {
                            Scheme_Num = dt_Scheme.Rows[0]["SchemeNo"].ToString();
                            string sch = exDataGridView1.CurrentRow.Cells["SchemeNo"].Value.ToString();
                            if (Scheme_Num == sch)
                            {
                                MessageBox.Show("已经是最佳方案", "提示");
                                return;
                            }
                            
                            string strsql2 = "SELECT TOP 1 [Eton_Line] FROM [mes].[dbo].[MES_station_operation_detail] WHERE SchemeNo='" + Scheme_Num + "' ";
                            DataTable dt_Line = DBConn.DataAcess.SqlConn.Query(strsql2).Tables[0];
                            if (dt_Line.Rows[0]["Eton_Line"].ToString() != "")
                            {
                                Line_Num = dt_Line.Rows[0][0].ToString();
                                string strsql3 = "SELECT memo, CASE WHEN CompleteState = 1 THEN '完整' ELSE '不完整' END AS CompleteState FROM MES_station_operation_master WHERE SchemeNo='" + Scheme_Num + "' ";
                                DataTable dt_SchemeState = DBConn.DataAcess.SqlConn.Query(strsql3).Tables[0];
                                string CompleteState = dt_SchemeState.Rows[0]["CompleteState"].ToString();
                                string memo = "";
                                if(dt_SchemeState.Rows[0]["memo"].ToString()=="")
                                {
                                    memo = "空";
                                }
                                else
                                {
                                    memo = dt_SchemeState.Rows[0]["memo"].ToString();
                                }
                                DialogResult key = MessageBox.Show("找到可用方案"+Scheme_Num+"("+ CompleteState + "方案,备注为:"+memo+", 生产线" + Line_Num + ") 是否应用到此订单? ", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (key == DialogResult.Yes)
                                {
                                    ArrayList SQLList = new ArrayList();
                                    SQLList.Add("UPDATE [dbo].[MES_order_master] SET [SchemeNo] = '" + Scheme_Num + "' WHERE order_no='" + Order_Num + "'");
                                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    Scheme_Num = "";
                                    Line_Num = "";
                                    return;
                                }
                            }
                            else { return; }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    #endregion
                }

                else if (v == 1)                
                {
                    #region 1为手动匹配
                    Order_Num = exDataGridView1.CurrentRow.Cells["order_no"].Value.ToString();
                    Style_Num = exDataGridView1.CurrentRow.Cells["style_no"].Value.ToString();

                    selectScheme f1 = new selectScheme(Style_Num);
                    f1.Owner = this;
                    f1.ShowDialog();
                    if (f1.DialogResult == DialogResult.OK)
                    {
                        ArrayList SQLList = new ArrayList();
                        SQLList.Add("UPDATE [dbo].[MES_order_master] SET [SchemeNo] = '" + Scheme_Num + "' WHERE order_no='" + Order_Num + "'");
                        DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (f1.DialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    #endregion
                }

                else if (v == 2)
                {
                    #region 不使用历史方案
                    Order_Num = exDataGridView1.CurrentRow.Cells["order_no"].Value.ToString();
                    Style_Num = exDataGridView1.CurrentRow.Cells["style_no"].Value.ToString();
                    Line_Num = "";
                    Scheme_Num = "";
                    this.DialogResult = DialogResult.OK;
                    #endregion
                }
            }
            
            else if (v == 3)            
            {
                #region 查看历史方案
                Order_Num = exDataGridView1.CurrentRow.Cells["order_no"].Value.ToString();
                Style_Num = exDataGridView1.CurrentRow.Cells["style_no"].Value.ToString();
                Line_Num = exDataGridView1.CurrentRow.Cells["Eton_Line"].Value.ToString();
                Scheme_Num = exDataGridView1.CurrentRow.Cells["SchemeNo"].Value.ToString();
                UPS_prun= exDataGridView1.CurrentRow.Cells["UPS_prun"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                #endregion
            }
        }
        #endregion

        #region 按钮：查找最佳方案
        /// <summary>
        /// 按钮：查找最佳方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CommitSchemeNum(0);//查找完全一样的方案
        }
        #endregion

        #region 按钮：手动匹配方案
        /// <summary>
        /// 按钮：手动匹配方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_M_Click(object sender, EventArgs e)
        {
            CommitSchemeNum(1);
        }
        #endregion

        #region 按钮：不使用历史方案
        private void Button_NoScheme_Click(object sender, EventArgs e)
        {
            CommitSchemeNum(2);
        }
        #endregion

        #region 按钮：查看/修改
        private void button1_Click_1(object sender, EventArgs e)
        {
            CommitSchemeNum(3);
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

        #region 改变按钮状态
        /// <summary>
        /// 改变按钮状态
        /// </summary>
        private void ChangeButtonStatus()
        {
            if (exDataGridView1.Rows.Count == 0)
            {
                this.Button_A.Enabled = false;
                this.Button_M.Enabled = false;
                this.Button_NoScheme.Enabled = false;
                this.Button_DelOrder.Enabled = false;
                this.Button_DelScheme.Enabled = false;
                this.button1.Enabled = false;
                this.button2.Enabled = true;
            }//如果系统中没有任何订单，除取消按钮外，其他均为不可用
            else if (exDataGridView1.CurrentRow.Cells["UPS_prun"].Value.ToString() != "")
            {
                this.Button_A.Enabled = false;
                this.Button_M.Enabled = false;
                this.Button_NoScheme.Enabled = false;
                this.Button_DelOrder.Enabled = false;
                this.Button_DelScheme.Enabled = false;
                this.button1.Enabled = true;
                this.button2.Enabled = true;
            }//如果已经推送到生产线的订单，不支持更改方案及重新推送,只能查看和取消
            else
            {
                if (exDataGridView1.CurrentRow.Cells["SchemeNo"].Value.ToString() != "")
                {
                    this.Button_A.Enabled = false;
                    this.Button_M.Enabled = true;
                    this.Button_NoScheme.Enabled = true;
                    this.Button_DelOrder.Enabled = true;
                    this.Button_DelScheme.Enabled = true;
                    this.button1.Enabled = true;
                    this.button2.Enabled = true;
                }
                else
                {
                    this.Button_A.Enabled = true;
                    this.Button_M.Enabled = true;
                    this.Button_NoScheme.Enabled = true;
                    this.Button_DelOrder.Enabled = true;
                    this.Button_DelScheme.Enabled = false;
                    if (Button_NoScheme.Visible == false)
                    { this.button1.Enabled = true; }
                    else { this.button1.Enabled = false; }
                    this.button2.Enabled = true;
                }
            }
        }
        #endregion

        #region 单击GexDataGridView1行 判断按钮状态
        private void exDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeButtonStatus();
        }

        #endregion

        #region 按钮：删除订单
        /// <summary>
        /// 按钮：删除订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            DeleteOrderInf(1);
            GetexDataGridview1();
            ChangeButtonStatus();
        }
        #endregion

        #region 删除订单或方案
        /// <summary>
        /// 删除订单或方案
        /// </summary>
        /// <param name="a">1删除订单 0删除订单对应的方案</param>
        private void DeleteOrderInf(int a)
        {
            Order_Num = exDataGridView1.CurrentRow.Cells["order_no"].Value.ToString();
            Scheme_Num = exDataGridView1.CurrentRow.Cells["SchemeNo"].Value.ToString();
            UPS_prun = exDataGridView1.CurrentRow.Cells["UPS_prun"].Value.ToString();
            ArrayList SQLList = new ArrayList();
                if (UPS_prun != "")
                {
                        MessageBox.Show("此订单已推送到生产线，不能修改和删除", "", MessageBoxButtons.OK, MessageBoxIcon.Question);                    
                        return;                   
                }
                
                if (a == 1)//1代表删除订单
                {
                    SQLList.Add("DELETE FROM [dbo].[MES_order_master] WHERE  order_no='" + Order_Num + "'");
                    SQLList.Add("DELETE FROM[dbo].[MES_order_detail_operation] WHERE  order_no='" + Order_Num + "'");
                    SQLList.Add("UPDATE MES_GetOrder  SET ToOrderMasterTable = 0 WHERE order_no ='" + Order_Num +"'");
            }
                else //0代表保留订单信息
                {
                    SQLList.Add("UPDATE MES_order_master SET SchemeNo=NULL,UPS_prun=NULL where order_no='" + Order_Num + "'");
                }

                DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                MessageBox.Show("完成", "提示");
            }
        #endregion

        #region 按钮：删除对应方案
        /// <summary>
        /// 按钮：删除对应方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_DelScheme_Click(object sender, EventArgs e)
        {
            DeleteOrderInf(0);
            GetexDataGridview1();
            ChangeButtonStatus();
        }
        #endregion
    }
}



