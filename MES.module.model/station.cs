using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    /// <summary>
    /// 对象名称：Station表（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：周玉磬
    /// 编写日期：2016/12/18 18:45:12
    /// </summary>
    [Serializable]
    public class Station
    {

        public int id { get; set; }

        /// <summary>
        /// 工作站编号
        /// </summary>
        public int Eton_WorkStation { get; set; }

        /// <summary>
        /// 生产线编号
        /// </summary>
        public int Eton_Line { get; set; }

        /// <summary>        /// 工作站锁定 1不锁定 2锁定        /// </summary>        public int EQLock { get; set; }

        /// <summary>        /// 状态 1启用 0停用        /// </summary>        public string state { get; set; }
   



    }
   


}
