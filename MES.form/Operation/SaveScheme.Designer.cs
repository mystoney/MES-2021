namespace MES.form.Operation
{
    partial class SaveScheme
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
            this.Button_Cancle = new System.Windows.Forms.Button();
            this.Button_Commit = new System.Windows.Forms.Button();
            this.checkBox_State = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Cancle
            // 
            this.Button_Cancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Cancle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Cancle.Image = global::MES.form.Properties.Resources.No;
            this.Button_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Cancle.Location = new System.Drawing.Point(153, 141);
            this.Button_Cancle.Name = "Button_Cancle";
            this.Button_Cancle.Size = new System.Drawing.Size(81, 30);
            this.Button_Cancle.TabIndex = 3;
            this.Button_Cancle.Text = "取消";
            this.Button_Cancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Cancle.UseVisualStyleBackColor = true;
            this.Button_Cancle.Click += new System.EventHandler(this.Button_Cancle_Click);
            // 
            // Button_Commit
            // 
            this.Button_Commit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Commit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Commit.Image = global::MES.form.Properties.Resources.Yes;
            this.Button_Commit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Commit.Location = new System.Drawing.Point(66, 141);
            this.Button_Commit.Name = "Button_Commit";
            this.Button_Commit.Size = new System.Drawing.Size(81, 30);
            this.Button_Commit.TabIndex = 2;
            this.Button_Commit.Text = "确定";
            this.Button_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Commit.UseVisualStyleBackColor = true;
            this.Button_Commit.Click += new System.EventHandler(this.Button_Commit_Click);
            // 
            // checkBox_State
            // 
            this.checkBox_State.AutoSize = true;
            this.checkBox_State.Location = new System.Drawing.Point(10, 114);
            this.checkBox_State.Name = "checkBox_State";
            this.checkBox_State.Size = new System.Drawing.Size(276, 16);
            this.checkBox_State.TabIndex = 4;
            this.checkBox_State.Text = "保留原最佳方案(不选择时默认设置为最佳方案)";
            this.checkBox_State.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "请给此方案填写说明信息(可不填)：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 84);
            this.textBox1.TabIndex = 7;
            // 
            // SaveScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(296, 179);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_State);
            this.Controls.Add(this.Button_Cancle);
            this.Controls.Add(this.Button_Commit);
            this.Name = "SaveScheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancle;
        private System.Windows.Forms.Button Button_Commit;
        private System.Windows.Forms.CheckBox checkBox_State;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}