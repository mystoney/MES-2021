namespace MES.form.Station
{
    partial class StationMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationMain));
            this.dataGridViewStation = new System.Windows.Forms.DataGridView();
            this.toolStripState = new System.Windows.Forms.ToolStrip();
            this.ButtonAddLine = new System.Windows.Forms.ToolStripButton();
            this.ButtonDELLine = new System.Windows.Forms.ToolStripButton();
            this.ButtonStartLine = new System.Windows.Forms.ToolStripButton();
            this.ButtonStopLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAddStation = new System.Windows.Forms.ToolStripButton();
            this.ButtonDELStation = new System.Windows.Forms.ToolStripButton();
            this.ButtonStartStation = new System.Windows.Forms.ToolStripButton();
            this.ButtonStopStation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolsNumExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GridLine = new MyContrals.ExDataGridView();
            this.GridStation = new MyContrals.ExDataGridView();
            this.txContextMenuStripLine = new TX.Framework.WindowUI.Controls.TXContextMenuStrip();
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选中行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选中行ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.所有行ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txContextMenuStripStation = new TX.Framework.WindowUI.Controls.TXContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStation)).BeginInit();
            this.toolStripState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStation)).BeginInit();
            this.txContextMenuStripLine.SuspendLayout();
            this.txContextMenuStripStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStation
            // 
            this.dataGridViewStation.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStation.Name = "dataGridViewStation";
            this.dataGridViewStation.RowTemplate.Height = 23;
            this.dataGridViewStation.Size = new System.Drawing.Size(1176, 1033);
            this.dataGridViewStation.TabIndex = 0;
            // 
            // toolStripState
            // 
            this.toolStripState.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStripState.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddLine,
            this.ButtonDELLine,
            this.ButtonStartLine,
            this.ButtonStopLine,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.ButtonAddStation,
            this.ButtonDELStation,
            this.ButtonStartStation,
            this.ButtonStopStation,
            this.toolStripSeparator6,
            this.ToolsNumExit});
            this.toolStripState.Location = new System.Drawing.Point(0, 0);
            this.toolStripState.Name = "toolStripState";
            this.toolStripState.Size = new System.Drawing.Size(1176, 39);
            this.toolStripState.TabIndex = 4;
            this.toolStripState.Text = "toolStrip1";
            // 
            // ButtonAddLine
            // 
            this.ButtonAddLine.Image = global::MES.form.Properties.Resources._32_balloonica_002;
            this.ButtonAddLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAddLine.Name = "ButtonAddLine";
            this.ButtonAddLine.Size = new System.Drawing.Size(92, 36);
            this.ButtonAddLine.Text = "增加产线";
            this.ButtonAddLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddLine.Click += new System.EventHandler(this.ButtonAddLine_Click_1);
            // 
            // ButtonDELLine
            // 
            this.ButtonDELLine.Image = global::MES.form.Properties.Resources._32_balloonica_057;
            this.ButtonDELLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDELLine.Name = "ButtonDELLine";
            this.ButtonDELLine.Size = new System.Drawing.Size(92, 36);
            this.ButtonDELLine.Text = "删除产线";
            this.ButtonDELLine.Click += new System.EventHandler(this.ButtonDELLine_Click_1);
            // 
            // ButtonStartLine
            // 
            this.ButtonStartLine.Image = global::MES.form.Properties.Resources._32_balloonica_050;
            this.ButtonStartLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonStartLine.Name = "ButtonStartLine";
            this.ButtonStartLine.Size = new System.Drawing.Size(92, 36);
            this.ButtonStartLine.Text = "启用产线";
            this.ButtonStartLine.Click += new System.EventHandler(this.ButtonStartLine_Click);
            // 
            // ButtonStopLine
            // 
            this.ButtonStopLine.Image = global::MES.form.Properties.Resources._32_balloonica_068;
            this.ButtonStopLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonStopLine.Name = "ButtonStopLine";
            this.ButtonStopLine.Size = new System.Drawing.Size(92, 36);
            this.ButtonStopLine.Text = "停用产线";
            this.ButtonStopLine.Click += new System.EventHandler(this.ButtonStopLine_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MES.form.Properties.Resources._32_balloonica_012;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 36);
            this.toolStripButton1.Text = "编辑产能";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonAddStation
            // 
            this.ButtonAddStation.Image = global::MES.form.Properties.Resources._32_balloonica_002;
            this.ButtonAddStation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAddStation.Name = "ButtonAddStation";
            this.ButtonAddStation.Size = new System.Drawing.Size(104, 36);
            this.ButtonAddStation.Text = "增加工作站";
            this.ButtonAddStation.Click += new System.EventHandler(this.ButtonAddStation_Click_1);
            // 
            // ButtonDELStation
            // 
            this.ButtonDELStation.Image = global::MES.form.Properties.Resources._32_balloonica_057;
            this.ButtonDELStation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDELStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDELStation.Name = "ButtonDELStation";
            this.ButtonDELStation.Size = new System.Drawing.Size(104, 36);
            this.ButtonDELStation.Text = "删除工作站";
            this.ButtonDELStation.Click += new System.EventHandler(this.ButtonDELStation_Click);
            // 
            // ButtonStartStation
            // 
            this.ButtonStartStation.Image = global::MES.form.Properties.Resources._32_balloonica_050;
            this.ButtonStartStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonStartStation.Name = "ButtonStartStation";
            this.ButtonStartStation.Size = new System.Drawing.Size(104, 36);
            this.ButtonStartStation.Text = "启用工作站";
            this.ButtonStartStation.Click += new System.EventHandler(this.ButtonStartStation_Click);
            // 
            // ButtonStopStation
            // 
            this.ButtonStopStation.Image = global::MES.form.Properties.Resources._32_balloonica_068;
            this.ButtonStopStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonStopStation.Name = "ButtonStopStation";
            this.ButtonStopStation.Size = new System.Drawing.Size(104, 36);
            this.ButtonStopStation.Text = "停用工作站";
            this.ButtonStopStation.Click += new System.EventHandler(this.ButtonStopStation_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolsNumExit
            // 
            this.ToolsNumExit.Image = global::MES.form.Properties.Resources._32_balloonica_044;
            this.ToolsNumExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolsNumExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolsNumExit.Name = "ToolsNumExit";
            this.ToolsNumExit.Size = new System.Drawing.Size(68, 36);
            this.ToolsNumExit.Text = "退出";
            this.ToolsNumExit.Click += new System.EventHandler(this.ToolsNumExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GridLine);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridStation);
            this.splitContainer1.Size = new System.Drawing.Size(1176, 994);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
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
            this.GridLine.Size = new System.Drawing.Size(392, 994);
            this.GridLine.TabIndex = 1;
            this.GridLine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLine_CellClick);
            this.GridLine.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridLine_CellMouseDoubleClick);
            this.GridLine.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridLine_CellMouseDown);
            // 
            // GridStation
            // 
            this.GridStation.AllowUserToAddRows = false;
            this.GridStation.AllowUserToDeleteRows = false;
            this.GridStation.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridStation.Location = new System.Drawing.Point(0, 0);
            this.GridStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridStation.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridStation.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridStation.MergeColumnNames")));
            this.GridStation.Name = "GridStation";
            this.GridStation.RowHeadersVisible = false;
            this.GridStation.RowTemplate.Height = 27;
            this.GridStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridStation.Size = new System.Drawing.Size(779, 994);
            this.GridStation.TabIndex = 2;
            this.GridStation.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridStation_CellMouseDoubleClick);
            this.GridStation.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridStation_CellMouseDown);
            // 
            // txContextMenuStripLine
            // 
            this.txContextMenuStripLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txContextMenuStripLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择ToolStripMenuItem,
            this.取消选择ToolStripMenuItem});
            this.txContextMenuStripLine.Name = "txContextMenuStripUPS";
            this.txContextMenuStripLine.Size = new System.Drawing.Size(125, 48);
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选中行ToolStripMenuItem,
            this.所有行ToolStripMenuItem});
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.选择ToolStripMenuItem.Text = "选择";
            // 
            // 选中行ToolStripMenuItem
            // 
            this.选中行ToolStripMenuItem.Name = "选中行ToolStripMenuItem";
            this.选中行ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.选中行ToolStripMenuItem.Text = "选中行";
            this.选中行ToolStripMenuItem.Click += new System.EventHandler(this.选中行ToolStripMenuItem_Click);
            // 
            // 所有行ToolStripMenuItem
            // 
            this.所有行ToolStripMenuItem.Name = "所有行ToolStripMenuItem";
            this.所有行ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.所有行ToolStripMenuItem.Text = "所有行";
            this.所有行ToolStripMenuItem.Click += new System.EventHandler(this.所有行ToolStripMenuItem_Click);
            // 
            // 取消选择ToolStripMenuItem
            // 
            this.取消选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选中行ToolStripMenuItem1,
            this.所有行ToolStripMenuItem1});
            this.取消选择ToolStripMenuItem.Name = "取消选择ToolStripMenuItem";
            this.取消选择ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.取消选择ToolStripMenuItem.Text = "取消选择";
            // 
            // 选中行ToolStripMenuItem1
            // 
            this.选中行ToolStripMenuItem1.Name = "选中行ToolStripMenuItem1";
            this.选中行ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.选中行ToolStripMenuItem1.Text = "选中行";
            this.选中行ToolStripMenuItem1.Click += new System.EventHandler(this.选中行ToolStripMenuItem1_Click);
            // 
            // 所有行ToolStripMenuItem1
            // 
            this.所有行ToolStripMenuItem1.Name = "所有行ToolStripMenuItem1";
            this.所有行ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.所有行ToolStripMenuItem1.Text = "所有行";
            this.所有行ToolStripMenuItem1.Click += new System.EventHandler(this.所有行ToolStripMenuItem1_Click);
            // 
            // txContextMenuStripStation
            // 
            this.txContextMenuStripStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txContextMenuStripStation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.txContextMenuStripStation.Name = "txContextMenuStripUPS";
            this.txContextMenuStripStation.Size = new System.Drawing.Size(125, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "选择";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem2.Text = "选中行";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem3.Text = "所有行";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem4.Text = "取消选择";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem5.Text = "选中行";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem6.Text = "所有行";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // StationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 1033);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripState);
            this.Controls.Add(this.dataGridViewStation);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StationMain";
            this.ShowIcon = false;
            this.Text = "工作站管理";
            this.Load += new System.EventHandler(this.StationMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStation)).EndInit();
            this.toolStripState.ResumeLayout(false);
            this.toolStripState.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStation)).EndInit();
            this.txContextMenuStripLine.ResumeLayout(false);
            this.txContextMenuStripStation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStation;
        private System.Windows.Forms.ToolStrip toolStripState;
        private System.Windows.Forms.ToolStripButton ButtonStartLine;
        private System.Windows.Forms.ToolStripButton ButtonStopLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ButtonStartStation;
        private System.Windows.Forms.ToolStripButton ButtonStopStation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ToolsNumExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyContrals.ExDataGridView GridStation;
        private MyContrals.ExDataGridView GridLine;
        private TX.Framework.WindowUI.Controls.TXContextMenuStrip txContextMenuStripLine;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选中行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选中行ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 所有行ToolStripMenuItem1;
        private TX.Framework.WindowUI.Controls.TXContextMenuStrip txContextMenuStripStation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripButton ButtonAddLine;
        private System.Windows.Forms.ToolStripButton ButtonDELLine;
        private System.Windows.Forms.ToolStripButton ButtonAddStation;
        private System.Windows.Forms.ToolStripButton ButtonDELStation;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}