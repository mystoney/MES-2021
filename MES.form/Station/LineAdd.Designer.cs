namespace MES.form.Station
{
    partial class LineAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineAdd));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txTextBoxLine = new System.Windows.Forms.TextBox();
            this.txTextBoxStation = new System.Windows.Forms.TextBox();
            this.txTextBoxLineCapacity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(224, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(128, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "工作站默认状态为停用 请在使用前启用工作站";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(8, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "增加生产线同时请至少为此生产线添加一个工作站";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(140, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "工作站：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "生产线：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(265, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "设计产能(小时)：";
            // 
            // txTextBoxLine
            // 
            this.txTextBoxLine.Location = new System.Drawing.Point(72, 95);
            this.txTextBoxLine.Name = "txTextBoxLine";
            this.txTextBoxLine.Size = new System.Drawing.Size(60, 21);
            this.txTextBoxLine.TabIndex = 24;
            this.txTextBoxLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTextBoxLine_KeyPress);
            // 
            // txTextBoxStation
            // 
            this.txTextBoxStation.Location = new System.Drawing.Point(202, 95);
            this.txTextBoxStation.Name = "txTextBoxStation";
            this.txTextBoxStation.Size = new System.Drawing.Size(60, 21);
            this.txTextBoxStation.TabIndex = 25;
            this.txTextBoxStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTextBoxLine_KeyPress);
            // 
            // txTextBoxLineCapacity
            // 
            this.txTextBoxLineCapacity.Location = new System.Drawing.Point(371, 95);
            this.txTextBoxLineCapacity.Name = "txTextBoxLineCapacity";
            this.txTextBoxLineCapacity.Size = new System.Drawing.Size(60, 21);
            this.txTextBoxLineCapacity.TabIndex = 26;
            this.txTextBoxLineCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTextBoxLineCapacity_KeyPress);
            // 
            // LineAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 184);
            this.Controls.Add(this.txTextBoxLineCapacity);
            this.Controls.Add(this.txTextBoxStation);
            this.Controls.Add(this.txTextBoxLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LineAdd";
            this.Text = "增加生产线";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTextBoxLine;
        private System.Windows.Forms.TextBox txTextBoxStation;
        private System.Windows.Forms.TextBox txTextBoxLineCapacity;
    }
}