
namespace MES.form.Order
{
    partial class OrderMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ButtonSelectOrder = new System.Windows.Forms.ToolStripButton();
            this.ButtonGetOpList = new System.Windows.Forms.ToolStripButton();
            this.ButtonChangeScheme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSave = new System.Windows.Forms.ToolStripButton();
            this.ButtonToMES = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txGroupBox3 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_OpListNo = new System.Windows.Forms.Label();
            this.lb_SchemeNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txGroupBox2 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.lb_memo_no = new System.Windows.Forms.TextBox();
            this.lb_memo_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_Combination_no = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_order_no = new System.Windows.Forms.Label();
            this.lb_manhour = new System.Windows.Forms.Label();
            this.lb_job_qty = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_style_num = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_style_des = new System.Windows.Forms.Label();
            this.lb_customer_state_des = new System.Windows.Forms.Label();
            this.lb_customer_state = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.GridUPS = new MyContrals.ExDataGridView();
            this.GridProduct = new MyContrals.ExDataGridView();
            this.GridOperation = new MyContrals.ExDataGridView();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.txGroupBox3.SuspendLayout();
            this.txGroupBox2.SuspendLayout();
            this.txGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperation)).BeginInit();
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
            this.toolStripSeparator1,
            this.ButtonSave,
            this.ButtonToMES,
            this.toolStripButton14});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1624, 39);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // ButtonSelectOrder
            // 
            this.ButtonSelectOrder.Image = global::MES.form.Properties.Resources._32_balloonica_079;
            this.ButtonSelectOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSelectOrder.Name = "ButtonSelectOrder";
            this.ButtonSelectOrder.Size = new System.Drawing.Size(105, 36);
            this.ButtonSelectOrder.Text = "选择工单";
            this.ButtonSelectOrder.ToolTipText = "按订单查询";
            this.ButtonSelectOrder.Click += new System.EventHandler(this.ButtonSelectOrder_Click);
            // 
            // ButtonGetOpList
            // 
            this.ButtonGetOpList.Image = global::MES.form.Properties.Resources._32_balloonica_056;
            this.ButtonGetOpList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGetOpList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGetOpList.Name = "ButtonGetOpList";
            this.ButtonGetOpList.Size = new System.Drawing.Size(135, 36);
            this.ButtonGetOpList.Text = "刷新工序清单";
            this.ButtonGetOpList.Click += new System.EventHandler(this.ButtonGetOpList_Click);
            // 
            // ButtonChangeScheme
            // 
            this.ButtonChangeScheme.Image = global::MES.form.Properties.Resources._32_balloonica_043;
            this.ButtonChangeScheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonChangeScheme.Name = "ButtonChangeScheme";
            this.ButtonChangeScheme.Size = new System.Drawing.Size(135, 36);
            this.ButtonChangeScheme.Text = "修改生产路线";
            this.ButtonChangeScheme.ToolTipText = "按订单查询";
            this.ButtonChangeScheme.Click += new System.EventHandler(this.ButtonNewOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Image = global::MES.form.Properties.Resources._32_balloonica_060;
            this.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(120, 36);
            this.ButtonSave.Text = "保存排产表";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.Visible = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonToMES
            // 
            this.ButtonToMES.Image = global::MES.form.Properties.Resources._32_balloonica_077;
            this.ButtonToMES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonToMES.Name = "ButtonToMES";
            this.ButtonToMES.Size = new System.Drawing.Size(135, 36);
            this.ButtonToMES.Text = "提交到生产线";
            this.ButtonToMES.Click += new System.EventHandler(this.ButtonToMES_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = global::MES.form.Properties.Resources._32_balloonica_044;
            this.toolStripButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(75, 36);
            this.toolStripButton14.Text = "退出";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 837);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.txGroupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.txGroupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.txGroupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lb_customer_state_des);
            this.splitContainer1.Panel1.Controls.Add(this.lb_customer_state);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1624, 837);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txGroupBox3
            // 
            this.txGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox3.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox3.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox3.Controls.Add(this.label7);
            this.txGroupBox3.Controls.Add(this.lb_OpListNo);
            this.txGroupBox3.Controls.Add(this.lb_SchemeNo);
            this.txGroupBox3.Controls.Add(this.label6);
            this.txGroupBox3.Location = new System.Drawing.Point(16, 514);
            this.txGroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.txGroupBox3.Name = "txGroupBox3";
            this.txGroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.txGroupBox3.Size = new System.Drawing.Size(327, 100);
            this.txGroupBox3.TabIndex = 75;
            this.txGroupBox3.TabStop = false;
            this.txGroupBox3.Text = "工单排产信息";
            this.txGroupBox3.TextMargin = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(25, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "工序清单号";
            // 
            // lb_OpListNo
            // 
            this.lb_OpListNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_OpListNo.AutoSize = true;
            this.lb_OpListNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_OpListNo.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_OpListNo.Location = new System.Drawing.Point(135, 36);
            this.lb_OpListNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_OpListNo.Name = "lb_OpListNo";
            this.lb_OpListNo.Size = new System.Drawing.Size(117, 24);
            this.lb_OpListNo.TabIndex = 60;
            this.lb_OpListNo.Text = "lb_OpListNo";
            // 
            // lb_SchemeNo
            // 
            this.lb_SchemeNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SchemeNo.AutoSize = true;
            this.lb_SchemeNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SchemeNo.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_SchemeNo.Location = new System.Drawing.Point(135, 66);
            this.lb_SchemeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SchemeNo.Name = "lb_SchemeNo";
            this.lb_SchemeNo.Size = new System.Drawing.Size(128, 24);
            this.lb_SchemeNo.TabIndex = 61;
            this.lb_SchemeNo.Text = "lb_SchemeNo";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(25, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "生产路线";
            // 
            // txGroupBox2
            // 
            this.txGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox2.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox2.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox2.Controls.Add(this.lb_memo_no);
            this.txGroupBox2.Controls.Add(this.lb_memo_name);
            this.txGroupBox2.Controls.Add(this.label3);
            this.txGroupBox2.Controls.Add(this.label13);
            this.txGroupBox2.Controls.Add(this.lb_Combination_no);
            this.txGroupBox2.Controls.Add(this.label5);
            this.txGroupBox2.Location = new System.Drawing.Point(17, 214);
            this.txGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.txGroupBox2.Name = "txGroupBox2";
            this.txGroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.txGroupBox2.Size = new System.Drawing.Size(327, 292);
            this.txGroupBox2.TabIndex = 74;
            this.txGroupBox2.TabStop = false;
            this.txGroupBox2.Text = "工单选项信息";
            this.txGroupBox2.TextMargin = 6;
            // 
            // lb_memo_no
            // 
            this.lb_memo_no.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_memo_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_memo_no.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_memo_no.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_memo_no.Location = new System.Drawing.Point(116, 66);
            this.lb_memo_no.Margin = new System.Windows.Forms.Padding(4);
            this.lb_memo_no.Multiline = true;
            this.lb_memo_no.Name = "lb_memo_no";
            this.lb_memo_no.ReadOnly = true;
            this.lb_memo_no.Size = new System.Drawing.Size(193, 58);
            this.lb_memo_no.TabIndex = 73;
            this.lb_memo_no.Text = "lb_memo_no";
            // 
            // lb_memo_name
            // 
            this.lb_memo_name.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_memo_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_memo_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_memo_name.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_memo_name.Location = new System.Drawing.Point(116, 121);
            this.lb_memo_name.Margin = new System.Windows.Forms.Padding(4);
            this.lb_memo_name.Multiline = true;
            this.lb_memo_name.Name = "lb_memo_name";
            this.lb_memo_name.ReadOnly = true;
            this.lb_memo_name.Size = new System.Drawing.Size(193, 164);
            this.lb_memo_name.TabIndex = 72;
            this.lb_memo_name.Text = "lb_memo_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "选项值";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(25, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 70;
            this.label13.Text = "选项组合号";
            // 
            // lb_Combination_no
            // 
            this.lb_Combination_no.AutoSize = true;
            this.lb_Combination_no.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Combination_no.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_Combination_no.Location = new System.Drawing.Point(132, 35);
            this.lb_Combination_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Combination_no.Name = "lb_Combination_no";
            this.lb_Combination_no.Size = new System.Drawing.Size(177, 24);
            this.lb_Combination_no.TabIndex = 71;
            this.lb_Combination_no.Text = "lb_Combination_no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "选项说明";
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.label1);
            this.txGroupBox1.Controls.Add(this.label2);
            this.txGroupBox1.Controls.Add(this.label4);
            this.txGroupBox1.Controls.Add(this.lb_order_no);
            this.txGroupBox1.Controls.Add(this.lb_manhour);
            this.txGroupBox1.Controls.Add(this.lb_job_qty);
            this.txGroupBox1.Controls.Add(this.label10);
            this.txGroupBox1.Controls.Add(this.lb_style_num);
            this.txGroupBox1.Controls.Add(this.label9);
            this.txGroupBox1.Controls.Add(this.lb_style_des);
            this.txGroupBox1.Location = new System.Drawing.Point(16, 15);
            this.txGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.txGroupBox1.Size = new System.Drawing.Size(328, 185);
            this.txGroupBox1.TabIndex = 72;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "工单基本信息";
            this.txGroupBox1.TextMargin = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "工单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "工单数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(27, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "款号";
            // 
            // lb_order_no
            // 
            this.lb_order_no.AutoSize = true;
            this.lb_order_no.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_order_no.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_order_no.Location = new System.Drawing.Point(121, 34);
            this.lb_order_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_order_no.Name = "lb_order_no";
            this.lb_order_no.Size = new System.Drawing.Size(112, 24);
            this.lb_order_no.TabIndex = 55;
            this.lb_order_no.Text = "lb_order_no";
            // 
            // lb_manhour
            // 
            this.lb_manhour.AutoSize = true;
            this.lb_manhour.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_manhour.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_manhour.Location = new System.Drawing.Point(140, 151);
            this.lb_manhour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_manhour.Name = "lb_manhour";
            this.lb_manhour.Size = new System.Drawing.Size(113, 24);
            this.lb_manhour.TabIndex = 69;
            this.lb_manhour.Text = "lb_manhour";
            // 
            // lb_job_qty
            // 
            this.lb_job_qty.AutoSize = true;
            this.lb_job_qty.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_job_qty.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_job_qty.Location = new System.Drawing.Point(121, 64);
            this.lb_job_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_job_qty.Name = "lb_job_qty";
            this.lb_job_qty.Size = new System.Drawing.Size(100, 24);
            this.lb_job_qty.TabIndex = 56;
            this.lb_job_qty.Text = "lb_job_qty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(27, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "平缝总工时";
            // 
            // lb_style_num
            // 
            this.lb_style_num.AutoSize = true;
            this.lb_style_num.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_style_num.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_style_num.Location = new System.Drawing.Point(121, 92);
            this.lb_style_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_style_num.Name = "lb_style_num";
            this.lb_style_num.Size = new System.Drawing.Size(105, 24);
            this.lb_style_num.TabIndex = 57;
            this.lb_style_num.Text = "lb_style_no";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(27, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 62;
            this.label9.Text = "款式";
            // 
            // lb_style_des
            // 
            this.lb_style_des.AutoSize = true;
            this.lb_style_des.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_style_des.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_style_des.Location = new System.Drawing.Point(121, 122);
            this.lb_style_des.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_style_des.Name = "lb_style_des";
            this.lb_style_des.Size = new System.Drawing.Size(113, 24);
            this.lb_style_des.TabIndex = 63;
            this.lb_style_des.Text = "lb_style_des";
            // 
            // lb_customer_state_des
            // 
            this.lb_customer_state_des.AutoSize = true;
            this.lb_customer_state_des.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_customer_state_des.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_customer_state_des.Location = new System.Drawing.Point(529, 30);
            this.lb_customer_state_des.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_customer_state_des.Name = "lb_customer_state_des";
            this.lb_customer_state_des.Size = new System.Drawing.Size(175, 15);
            this.lb_customer_state_des.TabIndex = 67;
            this.lb_customer_state_des.Text = "lb_customer_state_des";
            // 
            // lb_customer_state
            // 
            this.lb_customer_state.AutoSize = true;
            this.lb_customer_state.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_customer_state.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_customer_state.Location = new System.Drawing.Point(529, 4);
            this.lb_customer_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_customer_state.Name = "lb_customer_state";
            this.lb_customer_state.Size = new System.Drawing.Size(143, 15);
            this.lb_customer_state.TabIndex = 66;
            this.lb_customer_state.Text = "lb_customer_state";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "订单说明";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 64;
            this.label12.Text = "订单类型";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer2.Panel2.Controls.Add(this.GridOperation);
            this.splitContainer2.Size = new System.Drawing.Size(1351, 837);
            this.splitContainer2.SplitterDistance = 604;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.GridUPS);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.GridProduct);
            this.splitContainer4.Size = new System.Drawing.Size(604, 837);
            this.splitContainer4.SplitterDistance = 602;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // GridUPS
            // 
            this.GridUPS.AllowUserToAddRows = false;
            this.GridUPS.AllowUserToDeleteRows = false;
            this.GridUPS.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridUPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUPS.Location = new System.Drawing.Point(0, 0);
            this.GridUPS.Margin = new System.Windows.Forms.Padding(4);
            this.GridUPS.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridUPS.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridUPS.MergeColumnNames")));
            this.GridUPS.MultiSelect = false;
            this.GridUPS.Name = "GridUPS";
            this.GridUPS.RowHeadersVisible = false;
            this.GridUPS.RowHeadersWidth = 51;
            this.GridUPS.RowTemplate.Height = 27;
            this.GridUPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUPS.Size = new System.Drawing.Size(604, 602);
            this.GridUPS.TabIndex = 6;
            // 
            // GridProduct
            // 
            this.GridProduct.AllowUserToAddRows = false;
            this.GridProduct.AllowUserToDeleteRows = false;
            this.GridProduct.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProduct.Location = new System.Drawing.Point(0, 0);
            this.GridProduct.Margin = new System.Windows.Forms.Padding(4);
            this.GridProduct.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridProduct.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridProduct.MergeColumnNames")));
            this.GridProduct.MultiSelect = false;
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.RowHeadersVisible = false;
            this.GridProduct.RowHeadersWidth = 51;
            this.GridProduct.RowTemplate.Height = 27;
            this.GridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProduct.Size = new System.Drawing.Size(604, 230);
            this.GridProduct.TabIndex = 9;
            // 
            // GridOperation
            // 
            this.GridOperation.AllowUserToAddRows = false;
            this.GridOperation.AllowUserToDeleteRows = false;
            this.GridOperation.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOperation.Location = new System.Drawing.Point(0, 0);
            this.GridOperation.Margin = new System.Windows.Forms.Padding(4);
            this.GridOperation.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOperation.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOperation.MergeColumnNames")));
            this.GridOperation.MultiSelect = false;
            this.GridOperation.Name = "GridOperation";
            this.GridOperation.RowHeadersVisible = false;
            this.GridOperation.RowHeadersWidth = 51;
            this.GridOperation.RowTemplate.Height = 27;
            this.GridOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOperation.Size = new System.Drawing.Size(742, 837);
            this.GridOperation.TabIndex = 7;
            // 
            // OrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 876);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderMain";
            this.Text = "OrderMain";
            this.Load += new System.EventHandler(this.OrderMain_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.txGroupBox3.ResumeLayout(false);
            this.txGroupBox3.PerformLayout();
            this.txGroupBox2.ResumeLayout(false);
            this.txGroupBox2.PerformLayout();
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ButtonChangeScheme;
        private System.Windows.Forms.ToolStripButton ButtonSelectOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtonSave;
        private System.Windows.Forms.ToolStripButton ButtonToMES;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lb_Combination_no;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_manhour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_customer_state_des;
        private System.Windows.Forms.Label lb_customer_state;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_style_des;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_SchemeNo;
        private System.Windows.Forms.Label lb_OpListNo;
        private System.Windows.Forms.Label lb_style_num;
        private System.Windows.Forms.Label lb_job_qty;
        private System.Windows.Forms.Label lb_order_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox3;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private MyContrals.ExDataGridView GridUPS;
        private MyContrals.ExDataGridView GridProduct;
        private MyContrals.ExDataGridView GridOperation;
        private System.Windows.Forms.TextBox lb_memo_no;
        private System.Windows.Forms.TextBox lb_memo_name;
        private System.Windows.Forms.ToolStripButton ButtonGetOpList;
    }
}