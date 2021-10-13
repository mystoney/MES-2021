using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：SAP导入过来的Tmp_ZMTMFILL表(充绒表)数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZMTMFILL
    {

        public int id { get; set; }







        /// <summary>
        /// 订单号
        /// </summary>

        public string AUFNR { get; set; }







        /// <summary>
        /// 款号
        /// </summary>

        public string STYNU { get; set; }







        /// <summary>
        /// 品类编号
        /// </summary>

        public string CATCD { get; set; }







        /// <summary>
        /// 网格值
        /// </summary>

        public string ZSIZE { get; set; }







        /// <summary>
        /// 填充物编号
        /// </summary>

        public string ZSTUFNO { get; set; }







        /// <summary>
        /// 填充物
        /// </summary>

        public string ZSTUF { get; set; }







        /// <summary>
        /// 部位
        /// </summary>

        public string ZPART { get; set; }







        /// <summary>
        /// 绒道
        /// </summary>

        public int ZLINE { get; set; }







        /// <summary>
        /// 面积
        /// </summary>

        public decimal ZSQURE { get; set; }







        /// <summary>
        /// 克重
        /// </summary>

        public decimal ZGRAMS { get; set; }







        /// <summary>
        /// 充绒量
        /// </summary>

        public decimal ZQUANT { get; set; }







        /// <summary>
        /// 累计
        /// </summary>

        public decimal ZCUML { get; set; }

    }
}
