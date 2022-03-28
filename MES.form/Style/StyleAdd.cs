using MyContrals;
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
using Helper;
using MES.module.BLL;
using MES.module.BLL.StyleFromZYQ;
using static MES.module.BLL.StyleBll;

namespace MES.form.Style
{
    public partial class StyleAdd : Form
    {
        public StyleAdd()
        {
            InitializeComponent();
        }
        //获取到的选项表 FromZYQ   
        DataTable dt_StyleItem = new DataTable();

        //选择后需要写入数据库的选项表 显示
        DataTable dt_StyleItemFinal = new DataTable();
        DataSet ItemCombination = new DataSet();
        private void StyleAdd_Load(object sender, EventArgs e)
        {
            //设置隔行背景色
            this.GridOptionItem.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridOptionItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridOptionItem.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

            this.GridCombination.RowsDefaultCellStyle.BackColor = Color.White;
            this.GridCombination.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.GridCombination.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

            dt_StyleItemFinal.Columns.Add("style_no", typeof(string));
            dt_StyleItemFinal.Columns.Add("Item_No", typeof(string));
            dt_StyleItemFinal.Columns.Add("Item_Name", typeof(string));
            dt_StyleItemFinal.Columns.Add("Option_No", typeof(int));
            dt_StyleItemFinal.Columns.Add("Option_Name", typeof(string));
            dt_StyleItemFinal.DefaultView.Sort = "Item_No ASC,Option_No ASC";
        }


