using System;
using System.Data;
using System.Windows.Forms;


using MES.module.BLL;

namespace MES.form.Operation
{
    public partial class Selectoptype : Form
    {
        public string op_type = "";
        public string op_type_Line_Num = "";
        public string op_type_Station = "";
        public string op_des = "";
        public string op_type_id = "";





        #region 初始化
        /// <summary>
        /// 
        /// </summary>
        /// <param name="l">生产线编号</param>
        public Selectoptype(string l)
        {
            op_type_Line_Num = l;
            InitializeComponent();
        }
        #endregion

        #region Selectoptype_Load
        /// <summary>
        /// 加载GRID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Selectoptype_Load(object sender, EventArgs e)
        {
            StationBll sb = new StationBll();
            GetexDataGridview1();

            comboBox1.DisplayMember = "Eton_WorkStation";//Combobox加载现有生产线
            comboBox1.DataSource = sb.get_Station(op_type_Line_Num);
        }
        #endregion

        #region 加载GetexDataGridview1 加载工序类型
        /// <summary>
        /// 加载GetexDataGridview1 加载工序类型
        /// </summary>
        private void GetexDataGridview1()
        {
            #region 加载工序类型

                string strsql = "SELECT id,op_type_id,op_type, op_des, UPS_type FROM MES_OPERTYPE where UPS_type ='01' and op_type<>2";
                DataTable dt_Order = DBConn.DataAcess.SqlConn.Query(strsql).Tables[0];
                if (this.exDataGridView1.Columns.Count == 0)
                {
                    this.exDataGridView1.AddColumn("id", "数据库序号", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.exDataGridView1.AddColumn("op_type_id", "工序序号", 130, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.exDataGridView1.AddColumn("op_type", "工序类型序号", 130, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("op_des", "工序类型描述", 150, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                    this.exDataGridView1.AddColumn("UPS_type", "吊挂线品牌", 70, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                    // 实现列的锁定功能  
                    this.exDataGridView1.Columns[2].Frozen = true;
                }//加载所有款号
                exDataGridView1.DataSource = dt_Order;
            
            #endregion
            this.exDataGridView1.MultiSelect = false;
        }
        #endregion

        #region 提交选择的款号/订单号/方案号
        /// <summary>
        /// 
        /// </summary>
        private void Commitoptype()
        {

            try
            {
                op_type = exDataGridView1.CurrentRow.Cells["op_type"].Value.ToString();
                op_type_Station = comboBox1.Text;
                op_des= exDataGridView1.CurrentRow.Cells["op_des"].Value.ToString();
                op_type_id = exDataGridView1.CurrentRow.Cells["op_type_id"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 双击行
        /// <summary>
        /// 双击行选中CHECKBOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Commitoptype();
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
            Commitoptype();
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

    }
}
