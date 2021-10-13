using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Services
{
    class PadClient

    {
        private string _IP; //IP
        private int _Port; //PORT
        private string _Line; //工作站编号
        private string _Station; //工作站编号


        public PadClient(string IP, int Port, string Line = "", string Station = "")
        {
            this._IP = IP;
            this._Port = Port;
            this._Line = Line;
            this._Station = Station;
        }

        //IP
        public string IP
        {
            get { return _IP; }
            //set { _IP = value;}
        }

        //端口
        public int PORT
        {
            get { return _Port; }
            set { _Port = value; }
        }

        //生产线
        public string LINE
        {
            get { return _Line; }
            set { _Line = value; }
        }

        //工作站 
        public string Station
        {
            get { return _Station; }
            set { _Station = value; }
        }



    }
}
