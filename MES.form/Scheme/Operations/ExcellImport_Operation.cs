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

                    DataColumn dc_OperationNo = new DataColumn();
                    dc_OperationNo.ColumnName = "OperationNo";

                    Helper.Excel.ExcelHelper excelHelper = new Helper.Excel.ExcelHelper(ofd.FileName);
                    ds = excelHelper.exceltoDataSet();
                    ds.Tables[0].Columns.Add(dc_OperationNo);
                    OperationBLL ob = new OperationBLL();
                    Int64 MaxOperationNo = ob.GetMaxOperationNo();
                    for (int p = ds.Tables[0].Rows.Count - 1; p >= 0; p--)
                    {
                        string OperationNo = string.Format("{0:d10}", MaxOperationNo);
                        ds.Tables[0].Rows[p]["OperationNo"] = "OP" + ds.Tables[0].Rows[p]["OperationType"].ToString().Trim() + OperationNo;
                        if (ds.Tables[0].Rows[p][0] is DBNull)
                            ds.Tables[0].Rows[p].Delete();
                        else if (ds.Tables[0].Rows[p][0].ToString().Trim() == "")
                            ds.Tables[0].Rows[p].Delete();
                        MaxOperationNo = MaxOperationNo + 1;
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
                    string s_ToCaobo = ob.OperationToCaobo(OplistNo);
                    string s_ToJingYuan = ob.OperationToJingYuan(OplistNo);
                    if (s_ToCaobo == "1" && s_ToJingYuan == "1")
                    {
                        MessageBox.Show("完成");
                        ds.Tables.Clear();

                    }
                    else if (s_ToCaobo == "1")
                    {
                        MessageBox.Show("推送至JingYuan错误：" + s_ToJingYuan);

                    }
                    else if (s_ToJingYuan == "1")
                    {
                        MessageBox.Show("推送至生产线PAD错误：" + s_ToCaobo);

                    }
                    else
                    {
                        MessageBox.Show("推送错误,请联系管理员：" + s_ToCaobo+ " "+ s_ToJingYuan);
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