        private void GetGrid(String StyleNo)
        {
            if (tb_StyleList.Items.Count==0) { return; }
            DataRowView dr_Style = (DataRowView)tb_StyleList.Items[tb_StyleList.SelectedIndex];
            StyleBll sb = new StyleBll();

            dt_StyleItemFinal = sb.Style_KeyOptionAll(dr_Style.Row["Style_No"].ToString());

            GridOptionItem.DataSource = dt_StyleItemFinal; 

            if (this.GridOptionItem.Columns.Count == 0)
            {
                this.GridOptionItem.AddColumn("style_no", "款号", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null,true);
                this.GridOptionItem.AddColumn("Item_No", "选项", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOptionItem.AddColumn("Item_Name", "选项说明", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOptionItem.AddColumn("Option_No", "选项值", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridOptionItem.AddColumn("Option_Name", "选项值说明", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                this.GridOptionItem.Columns[1].Frozen = true;// 实现列的锁定功能 
                //禁止用户改变DataGridView1所有行的行高
                GridOptionItem.AllowUserToResizeRows = false;

            }
        }

        private void GetGridCombination()
        {

            if (dt_StyleItemFinal.Rows.Count == 0)
            {
                ItemCombination.Clear(); 
                return; 
            
            }
            //if (tb_StyleList.Items.Count == 0 || tb_StyleList.Text.Trim() == "")
            //{
            //    return;
            //}


            

            StyleBll sb = new StyleBll();
            
            ItemCombination=sb.GetItemCombination(dt_StyleItemFinal);

            if (this.GridCombination.Columns.Count == 0)
            {
                this.GridCombination.AddColumn("style_no", "款号", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCombination.AddColumn("Combination_no", "组合", 40, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCombination.AddColumn("memo_no", "Item&Option", 400, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCombination.AddColumn("memo_name", "选项说明", 400, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                this.GridCombination.Columns[1].Frozen = true;// 实现列的锁定功能 
                //禁止用户改变DataGridView1所有行的行高
                GridCombination.AllowUserToResizeRows = false;

            }
            GridCombination.DataSource = ItemCombination.Tables["dt_ItemCombination_master"];
        }


        #region 按钮-获取ZYQ提供的款号选项表+加载款号
        /// <summary>
        /// 获取ZYQ提供的款号选项表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

                StyleBll sb = new StyleBll();
                dt_StyleItem = sb.GetStyleListFormZYQ();             
                GetStyleList();


        }
        #endregion

        #region  加载款号
        /// <summary>
        /// 加载款号
        /// </summary>
        private void GetStyleList()
        {
            DataTable dtStyle = new DataTable();
            if (dt_StyleItem.Rows.Count > 0)
            {
                DataView dataview = dt_StyleItem.DefaultView;
                dtStyle = dataview.ToTable(true, "style_no");
                DataRow dr = dtStyle.NewRow();
                dtStyle.Rows.InsertAt(dr, 0);
                tb_StyleList.DataSource = dtStyle;
                tb_StyleList.DisplayMember = "style_no";
            }
        }
        #endregion

        #region 按钮-加载选项
        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_StyleList.Text.Trim() != "")
            {
                GetItemList(tb_StyleList.Text.Trim());
            }
            GetGrid(tb_StyleList.Text.Trim());
            GetGridCombination();

        }
        #endregion

        #region 加载选项
        /// <summary>
        /// 加载选项
        /// </summary>
        /// <param name="StyleNo">款号</param>
        private void GetItemList(string StyleNo)
        {
            DataTable dtItem = new DataTable();
            //DataTable dtItem1 = new DataTable();
            //筛选到指定款号的列
            //dtItem = dt_StyleItem.AsEnumerable()
            //   .GroupBy(r => new { Col1 = r["Item_No"], Col2 = r["Item_Name"] })
            //  .Select(g => g.OrderBy(r => r["Style_No"]).First()).Where(r => r["Style_No"].ToString() == StyleNo)
            //  .CopyToDataTable();

            var aa = dt_StyleItem.AsEnumerable()
                .Where(r => r["Style_No"].ToString() == StyleNo)
                .GroupBy(r => new { Item_No = r["Item_No"], Item_Name = r["Item_Name"] })
                .Select(a => new { a.Key.Item_Name, a.Key.Item_No })
                .ToList();

            string ss1= Helper.Json.JsonHelper.SerializeObject(aa);

            dtItem = Helper.Json.JsonHelper.DeserializeJsonToObject<DataTable>(ss1);

            //DataRow[] drs = dtItem1.Select();
            //dtItem = dt_StyleItem.Clone(); //克隆结构
            //drs.ToList<DataRow>().ForEach((r) => dtItem.ImportRow(r));

            if (dtItem.Rows.Count > 0)
            {
                //DataRow[] drs = dtItem.Select("style_no = '" + StyleNo + "'");
                //if (null != drs)
                //{
                //    dtItem1 = drs.CopyToDataTable();
                //    DataView dataview = dtItem1.DefaultView;
                //    dtItem = dataview.ToTable();            
                //    DataRow dr = dtItem.NewRow();
                //    dtItem.Rows.InsertAt(dr, 0);
                tb_ItemList.DataSource = dtItem;
                tb_ItemList.DisplayMember = "Item_No";
                //}                
            }
        }
        #endregion

        #region 加载Item时整理显示内容
        private void txComboBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            if (tb_ItemList.DataSource != null)
            {
                DataRowView myDataRowView = (DataRowView)(e.ListItem);
                e.Value = string.Format("{0}-{1}", myDataRowView["Item_No"], myDataRowView["Item_Name"]);
            }
        }
        #endregion

        #region 加载选项值
        /// <summary>
        /// 加载选项值
        /// </summary>
        /// <param name="StyleNo">款号</param>
        /// <param name="ItemNo">选项</param>
        private void GetOptionList(string StyleNo,string ItemNo)
        {
            DataTable dtOption = new DataTable();
            //筛选到款号和选项的列
            dtOption = dt_StyleItem.AsEnumerable()
               .GroupBy(r => new { Col1 = r["Item_No"], Col2 = r["Item_Name"] })
               .SelectMany(g => g.OrderBy(r => r["Style_No"])).Where(r => r["Style_No"].ToString() == StyleNo && r["Item_No"].ToString() == ItemNo)
               .CopyToDataTable();

            if (dtOption.Rows.Count > 0)
            {
               tb_OptionList.DataSource = dtOption;
               tb_OptionList.DisplayMember = "Option_No";                
            }
        }
        #endregion

        #region 加载Option时整理显示内容
        private void tb_OptionList_Format(object sender, ListControlConvertEventArgs e)
        {
            if (tb_OptionList.DataSource != null)
            {
                DataRowView myDataRowView = (DataRowView)(e.ListItem);
                e.Value = string.Format("{0}-{1}", myDataRowView["Option_No"], myDataRowView["Option_Name"]);
            }
        }
        #endregion

        #region 按钮增加选项
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_ItemList.Text.Trim() != "-")
            {
                string ItemNo = tb_ItemList.Text.Trim().Split('-')[0];
                AddItem(ItemNo);

            }
            GetGridCombination();
        }
        #endregion

        #region 增加选项
        private void AddItem(string ItemNo)
        {
            if (tb_ItemList.Items.Count == 0)
            {
                return;
            }
            DataRowView dr_Style = (DataRowView)tb_StyleList.Items[tb_StyleList.SelectedIndex];
            DataRowView dr_Item = (DataRowView)tb_ItemList.Items[tb_ItemList.SelectedIndex];
            if (tb_StyleList.Text.Trim() == "")
            {
                MessageBox.Show("请选择款号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (tb_ItemList.Text.Trim() == "-")
            {
                MessageBox.Show("请选择选项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            for (int i = 0; i < dt_StyleItemFinal.Rows.Count; i++)
            {
                if (dt_StyleItemFinal.Rows[i]["Style_No"].ToString() == dr_Style.Row["Style_No"].ToString() && dt_StyleItemFinal.Rows[i]["Item_No"].ToString() == dr_Item.Row["Item_No"].ToString())
                {
                    return;
                }
            }
            for (int i = 0; i < tb_OptionList.Items.Count; i++)
            {
                DataRowView dr_Option = (DataRowView)tb_OptionList.Items[i];
                DataRow dr = dt_StyleItemFinal.NewRow();
                dr["Style_No"] = dr_Style.Row["Style_No"];
                dr["Item_No"] = dr_Item.Row["Item_No"];
                dr["Item_Name"] = dr_Item.Row["Item_Name"];
                dr["Option_No"] = dr_Option.Row["Option_No"];
                dr["Option_Name"] = dr_Option.Row["Option_Name"];
                dt_StyleItemFinal.Rows.Add(dr);
            }

            DataView dv = dt_StyleItemFinal.DefaultView;
            dv.Sort = "Item_No,Option_No";
            GridOptionItem.DataSource = dv.ToTable();
        }
        #endregion


        #region 按钮删除选项
        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_ItemList.Text.Trim() != "-")
            {
                string ItemNo = tb_ItemList.Text.Trim().Split('-')[0];
                DelItem(ItemNo);

            }
            GetGridCombination();
        }
        #endregion

        #region 删除选项
        private void DelItem(string ItemNo)
        {
            if (tb_ItemList.Items.Count == 0)
            {
                return;
            }
            DataRowView dr_Style = (DataRowView)tb_StyleList.Items[tb_StyleList.SelectedIndex];
            DataRowView dr_Item = (DataRowView)tb_ItemList.Items[tb_ItemList.SelectedIndex];
            if (tb_StyleList.Text.Trim() == "")
            {
                MessageBox.Show("请选择款号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (tb_ItemList.Text.Trim() == "")
            {
                MessageBox.Show("请选择选项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            for (int i = dt_StyleItemFinal.Rows.Count - 1; i >= 0; i--)
            {
                if (dt_StyleItemFinal.Rows[i]["Style_No"].ToString() == dr_Style.Row["Style_No"].ToString() && dt_StyleItemFinal.Rows[i]["Item_No"].ToString() == dr_Item.Row["Item_No"].ToString())
                {
                    dt_StyleItemFinal.Rows.Remove(dt_StyleItemFinal.Rows[i]);                    
                }
            }
            DataView dv = dt_StyleItemFinal.DefaultView;
            dv.Sort = "Item_No,Option_No";
            GridOptionItem.DataSource = dv.ToTable();


            GridOptionItem.DataSource = dt_StyleItemFinal;
        }
        #endregion


        #region 按钮-确定
        private void ButtonYes_Click(object sender, EventArgs e)
        {

            DataRowView dr_Style = (DataRowView)tb_StyleList.Items[tb_StyleList.SelectedIndex];
            StyleBll sb = new StyleBll();
            DataTable dt = sb.Style_KeyOptionAll(dr_Style.Row["Style_No"].ToString());
            if (sb.Style_CompareDataTable(dt, dt_StyleItemFinal) == true)
            {
                return;
            }             
            //保存新的选项表 会删除此款号在原数据库中的所有选项 再插入新的选项表
            if (sb.SaveOption(dt_StyleItemFinal, ItemCombination, dr_Style.Row["Style_No"].ToString()) == 1)
            {
                MessageBox.Show("完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
       }
        #endregion


        #region 按钮-取消
        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void tb_ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_ItemList.Text.Trim() != "-")
            {
                string ItemNo = tb_ItemList.Text.Trim().Split('-')[0];
                GetOptionList(tb_StyleList.Text.Trim(), ItemNo);
            }
            
        }

        private void tb_StyleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGrid("");
            GetGridCombination();
        }
    }


}
