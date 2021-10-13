namespace 测试项目
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.exDataGridView1 = new MyContrals.ExDataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(573, 218);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exDataGridView1
            // 
            this.exDataGridView1.AllowUserToAddRows = false;
            this.exDataGridView1.AllowUserToDeleteRows = false;
            this.exDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exDataGridView1.Location = new System.Drawing.Point(818, 207);
            this.exDataGridView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.exDataGridView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("exDataGridView1.MergeColumnNames")));
            this.exDataGridView1.Name = "exDataGridView1";
            this.exDataGridView1.RowHeadersVisible = false;
            this.exDataGridView1.RowTemplate.Height = 27;
            this.exDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exDataGridView1.Size = new System.Drawing.Size(351, 247);
            this.exDataGridView1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(874, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 680);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.exDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private MyContrals.ExDataGridView exDataGridView1;
        private System.Windows.Forms.Button button3;
    }
}