namespace MES.form.Operation
{
    partial class SelectOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectOrder));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.exDataGridView1 = new MyContrals.ExDataGridView();
            this.Button_DelScheme = new System.Windows.Forms.Button();
            this.Button_DelOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_NoScheme = new System.Windows.Forms.Button();
            this.Button_M = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_A = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 30;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(908, 281);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "由下面列表中选择系统中已有订单号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer2.Panel2.Controls.Add(this.Button_DelScheme);
            this.splitContainer2.Panel2.Controls.Add(this.Button_DelOrder);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.Button_NoScheme);
            this.splitContainer2.Panel2.Controls.Add(this.Button_M);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.Button_A);
            this.splitContainer2.Panel2MinSize = 40;
            this.splitContainer2.Size = new System.Drawing.Size(908, 250);
            this.splitContainer2.SplitterDistance = 209;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
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
            this.exDataGridView1.Size = new System.Drawing.Size(908, 209);
            this.exDataGridView1.TabIndex = 0;
            this.exDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exDataGridView1_CellClick);
            // 
            // Button_DelScheme
            // 
            this.Button_DelScheme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_DelScheme.Image = global::MES.form.Properties.Resources.No;
            this.Button_DelScheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_DelScheme.Location = new System.Drawing.Point(6, 5);
            this.Button_DelScheme.Name = "Button_DelScheme";
            this.Button_DelScheme.Size = new System.Drawing.Size(108, 30);
            this.Button_DelScheme.TabIndex = 7;
            this.Button_DelScheme.Text = "删除方案";
            this.Button_DelScheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_DelScheme.UseVisualStyleBackColor = true;
            this.Button_DelScheme.Click += new System.EventHandler(this.Button_DelScheme_Click);
            // 
            // Button_DelOrder
            // 
            this.Button_DelOrder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_DelOrder.Image = global::MES.form.Properties.Resources._32_balloonica_057;
            this.Button_DelOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_DelOrder.Location = new System.Drawing.Point(120, 5);
            this.Button_DelOrder.Name = "Button_DelOrder";
            this.Button_DelOrder.Size = new System.Drawing.Size(108, 30);
            this.Button_DelOrder.TabIndex = 6;
            this.Button_DelOrder.Text = "删除订单";
            this.Button_DelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_DelOrder.UseVisualStyleBackColor = true;
            this.Button_DelOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = global::MES.form.Properties.Resources._32_balloonica_054;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(576, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "查看/修改";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Button_NoScheme
            // 
            this.Button_NoScheme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_NoScheme.Image = global::MES.form.Properties.Resources._32_balloonica_046;
            this.Button_NoScheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_NoScheme.Location = new System.Drawing.Point(462, 5);
            this.Button_NoScheme.Name = "Button_NoScheme";
            this.Button_NoScheme.Size = new System.Drawing.Size(108, 30);
            this.Button_NoScheme.TabIndex = 3;
            this.Button_NoScheme.Text = "建立新方案";
            this.Button_NoScheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_NoScheme.UseVisualStyleBackColor = true;
            this.Button_NoScheme.Click += new System.EventHandler(this.Button_NoScheme_Click);
            // 
            // Button_M
            // 
            this.Button_M.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_M.Image = global::MES.form.Properties.Resources._32_balloonica_028;
            this.Button_M.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_M.Location = new System.Drawing.Point(348, 5);
            this.Button_M.Name = "Button_M";
            this.Button_M.Size = new System.Drawing.Size(108, 30);
            this.Button_M.TabIndex = 2;
            this.Button_M.Text = "指定方案";
            this.Button_M.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_M.UseVisualStyleBackColor = true;
            this.Button_M.Click += new System.EventHandler(this.Button_M_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = global::MES.form.Properties.Resources.No;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(690, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_A
            // 
            this.Button_A.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_A.Image = global::MES.form.Properties.Resources.wangyuanjing;
            this.Button_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_A.Location = new System.Drawing.Point(234, 5);
            this.Button_A.Name = "Button_A";
            this.Button_A.Size = new System.Drawing.Size(108, 30);
            this.Button_A.TabIndex = 1;
            this.Button_A.Text = "找最佳方案";
            this.Button_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_A.UseVisualStyleBackColor = true;
            this.Button_A.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(908, 281);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SelectScheme_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button_A;
        private MyContrals.ExDataGridView exDataGridView1;
        private System.Windows.Forms.Button Button_NoScheme;
        private System.Windows.Forms.Button Button_M;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_DelOrder;
        private System.Windows.Forms.Button Button_DelScheme;
    }
}