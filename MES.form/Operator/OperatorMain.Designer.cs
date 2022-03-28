
namespace MES.form.Operator
{
    partial class OperatorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorMain));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ButtonSelectOrder = new System.Windows.Forms.ToolStripButton();
            this.ButtonGetOpList = new System.Windows.Forms.ToolStripButton();
            this.ButtonChangeScheme = new System.Windows.Forms.ToolStripButton();
            this.ButtonToMES = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GridLine = new MyContrals.ExDataGridView();
            this.GridOperator = new MyContrals.ExDataGridView();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperator)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSelectOrder,
            this.ButtonGetOpList,
            this.ButtonChangeScheme,
            this.ButtonToMES,
            this.toolStripSeparator1,
            this.ButtonSave,
            this.toolStripButton14});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 39);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ButtonSelectOrder
            // 
            this.ButtonSelectOrder.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSelectOrder.Image")));
            this.ButtonSelectOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSelectOrder.Name = "ButtonSelectOrder";
            this.ButtonSelectOrder.Size = new System.Drawing.Size(68, 36);
            this.ButtonSelectOrder.Text = "增加";
            this.ButtonSelectOrder.ToolTipText = "按订单查询";
            // 
            // ButtonGetOpList
            // 
            this.ButtonGetOpList.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGetOpList.Image")));
            this.ButtonGetOpList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGetOpList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGetOpList.Name = "ButtonGetOpList";
            this.ButtonGetOpList.Size = new System.Drawing.Size(68, 36);
            this.ButtonGetOpList.Text = "停用";
            // 
            // ButtonChangeScheme
            // 
            this.ButtonChangeScheme.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChangeScheme.Image")));
            this.ButtonChangeScheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonChangeScheme.Name = "ButtonChangeScheme";
            this.ButtonChangeScheme.Size = new System.Drawing.Size(68, 36);
            this.ButtonChangeScheme.Text = "编辑";
            this.ButtonChangeScheme.ToolTipText = "按订单查询";
            // 
            // ButtonToMES
            // 
            this.ButtonToMES.Image = ((System.Drawing.Image)(resources.GetObject("ButtonToMES.Image")));
            this.ButtonToMES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonToMES.Name = "ButtonToMES";
            this.ButtonToMES.Size = new System.Drawing.Size(72, 36);
            this.ButtonToMES.Text = "4444";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(104, 36);
            this.ButtonSave.Text = "保存排产表";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.Visible = false;
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(68, 36);
            this.toolStripButton14.Text = "退出";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 411);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GridLine);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridOperator);
            this.splitContainer1.Size = new System.Drawing.Size(800, 411);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // GridLine
            // 
            this.GridLine.AllowUserToAddRows = false;
            this.GridLine.AllowUserToDeleteRows = false;
            this.GridLine.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLine.Location = new System.Drawing.Point(0, 0);
            this.GridLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridLine.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridLine.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridLine.MergeColumnNames")));
            this.GridLine.Name = "GridLine";
            this.GridLine.RowHeadersVisible = false;
            this.GridLine.RowTemplate.Height = 27;
            this.GridLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridLine.Size = new System.Drawing.Size(266, 411);
            this.GridLine.TabIndex = 1;
            // 
            // GridOperator
            // 
            this.GridOperator.AllowUserToAddRows = false;
            this.GridOperator.AllowUserToDeleteRows = false;
            this.GridOperator.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOperator.Location = new System.Drawing.Point(0, 0);
            this.GridOperator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridOperator.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOperator.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOperator.MergeColumnNames")));
            this.GridOperator.Name = "GridOperator";
            this.GridOperator.RowHeadersVisible = false;
            this.GridOperator.RowTemplate.Height = 27;
            this.GridOperator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOperator.Size = new System.Drawing.Size(529, 411);
            this.GridOperator.TabIndex = 2;
            // 
            // OperatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "OperatorMain";
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.OperatorMain_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ButtonSelectOrder;
        private System.Windows.Forms.ToolStripButton ButtonGetOpList;
        private System.Windows.Forms.ToolStripButton ButtonChangeScheme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtonToMES;
        private System.Windows.Forms.ToolStripButton ButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyContrals.ExDataGridView GridLine;
        private MyContrals.ExDataGridView GridOperator;
    }
}