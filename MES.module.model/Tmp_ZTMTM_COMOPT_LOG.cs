using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    [Serializable]
    public class Tmp_ZTMTM_COMOPT_LOG: Tmp_ZTMTM_COMOPT
    {
        public new int id { get; set; }


        /// <summary>
        /// 插入历史表的时间
        /// </summary>

        public DateTime input_date { get; set; }

        /// <summary>
        /// 插入记录的状态
        /// </summary>
        public string state { get; set; }
    }
}
