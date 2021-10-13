using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.model
{
    [Serializable]
    class Style
    {

        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Style_No { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Item_No { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Item_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Item_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Option_No { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string Option_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime sync_time { get; set; }




    }
}
