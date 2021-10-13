using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MES.module.Base.PublicClass
{
    public class XMLToClass
    {  
        /// <summary>  
       /// xml字符串转类  
       /// </summary>  
       /// <typeparam name="T"></typeparam>  
       /// <param name="key"></param>  
       /// <returns></returns>  
        public static T CXMLToClass<T>(string msg)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringReader sr = new StringReader(msg);


            try
            {
                return (T)serializer.Deserialize(sr);
            }
            catch (Exception )
            {

                throw;
            }
            
            //
        }


        /// <summary>  
        /// xml字符串转类  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="key"></param>  
        /// <returns></returns>  
        public static List<T> CXMLToList<T>(string msg)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            StringReader sr = new StringReader(msg);


            try
            {
                return (List<T>)serializer.Deserialize(sr);
            }
            catch (Exception )
            {

                return null;
            }

            //return (T)serializer.Deserialize(sr);
        }
    }
}
