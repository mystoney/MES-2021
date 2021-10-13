
namespace MES.form.Scheme
{
    partial class SchemeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemeMain));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ButtonSelectScheme = new System.Windows.Forms.ToolStripButton();
            this.ButtonImportScheme = new System.Windows.Forms.ToolStripButton();
            this.ButtonImportOperation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.combo_Line = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridStation = new MyContrals.ExDataGridView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.lb_com_memo = new System.Windows.Forms.Label();
            this.lb_SchemeNo = new System.Windows.Forms.Label();
            this.lb_Combination = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Styleno = new System.Windows.Forms.Label();
            this.GridUPS = new MyContrals.ExDataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUPS)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSelectScheme,
            this.ButtonImportScheme,
            this.ButtonImportOperation,
            this.toolStripSeparator1,
            this.ButtonSave,
            this.toolStripButton14});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1218, 39);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ButtonSelectScheme
            // 
            this.ButtonSelectScheme.Image = global::MES.form.Properties.Resources._32_balloonica_079;
            this.ButtonSelectScheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSelectScheme.Name = "ButtonSelectScheme";
            this.ButtonSelectScheme.Size = new System.Drawing.Size(92, 36);
            this.ButtonSelectScheme.Text = "查询方案";
            this.ButtonSelectScheme.ToolTipText = "按订单查询";
            this.ButtonSelectScheme.Click += new System.EventHandler(this.ButtonSelectScheme_Click);
            // 
            // ButtonImportScheme
            // 
            this.ButtonImportScheme.Enabled = false;
            this.ButtonImportScheme.Image = global::MES.form.Properties.Resources._32_balloonica_019;
            this.ButtonImportScheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonImportScheme.Name = "ButtonImportScheme";
            this.ButtonImportScheme.Size = new System.Drawing.Size(92, 36);
            this.ButtonImportScheme.Text = "导入方案";
            this.ButtonImportScheme.ToolTipText = "按订单查询";
            // 
            // ButtonImportOperation
            // 
            this.ButtonImportOperation.Enabled = false;
            this.ButtonImportOperation.Image = global::MES.form.Properties.Resources._32_balloonica_019;
            this.ButtonImportOperation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonImportOperation.Name = "ButtonImportOperation";
            this.ButtonImportOperation.Size = new System.Drawing.Size(92, 36);
            this.ButtonImportOperation.Text = "导入工序";
            this.ButtonImportOperation.ToolTipText = "按订单查询";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Image = global::MES.form.Properties.Resources._32_balloonica_060;
            this.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(92, 36);
            this.ButtonSave.Text = "保存方案";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = global::MES.form.Properties.Resources._32_balloonica_044;
            this.toolStripButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(68, 36);
            this.toolStripButton14.Text = "退出";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 992);
            this.panel1.TabIndex = 12;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1218, 992);
            this.splitContainer3.SplitterDistance = 238;
            this.splitContainer3.TabIndex = 1;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer5.Panel1.Controls.Add(this.combo_Line);
            this.splitContainer5.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.GridStation);
            this.splitContainer5.Size = new System.Drawing.Size(238, 992);
            this.splitContainer5.SplitterDistance = 30;
            this.splitContainer5.SplitterWidth = 1;
            this.splitContainer5.TabIndex = 2;
            // 
            // combo_Line
            // 
            this.combo_Line.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Line.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combo_Line.FormattingEnabled = true;
            this.combo_Line.Location = new System.Drawing.Point(77, 7);
            this.combo_Line.Name = "combo_Line";
            this.combo_Line.Size = new System.Drawing.Size(119, 20);
            this.combo_Line.TabIndex = 68;
            this.combo_Line.SelectedIndexChanged += new System.EventHandler(this.combo_Line_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "选择生产线";
            // 
            // GridStation
            // 
            this.GridStation.AllowUserToAddRows = false;
            this.GridStation.AllowUserToDeleteRows = false;
            this.GridStation.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridStation.Location = new System.Drawing.Point(0, 0);
            this.GridStation.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridStation.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridStation.MergeColumnNames")));
            this.GridStation.MultiSelect = false;
            this.GridStation.Name = "GridStation";
            this.GridStation.RowHeadersVisible = false;
            this.GridStation.RowTemplate.Height = 27;
            this.GridStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridStation.Size = new System.Drawing.Size(238, 961);
            this.GridStation.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer6);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer4.Size = new System.Drawing.Size(976, 992);
            this.splitContainer4.SplitterDistance = 80;
            this.splitContainer4.TabIndex = 7;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer6.Panel2.Controls.Add(this.button10);
            this.splitContainer6.Panel2.Controls.Add(this.button2);
            this.splitContainer6.Panel2.Controls.Add(this.button9);
            this.splitContainer6.Panel2.Controls.Add(this.button7);
            this.splitContainer6.Panel2.Controls.Add(this.button1);
            this.splitContainer6.Panel2.Controls.Add(this.button8);
            this.splitContainer6.Panel2.Controls.Add(this.button3);
            this.splitContainer6.Panel2.Controls.Add(this.button4);
            this.splitContainer6.Panel2.Controls.Add(this.button5);
            this.splitContainer6.Panel2.Controls.Add(this.button6);
            this.splitContainer6.Size = new System.Drawing.Size(80, 992);
            this.splitContainer6.SplitterDistance = 30;
            this.splitContainer6.SplitterWidth = 1;
            this.splitContainer6.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(3, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 87;
            this.button2.Text = "指定普通";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(3, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 85;
            this.button9.Text = "指定质检";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(3, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 83;
            this.button7.Text = "指定上架";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 42);
            this.button1.TabIndex = 87;
            this.button1.Text = "选择款号及选项";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(3, 357);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 84;
            this.button8.Text = "指定下架";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(3, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 79;
            this.button3.Text = "添  加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(3, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 80;
            this.button4.Text = "删  除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(3, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 81;
            this.button5.Text = "上  移";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(3, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 82;
            this.button6.Text = "下  移";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer7.Panel1.Controls.Add(this.lb_com_memo);
            this.splitContainer7.Panel1.Controls.Add(this.lb_SchemeNo);
            this.splitContainer7.Panel1.Controls.Add(this.lb_Combination);
            this.splitContainer7.Panel1.Controls.Add(this.label5);
            this.splitContainer7.Panel1.Controls.Add(this.lb_Styleno);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.GridUPS);
            this.splitContainer7.Size = new System.Drawing.Size(892, 992);
            this.splitContainer7.SplitterDistance = 30;
            this.splitContainer7.SplitterWidth = 1;
            this.splitContainer7.TabIndex = 0;
            // 
            // lb_com_memo
            // 
            this.lb_com_memo.AutoSize = true;
            this.lb_com_memo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_com_memo.Location = new System.Drawing.Point(269, 9);
            this.lb_com_memo.Name = "lb_com_memo";
            this.lb_com_memo.Size = new System.Drawing.Size(32, 17);
            this.lb_com_memo.TabIndex = 93;
            this.lb_com_memo.Text = "说明";
            // 
            // lb_SchemeNo
            // 
            this.lb_SchemeNo.AutoSize = true;
            this.lb_SchemeNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SchemeNo.Location = new System.Drawing.Point(79, 9);
            this.lb_SchemeNo.Name = "lb_SchemeNo";
            this.lb_SchemeNo.Size = new System.Drawing.Size(73, 17);
            this.lb_SchemeNo.TabIndex = 94;
            this.lb_SchemeNo.Text = "SchemeNo";
            // 
            // lb_Combination
            // 
            this.lb_Combination.AutoSize = true;
            this.lb_Combination.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Combination.Location = new System.Drawing.Point(234, 9);
            this.lb_Combination.Name = "lb_Combination";
            this.lb_Combination.Size = new System.Drawing.Size(32, 17);
            this.lb_Combination.TabIndex = 91;
            this.lb_Combination.Text = "选项";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "生产路线";
            // 
            // lb_Styleno
            // 
            this.lb_Styleno.AutoSize = true;
            this.lb_Styleno.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Styleno.Location = new System.Drawing.Point(158, 9);
            this.lb_Styleno.Name = "lb_Styleno";
            this.lb_Styleno.Size = new System.Drawing.Size(68, 17);
            this.lb_Styleno.TabIndex = 89;
            this.lb_Styleno.Text = "请选择款号";
            // 
            // GridUPS
            // 
            this.GridUPS.AllowUserToAddRows = false;
            this.GridUPS.AllowUserToDeleteRows = false;
            this.GridUPS.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.GridUPS.Size = new System.Drawing.Size(892, 961);
            this.GridUPS.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(3, 459);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 42);
            this.button10.TabIndex = 88;
            this.button10.Text = "清空";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // SchemeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 1031);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "SchemeMain";
            this.Text = "SchemeMain";
            this.Load += new System.EventHandler(this.SchemeMain_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridStation)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ButtonSelectScheme;
        private System.Windows.Forms.ToolStripButton ButtonImportScheme;
        private System.Windows.Forms.ToolStripButton ButtonImportOperation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private TX.Framework.WindowUI.Controls.TXComboBox combo_Line;
        private System.Windows.Forms.Label label6;
        private MyContrals.ExDataGridView GridStation;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Label lb_com_memo;
        private System.Windows.Forms.Label lb_SchemeNo;
        private System.Windows.Forms.Label lb_Combination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Styleno;
        private MyContrals.ExDataGridView GridUPS;
        private System.Windows.Forms.Button button10;
    }
}