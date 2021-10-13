
namespace MES.form.Scheme
{
    partial class SchemeSave
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
            this.checkBox_State = new System.Windows.Forms.CheckBox();
            this.Button_Cancle = new System.Windows.Forms.Button();
            this.Button_Commit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_State
            // 
            this.checkBox_State.AutoSize = true;
            this.checkBox_State.Location = new System.Drawing.Point(77, 94);
            this.checkBox_State.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_State.Name = "checkBox_State";
            this.checkBox_State.Size = new System.Drawing.Size(277, 21);
            this.checkBox_State.TabIndex = 9;
            this.checkBox_State.Text = "保留原最佳方案(不选择时默认设置为最佳方案)";
            this.checkBox_State.UseVisualStyleBackColor = true;
            // 
            // Button_Cancle
            // 
            this.Button_Cancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Cancle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Cancle.Image = global::MES.form.Properties.Resources.No;
            this.Button_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Cancle.Location = new System.Drawing.Point(193, 119);
            this.Button_Cancle.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Cancle.Name = "Button_Cancle";
            this.Button_Cancle.Size = new System.Drawing.Size(108, 30);
            this.Button_Cancle.TabIndex = 8;
            this.Button_Cancle.Text = "取消";
            this.Button_Cancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Cancle.UseVisualStyleBackColor = true;
            this.Button_Cancle.Click += new System.EventHandler(this.Button_Cancle_Click);
            // 
            // Button_Commit
            // 
            this.Button_Commit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Commit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Commit.Image = global::MES.form.Properties.Resources.Yes;
            this.Button_Commit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Commit.Location = new System.Drawing.Point(77, 119);
            this.Button_Commit.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Commit.Name = "Button_Commit";
            this.Button_Commit.Size = new System.Drawing.Size(108, 30);
            this.Button_Commit.TabIndex = 7;
            this.Button_Commit.Text = "确定";
            this.Button_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Commit.UseVisualStyleBackColor = true;
            this.Button_Commit.Click += new System.EventHandler(this.Button_Commit_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 80);
            this.textBox3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "方案备注";
            // 
            // SchemeSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(367, 162);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox_State);
            this.Controls.Add(this.Button_Cancle);
            this.Controls.Add(this.Button_Commit);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SchemeSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "方案信息：";
            this.Load += new System.EventHandler(this.SchemeSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_State;
        private System.Windows.Forms.Button Button_Cancle;
        private System.Windows.Forms.Button Button_Commit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}