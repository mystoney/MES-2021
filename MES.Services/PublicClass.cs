using SocketHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MES.Services
{
    class PublicClass
    {


        private static string _factory; //哪个厂家的MES

        /// <summary>
        /// 设置哪个生产厂家的MES，0-ETON
        /// </summary>
        public static string Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }


        /// <summary>
        /// 此方法将得到ETON的信息转换成ArrayList数组
        /// </summary>
        /// <param name="msg">要转换的信息</param>
        /// <returns>ArrayList[0]取出标志位，ArrayList[1]取出数据位</returns>
        public static ArrayList Client_msg(string msg)
        {
            string[] s;



            s = Regex.Split(msg, "MYMES");

            ArrayList ss = new ArrayList();

            //s[0]为空
            ss.Add(s[1].ToString().Substring(0, 4));    //取得命令的类型
            ss.Add(s[1].ToString().Substring(4, 6).Trim());    //取得生产线
            ss.Add(s[1].ToString().Substring(10, 6));   //取得工作站

            return ss;
        }




        /// <summary>
        /// 处理PAD传到服务器的信息
        /// </summary>
        /// <param name="server">server服务</param>
        /// <param name="FactoryID">工厂ID</param>
        /// <param name="msg">Pad传入服务器的信息</param>
        /// <param name="Pad_list">记录有所有PAD的List列表</param>
        /// <param name="IP">PAD的IP</param>
        /// <param name="Port">PAD的端口号</param>
        /// <param name="Line">生产线编号</param>
        /// <param name="Station">工作站编号</param>
        public static void ProcessMsg(TCPServer server, string FactoryID, string msg, ref List<PadClient> Pad_list, string IP = "", int Port = 0, string Line = "", string Station = "")
        {
            string s;
            ArrayList PadMsg = new ArrayList();

            s = "";
            PadMsg = Client_msg(msg);

            if (FactoryID == "01") //铱滕吊挂在此处理
            {
                if (PadMsg[0].ToString() == "STAR")  //说明是PAD向SERVER提出请求上线，将PAD的IP、端口、生产线、工作站都写入到Pad_List列表
                {
                    InsertPadIP(ref Pad_list, IP, Port, PadMsg[1].ToString(), Convert.ToInt32(PadMsg[2]).ToString());
                    s = ReMsg(FactoryID, "RE" + PadMsg[0].ToString());
                    server.SendData(IP, Port, s);
                }

            }

        }

        /// <summary>
        /// 按工厂ID与消息类型生成回复信息
        /// </summary>
        /// <param name="FactoryID">工厂ID</param>
        /// <param name="MsgType">消息类型</param>
        /// <returns>生成的回复信息</returns>
        private static string ReMsg(string FactoryID, string MsgType)
        {
            string s;
            s = "";

            if (FactoryID == "01") //铱滕吊挂在此处理
            {
                if (MsgType == "RESTAR")  //说明是回复STAR信息
                {
                    s = "MYMES" + MsgType + "01" + "\r\n";
                }

            }


            return s;
        }



        /// <summary>
        /// 将PAD端的连接插入到List列表中
        /// </summary>
        /// <param name="Pad_list">记录有所有PAD的List列表</param>
        /// <param name="IP">PAD的IP</param>
        /// <param name="Port">PAD的端口号</param>
        /// <param name="Line">生产线编号,铱滕为""</param>
        /// <param name="Station">工作站编号</param>
        private static void InsertPadIP(ref List<PadClient> Pad_list, string IP, int Port = 0, string Line = "", string Station = "")
        {

            PadClient PC = new PadClient(IP, Port, Line, Station);
            List<PadClient> PC1 = SelectIPS(Pad_list, IP, 0, Line, Station);
            if (PC1 != null)
            {
                for (int i = 0; i < PC1.Count; i++)
                {
                    Pad_list.Remove(PC1[i]);
                }

            }

            Pad_list.Add(PC);
        }

        public static void DeletePadIP(ref List<PadClient> Pad_list, string IP, int Port = 0, string Line = "", string Station = "")
        {
            List<PadClient> PC1 = SelectIPS(Pad_list, IP, 0, "", "");
            if (PC1 != null)
            {
                for (int i = 0; i < PC1.Count; i++)
                {
                    Pad_list.Remove(PC1[i]);
                }

            }
            return;
        }



        /// <summary>
        /// 判断IP与端口是否存在于PAD_List中
        /// </summary>
        /// <param name="Pad_List">被查询的Pad_list</param>
        /// <param name="IP">需要在列表中查找的IP,IP不为""时先按照IP查询</param>
        /// <param name="Port">需要查找的端口号，如果为0则表示不需要查询端口号</param>
        /// <param name="Line">生产线编号，如果IP为"",则以生产线与工作站查找，铱滕为""</param>
        /// <param name="station">工作站编号</param>
        /// <returns>返回找到的ClientIPPort的泛型数组，如果没找到则返回null</returns>
        private static List<PadClient> SelectIPS(List<PadClient> Pad_list, string IP = "", int Port = 0, string Line = "", string station = "")
        {

            List<PadClient> PCA = new List<PadClient>();

            if (IP != "")
            {
                foreach (PadClient PC in Pad_list)
                {
                    if (PC.IP == IP && (Port == 0 ? true : PC.PORT == Convert.ToInt32(Port)))
                    {

                        PCA.Add(PC);

                    }
                }
            }


            if (station != "")
            {
                foreach (PadClient PC in Pad_list)
                {
                    if (PC.Station == station && PC.LINE == Line)
                    {

                        PCA.Add(PC);
                    }
                }
            }

            if (PCA.Count > 0)
            {
                return PCA;
            }
            else
            {
                return null;
            }


        }


        public static void SendMsg(TCPServer server, PadClient PC, string Message)
        {

            server.SendData(PC.IP, PC.PORT, Message);

        }
        public static void SendMsg(TCPServer server, ref List<PadClient> Pad_list, string Line, string Station, string Message)
        {
            List<PadClient> PC = SelectIPS(Pad_list, "", 0, Line, Station);
            if (PC != null)
            {
                for (int i = 0; i < PC.Count; i++)
                {
                    server.SendData(PC[i].IP, PC[i].PORT, Message);
                }

            }


        }
    }
}
