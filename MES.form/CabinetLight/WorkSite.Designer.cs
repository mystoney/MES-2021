namespace MES.form.CabinetLight
{
    partial class WorkSite
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
            this.tbCabinetId = new System.Windows.Forms.TextBox();
            this.tbSiteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCabinetId
            // 
            this.tbCabinetId.Location = new System.Drawing.Point(102, 67);
            this.tbCabinetId.Name = "tbCabinetId";
            this.tbCabinetId.Size = new System.Drawing.Size(140, 21);
            this.tbCabinetId.TabIndex = 1;
            // 
            // tbSiteName
            // 
            this.tbSiteName.Location = new System.Drawing.Point(102, 101);
            this.tbSiteName.Name = "tbSiteName";
            this.tbSiteName.Size = new System.Drawing.Size(140, 21);
            this.tbSiteName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "站点名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "柜子ID：";
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonNo.Location = new System.Drawing.Point(142, 145);
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
            this.ButtonYes.Location = new System.Drawing.Point(46, 145);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(90, 25);
            this.ButtonYes.TabIndex = 3;
            this.ButtonYes.Text = "确定";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID：";
            // 
            // WorkSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCabinetId);
            this.Controls.Add(this.tbSiteName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Name = "WorkSite";
            this.Text = "WorkSite";
            this.Load += new System.EventHandler(this.WorkSite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCabinetId;
        private System.Windows.Forms.TextBox tbSiteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Label label1;
    }
}