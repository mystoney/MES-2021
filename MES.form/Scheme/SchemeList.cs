using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.form.Scheme
{
    class SchemeList
    {

        string _style_no;

        int _SchemeNo;
        int _Eton_Line;
        int _Eton_WorkStation;
        string _OpCodeAlpha1;
        int _GST_xh;
        string _operation_addr;
        string _operation_des;
        string _price = "0.00";
        string _Time_unit="s";
        string _OpQualityRequirement;
        string _StyleQualityRequirement;
        string _Technology_picture;
        string _standard_time="0";
        string _EQ_ID;
        string _EQ_des;
        string _GST_gxDJ;
        string _GST_XCBJ;
        string _GST_GZDM;
        string _op_type;













        //主表 MES_station_operation_master
        public string style_no
        {
            get
            {
                return _style_no;
            }
            set
            {
                _style_no = value;
            }
        }


        //子表 MES_station_operation_detail
        public int SchemeNo
        {
            get
            {
                return _SchemeNo;
            }
            set
            {
                _SchemeNo = value;
            }
        }
        public int Eton_Line
        {
            get
            {
                return _Eton_Line;
            }
            set
            {
                _Eton_Line = value;
            }
        }
        public int Eton_WorkStation
        {
            get
            {
                return _Eton_WorkStation;
            }
            set
            {
                _Eton_WorkStation = value;
            }
        }
        public int GST_xh
        {
            get
            {
                return _GST_xh;
            }
            set
            {
                _GST_xh = value;
            }
        }
        public string OpCodeAlpha1
        {
            get
            {
                return _OpCodeAlpha1;
            }
            set
            {
                _OpCodeAlpha1 = value;
            }
        }
        public string operation_addr
        {
            get
            {
                return _operation_addr;
            }
            set
            {
                _operation_addr = value;
            }
        }
        public string operation_des
        {
            get
            {
                return _operation_des;
            }
            set
            {
                _operation_des = value;
            }
        }
        public string price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Time_unit
        {
            get
            {
                return _Time_unit;
            }
            set
            {
                _Time_unit = value;
            }
        }
        public string OpQualityRequirement
        {
            get
            {
                return _OpQualityRequirement;
            }
            set
            {
                _OpQualityRequirement = value;
            }
        }
        public string StyleQualityRequirement
        {
            get
            {
                return _StyleQualityRequirement;
            }
            set
            {
                _StyleQualityRequirement = value;
            }
        }
        public string Technology_picture
        {
            get
            {
                return _Technology_picture;
            }
            set
            {
                _Technology_picture = value;
            }
        }
        public string standard_time
        {
            get
            {
                return _standard_time;
            }
            set
            {
                _standard_time = value;
            }
        }
        public string EQ_ID
        {
            get
            {
                return _EQ_ID;
            }
            set
            {
                _EQ_ID = value;
            }
        }
        public string EQ_des
        {
            get
            {
                return _EQ_des;
            }
            set
            {
                _EQ_des = value;
            }
        }
        public string GST_gxDJ
        {
            get
            {
                return _GST_gxDJ;
            }
            set
            {
                _GST_gxDJ = value;
            }
        }
        public string GST_XCBJ
        {
            get
            {
                return _GST_XCBJ;
            }
            set
            {
                _GST_XCBJ = value;
            }
        }
        public string GST_GZDM
        {
            get
            {
                return _GST_GZDM;
            }
            set
            {
                _GST_GZDM = value;
            }
        }
        public string op_type
        {
            get
            {
                return _op_type;
            }
            set
            {
                _op_type = value;
            }
        }



    }
}


