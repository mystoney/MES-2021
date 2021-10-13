namespace MES.form.Station
{
    partial class StationAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationAdd));
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txComboBox1 = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.txTextBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Line = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonNo.Location = new System.Drawing.Point(143, 136);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(90, 25);
            this.ButtonNo.TabIndex = 4;
            this.ButtonNo.Text = "取消";
            this.ButtonNo.UseVisualStyleBackColor = false;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonYes.Location = new System.Drawing.Point(47, 136);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(90, 25);
            this.ButtonYes.TabIndex = 3;
            this.ButtonYes.Text = "确定";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "产能(小时)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(103, 96);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(0, 23);
            this.textBox4.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(31, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "生产线：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txComboBox1
            // 
            this.txComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txComboBox1.FormattingEnabled = true;
            this.txComboBox1.Location = new System.Drawing.Point(103, 58);
            this.txComboBox1.Name = "txComboBox1";
            this.txComboBox1.Size = new System.Drawing.Size(140, 25);
            this.txComboBox1.TabIndex = 2;
            this.txComboBox1.SelectedIndexChanged += new System.EventHandler(this.txComboBox1_SelectedIndexChanged);
            // 
            // txTextBox1
            // 
            this.txTextBox1.Location = new System.Drawing.Point(103, 92);
            this.txTextBox1.Name = "txTextBox1";
            this.txTextBox1.Size = new System.Drawing.Size(140, 23);
            this.txTextBox1.TabIndex = 40;
            this.txTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTextBox1_KeyPress);
            // 
            // textBox_Line
            // 
            this.textBox_Line.Location = new System.Drawing.Point(103, 58);
            this.textBox_Line.Name = "textBox_Line";
            this.textBox_Line.Size = new System.Drawing.Size(140, 23);
            this.textBox_Line.TabIndex = 41;
            this.textBox_Line.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTextBox1_KeyPress);
            // 
            // StationAdd
            // 
            this.AcceptButton = this.ButtonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 177);
            this.Controls.Add(this.textBox_Line);
            this.Controls.Add(this.txTextBox1);
            this.Controls.Add(this.txComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StationAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加工作站";
            this.Load += new System.EventHandler(this.StationAdd_Load);
            this.Enter += new System.EventHandler(this.ButtonYes_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private TX.Framework.WindowUI.Controls.TXComboBox txComboBox1;
        private System.Windows.Forms.TextBox txTextBox1;
        private System.Windows.Forms.TextBox textBox_Line;
    }
}