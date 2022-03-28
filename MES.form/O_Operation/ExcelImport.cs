using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
//using Microsoft.Office.Interop.Excel;
using System.Net;
using Newtonsoft.Json;

namespace MES.form.Operation
{
    public partial class ExcelImport : Form
    {
        public string Order_Num = "";
        public string Style_Num = "";
        public ExcelImport()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        private void ExcelImport_Load(object sender, EventArgs e)
        {

        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {





            ds.Tables.Clear();

            OpenFileDialog ofd = new OpenFileDialog();//首先根据打开文件对话框，选择要打开的文件

            ofd.Filter = "Excel表格|*.xlsx|Excel97-2003表格|*.xls|所有文件|*.*";//打开文件对话框筛选器，默认显示文件类型

            string strPath;//定义文件路径

            if (ofd.ShowDialog() == DialogResult.OK)

            {

                try

                {

                    strPath = ofd.FileName;

                    //string sss = ofd.SafeFileName;//获取文件名称

                    string fileType = System.IO.Path.GetExtension(strPath);//获取文件的后缀

                    string strCon = "";

                    if (fileType == ".xls")//如果为97-2003格式文件

                    {

                        strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";

                    }

                    else//如果为2007格式文件

                    {

                        strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strPath + ";Extended Properties='Excel 12.0;HDR=YES;IEMX=1'";

                    }

                    OleDbConnection conn = new OleDbConnection(strCon);

                    Application.DoEvents();



                    //插入主表

                    string strSql = "select * from [Sheet1$]";

                    OleDbCommand Cmd = new OleDbCommand(strSql, conn);

                    OleDbDataAdapter da = new OleDbDataAdapter(Cmd);



                    da.Fill(ds, "master");
                    if (ds.Tables[0].Rows.Count < 1)
                    {
                        MessageBox.Show("请在EXCEL-SHEET1写入工单信息！", "温馨提示", MessageBoxButtons.OK);
                        return;
                    }

                    if (ds.Tables[0].Rows.Count > 1)
                    {
                        MessageBox.Show("每次只支持导入一张工单！请修改EXCEL-SHEET1", "温馨提示", MessageBoxButtons.OK);
                        return;
                    }
                    if (CheckOrder() == false)
                    {
                        MessageBox.Show("已经存在的工单，请不要重复导入！", "温馨提示", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        string getordermodel= "http://172.16.1.34:9097/api/job_qty_Api/Get_Job_Qty?job_no=" + ds.Tables["master"].Rows[0]["工单号"].ToString().Trim();
                        
                        
                        GetJobModel m = DeserializeJsonToObject<GetJobModel>( HttpGetnew(getordermodel));

                        if (m.num == 0)
                        {
                            MessageBox.Show("没有找到对应的工单号，请核对后重试！", "温馨提示", MessageBoxButtons.OK);
                        }
                        else
                        {
                            ds.Tables["master"].Rows[0]["数量"] = m.num;
                            ds.Tables["master"].Rows[0]["款号"] = m.style;
                        }


                        //string GetQtystr = "http://172.16.1.34:9097/api/job_qty_Api/Get_Job_Qty?job_no=" + ds.Tables["master"].Rows[0]["工单号"].ToString().Trim();
                        //int Order_Qty = 0;
                        //if (HttpGet(GetQtystr) == 0)
                        //{
                        //    MessageBox.Show("没有找到对应的工单号，请核对后重试！", "温馨提示", MessageBoxButtons.OK);
                        //}
                        //else
                        //{
                        //    Order_Qty = HttpGet(GetQtystr);
                        //    ds.Tables["master"].Rows[0]["数量"] = Order_Qty;
                        //}

                        Grid_master.DataSource = ds.Tables[0];

                        Grid_master.AllowUserToAddRows = false;

                        Grid_master.AllowUserToDeleteRows = false;

                        //插入子表



                        string strSqlOrder = "select * from [Sheet2$]";

                        OleDbCommand CmdOrder = new OleDbCommand(strSqlOrder, conn);

                        OleDbDataAdapter daOrder = new OleDbDataAdapter(CmdOrder);

                        DataTable dt1 = new DataTable();
                        //daOrder.Fill(ds, "detail");
                        daOrder.Fill(dt1);

                        ds.Tables.Add(UpdateDataTable(dt1));



                        for (int p = ds.Tables["Table1"].Rows.Count - 1; p >= 0; p--)

                        {
                            if (ds.Tables["Table1"].Rows[p][0] is DBNull)
                                ds.Tables["Table1"].Rows[p].Delete();
                            else if (ds.Tables["Table1"].Rows[p][0].ToString().Trim() == "")
                                ds.Tables["Table1"].Rows[p].Delete();
                        }
                        ds.Tables["Table1"].AcceptChanges();





                        if (ds.Tables["Table1"].Rows.Count < 1)
                        {
                            MessageBox.Show("请在EXCEL-SHEET2写入工单信息！", "温馨提示", MessageBoxButtons.OK);
                            return;
                        }
                        if (CheckTablesOrder() == false)
                        {
                            MessageBox.Show("主子表订单不一致！", "温馨提示", MessageBoxButtons.OK);
                            return;
                        }
                        if (CheckOpration上架下架() == false)
                        {
                            MessageBox.Show("必须包含上架及下架工序，并且上架及下架工序都不可以超过1个", "温馨提示", MessageBoxButtons.OK);
                            return;
                        }
                        if (CheckOpration全质检() == false)
                        {
                            if (MessageBox.Show("导入的订单中没有全质检工序，是否继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                            {
                                return;
                            }
                        }

                        if (CheckTimeUnit() == false)
                        {

                            if (MessageBox.Show("时间单位将被强制转换为s(秒)！点击OK继续，Cancel取消", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                            {
                                return;
                            }
                            else
                            {
                                for (int i = 0; i < ds.Tables["Table1"].Rows.Count; i++)
                                {
                                    if (ds.Tables["Table1"].Rows[i]["标准工时"].ToString().Trim() == "" || ds.Tables["Table1"].Rows[i]["标准工时"] is DBNull)
                                    { ds.Tables["Table1"].Rows[i]["标准工时"] = 0; }
                                    ds.Tables["Table1"].Rows[i]["时间单位"] = "s";
                                }
                            }
                        }
                        if (CheckTablesBlankRow() == false)
                        {
                            MessageBox.Show("请检查是否有没有填写工序序号或工序代码的行", "温馨提示", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {

                            Grid_detail.DataSource = ds.Tables["Table1"];
                            Grid_detail.AllowUserToAddRows = false;
                            Grid_detail.AllowUserToDeleteRows = false;
                        }
                    }
                }
                //MessageBox.Show(sss);

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//捕捉异常                
                }
            }
        }
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

                rowNew["工序序号"] = row["工序序号"];
                //修改记录值
                //rowNew["工序代码"] = Convert.ToDateTime(row["RQ"]).ToString("yyyy-MM-dd").ToString();
                rowNew["工序代码"] = row["工序代码"];
                rowNew["工序简称"] = row["工序简称"];
                rowNew["工序描述"] = row["工序描述"];
                rowNew["单价"] = row["单价"];
                rowNew["时间单位"] = row["时间单位"];
                rowNew["常规工艺要求"] = row["常规工艺要求"];
                rowNew["款式工艺要求"] = row["款式工艺要求"];
                rowNew["工艺图路径"] = row["工艺图路径"];
                rowNew["标准工时"] = row["标准工时"];
                rowNew["机器ID"] = row["机器ID"];
                rowNew["机器描述"] = row["机器描述"];
                rowNew["工序等级"] = row["工序等级"];
                rowNew["生产部件"] = row["生产部件"];
                rowNew["GST工序代码"] = row["GST工序代码"];
                rowNew["工单号"] = row["工单号"];
                dtResultTemp.Rows.Add(rowNew);
            }
            dtResultTemp.DefaultView.Sort = "工序序号";
            dtResultTemp = dtResultTemp.DefaultView.ToTable();


            DataTable dtResult = new DataTable();
            dtResult = dtResultTemp.Clone();
            for (int i = 0; i < dtResultTemp.Rows.Count; i++)
            {
                if (dtResultTemp.Rows[i]["工序序号"].ToString() == "10000")
                {
                    dtResult.ImportRow(dtResultTemp.Rows[i]);
                }
            }
            for (int i = 0; i < dtResultTemp.Rows.Count; i++)
            {
                if (dtResultTemp.Rows[i]["工序序号"].ToString() != "10000" && dtResultTemp.Rows[i]["工序序号"].ToString() != "10000")
                {
                    dtResult.ImportRow(dtResultTemp.Rows[i]);
                }
            }
            return dtResult;
        }

        private bool CheckOrder()
        {
            string order_no = ds.Tables[0].Rows[0]["工单号"].ToString();
            string sqlcmd = "SELECT COUNT(order_no) AS Expr1 FROM MES_order_master WHERE order_no = '" + order_no + "'";
            int n = Convert.ToInt16(DBConn.DataAcess.SqlConn.GetSingle(sqlcmd));
            if (n > 0) { return false; }
            else { return true; }
        }
        private bool CheckTablesOrder()
        {
            bool B = true;
            for (int i = 0; i < ds.Tables["Table1"].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[0]["工单号"].ToString() != ds.Tables["Table1"].Rows[i]["工单号"].ToString())
                { B = false; }


            }
            return B;
        }

        /// <summary>
        /// 时间单位必须录入s
        /// </summary>
        /// <returns></returns>
        private bool CheckTimeUnit()
        {
            bool B = true;
            for (int i = 0; i < ds.Tables["Table1"].Rows.Count; i++)
            {
                if (ds.Tables["Table1"].Rows[i]["时间单位"].ToString().Trim().ToLower()!="s")
                { B = false; }
            }
            return B;
        }

        /// <summary>
        /// 检查有且并有一个上架/下架工序
        /// </summary>
        /// <returns></returns>
        private bool CheckOpration上架下架()
        {
            bool B = true;
            int shangjia = 0;
            int xiajia = 0;
            for (int i = 0; i < ds.Tables["Table1"].Rows.Count; i++)
            {
                if (ds.Tables["Table1"].Rows[i]["工序代码"].ToString().Trim() == "10000")
                {
                    shangjia = shangjia + 1;
                }
                if (ds.Tables["Table1"].Rows[i]["工序代码"].ToString().Trim() == "10001")
                {
                    xiajia = xiajia + 1;
                }
            }
            if (shangjia < 1 || shangjia > 1 || xiajia < 1 || xiajia >1)
            {
                B = false;
            }
            else { B = true; }
            return B;
        }

        /// <summary>
        /// 检查有且并有一个全质检工序
        /// </summary>
        /// <returns></returns>
        private bool CheckOpration全质检()
        {
            bool B = true;
            int quanzhijian = 0;
            for (int i = 0; i < ds.Tables["Table1"].Rows.Count; i++)
            {
                if (ds.Tables["Table1"].Rows[i]["工序代码"].ToString().Trim() == "2160")
                {
                    quanzhijian = quanzhijian + 1;
                }
            }
            if (quanzhijian < 1 || quanzhijian > 1 )
            {
                B = false;
            }
            else { B = true; }
            return B;
        }



        private bool CheckTablesBlankRow()
        {
            bool B = true;
            for (int i = 0; i < ds.Tables["Table1"].Rows.Count; i++)
            {

                if (ds.Tables["Table1"].Rows[i]["工序代码"].ToString().Trim() == "" || ds.Tables["Table1"].Rows[i]["工序序号"].ToString().Trim() == "")
                { B = false; }
            }
            return B;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region 使用SqlBulkCopy将DataTable中的数据批量插入数据库中
        /// <summary>
        /// 注意：DataTable中的列需要与数据库表中的列完全一致。
        /// 已自测可用。
        /// </summary>
        /// <param name="conStr">数据库连接串</param>
        /// <param name="strTableName">数据库中对应的表名</param>
        /// <param name="dtData">数据集</param>
        public static void SqlBulkCopyInsert(string conStr, string strTableName, System.Data.DataTable dtData)
        {
            try
            {
                using (SqlBulkCopy sqlRevdBulkCopy = new SqlBulkCopy(conStr))//引用SqlBulkCopy
                {
                    sqlRevdBulkCopy.DestinationTableName = strTableName;//数据库中对应的表名
                    if(strTableName == "[dbo].[MES_order_master]")
                    {
                        sqlRevdBulkCopy.ColumnMappings.Add("工单号", "order_no");
                        sqlRevdBulkCopy.ColumnMappings.Add("工单日期", "order_date");
                        //sqlRevdBulkCopy.ColumnMappings.Add("录入日期", "inputdate");改为取导入订单时系统时间
                        sqlRevdBulkCopy.ColumnMappings.Add("款号", "style_no");
                        sqlRevdBulkCopy.ColumnMappings.Add("数量", "order_qty");
                    }
                    if (strTableName == "[dbo].[MES_order_detail_operation]")
                    {
                        
                        sqlRevdBulkCopy.ColumnMappings.Add("工序序号", "GST_xh");
                        sqlRevdBulkCopy.ColumnMappings.Add("工序代码", "OpCodeAlpha1");
                        sqlRevdBulkCopy.ColumnMappings.Add("工序简称", "operation_addr");
                        sqlRevdBulkCopy.ColumnMappings.Add("工序描述", "operation_des");
                        sqlRevdBulkCopy.ColumnMappings.Add("单价", "price");
                        sqlRevdBulkCopy.ColumnMappings.Add("时间单位", "Time_unit");
                        sqlRevdBulkCopy.ColumnMappings.Add("常规工艺要求", "OpQualityRequirement");
                        sqlRevdBulkCopy.ColumnMappings.Add("款式工艺要求", "StyleQualityRequirement");
                        sqlRevdBulkCopy.ColumnMappings.Add("工艺图路径", "Technology_picture");
                        sqlRevdBulkCopy.ColumnMappings.Add("标准工时", "standard_time");
                        sqlRevdBulkCopy.ColumnMappings.Add("机器ID", "EQ_ID");
                        sqlRevdBulkCopy.ColumnMappings.Add("机器描述", "EQ_des");
                        sqlRevdBulkCopy.ColumnMappings.Add("工序等级", "GST_gxDJ");
                        sqlRevdBulkCopy.ColumnMappings.Add("生产部件", "GST_XCBJ");
                        sqlRevdBulkCopy.ColumnMappings.Add("GST工序代码", "GST_GZDM");
                        sqlRevdBulkCopy.ColumnMappings.Add("工单号", "order_no");
                    }

                    sqlRevdBulkCopy.NotifyAfter = dtData.Rows.Count;//有几行数据
                    sqlRevdBulkCopy.WriteToServer(dtData);//数据导入数据库


                    sqlRevdBulkCopy.Close();//关闭连接
                    
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        #endregion






        private void buttonOK_Click(object sender, EventArgs e)
        {


            if (Grid_master.Rows.Count < 1 || Grid_detail.Rows.Count < 1)
            {
                MessageBox.Show("数据不完整！请导入数据正确的工单和工序", "温馨提示", MessageBoxButtons.OK); return;
            }
           if (CheckOrder() == false) { MessageBox.Show("已经存在的工单，请不要重复导入！", "温馨提示", MessageBoxButtons.OK); return; }

            


            DialogResult key = MessageBox.Show("点击'确定'将生成新的订单 点击'取消'返回修改", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                
                try
                {


                    //SqlBulkCopyInsert(DBConn.DataAcess.SqlConn.connectionString, "[dbo].[Table_1]", ds.Tables[0]);
                   SqlBulkCopyInsert(DBConn.DataAcess.SqlConn.connectionString, "[dbo].[MES_order_master]", ds.Tables[0]);
                    //为子表排序
                    ArrayList SQLList = new ArrayList();


                    

                    SqlBulkCopyInsert(DBConn.DataAcess.SqlConn.connectionString, "[dbo].[MES_order_detail_operation]", ds.Tables["Table1"]);



                    SQLList.Add("UPDATE [dbo].[MES_order_detail_operation] SET [Time_unit] ='s' WHERE order_no = '" + ds.Tables[0].Rows[0]["工单号"].ToString().Trim() + "'");
                        SQLList.Add("UPDATE [dbo].[MES_order_master] SET order_date='20'+substring(order_no,2,2)+'-'+substring(order_no,4,2)+'-'+substring(order_no,6,2),[input_date] = '" + DateTime.Now.ToString() + "' WHERE [order_no] = '" + ds.Tables[0].Rows[0]["工单号"].ToString().Trim() + "'");
                    DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                    MessageBox.Show("完成！", "温馨提示", MessageBoxButtons.OK);
                        Order_Num = ds.Tables[0].Rows[0]["工单号"].ToString().Trim();
                        Style_Num = ds.Tables[0].Rows[0]["款号"].ToString().Trim();
                        this.DialogResult = DialogResult.OK;
                        this.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            else
            {
                return;
            }


            //try
            //{
            //    //定义一个ArrayList用来存储将要执行的SQL语句-写入order_master表
            //    ArrayList SQLList_master = new ArrayList();
            //    //定义一个ArrayList用来存储将要执行的SQL语句-写入order_detail表
            //    ArrayList SQLList_detail = new ArrayList();
            //    DialogResult key = MessageBox.Show("点击'确定'将生成新的订单 点击'取消'返回修改", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (key == DialogResult.Yes)
            //    {
            //        for (int i = 0; i < Grid_master.Rows.Count; i++)
            //        {
            //            SQLList_master.Add("");
            //        }
            //        for (int i = 0; i < Grid_detail.Rows.Count; i++)
            //        {
            //            SQLList_detail.Add("");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("发生错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
        }



        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"\\xx-file\信息部\ERP Folder\MesOrder.xlsx"))
            {
                if (File.Exists(@"D:\MesOrder.xlsx"))
                {
                    DialogResult keynn = MessageBox.Show("D盘根目录MesOrder.xlsx已存在，是否覆盖？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (keynn == DialogResult.OK)
                    {
                        File.Delete(@"D:\MesOrder.xlsx");
                        File.Copy(@"\\xx-file\信息部\ERP Folder\MesOrder.xlsx", @"D:\MesOrder.xlsx", true);
                        MessageBox.Show("文件下载成功！");
                    }
                    else { return; }
                }
                else

                {
                    File.Copy(@"\\xx-file\信息部\ERP Folder\MesOrder.xlsx", @"D:\MesOrder.xlsx", true);
                    MessageBox.Show("文件下载成功！");
                }

            }
            else
            {
                MessageBox.Show("需要下载的文件不存在，请联系信息部！");
            }

        }

        //private void button31_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = HttpGet("http://172.16.1.34:9097/api/job_qty_Api/Get_Job_Qty?job_no=Z191104-001");
        //}

        public static int HttpGet(string url)
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


                return int.Parse(reader.ReadToEnd());
            }
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

    }



}
