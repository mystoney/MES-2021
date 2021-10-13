using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SocketHelper;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data.Odbc;


namespace MES.Services
{
    
    public partial class FrmServer : Form
    {
        private int i=1;


        TCPServer server;
        private List<PadClient> Pad_list = new List<PadClient>(); //记录连接进来的IP与PORT的列表,同时还要记录这个IP的工作站号
        private System.Data.Odbc.OdbcConnection EtonConn;

        public FrmServer()
        {
            InitializeComponent();
            //掩耳盗铃线程控制UI控件
            CheckForIllegalCrossThreadCalls = false;
            DelegateHelper.TcpServerErrorMsg = ErrorMsgData;
            DelegateHelper.TcpServerReceive = ReceviedData;
            DelegateHelper.TcpServerStateInfo = StateInfoData;
            DelegateHelper.ReturnClientCountCallBack = GetClientCount;
            DelegateHelper.TcpServerAddClient = AddClient;
            DelegateHelper.TcpServerDelClient = DelClient;
        }

        private void BtnCon_Click(object sender, EventArgs e)
        {
            server = new TCPServer(int.Parse(TxtPort.Text));
            server.Start();
        }


        private void GetClientCount(string count)
        {
            try
            {
                label5.Text = (string.Format("客户端数量：{0}", count));
            }
            catch
            {
            }
        }

        private void ReceviedData(Socket temp, string msg)
        {
            try
            {
                ArrayList PadMsg = new ArrayList();

                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                MsgInfomationList.Items.Add(string.Format("IP：{0}-端口：{1}=>发来消息：{2}", ip, port, msg));

                //根据发送来的消息与吊挂厂家的信息进行通信
                PublicClass.ProcessMsg(server, PublicClass.Factory, msg, ref Pad_list, ip, Convert.ToInt32(port));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private void StateInfoData(string msg)
        {
            try
            {
                StateInfoList.Items.Add(string.Format("状态消息：{0}", msg));
            }
            catch
            {
            }
        }
        private void ErrorMsgData(string msg)
        {
            try
            {
                ErrorMsgList.Items.Add(string.Format("错误消息：{0}", msg));
            }
            catch
            {
            }
        }



        private void AddClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                ClientList.Items.Add(string.Format("{0}:{1}", ip, port));



            }
            catch
            {
            }
        }

        private void DelClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                ClientList.Items.Remove(string.Format("{0}:{1}", ip, port));


                //
                PublicClass.DeletePadIP(ref Pad_list, ip, Convert.ToInt16(port));



            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(client =>
            {
                try
                {
                    FrmClient frmClent = new FrmClient();
                    frmClent.ShowDialog();
                }
                catch
                {
                }
            });
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server != null)
                server.Stop();
            System.Environment.Exit(0);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (ClientList.SelectedItem != null)
            {
                try
                {
                    string[] strArr = ClientList.Items[ClientList.SelectedIndex].ToString().Split(':');
                    server.SendData(strArr[0], int.Parse(strArr[1]), TxtSendMsg.Text);
                }
                catch
                {
                }
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            PublicClass.Factory = "01";
            EtonConn = DataClass.GetEtonConnect(System.Configuration.ConfigurationManager.AppSettings["EtonServer"].ToString().Replace(";", ""), System.Configuration.ConfigurationManager.AppSettings["EtonDB"].ToString().Replace(";", "").Replace("\\", "/"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.TxtSendMsg.Text = "00000000LKAL\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.MsgInfomationList.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("客户端列表:" + Pad_list.Count);
            foreach (PadClient PadC in Pad_list)
            {
                Console.WriteLine("      IP:{0},PORT:{1},LINE:{2},station:{3}", PadC.IP, PadC.PORT, PadC.LINE, PadC.Station);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] strArr = ClientList.Items[ClientList.SelectedIndex].ToString().Split(':');

            for (int i = 0; i <= 120; i++)
            {
                if (i < 10)
                {
                    this.TxtSendMsg.Text = "0000000" + Convert.ToString(i) + "LACK\r\n";

                }
                else if (i < 100)
                {
                    this.TxtSendMsg.Text = "000000" + Convert.ToString(i) + "LACK\r\n";

                }
                else if (i < 1000)
                {
                    this.TxtSendMsg.Text = "00000" + Convert.ToString(i) + "LACK\r\n";

                }

                server.SendData(strArr[0], int.Parse(strArr[1]), TxtSendMsg.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;

            OdbcCommand Odbccmd = new OdbcCommand();
            OdbcDataAdapter OdbcDA = new OdbcDataAdapter();

            DataTable dt = new DataTable();

            StringBuilder cmd = new StringBuilder();

            Odbccmd.Connection = EtonConn;

            cmd.AppendLine("select a.id,a.railload,a.nextwp,a.prun,b.operation,b.logtime");
            cmd.AppendLine("from prodclam a left join");
            cmd.AppendLine("    logclamp b on a.id = b.clamp and a.nextwp = b.nextwp and a.seqno = b.seqno");
            cmd.AppendLine("where a.railload <> 0 and b.logtime > 0 and a.railload<> a.nextwp");
            cmd.AppendLine("     group by a.id,a.railload,a.nextwp,a.prun,b.operation,b.logtime");
            cmd.AppendLine("     order by a.railload,b.logtime");


            Odbccmd.CommandText = cmd.ToString();

            OdbcDA.SelectCommand = Odbccmd;

            OdbcDA.Fill(dt);



            if (Pad_list.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine(dt.Rows[i]["railload"].ToString());
                    //PublicClass.SendMsg(server, ref Pad_list, "000000" , dt.Rows[i]["railload"].ToString(), "MYMESSTATMA" + dt.Rows[i]["prun"].ToString().PadLeft(12, '0') + dt.Rows[i]["operation"].ToString().PadLeft(10, '0') + "/r/n");
                    PublicClass.SendMsg(server, ref Pad_list, "000000", dt.Rows[i]["railload"].ToString(), "MYMESSTATMA" +  dt.Rows[i]["id"].ToString().PadLeft(10, '0') + "/r/n");
                }

            }
            this.timer1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (i % 2 == 0)
            {
                PublicClass.SendMsg(server, ref Pad_list, "000000", "1001", "MYMESSTATMA0012345678" + "/r/n");
            }
            else
            {
                PublicClass.SendMsg(server, ref Pad_list, "000000", "1001", "MYMESSTATMA0023456789" + "/r/n");
            }

            i++;

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.timer2.Interval = 1000;
            this.timer2.Enabled = true;
        }
    }
}
