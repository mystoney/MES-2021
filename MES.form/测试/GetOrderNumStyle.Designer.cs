namespace MES.form.测试
{
    partial class GetOrderNumStyle
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
            this.txTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.Style = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txTextBox1
            // 
            this.txTextBox1.Location = new System.Drawing.Point(104, 49);
            this.txTextBox1.Name = "txTextBox1";
            this.txTextBox1.Size = new System.Drawing.Size(140, 21);
            this.txTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "输入工单号";
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonNo.Location = new System.Drawing.Point(144, 120);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(90, 25);
            this.ButtonNo.TabIndex = 3;
            this.ButtonNo.Text = "取消";
            this.ButtonNo.UseVisualStyleBackColor = false;
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonYes.Location = new System.Drawing.Point(48, 120);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(90, 25);
            this.ButtonYes.TabIndex = 2;
            this.ButtonYes.Text = "确定";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "款号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(183, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "数量";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.BackColor = System.Drawing.Color.Transparent;
            this.Num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num.Location = new System.Drawing.Point(221, 91);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(32, 17);
            this.Num.TabIndex = 48;
            this.Num.Text = "数量";
            // 
            // Style
            // 
            this.Style.AutoSize = true;
            this.Style.BackColor = System.Drawing.Color.Transparent;
            this.Style.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Style.Location = new System.Drawing.Point(70, 91);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(32, 17);
            this.Style.TabIndex = 47;
            this.Style.Text = "款号";
            // 
            // GetOrderNumStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 160);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Style);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.MaximizeBox = false;
            this.Name = "GetOrderNumStyle";
            this.Text = "GetOrderNumStyle";
            this.Load += new System.EventHandler(this.GetOrderNumStyle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label Style;
    }
}