namespace 测试项目
{
    partial class WaitingForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbWaitingTip = new System.Windows.Forms.Label();
            this.WaitingProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LbWaitingTip
            // 
            this.LbWaitingTip.AutoSize = true;
            this.LbWaitingTip.Location = new System.Drawing.Point(46, 50);
            this.LbWaitingTip.Name = "LbWaitingTip";
            this.LbWaitingTip.Size = new System.Drawing.Size(55, 15);
            this.LbWaitingTip.TabIndex = 0;
            this.LbWaitingTip.Text = "label1";
            // 
            // WaitingProgressBar
            // 
            this.WaitingProgressBar.Location = new System.Drawing.Point(107, 42);
            this.WaitingProgressBar.Name = "WaitingProgressBar";
            this.WaitingProgressBar.Size = new System.Drawing.Size(328, 23);
            this.WaitingProgressBar.TabIndex = 1;
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 305);
            this.Controls.Add(this.WaitingProgressBar);
            this.Controls.Add(this.LbWaitingTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitingForm";
            this.Text = "WaitingForm";
            this.Load += new System.EventHandler(this.WaitingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label LbWaitingTip;
        public System.Windows.Forms.ProgressBar WaitingProgressBar;
    }
}