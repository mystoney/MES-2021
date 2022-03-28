namespace MES.form.CabinetLight
{
    partial class CabinetMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CabinetMain));
            this.txPanel1 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GridWorkSite = new MyContrals.ExDataGridView();
            this.txButton3 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.GridCabinetLight = new MyContrals.ExDataGridView();
            this.txButton6 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton5 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton4 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridWorkSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCabinetLight)).BeginInit();
            this.SuspendLayout();
            // 
            // txPanel1
            // 
            this.txPanel1.BackColor = System.Drawing.Color.Transparent;
            this.txPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel1.Controls.Add(this.splitContainer1);
            this.txPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel1.Location = new System.Drawing.Point(0, 0);
            this.txPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.txPanel1.Name = "txPanel1";
            this.txPanel1.Size = new System.Drawing.Size(1354, 721);
            this.txPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 721);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.GridWorkSite);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txButton3);
            this.splitContainer2.Panel2.Controls.Add(this.txButton2);
            this.splitContainer2.Panel2.Controls.Add(this.txButton1);
            this.splitContainer2.Panel2MinSize = 40;
            this.splitContainer2.Size = new System.Drawing.Size(469, 721);
            this.splitContainer2.SplitterDistance = 676;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // GridWorkSite
            // 
            this.GridWorkSite.AllowUserToAddRows = false;
            this.GridWorkSite.AllowUserToDeleteRows = false;
            this.GridWorkSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridWorkSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridWorkSite.Location = new System.Drawing.Point(0, 0);
            this.GridWorkSite.Margin = new System.Windows.Forms.Padding(4);
            this.GridWorkSite.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridWorkSite.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridWorkSite.MergeColumnNames")));
            this.GridWorkSite.Name = "GridWorkSite";
            this.GridWorkSite.RowHeadersVisible = false;
            this.GridWorkSite.RowTemplate.Height = 27;
            this.GridWorkSite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridWorkSite.Size = new System.Drawing.Size(469, 676);
            this.GridWorkSite.TabIndex = 1;
            this.GridWorkSite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridWorkSite_CellClick);
            // 
            // txButton3
            // 
            this.txButton3.Image = null;
            this.txButton3.Location = new System.Drawing.Point(145, 4);
            this.txButton3.Margin = new System.Windows.Forms.Padding(4);
            this.txButton3.Name = "txButton3";
            this.txButton3.Size = new System.Drawing.Size(133, 31);
            this.txButton3.TabIndex = 2;
            this.txButton3.Text = "修改";
            this.txButton3.UseVisualStyleBackColor = true;
            this.txButton3.Click += new System.EventHandler(this.txButton3_Click_1);
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(286, 4);
            this.txButton2.Margin = new System.Windows.Forms.Padding(4);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(133, 31);
            this.txButton2.TabIndex = 1;
            this.txButton2.Text = "删除";
            this.txButton2.UseVisualStyleBackColor = true;
            this.txButton2.Click += new System.EventHandler(this.txButton2_Click);
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(4, 4);
            this.txButton1.Margin = new System.Windows.Forms.Padding(4);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(133, 31);
            this.txButton1.TabIndex = 0;
            this.txButton1.Text = "新增";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click_1);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.GridCabinetLight);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txButton6);
            this.splitContainer3.Panel2.Controls.Add(this.txButton5);
            this.splitContainer3.Panel2.Controls.Add(this.txButton4);
            this.splitContainer3.Panel2MinSize = 40;
            this.splitContainer3.Size = new System.Drawing.Size(880, 721);
            this.splitContainer3.SplitterDistance = 676;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // GridCabinetLight
            // 
            this.GridCabinetLight.AllowUserToAddRows = false;
            this.GridCabinetLight.AllowUserToDeleteRows = false;
            this.GridCabinetLight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCabinetLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCabinetLight.Location = new System.Drawing.Point(0, 0);
            this.GridCabinetLight.Margin = new System.Windows.Forms.Padding(4);
            this.GridCabinetLight.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridCabinetLight.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridCabinetLight.MergeColumnNames")));
            this.GridCabinetLight.Name = "GridCabinetLight";
            this.GridCabinetLight.RowHeadersVisible = false;
            this.GridCabinetLight.RowTemplate.Height = 27;
            this.GridCabinetLight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCabinetLight.Size = new System.Drawing.Size(880, 676);
            this.GridCabinetLight.TabIndex = 0;
            // 
            // txButton6
            // 
            this.txButton6.Image = null;
            this.txButton6.Location = new System.Drawing.Point(164, 4);
            this.txButton6.Margin = new System.Windows.Forms.Padding(4);
            this.txButton6.Name = "txButton6";
            this.txButton6.Size = new System.Drawing.Size(133, 31);
            this.txButton6.TabIndex = 3;
            this.txButton6.Text = "修改";
            this.txButton6.UseVisualStyleBackColor = true;
            this.txButton6.Click += new System.EventHandler(this.txButton6_Click);
            // 
            // txButton5
            // 
            this.txButton5.Image = null;
            this.txButton5.Location = new System.Drawing.Point(306, 4);
            this.txButton5.Margin = new System.Windows.Forms.Padding(4);
            this.txButton5.Name = "txButton5";
            this.txButton5.Size = new System.Drawing.Size(133, 31);
            this.txButton5.TabIndex = 2;
            this.txButton5.Text = "删除";
            this.txButton5.UseVisualStyleBackColor = true;
            this.txButton5.Click += new System.EventHandler(this.txButton5_Click);
            // 
            // txButton4
            // 
            this.txButton4.Image = null;
            this.txButton4.Location = new System.Drawing.Point(23, 4);
            this.txButton4.Margin = new System.Windows.Forms.Padding(4);
            this.txButton4.Name = "txButton4";
            this.txButton4.Size = new System.Drawing.Size(133, 31);
            this.txButton4.TabIndex = 1;
            this.txButton4.Text = "新增";
            this.txButton4.UseVisualStyleBackColor = true;
            this.txButton4.Click += new System.EventHandler(this.txButton4_Click);
            // 
            // CabinetMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 721);
            this.Controls.Add(this.txPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CabinetMain";
            this.Text = "CabinetMain";
            this.Load += new System.EventHandler(this.CabinetMain_Load);
            this.txPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridWorkSite)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCabinetLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXPanel txPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MyContrals.ExDataGridView GridWorkSite;
        private TX.Framework.WindowUI.Controls.TXButton txButton3;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MyContrals.ExDataGridView GridCabinetLight;
        private TX.Framework.WindowUI.Controls.TXButton txButton6;
        private TX.Framework.WindowUI.Controls.TXButton txButton5;
        private TX.Framework.WindowUI.Controls.TXButton txButton4;
    }
}