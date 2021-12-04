
namespace MES.form.Scheme
{
    partial class SchemeSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemeSelect));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_StyleList = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GridCombinationList = new MyContrals.ExDataGridView();
            this.GridSchemeList = new MyContrals.ExDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_EditMemo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCombinationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSchemeList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 31);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.tb_StyleList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer2.Size = new System.Drawing.Size(794, 416);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "款  号";
            // 
            // tb_StyleList
            // 
            this.tb_StyleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_StyleList.FormattingEnabled = true;
            this.tb_StyleList.Location = new System.Drawing.Point(58, 13);
            this.tb_StyleList.Name = "tb_StyleList";
            this.tb_StyleList.Size = new System.Drawing.Size(156, 20);
            this.tb_StyleList.TabIndex = 75;
            this.tb_StyleList.SelectedIndexChanged += new System.EventHandler(this.tb_StyleList_SelectedIndexChanged);
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer8.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer8.Panel2.Controls.Add(this.bt_EditMemo);
            this.splitContainer8.Panel2.Controls.Add(this.button1);
            this.splitContainer8.Panel2.Controls.Add(this.button2);
            this.splitContainer8.Size = new System.Drawing.Size(794, 372);
            this.splitContainer8.SplitterDistance = 338;
            this.splitContainer8.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.GridCombinationList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridSchemeList);
            this.splitContainer1.Size = new System.Drawing.Size(794, 338);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // GridCombinationList
            // 
            this.GridCombinationList.AllowUserToAddRows = false;
            this.GridCombinationList.AllowUserToDeleteRows = false;
            this.GridCombinationList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridCombinationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCombinationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCombinationList.Location = new System.Drawing.Point(0, 0);
            this.GridCombinationList.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridCombinationList.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridCombinationList.MergeColumnNames")));
            this.GridCombinationList.Name = "GridCombinationList";
            this.GridCombinationList.RowHeadersVisible = false;
            this.GridCombinationList.RowTemplate.Height = 27;
            this.GridCombinationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCombinationList.Size = new System.Drawing.Size(794, 200);
            this.GridCombinationList.TabIndex = 5;
            this.GridCombinationList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridCombinationList_CellMouseClick);
            // 
            // GridSchemeList
            // 
            this.GridSchemeList.AllowUserToAddRows = false;
            this.GridSchemeList.AllowUserToDeleteRows = false;
            this.GridSchemeList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridSchemeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSchemeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSchemeList.Location = new System.Drawing.Point(0, 0);
            this.GridSchemeList.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridSchemeList.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridSchemeList.MergeColumnNames")));
            this.GridSchemeList.Name = "GridSchemeList";
            this.GridSchemeList.RowHeadersVisible = false;
            this.GridSchemeList.RowTemplate.Height = 27;
            this.GridSchemeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSchemeList.Size = new System.Drawing.Size(794, 134);
            this.GridSchemeList.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "取 消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 79;
            this.button2.Text = "确 定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_EditMemo
            // 
            this.bt_EditMemo.Location = new System.Drawing.Point(3, 4);
            this.bt_EditMemo.Name = "bt_EditMemo";
            this.bt_EditMemo.Size = new System.Drawing.Size(75, 23);
            this.bt_EditMemo.TabIndex = 82;
            this.bt_EditMemo.Text = "编辑备注";
            this.bt_EditMemo.UseVisualStyleBackColor = true;
            this.bt_EditMemo.Click += new System.EventHandler(this.bt_EditMemo_Click);
            // 
            // SchemeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "SchemeSelect";
            this.Text = "SchemeSelect";
            this.Load += new System.EventHandler(this.SchemeSelect_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCombinationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSchemeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private TX.Framework.WindowUI.Controls.TXComboBox tb_StyleList;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyContrals.ExDataGridView GridCombinationList;
        private MyContrals.ExDataGridView GridSchemeList;
        private System.Windows.Forms.Button bt_EditMemo;
    }
}