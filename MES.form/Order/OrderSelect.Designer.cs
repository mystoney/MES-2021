
namespace MES.form.Order
{
    partial class OrderSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSelect));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GridOrder = new MyContrals.ExDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cb_customer_state = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.CB_ContainUPSDone = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CKBox_SelectOrder = new System.Windows.Forms.CheckBox();
            this.DTPicker_SelectOrder = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.GridOrder);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2MinSize = 40;
            this.splitContainer2.Size = new System.Drawing.Size(1358, 677);
            this.splitContainer2.SplitterDistance = 636;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // GridOrder
            // 
            this.GridOrder.AllowUserToAddRows = false;
            this.GridOrder.AllowUserToDeleteRows = false;
            this.GridOrder.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridOrder.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOrder.Location = new System.Drawing.Point(0, 0);
            this.GridOrder.Margin = new System.Windows.Forms.Padding(4);
            this.GridOrder.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOrder.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOrder.MergeColumnNames")));
            this.GridOrder.MultiSelect = false;
            this.GridOrder.Name = "GridOrder";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridOrder.RowHeadersVisible = false;
            this.GridOrder.RowHeadersWidth = 51;
            this.GridOrder.RowTemplate.Height = 23;
            this.GridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOrder.Size = new System.Drawing.Size(1358, 636);
            this.GridOrder.TabIndex = 2;
            this.GridOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridOrder_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = global::MES.form.Properties.Resources._32_balloonica_054;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(419, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "提交";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = global::MES.form.Properties.Resources.No;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(571, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Image = global::MES.form.Properties.Resources._32_balloonica_002;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(972, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 38);
            this.button4.TabIndex = 20;
            this.button4.Text = "获取新的工单信息";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Image = global::MES.form.Properties.Resources._32_balloonica_054;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(590, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 38);
            this.button5.TabIndex = 24;
            this.button5.Text = "加载工单号";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cb_customer_state
            // 
            this.cb_customer_state.AutoSize = true;
            this.cb_customer_state.Location = new System.Drawing.Point(17, 16);
            this.cb_customer_state.Margin = new System.Windows.Forms.Padding(4);
            this.cb_customer_state.Name = "cb_customer_state";
            this.cb_customer_state.Size = new System.Drawing.Size(119, 19);
            this.cb_customer_state.TabIndex = 25;
            this.cb_customer_state.Text = "显示测试工单";
            this.cb_customer_state.UseVisualStyleBackColor = true;
            this.cb_customer_state.CheckedChanged += new System.EventHandler(this.cb_customer_state_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Image = global::MES.form.Properties.Resources._32_balloonica_054;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(745, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 38);
            this.button6.TabIndex = 24;
            this.button6.Text = "获取工单选项及选项值";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CB_ContainUPSDone
            // 
            this.CB_ContainUPSDone.AutoSize = true;
            this.CB_ContainUPSDone.Location = new System.Drawing.Point(153, 16);
            this.CB_ContainUPSDone.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ContainUPSDone.Name = "CB_ContainUPSDone";
            this.CB_ContainUPSDone.Size = new System.Drawing.Size(149, 19);
            this.CB_ContainUPSDone.TabIndex = 26;
            this.CB_ContainUPSDone.Text = "显示推送过的工单";
            this.CB_ContainUPSDone.UseVisualStyleBackColor = true;
            this.CB_ContainUPSDone.CheckedChanged += new System.EventHandler(this.CB_ContainUPSDone_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(4, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CKBox_SelectOrder);
            this.splitContainer1.Panel1.Controls.Add(this.DTPicker_SelectOrder);
            this.splitContainer1.Panel1.Controls.Add(this.CB_ContainUPSDone);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.cb_customer_state);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1MinSize = 30;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1358, 725);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // CKBox_SelectOrder
            // 
            this.CKBox_SelectOrder.AutoSize = true;
            this.CKBox_SelectOrder.Location = new System.Drawing.Point(322, 16);
            this.CKBox_SelectOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CKBox_SelectOrder.Name = "CKBox_SelectOrder";
            this.CKBox_SelectOrder.Size = new System.Drawing.Size(104, 19);
            this.CKBox_SelectOrder.TabIndex = 36;
            this.CKBox_SelectOrder.Text = "工单日期：";
            this.CKBox_SelectOrder.UseVisualStyleBackColor = true;
            this.CKBox_SelectOrder.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DTPicker_SelectOrder
            // 
            this.DTPicker_SelectOrder.CustomFormat = "yyyyMMdd";
            this.DTPicker_SelectOrder.Location = new System.Drawing.Point(435, 10);
            this.DTPicker_SelectOrder.Name = "DTPicker_SelectOrder";
            this.DTPicker_SelectOrder.Size = new System.Drawing.Size(108, 25);
            this.DTPicker_SelectOrder.TabIndex = 35;
            this.DTPicker_SelectOrder.CloseUp += new System.EventHandler(this.DTPicker_SelectOrder_CloseUp);
            // 
            // OrderSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrderSelect";
            this.Text = "OrderSelect";
            this.Load += new System.EventHandler(this.OrderAdd_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private MyContrals.ExDataGridView GridOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox cb_customer_state;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox CB_ContainUPSDone;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox CKBox_SelectOrder;
        private System.Windows.Forms.DateTimePicker DTPicker_SelectOrder;
    }
}