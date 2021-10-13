using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MES.module.BLL;

namespace MES.form.Scheme
{
    public partial class ExcellImport_Operation : txMainFormEnterTab
    {
        public ExcellImport_Operation()
        {
            InitializeComponent();
        }
        string Styleno = "";
        string Combination_no = "";
        string com_memo_no = "";
        string com_memo_name = "";
        int OplistNo = 0;
        private void ExcellImport_Operation_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="SingleOrMulti">导入1个还是多个</param>
        private void selectStyleItemOption()
        {
            CombinationSelect cs = new CombinationSelect();
            DialogResult f1 = cs.ShowDialog();
            if (f1 == DialogResult.OK)
            {
                    Styleno = cs.dt_Combination.Rows[0]["style_no"].ToString().Trim();
                    Combination_no = cs.dt_Combination.Rows[0]["Combination_no"].ToString().Trim();
                    com_memo_name = cs.dt_Combination.Rows[0]["memo_name"].ToString().Trim();
                    com_memo_no = cs.dt_Combination.Rows[0]["memo_no"].ToString().Trim();
                    lb_CombinationNo.Text = Combination_no;
                    lb_Combination_memo_name.Text = com_memo_name;
                    lb_Combination_memo_no.Text = com_memo_no;
                    lb_StyleNo.Text = Styleno;

            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectStyleItemOption();
        }
        DataSet ds = new DataSet();
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            OplistNo = 0;

            OpenFileDialog ofd = new OpenFileDialog();//首先根据打开文件对话框，选择要打开的文件
            ofd.Filter = "Excel表格|*.xlsx|Excel97-2003表格|*.xls|所有文件|*.*";//打开文件对话框筛选器，默认显示文件类型
            string strPath;//定义文件路径
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    strPath = ofd.FileName;
                    TextBox28.Text= ofd.FileName; ;
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

                    string strSqlOrder = "select * from [Sheet1$]";

                    OleDbCommand CmdOrder = new OleDbCommand(strSqlOrder, conn);
                    OleDbDataAdapter daOrder = new OleDbDataAdapter(CmdOrder);
                    DataTable dt1 = new DataTable();
                    daOrder.Fill(dt1);
                    ds.Tables.Add(dt1);
                    for (int p = ds.Tables[0].Rows.Count - 1; p >= 0; p--)
                    {
                        if (ds.Tables[0].Rows[p][0] is DBNull)
                            ds.Tables[0].Rows[p].Delete();
                        else if (ds.Tables[0].Rows[p][0].ToString().Trim() == "")
                            ds.Tables[0].Rows[p].Delete();
                    }
                    ds.Tables[0].AcceptChanges();
                    Grid_detail.DataSource = ds.Tables[0];
                    Grid_detail.AllowUserToAddRows = false;
                    Grid_detail.AllowUserToDeleteRows = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//捕捉异常 
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Styleno == ""|| Combination_no=="")
            {
                return;
            }
            try
            {
                OperationBLL ob = new OperationBLL();
                OplistNo = ob.NewOperationList(Convert.ToInt32(Combination_no), com_memo_no, Grid_detail);

                if (OplistNo  == 0)
                {
                    MessageBox.Show("发生错误");

                }
                else
                {

                    string s = ob.OperationToCaobo(OplistNo);
                    if (s == "1")
                    {
                        MessageBox.Show("完成");
                        ds.Tables.Clear();

                    }
                    else
                    {
                        MessageBox.Show("推送至生产线PAD错误："+s);

                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//捕捉异常    

            }
        }


 

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
