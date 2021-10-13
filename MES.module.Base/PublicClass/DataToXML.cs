using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.IO;
using System.Xml;
using System.Web;

namespace MES.module.Base.PublicClass
{
    /**//// <summary>
        /// 把DataSet、DataTable、DataView格式转换成XML字符串、XML文件
        /// </summary>
    public class DataToXML
    {
        /**//// <summary>
        /// DataTable转XML
        /// </summary>
        /// <param name="dt">要转换成XML的DataTable</param>
        /// <returns>返回XML文件的字符串</returns>
        public static string DataTableToXml(DataTable dt)
        {

            #region 屏蔽老代码
            //StringBuilder strXml = new StringBuilder();
            //strXml.AppendLine("<XmlTable>");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    strXml.AppendLine("<rows>");
            //    //strXml.AppendLine("<"+dt.TableName+">");
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        strXml.AppendLine("<" + dt.Columns[j].ColumnName + ">" + dt.Rows[i][j] + "</" + dt.Columns[j].ColumnName + ">");
            //    }
            //    strXml.AppendLine("</rows>");
            //    //strXml.AppendLine("</" + dt.TableName + ">");
            //}
            //strXml.AppendLine("</XmlTable>");
            //return strXml.ToString();
            #endregion

            if (null == dt) return string.Empty;
            StringWriter writer = new StringWriter();
            dt.WriteXml(writer);
            string xmlstr = writer.ToString();
            writer.Close();
            return xmlstr;
        }


        /**//// <summary>
            /// 将DataSet对象中指定的Table转换成XML字符串
            /// </summary>
            /// <param name="ds">DataSet对象</param>
            /// <param name="tableIndex">DataSet对象中的Table索引</param>
            /// <returns>XML字符串</returns>
        public static string CDataToXml(DataSet ds, int tableIndex)
        {
            if (tableIndex != -1)
            {

                return DataTableToXml(ds.Tables[tableIndex]);
            }
            else
            {
                return DataTableToXml(ds.Tables[0]);
            }
        }


        /**//// <summary>
        /// 将DataSet对象转换成XML字符串
        /// </summary>
        /// <param name="ds">DataSet对象</param>
        /// <returns>XML字符串</returns>
        public static string CDataToXml(DataSet ds)
        {
            //return CDataToXml(ds, -1);


            if (null == ds) return string.Empty;
            StringWriter writer = new StringWriter();
            ds.WriteXml(writer);
            string xmlstr = writer.ToString();
            writer.Close();
            return xmlstr;


        }


        /**//// <summary>
        /// 将DataView对象转换成XML字符串
        /// </summary>
        /// <param name="dv">DataView对象</param>
        /// <returns>XML字符串</returns>
        public static string CDataToXml(DataView dv)
        {
            return DataTableToXml(dv.Table);
        }


        /**//// <summary>
        /// 将DataSet对象数据保存为XML文件
        /// </summary>
        /// <param name="dt">DataSet</param>
        /// <param name="xmlFilePath">XML文件路径</param>
        /// <returns>bool值</returns>
        public static bool CDataToXmlFile(DataTable dt, string xmlFilePath)
        {
            if ((dt != null) && (!string.IsNullOrEmpty(xmlFilePath)))
            {

                #region 屏蔽老代码
                //string path = xmlFilePath;
                //MemoryStream ms = null;
                //XmlTextWriter XmlWt = null;
                //try
                //{
                //    ms = new MemoryStream();
                //    //根据ms实例化XmlWt
                //    XmlWt = new XmlTextWriter(ms, Encoding.Unicode);
                //    //获取ds中的数据
                //    dt.WriteXml(XmlWt);
                //    int count = (int)ms.Length;
                //    byte[] temp = new byte[count];
                //    ms.Seek(0, SeekOrigin.Begin);
                //    ms.Read(temp, 0, count);
                //    //返回Unicode编码的文本
                //    UnicodeEncoding ucode = new UnicodeEncoding();
                //    //写文件
                //    StreamWriter sw = new StreamWriter(path);
                //    //sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf - 8\"?>");
                //    sw.WriteLine(ucode.GetString(temp).Trim());
                //    sw.Close();
                //    return true;
                //}
                //catch (System.Exception ex)
                //{
                //    throw ex;
                //}
                //finally
                //{
                //    //释放资源
                //    if (XmlWt != null)
                //    {
                //        XmlWt.Close();
                //        ms.Close();
                //        ms.Dispose();
                //    }
                //}

                #endregion 

                try
                {

                    dt.WriteXml(xmlFilePath);
                    return true;
                }
                catch (Exception e)
                {

                    throw e;
                }

            }
            else
            {
                return false;
            }
        }


        /**//// <summary>
        /// 将DataSet对象中指定的Table转换成XML文件
        /// </summary>
        /// <param name="ds">DataSet对象</param>
        /// <param name="tableIndex">DataSet对象中的Table索引</param>
        /// <param name="xmlFilePath">xml文件路径</param>
        /// <returns>bool]值</returns>
        public static bool CDataToXmlFile(DataSet ds, int tableIndex, string xmlFilePath)
        {
            if (tableIndex != -1)
            {
                return CDataToXmlFile(ds.Tables[tableIndex], xmlFilePath);
            }
            else
            {
                return CDataToXmlFile(ds.Tables[0], xmlFilePath);
            }
        }


        /**//// <summary>
        /// 将DataSet对象转换成XML文件
        /// </summary>
        /// <param name="ds">DataSet对象</param>
        /// <param name="xmlFilePath">xml文件路径</param>
        /// <returns>bool]值</returns>
        public static bool CDataToXmlFile(DataSet ds, string xmlFilePath)
        {
            // return CDataToXmlFile(ds, -1, xmlFilePath);

            if ((ds != null) && (!string.IsNullOrEmpty(xmlFilePath)))
            {

             

                try
                {

                    ds.WriteXml(xmlFilePath);
                    return true;
                }
                catch (Exception e)
                {

                    throw e;
                }

            }
            else
            {
                return false;
            }
        }


        /**//// <summary>
        /// 将DataView对象转换成XML文件
        /// </summary>
        /// <param name="dv">DataView对象</param>
        /// <param name="xmlFilePath">xml文件路径</param>
        /// <returns>bool]值</returns>
        public static bool CDataToXmlFile(DataView dv, string xmlFilePath)
        {
            return CDataToXmlFile(dv.Table, xmlFilePath);
        }
    }
}
