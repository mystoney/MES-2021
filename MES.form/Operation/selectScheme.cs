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

namespace MES.form.Operation
{
    public partial class selectScheme : Form
    {

        #region 窗体被调用
        public selectScheme():this(null)  
        {
            //*
            //* 
            //*----------Dragon be here!----------/ 
            //* 　　　┏┓　　　┏┓ 
            //* 　　┏┛┻━━━┛┻┓ 
            //* 　　┃　　　　　　　┃ 
            //* 　　┃　　　━　　　┃ 
            //* 　　┃　┳┛　┗┳　┃ 
            //* 　　┃　　　　　　　┃ 
            //* 　　┃　　　┻　　　┃ 
            //* 　　┃　　　　　　　┃ 
            //* 　　┗━┓　　　┏━┛ 
            //* 　　　　┃　　　┃神兽保佑 
            //* 　　　　┃　　　┃代码无BUG！ 
            //* 　　　　┃　　　┗━━━┓ 
            //* 　　　　┃　　　　　　　┣┓ 
            //* 　　　　┃　　　　　　　┏┛ 
            //* 　　　　┗┓┓┏━┳┓┏┛ 
            //* 　　　　　┃┫┫　┃┫┫ 
            //* 　　　　　┗┻┛　┗┻┛ 
            //* ━━━━━━神兽出没━━━━━━by:coder-pig 
            //*

        }
        #endregion
        string Style_Num = "";
        string Scheme_Num = "";

        #region 初始化
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StyleNum"></param>
        public selectScheme(String StyleNum)
        {
            InitializeComponent();
            Style_Num = StyleNum;
        }
        #endregion

        #region selectSchmem_Load
        /// <summary>
        /// 加载GRID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectSchmem_Load(object sender, EventArgs e)
        {
            GetexDataGridview1();
            if (exDataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("此订单对应的款号还没有过任何排产方案,单击确定建立新方案", "提示");
                ((SelectOrder)this.Owner).Scheme_Num = "";
                ((SelectOrder)this.Owner).Line_Num = "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }       
         }
        #endregion

        #region 加载GetexDataGridview1 显示所有款号
        /// <summary>
        /// 加载GetexDataGridview1 显示所有款号
        /// </summary>
        private void GetexDataGridview1()
        {
            //加载所有款号
            string strsql = "SELECT id, style_no, SchemeDate, SchemeNo, memo, CASE WHEN state = 1 THEN '是' ELSE ' ' END AS state, CASE WHEN CompleteState = 1 THEN '完整' ELSE '不完整' END AS CompleteState FROM MES_station_operation_master WHERE SchemeDate > '2019-09-17 00:00:00' and style_no = '" + Style_Num + "' ORDER BY CompleteState DESC ,state DESC, SchemeDate DESC";
            //2019.9.16 为测试无款号：string strsql = "SELECT id, style_no, SchemeDate, SchemeNo, memo, CASE WHEN state = 1 THEN '是' ELSE ' ' END AS state, CASE WHEN CompleteState = 1 THEN '完整' ELSE '不完整' END AS CompleteState FROM MES_station_operation_master ORDER BY CompleteState DESC ,state DESC, SchemeDate DESC";
            DataTable dt_Schmem = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
            
            if (this.exDataGridView1.Columns.Count == 0)
            {
                this.exDataGridView1.AddColumn("id", "id", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.exDataGridView1.AddColumn("style_no", "款号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.exDataGridView1.AddColumn("SchemeNo", "方案号", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.exDataGridView1.AddColumn("SchemeDate", "方案日期", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.exDataGridView1.AddColumn("state", "默认方案", 80, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.exDataGridView1.AddColumn("memo", "备注", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.exDataGridView1.AddColumn("CompleteState", "是否完整方案", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.exDataGridView1.Columns[0].Frozen = true;
            }

            exDataGridView1.DataSource = dt_Schmem;
            this.exDataGridView1.MultiSelect = false;
        }
        #endregion

        #region 提交选择的方案号
        /// <summary>
        /// 
        /// </summary>
        private void CommitSchmemNum()
        {
            //选择款号后，弹出选择订单窗体，显示该款号对应的多个订单供用户选择
            try
            {
                Scheme_Num = exDataGridView1.CurrentRow.Cells["SchemeNo"].Value.ToString();
               ( (SelectOrder)this.Owner).Scheme_Num = Scheme_Num.ToString();
                string strsql2 = "SELECT TOP 1 [Eton_Line] FROM [mes].[dbo].[MES_station_operation_detail] WHERE SchemeNo='" + Scheme_Num + "' ";
                DataTable dt_Line = DBConn.DataAcess.SqlConn.Query(strsql2).Tables[0];
                ((SelectOrder)this.Owner).Line_Num = dt_Line.Rows[0]["Eton_Line"].ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 双击行选中CHECKBOX
        /// <summary>
        /// 双击行选中CHECKBOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommitSchmemNum();
        }
        #endregion

        #region 按钮：确定
        /// <summary>
        /// 按钮：确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CommitSchmemNum(); //传入值为0 表示通过确定按钮调用
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
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
