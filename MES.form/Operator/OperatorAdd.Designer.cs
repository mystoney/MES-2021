
namespace MES.form.Operator
{
    partial class OperatorAdd
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
            this.textBox_OperatorID = new System.Windows.Forms.TextBox();
            this.TextBox_OperatorName = new System.Windows.Forms.TextBox();
            this.txComboBox1 = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.textBox_OperatorPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_OperatorType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_OperatorID
            // 
            this.textBox_OperatorID.Location = new System.Drawing.Point(120, 46);
            this.textBox_OperatorID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_OperatorID.Name = "textBox_OperatorID";
            this.textBox_OperatorID.Size = new System.Drawing.Size(185, 25);
            this.textBox_OperatorID.TabIndex = 1;
            this.textBox_OperatorID.Tag = "用户名";
            // 
            // TextBox_OperatorName
            // 
            this.TextBox_OperatorName.Location = new System.Drawing.Point(120, 89);
            this.TextBox_OperatorName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_OperatorName.Name = "TextBox_OperatorName";
            this.TextBox_OperatorName.Size = new System.Drawing.Size(185, 25);
            this.TextBox_OperatorName.TabIndex = 2;
            this.TextBox_OperatorName.Tag = "员工姓名";
            // 
            // txComboBox1
            // 
            this.txComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txComboBox1.FormattingEnabled = true;
            this.txComboBox1.Location = new System.Drawing.Point(120, 46);
            this.txComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.txComboBox1.Name = "txComboBox1";
            this.txComboBox1.Size = new System.Drawing.Size(185, 23);
            this.txComboBox1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "姓  名：";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(139, 94);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(0, 27);
            this.textBox4.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(43, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "账  号：";
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonNo.Location = new System.Drawing.Point(185, 213);
            this.ButtonNo.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(120, 31);
            this.ButtonNo.TabIndex = 5;
            this.ButtonNo.Text = "取消";
            this.ButtonNo.UseVisualStyleBackColor = false;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonYes.Location = new System.Drawing.Point(57, 213);
            this.ButtonYes.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(120, 31);
            this.ButtonYes.TabIndex = 4;
            this.ButtonYes.Text = "确定";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // textBox_OperatorPassword
            // 
            this.textBox_OperatorPassword.Location = new System.Drawing.Point(120, 132);
            this.textBox_OperatorPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_OperatorPassword.Name = "textBox_OperatorPassword";
            this.textBox_OperatorPassword.PasswordChar = '*';
            this.textBox_OperatorPassword.Size = new System.Drawing.Size(185, 25);
            this.textBox_OperatorPassword.TabIndex = 3;
            this.textBox_OperatorPassword.Tag = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "密  码：";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(139, 136);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 27);
            this.textBox2.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(43, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "工  种：";
            // 
            // cb_OperatorType
            // 
            this.cb_OperatorType.FormattingEnabled = true;
            this.cb_OperatorType.Items.AddRange(new object[] {
            "平缝",
            "辅助"});
            this.cb_OperatorType.Location = new System.Drawing.Point(120, 175);
            this.cb_OperatorType.Name = "cb_OperatorType";
            this.cb_OperatorType.Size = new System.Drawing.Size(185, 23);
            this.cb_OperatorType.TabIndex = 54;
            // 
            // OperatorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 284);
            this.Controls.Add(this.cb_OperatorType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_OperatorPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_OperatorID);
            this.Controls.Add(this.TextBox_OperatorName);
            this.Controls.Add(this.txComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OperatorAdd";
            this.Text = "增加操作员";
            this.Load += new System.EventHandler(this.OperatorAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_OperatorID;
        private System.Windows.Forms.TextBox TextBox_OperatorName;
        private TX.Framework.WindowUI.Controls.TXComboBox txComboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.TextBox textBox_OperatorPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_OperatorType;
    }
}