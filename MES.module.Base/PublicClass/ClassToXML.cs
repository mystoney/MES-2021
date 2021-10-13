using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MES.module.Base.PublicClass
{
    public static class ClassToXML
    {
        /// <summary>  
      /// 类转xml字符串  
      /// </summary>  
      /// <typeparam name="T"></typeparam>  
      /// <param name="key"></param>  
      /// <param name="source"></param>  
        public static string ClassToXml<T>(List<T> source)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, source);
            return sw.ToString();
        }
    }
}
