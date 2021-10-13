
namespace MES.form.Scheme.Operations
{
    partial class OperationsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button_YES = new System.Windows.Forms.Button();
            this.GridOPList = new MyContrals.ExDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOPList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 416);
            this.panel1.TabIndex = 1;
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
            this.splitContainer2.Panel1.Controls.Add(this.GridOPList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button_YES);
            this.splitContainer2.Size = new System.Drawing.Size(794, 416);
            this.splitContainer2.SplitterDistance = 381;
            this.splitContainer2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 124;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_YES
            // 
            this.button_YES.Location = new System.Drawing.Point(318, 2);
            this.button_YES.Name = "button_YES";
            this.button_YES.Size = new System.Drawing.Size(90, 23);
            this.button_YES.TabIndex = 123;
            this.button_YES.Text = "确定";
            this.button_YES.UseVisualStyleBackColor = true;
            this.button_YES.Click += new System.EventHandler(this.button3_Click);
            // 
            // GridOPList
            // 
            this.GridOPList.AllowUserToAddRows = false;
            this.GridOPList.AllowUserToDeleteRows = false;
            this.GridOPList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOPList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridOPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridOPList.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridOPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOPList.Location = new System.Drawing.Point(0, 0);
            this.GridOPList.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.GridOPList.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("GridOPList.MergeColumnNames")));
            this.GridOPList.MultiSelect = false;
            this.GridOPList.Name = "GridOPList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridOPList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridOPList.RowHeadersVisible = false;
            this.GridOPList.RowTemplate.Height = 27;
            this.GridOPList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOPList.Size = new System.Drawing.Size(794, 381);
            this.GridOPList.TabIndex = 4;
            this.GridOPList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridOPList_CellClick);
            // 
            // OperationsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OperationsMain";
            this.Text = "工序清单管理";
            this.Load += new System.EventHandler(this.OperationsMain_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridOPList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button_YES;
        private MyContrals.ExDataGridView GridOPList;
    }
}