namespace MES.Services
{
    partial class FrmServer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSendMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMsgList = new System.Windows.Forms.ListBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.StateInfoList = new System.Windows.Forms.ListBox();
            this.MsgInfomationList = new System.Windows.Forms.ListBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnCon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtSendMsg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ErrorMsgList);
            this.panel1.Controls.Add(this.ClientList);
            this.panel1.Controls.Add(this.StateInfoList);
            this.panel1.Controls.Add(this.MsgInfomationList);
            this.panel1.Controls.Add(this.TxtPort);
            this.panel1.Controls.Add(this.TxtIp);
            this.panel1.Controls.Add(this.BtnSend);
            this.panel1.Controls.Add(this.BtnCon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 605);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Location = new System.Drawing.Point(963, 523);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 23);
            this.button7.TabIndex = 49;
            this.button7.Text = "开始TIMER";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(779, 525);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 23);
            this.button6.TabIndex = 48;
            this.button6.Text = "多线程测试";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(492, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(678, 525);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "LACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(27, 539);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 29);
            this.button4.TabIndex = 45;
            this.button4.Text = "显示客户端数量";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(951, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "清屏";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(582, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "LKAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 42;
            this.button1.Text = "启动客户端";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "错误信息列表";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "客户端列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "状态信息列表";
            // 
            // TxtSendMsg
            // 
            this.TxtSendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSendMsg.Location = new System.Drawing.Point(308, 555);
            this.TxtSendMsg.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSendMsg.Name = "TxtSendMsg";
            this.TxtSendMsg.Size = new System.Drawing.Size(676, 25);
            this.TxtSendMsg.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "服务IP";
            // 
            // ErrorMsgList
            // 
            this.ErrorMsgList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ErrorMsgList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ErrorMsgList.FormattingEnabled = true;
            this.ErrorMsgList.ItemHeight = 20;
            this.ErrorMsgList.Location = new System.Drawing.Point(309, 234);
            this.ErrorMsgList.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorMsgList.Name = "ErrorMsgList";
            this.ErrorMsgList.Size = new System.Drawing.Size(424, 284);
            this.ErrorMsgList.TabIndex = 32;
            // 
            // ClientList
            // 
            this.ClientList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 20;
            this.ClientList.Location = new System.Drawing.Point(28, 66);
            this.ClientList.Margin = new System.Windows.Forms.Padding(4);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(272, 444);
            this.ClientList.TabIndex = 34;
            // 
            // StateInfoList
            // 
            this.StateInfoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StateInfoList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StateInfoList.FormattingEnabled = true;
            this.StateInfoList.ItemHeight = 20;
            this.StateInfoList.Location = new System.Drawing.Point(309, 64);
            this.StateInfoList.Margin = new System.Windows.Forms.Padding(4);
            this.StateInfoList.Name = "StateInfoList";
            this.StateInfoList.Size = new System.Drawing.Size(424, 104);
            this.StateInfoList.TabIndex = 33;
            // 
            // MsgInfomationList
            // 
            this.MsgInfomationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgInfomationList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MsgInfomationList.FormattingEnabled = true;
            this.MsgInfomationList.ItemHeight = 20;
            this.MsgInfomationList.Location = new System.Drawing.Point(741, 63);
            this.MsgInfomationList.Margin = new System.Windows.Forms.Padding(4);
            this.MsgInfomationList.Name = "MsgInfomationList";
            this.MsgInfomationList.Size = new System.Drawing.Size(347, 444);
            this.MsgInfomationList.TabIndex = 35;
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(77, 13);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(103, 25);
            this.TxtPort.TabIndex = 30;
            this.TxtPort.Text = "28888";
            // 
            // TxtIp
            // 
            this.TxtIp.Location = new System.Drawing.Point(693, 15);
            this.TxtIp.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(132, 25);
            this.TxtIp.TabIndex = 31;
            this.TxtIp.Text = "127.0.0.1";
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(993, 553);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(100, 29);
            this.BtnSend.TabIndex = 28;
            this.BtnSend.Text = "发送数据";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnCon
            // 
            this.BtnCon.Location = new System.Drawing.Point(200, 9);
            this.BtnCon.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(100, 29);
            this.BtnCon.TabIndex = 29;
            this.BtnCon.Text = "启动监听";
            this.BtnCon.UseVisualStyleBackColor = true;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.Location = new System.Drawing.Point(452, 525);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 23);
            this.button8.TabIndex = 50;
            this.button8.Text = "开始TIMER";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 605);
            this.Controls.Add(this.panel1);
            this.Name = "FrmServer";
            this.Text = "FrmServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmServer_FormClosing);
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSendMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ErrorMsgList;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.ListBox StateInfoList;
        private System.Windows.Forms.ListBox MsgInfomationList;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnCon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer2;
    }
}