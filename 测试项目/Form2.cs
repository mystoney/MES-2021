using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static MyContrals.ExDataGridView;

namespace 测试项目
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtTemp = new DataTable();

            using (SqlConnection con = new SqlConnection("server=172.16.1.79;uid=sa;pwd=MP@ssw0rd;database=MES;"))
            {
                SqlDataAdapter sa = new SqlDataAdapter("select top 100 * from [MES_line]", con);
                sa.Fill(dtTemp);
            }
            //创建复选框列     
            DataGridViewCheckBoxColumn checkboxCol = new DataGridViewCheckBoxColumn();
            //创建复选框列头单元格  
            datagridviewCheckboxHeaderCell ch = new datagridviewCheckboxHeaderCell();
            //设置复选框那列的单元格为复选框  
            checkboxCol.HeaderCell = ch;

            //将此复选框列添加到DataGridView中  
            this.dataGridView1.Columns.Add(checkboxCol);

            ch.OnCheckBoxClicked += new datagridviewcheckboxHeaderEventHander(ch_OnCheckBoxClicked);//关联单击事件  


            this.dataGridView1.DataSource = dtTemp;

            this.dataGridView1.Rows[0].Cells[0].Selected = false;
            this.dataGridView1.Rows[0].Cells[1].Selected = true;
            this.dataGridView1.Refresh();
            
        }


        private void ch_OnCheckBoxClicked(object sender, datagridviewCheckboxHeaderEventArgs e)
        {
            //foreach (DataGridViewRow dgvRow in this.dataGridView1.Rows)
            //{
            //    if (e.CheckedState)
            //    {
            //        dgvRow.Cells[0].Value = true;
            //    }
            //    else
            //    {
            //        dgvRow.Cells[0].Value = false;
            //    }
            //}

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {

                this.dataGridView1.Rows[i].Cells[0].Value = e.CheckedState;
                
            }




        }

        //定义触发单击事件的委托  
        delegate void datagridviewcheckboxHeaderEventHander(object sender, datagridviewCheckboxHeaderEventArgs e);
        class datagridviewCheckboxHeaderEventArgs : EventArgs
        {
            private bool checkedState = false;

            public bool CheckedState
            {
                get { return checkedState; }
                set { checkedState = value; }
            }
        }
        class datagridviewCheckboxHeaderCell : DataGridViewColumnHeaderCell
        {
            Point checkBoxLocation;
            Size checkBoxSize;
            bool _checked = false;
            Point _cellLocation = new Point();
            System.Windows.Forms.VisualStyles.CheckBoxState _cbState =
                System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;
            public event datagridviewcheckboxHeaderEventHander OnCheckBoxClicked;


            //绘制列头checkbox  
            protected override void Paint(System.Drawing.Graphics graphics,
               System.Drawing.Rectangle clipBounds,
               System.Drawing.Rectangle cellBounds,
               int rowIndex,
               DataGridViewElementStates dataGridViewElementState,
               object value,
               object formattedValue,
               string errorText,
               DataGridViewCellStyle cellStyle,
               DataGridViewAdvancedBorderStyle advancedBorderStyle,
               DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    dataGridViewElementState, value,
                    formattedValue, errorText, cellStyle,
                    advancedBorderStyle, paintParts);

                Point p = new Point();
                Size s = CheckBoxRenderer.GetGlyphSize(graphics,             System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);

                

                p.X = cellBounds.Location.X +
                    (cellBounds.Width / 2) - (s.Width / 2) - 1;//列头checkbox的X坐标  
                p.Y = cellBounds.Location.Y +
                    (cellBounds.Height / 2) - (s.Height / 2);//列头checkbox的Y坐标  

                _cellLocation = cellBounds.Location;
                checkBoxLocation = p;
                checkBoxSize = s;
                if (_checked)
                    _cbState = System.Windows.Forms.VisualStyles.
                        CheckBoxState.CheckedNormal;
                else
                    _cbState = System.Windows.Forms.VisualStyles.
                        CheckBoxState.UncheckedNormal;
                CheckBoxRenderer.DrawCheckBox
                (graphics, checkBoxLocation, _cbState);
            }



            /// <summary>  
            /// 点击列头checkbox单击事件  
            /// </summary>  
            protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
            {

                Point p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
                if (p.X >= checkBoxLocation.X && p.X <=
                    checkBoxLocation.X + checkBoxSize.Width
                && p.Y >= checkBoxLocation.Y && p.Y <=
                    checkBoxLocation.Y + checkBoxSize.Height)
                {
                    _checked = !_checked;


                    //获取列头checkbox的选择状态  
                    datagridviewCheckboxHeaderEventArgs ex = new datagridviewCheckboxHeaderEventArgs();
                    ex.CheckedState = _checked;

                    object sender = new object();//此处不代表选择的列头checkbox，只是作为参数传递。应该列头checkbox是绘制出来的，无法获得它的实例  

                    if (OnCheckBoxClicked != null)
                    {
                        OnCheckBoxClicked(sender, ex);//触发单击事件  
                        this.DataGridView.InvalidateCell(this);
                    }

                }
                base.OnMouseClick(e);
            }

        }











        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dtTemp = new DataTable();

            using (SqlConnection con = new SqlConnection("server=172.16.1.79;uid=sa;pwd=MP@ssw0rd;database=MES;"))
            {
                SqlDataAdapter sa = new SqlDataAdapter("select top 100 * from [MES_line]", con);
                sa.Fill(dtTemp);
            }
            this.exDataGridView1.DataSource = dtTemp;


            exDataGridView1.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
            exDataGridView1.AddColumn("ID", "ID");
            exDataGridView1.AddColumn("eton_line", "eton_line");

            for (int i = 0; i < this.exDataGridView1.Rows.Count; i++)
            {
                this.exDataGridView1.Rows[i].Cells[0].Value = true;
            }

            

            ////DataGridViewCheckBoxColumn colCB = new DataGridViewCheckBoxColumn();
            //DatagridViewCheckBoxHeaderCell cbHeader = new DatagridViewCheckBoxHeaderCell();
            ////colCB.HeaderCell = cbHeader;
            ////dataGridView1.Columns.Add(colCB);
            //cbHeader.Value = string.Empty;
            //cbHeader.OnCheckBoxClicked += new CheckBoxClickedHandler(cbHeader_OnCheckBoxClicked);

            //exDataGridView1.Columns[0].HeaderCell = cbHeader;
        }



        private void cbHeader_OnCheckBoxClicked(bool state)
        {
            //这一句很重要结束编辑状态
            //dgvWarn.EndEdit();
           
            if (exDataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < this.exDataGridView1.Rows.Count; i++)
                    {
                    exDataGridView1.Rows[i].Cells[0].Value = state;
                    }
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <this.exDataGridView1.Rows.Count; i++)
            {
                this.exDataGridView1.Rows[i].Cells[0].Value = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

