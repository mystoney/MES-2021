using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：SAP导入过来的SAP_ZTMTM_COMREL表数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/19 11:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZTMTM_COMREL
    {

        public int id { get; set; }







        /// <summary>        /// 品类编号        /// </summary>
        public string CATCD { get; set; }







        /// <summary>        /// 款号        /// </summary>
        public string STYNU { get; set; }







        /// <summary>        /// 部件编号        /// </summary>
        public string COMCD { get; set; }







        /// <summary>        /// 部件类型        /// </summary>
        public string COMTY { get; set; }







        /// <summary>        /// 选项编号        /// </summary>
        public string OPTNO { get; set; }







        /// <summary>        /// 成衣尺寸        /// </summary>
        public string ZSIZE { get; set; }







        /// <summary>        /// 附加属性         /// </summary>
        public string ZADDATT { get; set; }







        /// <summary>        /// 品类        /// </summary>
        public string CATGY { get; set; }







        /// <summary>        /// 部件        /// </summary>
        public string COMPT { get; set; }







        /// <summary>        /// 部件选项        /// </summary>
        public string COMOP { get; set; }







        /// <summary>        /// 物料号        /// </summary>
        public string MATCO { get; set; }







        /// <summary>        /// 选项描述        /// </summary>
        public string OPTDS { get; set; }







        /// <summary>        /// 选项英文描述        /// </summary>
        public string OPTED { get; set; }







        /// <summary>        /// 关键物料        /// </summary>
        public string KEYCOM { get; set; }







        /// <summary>        /// 款式用量        /// </summary>
        public decimal AMOUNT { get; set; }







        /// <summary>        /// 浮动价格        /// </summary>
        public decimal OPTPR { get; set; }







        /// <summary>        /// 初始默认        /// </summary>
        public string INITOP { get; set; }







        /// <summary>        /// 开放定制         /// </summary>
        public string CUSTOM { get; set; }







        /// <summary>        /// 是否展示        /// </summary>
        public string DISPL { get; set; }







        /// <summary>        /// 前台显示顺序        /// </summary>
        public string DISOD { get; set; }







        /// <summary>        /// 处理日期        /// </summary>
        public DateTime ERDAT { get; set; }







        /// <summary>        /// 处理时间        /// </summary>
        public DateTime ERZET { get; set; }







        /// <summary>        /// 创建人         /// </summary>
        public string UNAME { get; set; }







        /// <summary>        /// 备注        /// </summary>
        public string ZREFA { get; set; }







        /// <summary>        /// 状态         /// </summary>
        public string STATS { get; set; }

    }
}
