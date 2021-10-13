using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：SAP导入过来的Tmp_ZBTDATA表(量体信息表)数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZBTDATA
    {

        public int id { get; set; }







        /// <summary>
        /// 生产订单号
        /// </summary>

        public string AUFNR { get; set; }







        /// <summary>
        /// 量体部位
        /// </summary>

        public string ZPART { get; set; }







        /// <summary>
        /// 尺寸
        /// </summary>

        public string ZMMTS { get; set; }

    }
}
