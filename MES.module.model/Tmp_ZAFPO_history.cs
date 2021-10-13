using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：SAP导入过来的Tmp_ZAFPO_history表(生产订单信息历史表)数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZAFPO_history:Tmp_ZAFPO
    {

        public new int id { get; set; }







        ///// <summary>
        ///// 生产订单号
        ///// </summary>

        //public string AUFNR { get; set; }







        ///// <summary>
        ///// 销售订单号
        ///// </summary>

        //public string KDAUF { get; set; }







        ///// <summary>
        ///// 销售订单行号
        ///// </summary>

        //public int KUPOS { get; set; }







        ///// <summary>
        ///// 订单类型
        ///// </summary>

        //public string AUART { get; set; }







        ///// <summary>
        ///// 生产订单状态
        ///// </summary>

        //public string STAT { get; set; }







        ///// <summary>
        ///// 计划开始日期
        ///// </summary>

        //public DateTime ZGSTRP { get; set; }







        ///// <summary>
        ///// 生产工厂
        ///// </summary>

        //public string PWERK { get; set; }







        ///// <summary>
        ///// 款号
        ///// </summary>

        //public string ZZSTYLE { get; set; }







        ///// <summary>
        ///// 物料号
        ///// </summary>

        //public string MATNR { get; set; }







        ///// <summary>
        ///// 物料描述
        ///// </summary>

        //public string MAKTX { get; set; }







        ///// <summary>
        ///// 网格
        ///// </summary>

        //public string J_3ASIZE { get; set; }







        ///// <summary>
        ///// 网格数量
        ///// </summary>

        //public decimal MENGE { get; set; }







        ///// <summary>
        ///// 定制部件组合码
        ///// </summary>

        //public string ZCODE { get; set; }







        /// <summary>
        /// 插入到历史表的日期
        /// </summary>

        public DateTime input_date { get; set; }

    }
}
