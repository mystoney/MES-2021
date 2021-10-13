
namespace MES.form.Scheme
{
    partial class NewScheme
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
            this.ButtonImport = new System.Windows.Forms.Button();
            this.TextBox28 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Grid_master = new System.Windows.Forms.DataGridView();
            this.Grid_detail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonImport
            // 
            this.ButtonImport.Location = new System.Drawing.Point(463, 0);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(90, 23);
            this.ButtonImport.TabIndex = 111;
            this.ButtonImport.Text = "选择文件";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // TextBox28
            // 
            this.TextBox28.Location = new System.Drawing.Point(3, 1);
            this.TextBox28.Name = "TextBox28";
            this.TextBox28.Size = new System.Drawing.Size(454, 21);
            this.TextBox28.TabIndex = 109;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Azure;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.buttonDownload);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonImport);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox28);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Azure;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 729);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 114;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(559, 0);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(90, 23);
            this.buttonDownload.TabIndex = 112;
            this.buttonDownload.Text = "下载模板";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.Grid_master);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Grid_detail);
            this.splitContainer3.Size = new System.Drawing.Size(1008, 700);
            this.splitContainer3.SplitterDistance = 262;
            this.splitContainer3.TabIndex = 118;
            // 
            // Grid_master
            // 
            this.Grid_master.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Grid_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_master.Location = new System.Drawing.Point(0, 0);
            this.Grid_master.Name = "Grid_master";
            this.Grid_master.ReadOnly = true;
            this.Grid_master.RowTemplate.Height = 23;
            this.Grid_master.Size = new System.Drawing.Size(262, 700);
            this.Grid_master.TabIndex = 0;
            // 
            // Grid_detail
            // 
            this.Grid_detail.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_detail.Location = new System.Drawing.Point(0, 0);
            this.Grid_detail.Name = "Grid_detail";
            this.Grid_detail.ReadOnly = true;
            this.Grid_detail.RowTemplate.Height = 23;
            this.Grid_detail.Size = new System.Drawing.Size(742, 700);
            this.Grid_detail.TabIndex = 0;
            // 
            // NewScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.Name = "NewScheme";
            this.Text = "NewScheme";
            this.Load += new System.EventHandler(this.NewScheme_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button ButtonImport;
        internal System.Windows.Forms.TextBox TextBox28;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView Grid_master;
        private System.Windows.Forms.DataGridView Grid_detail;
    }
}