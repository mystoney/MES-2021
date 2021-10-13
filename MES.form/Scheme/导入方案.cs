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
    public partial class 导入方案 : Form
    {
        public 导入方案()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();

        private void 导入方案_Load(object sender, EventArgs e)
        {

        }


        private void buttonDownload_Click_1(object sender, EventArgs e)
        {
         
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {





            //ds.Tables.Clear();

            //OpenFileDialog ofd = new OpenFileDialog();//首先根据打开文件对话框，选择要打开的文件

            //ofd.Filter = "Excel表格|*.xlsx|Excel97-2003表格|*.xls|所有文件|*.*";//打开文件对话框筛选器，默认显示文件类型

            //string strPath;//定义文件路径

            //if (ofd.ShowDialog() == DialogResult.OK)

            //{

            //    try

            //    {

            //        strPath = ofd.FileName;

            //        //string sss = ofd.SafeFileName;//获取文件名称

            //        string fileType = System.IO.Path.GetExtension(strPath);//获取文件的后缀

            //        string strCon = "";

            //        if (fileType == ".xls")//如果为97-2003格式文件

            //        {

            //            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";

            //        }

            //        else//如果为2007格式文件

            //        {

            //            strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strPath + ";Extended Properties='Excel 12.0;HDR=YES;IEMX=1'";

            //        }

            //        OleDbConnection conn = new OleDbConnection(strCon);

            //        Application.DoEvents();



            //        //插入主表

            //        string strSql = "select * from [Sheet1$]";

            //        OleDbCommand Cmd = new OleDbCommand(strSql, conn);

            //        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);



            //        da.Fill(ds, "master");
            //        if (ds.Tables[0].Rows.Count < 1)
            //        {
            //            MessageBox.Show("请在EXCEL-SHEET1写入工单信息！", "温馨提示", MessageBoxButtons.OK);
            //            return;
            //        }

            //        if (ds.Tables[0].Rows.Count > 1)
            //        {
            //            MessageBox.Show("每次只支持导入一张工单！请修改EXCEL-SHEET1", "温馨提示", MessageBoxButtons.OK);
            //            return;
            //        }
            //        if (CheckOrder() == false)
            //        {
            //            MessageBox.Show("已经存在的工单，请不要重复导入！", "温馨提示", MessageBoxButtons.OK);
            //            return;
            //        }
            //        else
            //        {
            //            string getordermodel = "http://172.16.1.34:9097/api/job_qty_Api/Get_Job_Qty?job_no=" + ds.Tables["master"].Rows[0]["工单号"].ToString().Trim();


            //            GetJobModel m = DeserializeJsonToObject<GetJobModel>(HttpGetnew(getordermodel));

            //            if (m.num == 0)
            //            {
            //                MessageBox.Show("没有找到对应的工单号，请核对后重试！", "温馨提示", MessageBoxButtons.OK);
            //            }
            //            else
            //            {
            //                ds.Tables["master"].Rows[0]["数量"] = m.num;
            //                ds.Tables["master"].Rows[0]["款号"] = m.style;
            //            }


            //            //string GetQtystr = "http://172.16.1.34:9097/api/job_qty_Api/Get_Job_Qty?job_no=" + ds.Tables["master"].Rows[0]["工单号"].ToString().Trim();
            //            //int Order_Qty = 0;
            //            //if (HttpGet(GetQtystr) == 0)
            //            //{
            //            //    MessageBox.Show("没有找到对应的工单号，请核对后重试！", "温馨提示", MessageBoxButtons.OK);
            //            //}
            //            //else
            //            //{
            //            //    Order_Qty = HttpGet(GetQtystr);
            //            //    ds.Tables["master"].Rows[0]["数量"] = Order_Qty;
            //            //}

            //            Grid_master.DataSource = ds.Tables[0];

            //            Grid_master.AllowUserToAddRows = false;

            //            Grid_master.AllowUserToDeleteRows = false;

            //            //插入子表



            //            string strSqlOrder = "select * from [Sheet2$]";

            //            OleDbCommand CmdOrder = new OleDbCommand(strSqlOrder, conn);

            //            OleDbDataAdapter daOrder = new OleDbDataAdapter(CmdOrder);

            //            DataTable dt1 = new DataTable();
            //            //daOrder.Fill(ds, "detail");
            //            daOrder.Fill(dt1);

            //            ds.Tables.Add(UpdateDataTable(dt1));



            //            for (int p = ds.Tables["Table1"].Rows.Count - 1; p >= 0; p--)

            //            {
            //                if (ds.Tables["Table1"].Rows[p][0] is DBNull)
            //                    ds.Tables["Table1"].Rows[p].Delete();
            //                else if (ds.Tables["Table1"].Rows[p][0].ToString().Trim() == "")
            //                    ds.Tables["Table1"].Rows[p].Delete();
            //            }
            //            ds.Tables["Table1"].AcceptChanges();





            //            if (ds.Tables["Table1"].Rows.Count < 1)
            //            {
            //                MessageBox.Show("请在EXCEL-SHEET2写入工单信息！", "温馨提示", MessageBoxButtons.OK);
            //                return;
            //            }
            //            if (CheckTablesOrder() == false)
            //            {
            //                MessageBox.Show("主子表订单不一致！", "温馨提示", MessageBoxButtons.OK);
            //                return;
            //            }
            //            if (CheckOpration上架下架() == false)
            //            {
            //                MessageBox.Show("必须包含上架及下架工序，并且上架及下架工序都不可以超过1个", "温馨提示", MessageBoxButtons.OK);
            //                return;
            //            }
            //            if (CheckOpration全质检() == false)
            //            {
            //                if (MessageBox.Show("导入的订单中没有全质检工序，是否继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //                {
            //                    return;
            //                }
            //            }

            //            if (CheckTimeUnit() == false)
            //            {

            //                if (MessageBox.Show("时间单位将被强制转换为s(秒)！点击OK继续，Cancel取消", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //                {
            //                    return;
            //                }
            //                else
            //                {
            //                    for (int i = 0; i < ds.Tables["Table1"].Rows.Count; i++)
            //                    {
            //                        if (ds.Tables["Table1"].Rows[i]["标准工时"].ToString().Trim() == "" || ds.Tables["Table1"].Rows[i]["标准工时"] is DBNull)
            //                        { ds.Tables["Table1"].Rows[i]["标准工时"] = 0; }
            //                        ds.Tables["Table1"].Rows[i]["时间单位"] = "s";
            //                    }
            //                }
            //            }
            //            if (CheckTablesBlankRow() == false)
            //            {
            //                MessageBox.Show("请检查是否有没有填写工序序号或工序代码的行", "温馨提示", MessageBoxButtons.OK);
            //                return;
            //            }
            //            else
            //            {

            //                Grid_detail.DataSource = ds.Tables["Table1"];
            //                Grid_detail.AllowUserToAddRows = false;
            //                Grid_detail.AllowUserToDeleteRows = false;
            //            }
            //        }
            //    }
            //    //MessageBox.Show(sss);

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);//捕捉异常                
            //    }
            //}
        }


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

        private void buttonDownload_Click(object sender, EventArgs e)
        {

        }
    }
}

