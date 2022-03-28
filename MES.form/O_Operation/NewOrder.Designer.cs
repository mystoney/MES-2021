
namespace MES.form.Operation
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bt_GetScheme = new System.Windows.Forms.Button();
            this.ComboBoxOrderList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Stage = new System.Windows.Forms.RadioButton();
            this.RB_Product = new System.Windows.Forms.RadioButton();
            this.LBOrderstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_OrderNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lb_StyleNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TBOrderNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.exDataGridView1 = new MyContrals.ExDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exDataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.bt_GetScheme);
            this.splitContainer1.Panel1.Controls.Add(this.ComboBoxOrderList);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.LBOrderstatus);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Lb_OrderNum);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.Lb_StyleNum);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.TBOrderNo);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1MinSize = 30;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(897, 481);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // bt_GetScheme
            // 
            this.bt_GetScheme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_GetScheme.Image = global::MES.form.Properties.Resources._32_balloonica_054;
            this.bt_GetScheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GetScheme.Location = new System.Drawing.Point(483, 44);
            this.bt_GetScheme.Name = "bt_GetScheme";
            this.bt_GetScheme.Size = new System.Drawing.Size(101, 30);
            this.bt_GetScheme.TabIndex = 19;
            this.bt_GetScheme.Text = "加载方案";
            this.bt_GetScheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_GetScheme.UseVisualStyleBackColor = true;
            this.bt_GetScheme.Click += new System.EventHandler(this.bt_GetScheme_Click);
            // 
            // ComboBoxOrderList
            // 
            this.ComboBoxOrderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrderList.FormattingEnabled = true;
            this.ComboBoxOrderList.Location = new System.Drawing.Point(276, 51);
            this.ComboBoxOrderList.Name = "ComboBoxOrderList";
            this.ComboBoxOrderList.Size = new System.Drawing.Size(201, 20);
            this.ComboBoxOrderList.TabIndex = 18;
            this.ComboBoxOrderList.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrderList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "请选择工单号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Stage);
            this.groupBox1.Controls.Add(this.RB_Product);
            this.groupBox1.Location = new System.Drawing.Point(110, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RB_Stage
            // 
            this.RB_Stage.AutoSize = true;
            this.RB_Stage.Location = new System.Drawing.Point(83, 20);
            this.RB_Stage.Name = "RB_Stage";
            this.RB_Stage.Size = new System.Drawing.Size(71, 16);
            this.RB_Stage.TabIndex = 1;
            this.RB_Stage.Text = "测试订单";
            this.RB_Stage.UseVisualStyleBackColor = true;
            this.RB_Stage.CheckedChanged += new System.EventHandler(this.RB_Stage_CheckedChanged);
            // 
            // RB_Product
            // 
            this.RB_Product.AutoSize = true;
            this.RB_Product.Checked = true;
            this.RB_Product.Location = new System.Drawing.Point(6, 20);
            this.RB_Product.Name = "RB_Product";
            this.RB_Product.Size = new System.Drawing.Size(71, 16);
            this.RB_Product.TabIndex = 0;
            this.RB_Product.TabStop = true;
            this.RB_Product.Text = "生产订单";
            this.RB_Product.UseVisualStyleBackColor = true;
            this.RB_Product.CheckedChanged += new System.EventHandler(this.RB_Product_CheckedChanged);
            // 
            // LBOrderstatus
            // 
            this.LBOrderstatus.AutoSize = true;
            this.LBOrderstatus.Location = new System.Drawing.Point(783, 12);
            this.LBOrderstatus.Name = "LBOrderstatus";
            this.LBOrderstatus.Size = new System.Drawing.Size(41, 12);
            this.LBOrderstatus.TabIndex = 12;
            this.LBOrderstatus.Text = "请检查";
            this.LBOrderstatus.Click += new System.EventHandler(this.LBOrderstatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "订单状态：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lb_OrderNum
            // 
            this.Lb_OrderNum.AutoSize = true;
            this.Lb_OrderNum.Location = new System.Drawing.Point(596, 12);
            this.Lb_OrderNum.Name = "Lb_OrderNum";
            this.Lb_OrderNum.Size = new System.Drawing.Size(101, 12);
            this.Lb_OrderNum.TabIndex = 10;
            this.Lb_OrderNum.Text = "查询到的工单数量";
            this.Lb_OrderNum.Click += new System.EventHandler(this.Lb_OrderNum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "工单数量：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Lb_StyleNum
            // 
            this.Lb_StyleNum.AutoSize = true;
            this.Lb_StyleNum.Location = new System.Drawing.Point(428, 12);
            this.Lb_StyleNum.Name = "Lb_StyleNum";
            this.Lb_StyleNum.Size = new System.Drawing.Size(77, 12);
            this.Lb_StyleNum.TabIndex = 8;
            this.Lb_StyleNum.Text = "查询到的款号";
            this.Lb_StyleNum.Click += new System.EventHandler(this.Lb_StyleNum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "款号：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Image = global::MES.form.Properties.Resources._32_balloonica_054;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(237, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "检查工单信息";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TBOrderNo
            // 
            this.TBOrderNo.Location = new System.Drawing.Point(110, 5);
            this.TBOrderNo.Name = "TBOrderNo";
            this.TBOrderNo.Size = new System.Drawing.Size(121, 21);
            this.TBOrderNo.TabIndex = 2;
            this.TBOrderNo.TextChanged += new System.EventHandler(this.TBOrderNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "请输入工单号：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.exDataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2MinSize = 40;
            this.splitContainer2.Size = new System.Drawing.Size(897, 401);
            this.splitContainer2.SplitterDistance = 360;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // exDataGridView1
            // 
            this.exDataGridView1.AllowUserToAddRows = false;
            this.exDataGridView1.AllowUserToDeleteRows = false;
            this.exDataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.exDataGridView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.exDataGridView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("exDataGridView1.MergeColumnNames")));
            this.exDataGridView1.MultiSelect = false;
            this.exDataGridView1.Name = "exDataGridView1";
            this.exDataGridView1.RowHeadersVisible = false;
            this.exDataGridView1.RowTemplate.Height = 23;
            this.exDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exDataGridView1.Size = new System.Drawing.Size(897, 360);
            this.exDataGridView1.TabIndex = 0;
            this.exDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exDataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = global::MES.form.Properties.Resources._32_balloonica_054;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(314, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
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
            this.button2.Location = new System.Drawing.Point(428, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(897, 481);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加工单";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LBOrderstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_OrderNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lb_StyleNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TBOrderNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MyContrals.ExDataGridView exDataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Stage;
        private System.Windows.Forms.RadioButton RB_Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxOrderList;
        private System.Windows.Forms.Button bt_GetScheme;
    }
}