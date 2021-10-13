using MES.module.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.form.Scheme
{
    public partial class NewScheme : Form
    {
        public NewScheme()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();

        private void NewScheme_Load(object sender, EventArgs e)
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
                GetGrid(strCon);
            }
        }
        private void GetGrid(string strCon)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(strCon);
                conn.Open();

                //1 获取所有sheet页的名称，用于memo字段
                //2 sheet页为“款号$” 相同工序清单的款


                //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等
                DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
                //包含excel中表名的字符串数组
                //string[] strTableNames = new string[dtSheetName.Rows.Count];
                DataTable SchemeNoList = new DataTable();
                DataColumn dc = new DataColumn("SchemeNo");
                SchemeNoList.Columns.Add(dc);

                Application.DoEvents();
                
                OleDbDataAdapter myCommand = null;
                DataTable dt_款号 = new DataTable();
                //从指定的表明查询数据,可先把所有表名列出来供用户选择
                string strStyle = "select * from [款号$]";
                myCommand = new OleDbDataAdapter(strStyle, strCon);
                dt_款号 = new DataTable();
                myCommand.Fill(dt_款号);
                Grid_master.DataSource = dt_款号;

                //去掉EXCEL中读取到的名称为款号的sheet页
                for (int k = dtSheetName.Rows.Count-1; k >=0; k--)
                {
                    if (dtSheetName.Rows[k]["TABLE_NAME"].ToString() == "款号$")
                    {
                        dtSheetName.Rows.RemoveAt(k);
                    }
                }
                Grid_detail.DataSource = dtSheetName;



                //设置进度条
                int n = dtSheetName.Rows.Count * dt_款号.Rows.Count + 1;
                this.Enabled = false;
                MyContrals.WaitFormService.Show(this);
                MyContrals.WaitFormService.SetLeftText("lefttext");
                MyContrals.WaitFormService.SetProgressBarMax(n, "正在提交：");
                MyContrals.WaitFormService.SetRightText("righttext");
                MyContrals.WaitFormService.SetTopText("toptext");

                for (int i = dt_款号.Rows.Count-1; i>=0; i--)
                {
                    string Style_No = dt_款号.Rows[i][0].ToString();
                    for (int k = 0; k < dtSheetName.Rows.Count; k++)
                    {

                            string strCon_detail = "select * from [" + dtSheetName.Rows[k]["TABLE_NAME"].ToString() + "]";
                            OleDbCommand Cmd = new OleDbCommand(strCon_detail, conn);
                            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
                            string memo = dtSheetName.Rows[k]["TABLE_NAME"].ToString().Trim(new char[] { (char)39 });
                            da.Fill(ds, memo);

                            SchemeBll os = new SchemeBll();
                            int a = os.SaveScheme(Style_No, memo, ds.Tables[memo]);
                            if (a != 0)
                            {
                                //int a = 1;
                                DataRow newRow;
                                newRow = SchemeNoList.NewRow();
                                newRow["SchemeNo"] = a.ToString();
                                SchemeNoList.Rows.Add(newRow);
                                //Thread.Sleep(500);//睡眠500毫秒，也就是0.5秒                                
                            }
                        
                        MyContrals.WaitFormService.ProgressBarGrow();
                    }
                }
                MyContrals.WaitFormService.Close();
                MessageBox.Show("已全部完成，共导入" + dt_款号.Rows.Count + "个款号，共" + SchemeNoList.Rows.Count + "个方案");
                return;
                
            }
            catch (Exception ex)
            {
                MyContrals.WaitFormService.Close();
                MessageBox.Show(ex.Message);//捕捉异常  
                throw;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

              

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
