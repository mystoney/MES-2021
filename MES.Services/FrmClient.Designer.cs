namespace MES.Services
{
    partial class FrmClient
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSendMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMsgList = new System.Windows.Forms.ListBox();
            this.StateInfoList = new System.Windows.Forms.ListBox();
            this.MsgInfomationList = new System.Windows.Forms.ListBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "压力测试";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "断开连接";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "错误信息列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "状态信息列表";
            // 
            // TxtSendMsg
            // 
            this.TxtSendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSendMsg.Location = new System.Drawing.Point(16, 547);
            this.TxtSendMsg.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSendMsg.Name = "TxtSendMsg";
            this.TxtSendMsg.Size = new System.Drawing.Size(640, 25);
            this.TxtSendMsg.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "服务IP";
            // 
            // ErrorMsgList
            // 
            this.ErrorMsgList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ErrorMsgList.FormattingEnabled = true;
            this.ErrorMsgList.ItemHeight = 15;
            this.ErrorMsgList.Location = new System.Drawing.Point(20, 380);
            this.ErrorMsgList.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorMsgList.Name = "ErrorMsgList";
            this.ErrorMsgList.Size = new System.Drawing.Size(237, 139);
            this.ErrorMsgList.TabIndex = 13;
            // 
            // StateInfoList
            // 
            this.StateInfoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StateInfoList.FormattingEnabled = true;
            this.StateInfoList.ItemHeight = 15;
            this.StateInfoList.Location = new System.Drawing.Point(20, 64);
            this.StateInfoList.Margin = new System.Windows.Forms.Padding(4);
            this.StateInfoList.Name = "StateInfoList";
            this.StateInfoList.Size = new System.Drawing.Size(237, 289);
            this.StateInfoList.TabIndex = 14;
            // 
            // MsgInfomationList
            // 
            this.MsgInfomationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgInfomationList.FormattingEnabled = true;
            this.MsgInfomationList.ItemHeight = 15;
            this.MsgInfomationList.Location = new System.Drawing.Point(266, 64);
            this.MsgInfomationList.Margin = new System.Windows.Forms.Padding(4);
            this.MsgInfomationList.Name = "MsgInfomationList";
            this.MsgInfomationList.Size = new System.Drawing.Size(497, 454);
            this.MsgInfomationList.TabIndex = 15;
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(266, 13);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(103, 25);
            this.TxtPort.TabIndex = 11;
            this.TxtPort.Text = "5100";
            // 
            // TxtIp
            // 
            this.TxtIp.Location = new System.Drawing.Point(80, 13);
            this.TxtIp.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(132, 25);
            this.TxtIp.TabIndex = 12;
            this.TxtIp.Text = "127.0.0.1";
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(665, 544);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(100, 29);
            this.BtnSend.TabIndex = 9;
            this.BtnSend.Text = "发送数据";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnCon
            // 
            this.BtnCon.Location = new System.Drawing.Point(390, 11);
            this.BtnCon.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(100, 29);
            this.BtnCon.TabIndex = 10;
            this.BtnCon.Text = "连接服务器";
            this.BtnCon.UseVisualStyleBackColor = true;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 654);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSendMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorMsgList);
            this.Controls.Add(this.StateInfoList);
            this.Controls.Add(this.MsgInfomationList);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.TxtIp);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnCon);
            this.Name = "FrmClient";
            this.Text = "FrmClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSendMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ErrorMsgList;
        private System.Windows.Forms.ListBox StateInfoList;
        private System.Windows.Forms.ListBox MsgInfomationList;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnCon;
    }
}