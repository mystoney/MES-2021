
namespace MES.form.Style
{
    partial class StyleAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.tb_StyleList = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.tb_ItemList = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_OptionList = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.GridOptionItem = new MyContrals.ExDataGridView();
            this.GridCombination = new MyContrals.ExDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOptionItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCombination)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "选项";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "款号";
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonNo.Location = new System.Drawing.Point(304, 3);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(90, 25);
            this.ButtonNo.TabIndex = 41;
            this.ButtonNo.Text = "取消";
            this.ButtonNo.UseVisualStyleBackColor = false;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonYes.Location = new System.Drawing.Point(208, 3);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(90, 25);
            this.ButtonYes.TabIndex = 40;
            this.ButtonYes.Text = "确定";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // tb_StyleList
            // 
            this.tb_StyleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_StyleList.FormattingEnabled = true;
            this.tb_StyleList.Location = new System.Drawing.Point(63, 14);
            this.tb_StyleList.Name = "tb_StyleList";
            this.tb_StyleList.Size = new System.Drawing.Size(150, 20);
            this.tb_StyleList.TabIndex = 44;
            this.tb_StyleList.SelectedIndexChanged += new System.EventHandler(this.tb_StyleList_SelectedIndexChanged);
            // 
            // tb_ItemList
            // 
            this.tb_ItemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_ItemList.FormattingEnabled = true;
            this.tb_ItemList.Location = new System.Drawing.Point(63, 40);
            this.tb_ItemList.Name = "tb_ItemList";
            this.tb_ItemList.Size = new System.Drawing.Size(150, 20);
            this.tb_ItemList.TabIndex = 45;
            this.tb_ItemList.SelectedIndexChanged += new System.EventHandler(this.tb_ItemList_SelectedIndexChanged);
            this.tb_ItemList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.txComboBox2_Format);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(224, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 48;
            this.button1.Text = "增加此选项";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(320, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 49;
            this.button2.Text = "删除此选项";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(224, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 51;
            this.button3.Text = "加载款号";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(320, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 25);
            this.button4.TabIndex = 52;
            this.button4.Text = "加载选项";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.tb_OptionList);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.tb_StyleList);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.tb_ItemList);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(894, 534);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 53;
            // 
            // tb_OptionList
            // 
            this.tb_OptionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_OptionList.FormattingEnabled = true;
            this.tb_OptionList.Location = new System.Drawing.Point(63, 66);
            this.tb_OptionList.Name = "tb_OptionList";
            this.tb_OptionList.Size = new System.Drawing.Size(150, 20);
            this.tb_OptionList.TabIndex = 54;
            this.tb_OptionList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.tb_OptionList_Format);
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer2.Panel2.Controls.Add(this.ButtonYes);
            this.splitContainer2.Panel2.Controls.Add(this.ButtonNo);
            this.splitContainer2.Size = new System.Drawing.Size(894, 434);
            this.splitContainer2.SplitterDistance = 399;
            this.splitContainer2.TabIndex = 0;
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
            this.splitContainer3.Panel1.Controls.Add(this.GridOptionItem);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.GridCombination);
            this.splitContainer3.Size = new System.Drawing.Size(894, 399);
            this.splitContainer3.SplitterDistance = 500;
            this.splitContainer3.TabIndex = 0;
            // 
            // GridOptionItem
            // 
            this.GridOptionItem.AllowUserToAddRows = false;
            this.GridOptionItem.AllowUserToDeleteRows = false;
            this.GridOptionItem.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOptionItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridOptionItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridOptionItem.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridOptionItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOptionItem.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.GridOptionItem.Location = new System.Drawing.Point(0, 0);
            this.GridOptionItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridOptionItem.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOptionItem.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOptionItem.MergeColumnNames")));
            this.GridOptionItem.Name = "GridOptionItem";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOptionItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridOptionItem.RowHeadersVisible = false;
            this.GridOptionItem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.GridOptionItem.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridOptionItem.RowTemplate.Height = 23;
            this.GridOptionItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOptionItem.Size = new System.Drawing.Size(500, 399);
            this.GridOptionItem.TabIndex = 8;
            // 
            // GridCombination
            // 
            this.GridCombination.AllowUserToAddRows = false;
            this.GridCombination.AllowUserToDeleteRows = false;
            this.GridCombination.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCombination.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridCombination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCombination.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridCombination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCombination.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.GridCombination.Location = new System.Drawing.Point(0, 0);
            this.GridCombination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridCombination.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridCombination.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridCombination.MergeColumnNames")));
            this.GridCombination.Name = "GridCombination";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCombination.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridCombination.RowHeadersVisible = false;
            this.GridCombination.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.GridCombination.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridCombination.RowTemplate.Height = 23;
            this.GridCombination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCombination.Size = new System.Drawing.Size(390, 399);
            this.GridCombination.TabIndex = 9;
            // 
            // StyleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 568);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StyleAdd";
            this.Text = "款式必要选项管理";
            this.Load += new System.EventHandler(this.StyleAdd_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridOptionItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCombination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Button ButtonYes;
        private TX.Framework.WindowUI.Controls.TXComboBox tb_StyleList;
        private TX.Framework.WindowUI.Controls.TXComboBox tb_ItemList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private TX.Framework.WindowUI.Controls.TXComboBox tb_OptionList;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MyContrals.ExDataGridView GridOptionItem;
        private MyContrals.ExDataGridView GridCombination;
    }
}