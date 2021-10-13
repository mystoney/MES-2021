using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MES.module.BLL;

namespace MES.form.Operation
{

    public partial class NewOrder : Form
    {
        
        public string Style_Num="";
        public int order_qty=0;
        public string Order_Num = "";
        public string Scheme_Num = "";
        public string Line_Num = "";

        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            GetComboBoxOrderList();
            GetexDataGridview1(0);
        }

        #region 加载combolist
        private void GetComboBoxOrderList()
        {
            int StageProductNum = 1;
            if (RB_Product.Checked == true)
            {
                StageProductNum = 1;
            }
            else
            {
                StageProductNum = 0;
            }
            OrderBll ob = new OrderBll();
            DataTable dt_OrderList = new DataTable();
            dt_OrderList=ob.GetOrderList(StageProductNum);
            dt_OrderList.Rows.Add();
            dt_OrderList.DefaultView.Sort = "order_no";
            ComboBoxOrderList.DataSource = dt_OrderList;
            ComboBoxOrderList.DisplayMember = "order_no";
            ComboBoxOrderList.ValueMember = "style_no";
         }
        #endregion

        #region 加载GetexDataGridview1 显示工单款号对应的所有方案
        /// <summary>
        /// 加载GetexDataGridview1 显示工单款号对应的所有方案
        /// </summary>
        /// <param name="i">0是手输工单号 1是选择工单号</param>
        private void GetexDataGridview1(int i)
        {
                //if (LBOrderstatus.Text == "合法工单")
                //{
                    #region 加载方案
                    StringBuilder cmd = new StringBuilder();
                    cmd.Clear();
                    cmd.AppendLine("   select distinct MES_station_operation_master.id ");
                    cmd.AppendLine(" 		,MES_station_operation_master.SchemeNo ");
                    cmd.AppendLine(" 		,MES_station_operation_master.memo ");
                    cmd.AppendLine(" 		,MES_station_operation_master.SchemeDate ");
                    cmd.AppendLine(" 		,MES_station_operation_master.Style_No ");
                    cmd.AppendLine(" 		,convert(nvarchar,MES_station_operation_detail.Eton_Line) AS Eton_Line ");
                    cmd.AppendLine("   from MES_station_operation_master ");
                    cmd.AppendLine(" 		left join MES_station_operation_detail ");
                    cmd.AppendLine(" 		on MES_station_operation_master.SchemeNo=MES_station_operation_detail.SchemeNo ");
                    cmd.AppendLine("   where CompleteState=1 and MES_station_operation_master.Style_No='" + Style_Num + "'  ");
                    cmd.AppendLine("   order by MES_station_operation_master.id desc ");

                    DataTable dt_Scheme = DBConn.DataAcess.SqlConn.Query(cmd.ToString()).Tables[0];
                    if (this.exDataGridView1.Columns.Count == 0)
                    {
                        this.exDataGridView1.AddColumn("id", "序号", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                        this.exDataGridView1.AddColumn("SchemeNo", "方案号", 70, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                        this.exDataGridView1.AddColumn("memo", "方案描述", 150, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                        this.exDataGridView1.AddColumn("Eton_Line", "生产线编号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                        this.exDataGridView1.AddColumn("Style_No", "款号", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                        this.exDataGridView1.AddColumn("SchemeDate", "方案时间", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                        // 实现列的锁定功能  
                        this.exDataGridView1.Columns[1].Frozen = true;
                    }//加载所有款号
                    exDataGridView1.DataSource = dt_Scheme;
                    #endregion
                //}
                //else
                //{
                //    DataTable dt = (DataTable)exDataGridView1.DataSource;
                //    exDataGridView1.DataSource = dt; ;
                //}

                if (exDataGridView1.Rows.Count != 0)
                {
                    this.exDataGridView1.MultiSelect = false;
                    exDataGridView1.CurrentCell = exDataGridView1.Rows[0].Cells["SchemeNo"];
                }
            
        }
        #endregion

        #region 解析JSON字符串生成对象实体
        /// <summary>
        /// 解析JSON字符串生成对象实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串(eg.{"ID":"112","Name":"石子儿"})</param>
        /// <returns>对象实体</returns>
        public static T DeserializeJsonToObject<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(@json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            T t = o as T;
            return t;
        }
        #endregion

        #region 按钮：提交订单及方案信息
        private void button1_Click(object sender, EventArgs e)
        {
            if (Order_Num == "")
            {
                MessageBox.Show("请检查工单信息！", "提示");
                return;
            }

            if (LBOrderstatus.ForeColor != Color.Green)
            { 
                MessageBox.Show("请检查工单信息！", "提示");
                return; 
            }
            else if (exDataGridView1.Rows.Count == 0) 
            { 
                MessageBox.Show("没有可用方案！", "提示"); 
                return; 
            }
            Scheme_Num = exDataGridView1.CurrentRow.Cells["SchemeNo"].Value.ToString();
            Line_Num = exDataGridView1.CurrentRow.Cells["Eton_Line"].Value.ToString();
            if (MessageBox.Show("新订单将被指定使用'" + Scheme_Num + "方案，确认吗？'", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            else 
            {
                OrderBll ob = new OrderBll();
                if (ob.SaveOrder( Order_Num, Scheme_Num, order_qty) == 1)
                { 
                    MessageBox.Show("完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        #endregion

        #region 按钮：取消
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region RadioButton 选择测试订单/正式订单
        private void RB_Stage_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Stage.Checked == true)
            {
                GetComboBoxOrderList();
            }
        }

        private void RB_Product_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Product.Checked == true)
            {
                GetComboBoxOrderList();
            }
        }
        #endregion

        #region 敬元接口
        private void GetOrderInfo(string OrderNo)
        {
            OrderBll ob = new OrderBll();
            if (ob.OrderBeAllowed(OrderNo) == false)
            {
                Order_Num = "";
                Lb_StyleNum.Text = "";
                Lb_OrderNum.Text = "";
                LBOrderstatus.Text = "请检查工单号";
                LBOrderstatus.ForeColor = Color.Red;
                MessageBox.Show("已存在的工单号，请核对后重试！", "温馨提示", MessageBoxButtons.OK);
                return;
            }
            string getordermodel = "http://172.16.1.34:9097/api/job_qty_Api/Get_Job_Qty?job_no=" + OrderNo;
            GetJobModel m = DeserializeJsonToObject<GetJobModel>(HttpGetnew(getordermodel));
            if (m.num == 0)
            {
                Order_Num = "";
                Lb_StyleNum.Text = "";
                Lb_OrderNum.Text = "";
                LBOrderstatus.Text = "请检查工单号";
                LBOrderstatus.ForeColor = Color.Red;
                MessageBox.Show("没有找到对应的工单号，请核对后重试！", "温馨提示", MessageBoxButtons.OK);
            }
            else
            {
                
                Style_Num = m.style;
                order_qty = m.num;
                Lb_StyleNum.Text = m.style;
                Lb_OrderNum.Text = m.num.ToString().Trim();
                LBOrderstatus.Text = "合法工单";
                LBOrderstatus.ForeColor = Color.Green;
            }
        }
        public class GetJobModel
        {
            #region 字段信息

            /// <summary>
            /// 款号
            /// </summary>
            public string style { get; set; }

            /// <summary>
            /// 尺码
            /// </summary>
            public int num { get; set; }

            #endregion
        }
        public static string HttpGetnew(string url)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
        #endregion

        #region 按钮：输入订单号 检查订单信息
        private void button3_Click(object sender, EventArgs e)
        {
            if (TBOrderNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入工单号", "温馨提示", MessageBoxButtons.OK);
                return;
            }
            Order_Num = TBOrderNo.Text.Trim();
            GetOrderInfo(Order_Num);
            GetexDataGridview1(0);
        }
        #endregion

        #region 按钮：选择订单号 检查订单信息
        private void bt_GetScheme_Click(object sender, EventArgs e)
        {
            if (ComboBoxOrderList.Text.Trim() == "")
            {
                MessageBox.Show("请选择工单号", "温馨提示", MessageBoxButtons.OK);
                return;
            }
            Order_Num = ComboBoxOrderList.Text.Trim();
            GetOrderInfo(Order_Num);
            GetexDataGridview1(0);
        }
        #endregion

        private void exDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ComboBoxOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LBOrderstatus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lb_OrderNum_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Lb_StyleNum_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TBOrderNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }



}

