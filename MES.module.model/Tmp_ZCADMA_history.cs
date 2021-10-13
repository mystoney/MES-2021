using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：SAP导入过来的Tmp_ZCADMA_history表(面料信息历史表)数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZCADMA_history:Tmp_ZCADMA
    {

        public new int id { get; set; }







        ///// <summary>
        ///// 生产订单号
        ///// </summary>

        //public string AUFNR { get; set; }







        ///// <summary>
        ///// 面料编号
        ///// </summary>

        //public string MATNR { get; set; }







        ///// <summary>
        ///// 面料描述
        ///// </summary>

        //public string MAKTX { get; set; }







        ///// <summary>
        ///// 纹理
        ///// </summary>

        //public string ZZTEXTURE { get; set; }







        ///// <summary>
        ///// 幅宽
        ///// </summary>

        //public string ZZBREADTH { get; set; }







        ///// <summary>
        ///// 单位
        ///// </summary>

        //public string MEINS { get; set; }


        public DateTime input_date { get; set; }

    }
}
