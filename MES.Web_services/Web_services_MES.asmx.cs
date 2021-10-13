using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using MES.module.model;
using System.IO;
using MES.module.Base.PublicClass;
using System.Data;
using System.Text;

using MES.module.BLL;
using System.Collections;

namespace MES.Web_services
{
    /// <summary>
    /// Web_services_attune 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Web_services_MES : System.Web.Services.WebService
    {


        #region SAP传来的六张表
        /// <summary>
        /// 将SAP传来的Tmp_ZAFPO表插入到SQL的Tmp_ZAFPO表
        /// </summary>
        /// <param name="ZAFPO_XML">要插入的表的XML格式</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public  bool InsertZAFPO(string ZAFPO_XML)
        {
            ZAFPOBLL zafpoBLL = new ZAFPOBLL();
            //zafpoBLL.ZAFPO_Insert(SAPZAFPO);

            //string w;

            //StreamWriter sw = new StreamWriter("c:\\aa\\ZAFPO_XML1.txt", false);

            //sw.Write(ZAFPO_XML);
            //sw.Close();
             
            int  str1 = ZAFPO_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZAFPO>");

            ZAFPO_XML=ZAFPO_XML.Substring(str1);

            //StreamWriter sw1 = new StreamWriter("D:\\ZAFPO_XML.txt", false);

            //sw1.Write(ZAFPO_XML);
            //sw1.Close();

            //StreamWriter sw1 = new StreamWriter("D:\\1.txt", false);

            //sw1.Write(ZAFPO_XML);
            //sw1.Close();


            //List<Tmp_ZAFPO> _ZAFPO = new List<Tmp_ZAFPO>();
            //DataTable dt = new DataTable();
            //DataTable dt_new = new DataTable();



            //List<UColumnData> LUCD = new List<UColumnData>();

            //UColumnData UCD = new UColumnData();
            //UCD.ColumnName = "ZGSTRP";
            //UCD.ColumnType = typeof(DateTime);
            //LUCD.Add(UCD);


            //dt =XmlToData.CXmlToDatatTable(ZAFPO_XML);

            //dt_new = ChangeDatatableColumnsDataType.ChangeColumnsDataType<Tmp_ZAFPO>(dt);

            //dt.ReadXml(ZAFPO_XML);


            //_ZAFPO = DataToClass.CDataTableToClass<Tmp_ZAFPO>(dt_new,false);


            //_ZAFPO = DataToClass.CDataTableToClass<Tmp_ZAFPO>(dt_new);
            //_ZAFPO = XMLToClass.XMLstrToClass<Tmp_ZAFPO>(ZAFPO_XML);

            //w = ClassToXML.ClassToXml<Tmp_ZAFPO>(_ZAFPO);


            List<Tmp_ZAFPO> _Zafpo = new List<Tmp_ZAFPO>();

            _Zafpo=XMLToClass.CXMLToList<Tmp_ZAFPO>(ZAFPO_XML);

            try
            {
                zafpoBLL.InsertZAFPO(_Zafpo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }
            
       
            


            //zafpoBLL.InsertZAFPO(_Zafpo);



            //w=ClassToXML.ClassToXml<Tmp_ZAFPO>(_Zafpo);
            //Console.WriteLine(w);

            ////表示向txt写入文本
            //StreamWriter sw2 = new StreamWriter("D:\\1.XML", false,System.Text.Encoding.Unicode);

            //sw2.Write(w);
            //sw2.Close();



            
        }





        /// <summary>
        /// 将SAP传来的Tmp_ZAFPO表插入到SQL的Tmp_ZAFPO表
        /// </summary>
        /// <param name="ZBTDATA_XML">要插入的表的XML格式</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool InsertZBTDATA(string ZBTDATA_XML)
        {
            ZBTDATABLL ZbtdataBLL = new ZBTDATABLL();
    


            int str1 = ZBTDATA_XML.ToString().ToUpper().IndexOf("<ARRAYOFZBTDATA>");

            ZBTDATA_XML = ZBTDATA_XML.Substring(str1);


            //StreamWriter sw1 = new StreamWriter("D:\\ZBTDATA_XML.txt", false);

            //sw1.Write(ZBTDATA_XML);
            //sw1.Close();



            List<Tmp_ZBTDATA> _ZBTDATA = new List<Tmp_ZBTDATA>();

            _ZBTDATA = XMLToClass.CXMLToList<Tmp_ZBTDATA>(ZBTDATA_XML);

            try
            {
                ZbtdataBLL.InsertZBTDATA(_ZBTDATA);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }
            




         


            
        }



        /// <summary>
        /// 将SAP传来的Tmp_ZCADMA表插入到SQL的Tmp_ZCADMA表
        /// </summary>
        /// <param name="ZCADMA_XML">要插入的表的XML格式</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool InsertZCADMA(string ZCADMA_XML)
        {
            ZCADMABLL ZcadmaBLL = new ZCADMABLL();



            StreamWriter sw = new StreamWriter("c:\\aa\\zcadma_XML1.txt", false);

            sw.Write(ZCADMA_XML);
            sw.Close();



            int str1 = ZCADMA_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZCADMA>");

            ZCADMA_XML = ZCADMA_XML.Substring(str1);





            List<Tmp_ZCADMA> _ZCADMA = new List<Tmp_ZCADMA>();

            _ZCADMA = XMLToClass.CXMLToList<Tmp_ZCADMA>(ZCADMA_XML);



            try
            {
                ZcadmaBLL.InsertZCADMA(_ZCADMA);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
                //return false;
            }

            //return true;
                        
        }





        /// <summary>
        /// 将SAP传来的Tmp_ZCLSX表插入到SQL的Tmp_ZCLSX表
        /// </summary>
        /// <param name="ZCLSX_XML">要插入的表的XML格式</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool InsertZCLSX(string ZCLSX_XML)
        {
            ZCLSXBLL ZclsxBLL = new ZCLSXBLL();



            int str1 = ZCLSX_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZCLSX>");


            ZCLSX_XML = ZCLSX_XML.Substring(str1);




            //StreamWriter sw1 = new StreamWriter("D:\\ZCLSX_XML.txt", false);

            //sw1.Write(ZCLSX_XML);
            //sw1.Close();

            List<Tmp_ZCLSX> _ZCLSX = new List<Tmp_ZCLSX>();

            _ZCLSX = XMLToClass.CXMLToList<Tmp_ZCLSX>(ZCLSX_XML);



            try
            {
                ZclsxBLL.InsertZCLSX(_ZCLSX);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }

        }




        /// <summary>
        /// 将SAP传来的Tmp_ZMTMAUF表插入到SQL的Tmp_ZMTMAUF表
        /// </summary>
        /// <param name="ZMTMAUF_XML">要插入的表的XML格式</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool InsertZMTMAUF(string ZMTMAUF_XML)
        {
            ZMTMAUFBLL ZmtmaufBLL = new ZMTMAUFBLL();

            //StreamWriter sw = new StreamWriter("D:\\ZMTMAUF_XML1.txt", false);

            //sw.Write(ZMTMAUF_XML);
            //sw.Close();

            int str1 = ZMTMAUF_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZMTMAUF>");

            ZMTMAUF_XML = ZMTMAUF_XML.Substring(str1);


            //StreamWriter sw1 = new StreamWriter("D:\\ZMTMAUF_XML.txt",false);

            //sw1.Write(ZMTMAUF_XML);
            //sw1.Close();



            List<Tmp_ZMTMAUF> _ZMTMAUF = new List<Tmp_ZMTMAUF>();

            _ZMTMAUF = XMLToClass.CXMLToList<Tmp_ZMTMAUF>(ZMTMAUF_XML);



            try
            {
                ZmtmaufBLL.InsertZMTMAUF(_ZMTMAUF);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }

        }






        /// <summary>
        /// 将SAP传来的Tmp_ZMTMFILL表插入到SQL的Tmp_ZMTMFILL表
        /// </summary>
        /// <param name="ZMTMFILL_XML">要插入的表的XML格式</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool InsertZMTMFILL(string ZMTMFILL_XML)
        {
             ZMTMFILLBLL ZmtmfillBLL = new ZMTMFILLBLL();



            int str1 = ZMTMFILL_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZMTMFILL>");

            ZMTMFILL_XML = ZMTMFILL_XML.Substring(str1);



            //StreamWriter sw1 = new StreamWriter("C:\\测试接口\\ZMTMFILL_XML.txt", false);

            //sw1.Write(ZMTMFILL_XML);
            //sw1.Close();


            List<Tmp_ZMTMFILL> _ZMTMFILL = new List<Tmp_ZMTMFILL>();

            _ZMTMFILL = XMLToClass.CXMLToList<Tmp_ZMTMFILL>(ZMTMFILL_XML);


            try
            {
                ZmtmfillBLL.InsertZMTMFILL(_ZMTMFILL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }

        }


        #endregion

        #region 张鲸发来的三张表
        /// <summary>
        /// 将SAP传来的Tmp_ZTMTM_COMCTRL_LIST表插入到SQL的Tmp_ZTMTM_COMCTRL_LIST表
        /// </summary>
        /// <param name="Tmp_ZTMTM_COMCTRL_LIST">要插入的表的XML</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool Insert_Tmp_ZTMTM_COMCTRL(string Tmp_ZTMTM_COMCTRL_XML)
        {
            Tmp_ZTMTM_COMCTRLBLL LS = new Tmp_ZTMTM_COMCTRLBLL();

            //StreamWriter sw0 = new StreamWriter("C:\\aa\\a1.txt", false);

            //sw0.Write(Tmp_ZTMTM_COMCTRL_XML);
            //sw0.Close();


            int str1 = Tmp_ZTMTM_COMCTRL_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZTMTM_COMCTRL>");

            Tmp_ZTMTM_COMCTRL_XML = Tmp_ZTMTM_COMCTRL_XML.Substring(str1);


            //StreamWriter sw1 = new StreamWriter("C:\\aa\\a2.txt", false);

            //sw1.Write(Tmp_ZTMTM_COMCTRL_XML);
            //sw1.Close();



            List<Tmp_ZTMTM_COMCTRL> _ZTMTMCOMCTRL = new List<Tmp_ZTMTM_COMCTRL>();

            _ZTMTMCOMCTRL = XMLToClass.CXMLToList<Tmp_ZTMTM_COMCTRL>(Tmp_ZTMTM_COMCTRL_XML);





            //string s;
            //s = ClassToXML.ClassToXml<Tmp_ZTMTM_COMCTRL>(_ZTMTMCOMCTRL);


            //StreamWriter sw2 = new StreamWriter("C:\\aa\\a3.txt", false);

            //sw2.Write(s);
            //sw2.Close();


            



            try
            {
                LS.InsertALL(_ZTMTMCOMCTRL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }




        /// <summary>
        /// 将SAP传来的Tmp_ZTMTM_COMOPT表插入到SQL的Tmp_ZTMTM_COMOPT表
        /// </summary>
        /// <param name="Tmp_ZTMTM_COMOPT">要插入的表</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool Insert_Tmp_ZTMTM_COMOPT(string Tmp_ZTMTM_COMOPT_XML)
        {


            Tmp_ZTMTM_COMOPTBLL LS = new Tmp_ZTMTM_COMOPTBLL();

            StreamWriter sw0 = new StreamWriter("C:\\aa\\a1.txt", false);

            sw0.Write(Tmp_ZTMTM_COMOPT_XML);
            sw0.Close();

            

            int str1 = Tmp_ZTMTM_COMOPT_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZTMTM_COMOPT>");

            Tmp_ZTMTM_COMOPT_XML = Tmp_ZTMTM_COMOPT_XML.Substring(str1);


            StreamWriter sw1 = new StreamWriter("C:\\aa\\a2.txt", false);

            sw1.Write(Tmp_ZTMTM_COMOPT_XML);
            sw1.Close();



            List<Tmp_ZTMTM_COMOPT> _ZTMTMCOMOPT = new List<Tmp_ZTMTM_COMOPT>();

            _ZTMTMCOMOPT = XMLToClass.CXMLToList<Tmp_ZTMTM_COMOPT>(Tmp_ZTMTM_COMOPT_XML);





            string s;
            s = ClassToXML.ClassToXml<Tmp_ZTMTM_COMOPT>(_ZTMTMCOMOPT);


            StreamWriter sw2 = new StreamWriter("C:\\aa\\a3.txt", false);

            sw2.Write(s);
            sw2.Close();




            try
            {
                LS.InsertALL(_ZTMTMCOMOPT);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }
        }






        /// <summary>
        /// 将SAP传来的Tmp_ZTMTM_COMREL表插入到SQL的Tmp_ZTMTM_COMREL表
        /// </summary>
        /// <param name="Tmp_ZTMTM_COMREL">要插入的表</param>
        /// <returns>返回插入是否成功</returns>
        [WebMethod]
        public bool Insert_Tmp_ZTMTM_COMRELT(string Tmp_ZTMTM_COMREL_XML)
        {


            Tmp_ZTMTM_COMRELBLL LS = new Tmp_ZTMTM_COMRELBLL();



            StreamWriter sw0 = new StreamWriter("C:\\aa\\a1.txt", false);

            sw0.Write(Tmp_ZTMTM_COMREL_XML);
            sw0.Close();



            int str1 = Tmp_ZTMTM_COMREL_XML.ToString().ToUpper().IndexOf("<ARRAYOFTMP_ZTMTM_COMREL>");

            Tmp_ZTMTM_COMREL_XML = Tmp_ZTMTM_COMREL_XML.Substring(str1);


            StreamWriter sw1 = new StreamWriter("C:\\aa\\a2.txt", false);

            sw1.Write(Tmp_ZTMTM_COMREL_XML);
            sw1.Close();



            List<Tmp_ZTMTM_COMREL> _ZTMTMCOMREL = new List<Tmp_ZTMTM_COMREL>();

            _ZTMTMCOMREL = XMLToClass.CXMLToList<Tmp_ZTMTM_COMREL>(Tmp_ZTMTM_COMREL_XML);





            string s;
            s = ClassToXML.ClassToXml<Tmp_ZTMTM_COMREL>(_ZTMTMCOMREL);


            StreamWriter sw2 = new StreamWriter("C:\\aa\\a3.txt", false);

            sw2.Write(s);
            sw2.Close();


            try
            {
                LS.InsertALL(_ZTMTMCOMREL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }
        }
        #endregion



        /// <summary>
        /// 将数据插入到PLMTOMES表中
        /// </summary>
        /// <param name="Tmp_PLMTOMES_XML">待插入到PLMTOMES的数据的XML文件</param>
        /// <returns></returns>
        [WebMethod]
        public bool Insert_PLMTOMES(string Tmp_PLMTOMES_XML)
        {


            //StreamWriter sw2 = new StreamWriter("C:\\aa\\a3.txt", false);

            //sw2.Write(Tmp_PLMTOMES_XML);
            //sw2.Close();


            DataTable dt = new DataTable();

            try
            {
                ArrayList ArraySQL = new ArrayList();


                dt = XmlToData.CXmlToDatatTable(Tmp_PLMTOMES_XML);

                ArraySQL = DataTableTOArrayList.DtToArrayList(dt, "Tmp_PLMTOMES");

                
                DBConn.DataAcess.SqlConn.ExecuteSqlTran(ArraySQL);
                

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }

            return true;
        }

        [WebMethod]
        public string HELLOWORLD(string s)
        {
          
                return "helloworld";
          

        }

       

    }
}
