
namespace MES.form.Scheme
{
    partial class ExcellImport_Operation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_PushToCAOBO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.TextBox28 = new System.Windows.Forms.TextBox();
            this.lb_StyleNo = new System.Windows.Forms.Label();
            this.lb_CombinationNo = new System.Windows.Forms.Label();
            this.lb_Combination_memo_no = new System.Windows.Forms.Label();
            this.lb_Combination_memo_name = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Grid_detail = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 665);
            this.panel1.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.button_PushToCAOBO);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDownload);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonImport);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox28);
            this.splitContainer1.Panel1.Controls.Add(this.lb_StyleNo);
            this.splitContainer1.Panel1.Controls.Add(this.lb_CombinationNo);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Combination_memo_no);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Combination_memo_name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 665);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 11;
            // 
            // button_PushToCAOBO
            // 
            this.button_PushToCAOBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PushToCAOBO.Enabled = false;
            this.button_PushToCAOBO.Location = new System.Drawing.Point(1061, 33);
            this.button_PushToCAOBO.Name = "button_PushToCAOBO";
            this.button_PushToCAOBO.Size = new System.Drawing.Size(114, 23);
            this.button_PushToCAOBO.TabIndex = 124;
            this.button_PushToCAOBO.Text = "重试推送至生产线";
            this.button_PushToCAOBO.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 123;
            this.button1.Text = "选择款号及选项值";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(559, 32);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(90, 23);
            this.buttonDownload.TabIndex = 122;
            this.buttonDownload.Text = "下载模板";
            this.buttonDownload.UseVisualStyleBackColor = true;
            // 
            // ButtonImport
            // 
            this.ButtonImport.Location = new System.Drawing.Point(463, 32);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(90, 23);
            this.ButtonImport.TabIndex = 121;
            this.ButtonImport.Text = "选择文件";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // TextBox28
            // 
            this.TextBox28.Location = new System.Drawing.Point(3, 33);
            this.TextBox28.Name = "TextBox28";
            this.TextBox28.Size = new System.Drawing.Size(454, 21);
            this.TextBox28.TabIndex = 120;
            // 
            // lb_StyleNo
            // 
            this.lb_StyleNo.AutoSize = true;
            this.lb_StyleNo.Location = new System.Drawing.Point(177, 8);
            this.lb_StyleNo.Name = "lb_StyleNo";
            this.lb_StyleNo.Size = new System.Drawing.Size(29, 12);
            this.lb_StyleNo.TabIndex = 116;
            this.lb_StyleNo.Text = "款号";
            // 
            // lb_CombinationNo
            // 
            this.lb_CombinationNo.AutoSize = true;
            this.lb_CombinationNo.Location = new System.Drawing.Point(244, 8);
            this.lb_CombinationNo.Name = "lb_CombinationNo";
            this.lb_CombinationNo.Size = new System.Drawing.Size(65, 12);
            this.lb_CombinationNo.TabIndex = 117;
            this.lb_CombinationNo.Text = "选项组合号";
            // 
            // lb_Combination_memo_no
            // 
            this.lb_Combination_memo_no.AutoSize = true;
            this.lb_Combination_memo_no.Location = new System.Drawing.Point(332, 4);
            this.lb_Combination_memo_no.Name = "lb_Combination_memo_no";
            this.lb_Combination_memo_no.Size = new System.Drawing.Size(53, 12);
            this.lb_Combination_memo_no.TabIndex = 118;
            this.lb_Combination_memo_no.Text = "选项组合";
            // 
            // lb_Combination_memo_name
            // 
            this.lb_Combination_memo_name.AutoSize = true;
            this.lb_Combination_memo_name.Location = new System.Drawing.Point(332, 18);
            this.lb_Combination_memo_name.Name = "lb_Combination_memo_name";
            this.lb_Combination_memo_name.Size = new System.Drawing.Size(77, 12);
            this.lb_Combination_memo_name.TabIndex = 119;
            this.lb_Combination_memo_name.Text = "选项组合说明";
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
            this.splitContainer2.Panel1.Controls.Add(this.Grid_detail);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Size = new System.Drawing.Size(1178, 606);
            this.splitContainer2.SplitterDistance = 571;
            this.splitContainer2.TabIndex = 0;
            // 
            // Grid_detail
            // 
            this.Grid_detail.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_detail.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_detail.Location = new System.Drawing.Point(0, 0);
            this.Grid_detail.Name = "Grid_detail";
            this.Grid_detail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_detail.RowTemplate.Height = 23;
            this.Grid_detail.Size = new System.Drawing.Size(1178, 571);
            this.Grid_detail.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 124;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 123;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExcellImport_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 699);
            this.Controls.Add(this.panel1);
            this.Name = "ExcellImport_Operation";
            this.Text = "ExcellImport_Operation";
            this.Load += new System.EventHandler(this.ExcellImport_Operation_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button buttonDownload;
        internal System.Windows.Forms.Button ButtonImport;
        internal System.Windows.Forms.TextBox TextBox28;
        private System.Windows.Forms.Label lb_StyleNo;
        private System.Windows.Forms.Label lb_CombinationNo;
        private System.Windows.Forms.Label lb_Combination_memo_no;
        private System.Windows.Forms.Label lb_Combination_memo_name;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView Grid_detail;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button_PushToCAOBO;
    }
}