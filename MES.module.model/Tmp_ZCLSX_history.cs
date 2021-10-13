using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：SAP导入过来的Tmp_ZCLSX历史表(bom信息历史表)数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZCLSX_history:Tmp_ZCLSX
    {

        

        public new int id { get; set; }







        ///// <summary>
        ///// 生产订单号
        ///// </summary>

        //public string AUFNR { get; set; }







        ///// <summary>
        ///// 材料编号
        ///// </summary>

        //public string MATNR { get; set; }







        ///// <summary>
        ///// 材料描述
        ///// </summary>

        //public string MAKTX { get; set; }







        ///// <summary>
        ///// 物料类型
        ///// </summary>

        //public string MTART { get; set; }







        ///// <summary>
        ///// 物料类型描述
        ///// </summary>

        //public string MTBEZ { get; set; }







        ///// <summary>
        ///// 物料组
        ///// </summary>

        //public string MATKL { get; set; }







        ///// <summary>
        ///// 物料组描述
        ///// </summary>

        //public string WGBEZ { get; set; }







        ///// <summary>
        ///// 单件用量
        ///// </summary>

        //public string MENGE { get; set; }







        ///// <summary>
        ///// 订单需求数量
        ///// </summary>

        //public string BDMNG { get; set; }


        public DateTime input_date { get; set; }

    }
}
