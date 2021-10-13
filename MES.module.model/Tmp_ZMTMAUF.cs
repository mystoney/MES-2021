using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{

    /// <summary>
    /// 对象名称：SAP导入过来的Tmp_ZMTMAUF表(生产订单定制信息表)数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Tmp_ZMTMAUF
    {

        public int id { get; set; }







        /// <summary>
        /// 生产订单号
        /// </summary>

        public string AUFNR { get; set; }






        /// <summary>
        /// 品类编号
        /// </summary>

        public string CATCD { get; set; }







        /// <summary>
        /// 定制部件编码
        /// </summary>

        public string COMCD { get; set; }







        /// <summary>
        /// 部件类型
        /// </summary>

        public string COMTY { get; set; }







        /// <summary>
        /// 选项编码 
        /// </summary>

        public string OPTNO { get; set; }







        /// <summary>
        /// 物料编码
        /// </summary>

        public string MATCO { get; set; }







        /// <summary>
        /// 备注
        /// </summary>

        public string NOTEP { get; set; }

    }
}
