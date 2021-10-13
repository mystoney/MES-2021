using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：SAP导入过来的Tmp_ZMTMFILL_history表(充绒表历史)数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZTMTM_COMCTRL_LOG : Tmp_ZTMTM_COMCTRL
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
