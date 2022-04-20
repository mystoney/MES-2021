
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GridOperatorMaster = new MyContrals.ExDataGridView();
            this.GridOperator = new MyContrals.ExDataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ButtonOperatorAdd = new System.Windows.Forms.ToolStripButton();
            this.ButtonChangePassword = new System.Windows.Forms.ToolStripButton();
            this.ButtonOperatorState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.ButtonOperatorType = new System.Windows.Forms.ToolStripButton();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperatorMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperator)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 523);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GridOperatorMaster);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridOperator);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 523);
            this.splitContainer1.SplitterDistance = 579;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 4;
            // 
            // GridOperatorMaster
            // 
            this.GridOperatorMaster.AllowUserToAddRows = false;
            this.GridOperatorMaster.AllowUserToDeleteRows = false;
            this.GridOperatorMaster.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridOperatorMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOperatorMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOperatorMaster.Location = new System.Drawing.Point(0, 0);
            this.GridOperatorMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridOperatorMaster.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOperatorMaster.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOperatorMaster.MergeColumnNames")));
            this.GridOperatorMaster.Name = "GridOperatorMaster";
            this.GridOperatorMaster.RowHeadersVisible = false;
            this.GridOperatorMaster.RowHeadersWidth = 51;
            this.GridOperatorMaster.RowTemplate.Height = 27;
            this.GridOperatorMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOperatorMaster.Size = new System.Drawing.Size(579, 523);
            this.GridOperatorMaster.TabIndex = 1;
            // 
            // GridOperator
            // 
            this.GridOperator.AllowUserToAddRows = false;
            this.GridOperator.AllowUserToDeleteRows = false;
            this.GridOperator.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOperator.Location = new System.Drawing.Point(0, 0);
            this.GridOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridOperator.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOperator.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOperator.MergeColumnNames")));
            this.GridOperator.Name = "GridOperator";
            this.GridOperator.RowHeadersVisible = false;
            this.GridOperator.RowHeadersWidth = 51;
            this.GridOperator.RowTemplate.Height = 27;
            this.GridOperator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOperator.Size = new System.Drawing.Size(481, 523);
            this.GridOperator.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonOperatorAdd,
            this.ButtonRefresh,
            this.ButtonChangePassword,
            this.ButtonOperatorType,
            this.ButtonOperatorState,
            this.toolStripSeparator1,
            this.toolStripButton14});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1067, 39);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ButtonOperatorAdd
            // 
            this.ButtonOperatorAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonOperatorAdd.Image")));
            this.ButtonOperatorAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonOperatorAdd.Name = "ButtonOperatorAdd";
            this.ButtonOperatorAdd.Size = new System.Drawing.Size(120, 36);
            this.ButtonOperatorAdd.Text = "增加操作员";
            this.ButtonOperatorAdd.ToolTipText = "增加操作员";
            this.ButtonOperatorAdd.Click += new System.EventHandler(this.ButtonOperatorAdd_Click);
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChangePassword.Image")));
            this.ButtonChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(105, 36);
            this.ButtonChangePassword.Text = "修改密码";
            this.ButtonChangePassword.ToolTipText = "修改密码";
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // ButtonOperatorState
            // 
            this.ButtonOperatorState.Image = ((System.Drawing.Image)(resources.GetObject("ButtonOperatorState.Image")));
            this.ButtonOperatorState.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonOperatorState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonOperatorState.Name = "ButtonOperatorState";
            this.ButtonOperatorState.Size = new System.Drawing.Size(105, 36);
            this.ButtonOperatorState.Text = "更改状态";
            this.ButtonOperatorState.ToolTipText = "更改状态 停用/启用";
            this.ButtonOperatorState.Click += new System.EventHandler(this.ButtonOperatorState_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(75, 36);
            this.toolStripButton14.Text = "退出";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // ButtonOperatorType
            // 
            this.ButtonOperatorType.Image = ((System.Drawing.Image)(resources.GetObject("ButtonOperatorType.Image")));
            this.ButtonOperatorType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonOperatorType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonOperatorType.Name = "ButtonOperatorType";
            this.ButtonOperatorType.Size = new System.Drawing.Size(105, 36);
            this.ButtonOperatorType.Text = "更改工种";
            this.ButtonOperatorType.ToolTipText = "更改状态 停用/启用";
            this.ButtonOperatorType.Click += new System.EventHandler(this.ButtonOperatorType_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Image = global::MES.form.Properties.Resources._32_balloonica_056;
            this.ButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(75, 36);
            this.ButtonRefresh.Text = "刷新";
            this.ButtonRefresh.ToolTipText = "刷新";
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // OperatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperatorMain";
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.OperatorMain_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridOperatorMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperator)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ButtonOperatorAdd;
        private System.Windows.Forms.ToolStripButton ButtonOperatorState;
        private System.Windows.Forms.ToolStripButton ButtonChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyContrals.ExDataGridView GridOperatorMaster;
        private MyContrals.ExDataGridView GridOperator;
        private System.Windows.Forms.ToolStripButton ButtonOperatorType;
        private System.Windows.Forms.ToolStripButton ButtonRefresh;
    }
}