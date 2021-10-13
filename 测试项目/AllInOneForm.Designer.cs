namespace 测试项目
{
    partial class AllInOneForm
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
            this.AllInOneBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.BtStart = new System.Windows.Forms.Button();
            this.BtStop = new System.Windows.Forms.Button();
            this.LbTip = new System.Windows.Forms.Label();
            this.AllInOneProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AllInOneBackgroundWorker
            // 
            this.AllInOneBackgroundWorker.WorkerReportsProgress = true;
            this.AllInOneBackgroundWorker.WorkerSupportsCancellation = true;
            // 
            // BtStart
            // 
            this.BtStart.Location = new System.Drawing.Point(142, 196);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(75, 23);
            this.BtStart.TabIndex = 0;
            this.BtStart.Text = "启动";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // BtStop
            // 
            this.BtStop.Location = new System.Drawing.Point(283, 196);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(75, 23);
            this.BtStop.TabIndex = 1;
            this.BtStop.Text = "停止";
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // LbTip
            // 
            this.LbTip.AutoSize = true;
            this.LbTip.Location = new System.Drawing.Point(97, 106);
            this.LbTip.Name = "LbTip";
            this.LbTip.Size = new System.Drawing.Size(47, 15);
            this.LbTip.TabIndex = 2;
            this.LbTip.Text = "LbTip";
            // 
            // AllInOneProgressBar
            // 
            this.AllInOneProgressBar.Location = new System.Drawing.Point(158, 102);
            this.AllInOneProgressBar.Name = "AllInOneProgressBar";
            this.AllInOneProgressBar.Size = new System.Drawing.Size(296, 27);
            this.AllInOneProgressBar.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AllInOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 288);
            this.Controls.Add(this.AllInOneProgressBar);
            this.Controls.Add(this.LbTip);
            this.Controls.Add(this.BtStop);
            this.Controls.Add(this.BtStart);
            this.Name = "AllInOneForm";
            this.Text = "AllInOneForm";
            this.Load += new System.EventHandler(this.AllInOneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker AllInOneBackgroundWorker;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Label LbTip;
        private System.Windows.Forms.ProgressBar AllInOneProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}