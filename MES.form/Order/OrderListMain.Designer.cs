
namespace MES.form.Order
{
    partial class OrderListMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ButtonSelectScheme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonToMES = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GridOrder = new MyContrals.ExDataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkBox_customer_state = new System.Windows.Forms.CheckBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.GridUPS = new MyContrals.ExDataGridView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.GridProduct = new MyContrals.ExDataGridView();
            this.GridOperation = new MyContrals.ExDataGridView();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.ButtonSelectScheme,
            this.toolStripSeparator1,
            this.ButtonToMES,
            this.toolStripButton14});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1218, 39);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MES.form.Properties.Resources._32_balloonica_002;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(128, 36);
            this.toolStripButton1.Text = "获取和刷新订单";
            this.toolStripButton1.ToolTipText = "按订单查询";
            this.toolStripButton1.Click += new System.EventHandler(this.ButtonNewOrder_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::MES.form.Properties.Resources._32_balloonica_056;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(128, 36);
            this.toolStripButton2.Text = "刷新订单表信息";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ButtonSelectScheme
            // 
            this.ButtonSelectScheme.Image = global::MES.form.Properties.Resources._32_balloonica_043;
            this.ButtonSelectScheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSelectScheme.Name = "ButtonSelectScheme";
            this.ButtonSelectScheme.Size = new System.Drawing.Size(116, 36);
            this.ButtonSelectScheme.Text = "指定生产路线";
            this.ButtonSelectScheme.ToolTipText = "选择生产路线";
            this.ButtonSelectScheme.Click += new System.EventHandler(this.ButtonNewOrder_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonToMES
            // 
            this.ButtonToMES.Image = global::MES.form.Properties.Resources._32_balloonica_077;
            this.ButtonToMES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonToMES.Name = "ButtonToMES";
            this.ButtonToMES.Size = new System.Drawing.Size(116, 36);
            this.ButtonToMES.Text = "提交到生产线";
            this.ButtonToMES.Click += new System.EventHandler(this.ButtonToMES_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = global::MES.form.Properties.Resources._32_balloonica_044;
            this.toolStripButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(68, 36);
            this.toolStripButton14.Text = "退出";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 662);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GridOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1218, 662);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 0;
            // 
            // GridOrder
            // 
            this.GridOrder.AllowUserToAddRows = false;
            this.GridOrder.AllowUserToDeleteRows = false;
            this.GridOrder.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOrder.Location = new System.Drawing.Point(0, 0);
            this.GridOrder.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOrder.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOrder.MergeColumnNames")));
            this.GridOrder.MultiSelect = false;
            this.GridOrder.Name = "GridOrder";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridOrder.RowHeadersVisible = false;
            this.GridOrder.RowTemplate.Height = 23;
            this.GridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOrder.Size = new System.Drawing.Size(1218, 209);
            this.GridOrder.TabIndex = 3;
            this.GridOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridOrder_CellClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.checkBox_customer_state);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1218, 449);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // checkBox_customer_state
            // 
            this.checkBox_customer_state.AutoSize = true;
            this.checkBox_customer_state.Location = new System.Drawing.Point(4, 5);
            this.checkBox_customer_state.Name = "checkBox_customer_state";
            this.checkBox_customer_state.Size = new System.Drawing.Size(96, 16);
            this.checkBox_customer_state.TabIndex = 0;
            this.checkBox_customer_state.Text = "显示测试工单";
            this.checkBox_customer_state.UseVisualStyleBackColor = true;
            this.checkBox_customer_state.CheckedChanged += new System.EventHandler(this.checkBox_customer_state_CheckedChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.GridUPS);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1218, 420);
            this.splitContainer3.SplitterDistance = 406;
            this.splitContainer3.TabIndex = 0;
            // 
            // GridUPS
            // 
            this.GridUPS.AllowUserToAddRows = false;
            this.GridUPS.AllowUserToDeleteRows = false;
            this.GridUPS.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUPS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridUPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUPS.Location = new System.Drawing.Point(0, 0);
            this.GridUPS.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridUPS.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridUPS.MergeColumnNames")));
            this.GridUPS.MultiSelect = false;
            this.GridUPS.Name = "GridUPS";
            this.GridUPS.RowHeadersVisible = false;
            this.GridUPS.RowTemplate.Height = 27;
            this.GridUPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUPS.Size = new System.Drawing.Size(406, 420);
            this.GridUPS.TabIndex = 5;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.GridProduct);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.GridOperation);
            this.splitContainer4.Size = new System.Drawing.Size(808, 420);
            this.splitContainer4.SplitterDistance = 269;
            this.splitContainer4.TabIndex = 0;
            // 
            // GridProduct
            // 
            this.GridProduct.AllowUserToAddRows = false;
            this.GridProduct.AllowUserToDeleteRows = false;
            this.GridProduct.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProduct.Location = new System.Drawing.Point(0, 0);
            this.GridProduct.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridProduct.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridProduct.MergeColumnNames")));
            this.GridProduct.MultiSelect = false;
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.RowHeadersVisible = false;
            this.GridProduct.RowTemplate.Height = 27;
            this.GridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProduct.Size = new System.Drawing.Size(269, 420);
            this.GridProduct.TabIndex = 6;
            // 
            // GridOperation
            // 
            this.GridOperation.AllowUserToAddRows = false;
            this.GridOperation.AllowUserToDeleteRows = false;
            this.GridOperation.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOperation.Location = new System.Drawing.Point(0, 0);
            this.GridOperation.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOperation.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOperation.MergeColumnNames")));
            this.GridOperation.MultiSelect = false;
            this.GridOperation.Name = "GridOperation";
            this.GridOperation.RowHeadersVisible = false;
            this.GridOperation.RowTemplate.Height = 27;
            this.GridOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOperation.Size = new System.Drawing.Size(535, 420);
            this.GridOperation.TabIndex = 6;
            // 
            // OrderListMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "OrderListMain";
            this.Text = "OrderListMain";
            this.Load += new System.EventHandler(this.OrderListMain_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUPS)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton ButtonSelectScheme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtonToMES;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyContrals.ExDataGridView GridOrder;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox checkBox_customer_state;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MyContrals.ExDataGridView GridUPS;
        private System.Windows.Forms.SplitContainer splitContainer4;
        //private MyContrals.ExDataGridView GridProductList;
        private MyContrals.ExDataGridView GridOperation;
        private MyContrals.ExDataGridView GridProduct;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}