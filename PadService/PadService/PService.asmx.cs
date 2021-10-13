using System.Web.Services;
using System.Data;
using System;
using System.Collections;


namespace PadService
{
    /// <summary>
    /// PService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class PService : System.Web.Services.WebService
    {


        #region 根据工位信息获取工序信息
        /// <summary>
        /// 根据工位信息获取工序信息
        /// </summary>
        /// <param name="rail1">工位</param>
        /// <returns>工位对应的工序</returns>
        [WebMethod]
        public string GetWORKPLACE(string rail1)
        {
            //DBConn.DataAcess.SqlConn.ExecuteReader();
            DataSet ds = new DataSet("xmldata");
            string str = "select WORKPLACEDATA.rail1,style,styletext,operation,text,wpclamp,elcaddress from USEROPLI "
+ " join USERROUT"
+ " on USEROPLI.style = USERROUT.style and USEROPLI.listindex = USERROUT.listindex"
+ " join USEROPER"
+ " on USEROPLI.operation = USEROPER.id"
+ " join WORKPLACEDATA"
+ "  on WORKPLACEDATA.rail1 = USERROUT.rail0"
+ " join clampdata"
+ " on wpclamp = CLAMPid and clampdata.style = USEROPLI.style"
+ "  where WORKPLACEDATA.rail1 = "+ rail1;
            DataTable dt = DBConn.DataAcess.OdbcConn.Query(str).Tables[0];
            dt.TableName = "WORKPLACEDATA";
            ds.Tables.Add(dt.Copy());

            string sXmlData = string.Empty;

            sXmlData = ds.GetXml();
            return sXmlData;
        }
        #endregion



        /// <summary>
        /// 与ETON同步
        /// </summary>
        /// <param name="order_no">工单编号</param>
        /// <returns></returns>
        [WebMethod]
        public string ToMes(string order_no)
        {
            ArrayList ETArray = new ArrayList();
            //ArrayList MEArray = new ArrayList();

            #region 工序
            ///工序同步
            //            string GXsql = "select OpCodeAlpha1,left(operation_addr, 16) 工序描述,工序类型 from "
            //+ "(select a.OpCodeAlpha1, b.operation_addr, 2 工序类型 "
            //+ "from"
            //+ " (select opcodealpha1, max(id) as id "
            //+ " from MES_order_detail_operation where  order_no = '" + order_no + "'"
            //+ " group by opcodealpha1) a inner join "
            //+ " MES_order_detail_operation b on a.opcodealpha1 = b.OpCodeAlpha1 and a.id = b.id) t1"
            //+ "   where  t1.OpCodeAlpha1 not in (select OpCodeAlpha1 from MES_UPS_GST_operation)";


            //            DataTable GXDT = DBConn.DataAcess.SqlConn.Query(GXsql).Tables[0];//获取新增工序列表

            //            string maxETXHsql = " select max(ETON_Opcodealphal) from MES_UPS_GST_operation";

            //            object maxETXH = DBConn.DataAcess.SqlConn.GetSingle(maxETXHsql);
            //            int ETON_Opcodealphal = 0;
            //            if (maxETXH == null)
            //            {
            //                ETON_Opcodealphal = 50000;
            //            }


            //            foreach (DataRow GXDR in GXDT.Rows)
            //            {
            //                ETON_Opcodealphal = ETON_Opcodealphal + 1;
            //                ///插入本地工序表
            //                string insmesql = "INSERT INTO MES_UPS_GST_operation ([OpCodeAlpha1],[ETON_Opcodealphal],[input_date])  VALUES ('" + GXDR["OpCodeAlpha1"].ToString() + "'," + ETON_Opcodealphal + ", GETDATE())";

            //                //插入ETON数据库
            //                string insetgxgr = "insert into USEROPGR (ID,TEXT,PRODUCTGROUP,USEDINTARGET,CHKPNT,SKILLTYPE,OPTYPE,ADDRTYPE) VALUES(" + ETON_Opcodealphal + ", '" + GXDR["工序描述"].ToString() + "', 1, 1, 0, 0, 0, 0) ";
            //                string insertoper = "insert into USEROPER (ID,OPGROUP,TEXT,SAM,OPTYPE,ADDRTYPE,SAMPLING,CYCLES,PRATE,SAMPLING2) VALUES(" + ETON_Opcodealphal + ", " + ETON_Opcodealphal + ",'" + GXDR["工序描述"].ToString() + "', 0, 2, 19, 0, 1, 0, 0)";
            //                //string insetgxgr = "insert into USEROPGR (ID,TEXT,PRODUCTGROUP,USEDINTARGET,CHKPNT,SKILLTYPE,OPTYPE,ADDRTYPE) VALUES(" + ETON_Opcodealphal + ", '" + ETON_Opcodealphal + "', 1, 1, 0, 0, 0, 0) ";
            //                //string insertoper = "insert into USEROPER (ID,OPGROUP,TEXT,SAM,OPTYPE,ADDRTYPE,SAMPLING,CYCLES,PRATE,SAMPLING2) VALUES(" + ETON_Opcodealphal + ", " + ETON_Opcodealphal + ",'" + ETON_Opcodealphal + "', 0, 2, 19, 0, 1, 0, 0)";

            //                MEArray.Add(insmesql);
            //                ETArray.Add(insetgxgr);
            //                ETArray.Add(insertoper);

            //            }
            #endregion

            #region  款号订单
            string prunid = "";
            string stylsql = "select a.SchemeNo,a.style_no + a.memo 款式描述,isnull(b.order_qty,0) order_qty,b.order_no 工单号 from MES_station_operation_master a "
  + "join MES_order_master b on a.SchemeNo = b.SchemeNo where b.order_no = '" + order_no + "'";
            DataTable styldt = DBConn.DataAcess.SqlConn.Query(stylsql).Tables[0];
            if (styldt.Rows.Count > 0)
            {
                string prunsql = "select max(id)+1 from USERPRUN";
                prunid = DBConn.DataAcess.OdbcConn.GetSingle(prunsql).ToString();
                if (prunid.Length == 0)
                {
                    prunid = "1";
                }
                ///判断款式是否存在
                ///
                object STYLE = DBConn.DataAcess.OdbcConn.GetSingle("SELECT id  FROM USERSTYL where ID =" + styldt.Rows[0]["SchemeNo"].ToString());
                object pdorderno = DBConn.DataAcess.OdbcConn.GetSingle("select id from USERPRUN where ORDERNO = '" + order_no + "'");
                if (pdorderno != null)
                {
                    return "已生成订单" + pdorderno.ToString();

                }
                if (STYLE == null)
                {
                    string insertSTYL = "insert into USERSTYL (ID,TEXT,FLAG,ACTIVEFLAG) VALUES(" + styldt.Rows[0]["SchemeNo"].ToString() + ", '" + styldt.Rows[0]["款式描述"].ToString() + "', 2, 0) ";
                    ETArray.Add(insertSTYL);

                    string insertPRUN = "insert into USERPRUN (ID,STYLE,SIZENO,COLOUR,CUSTOMER,FREECRIT,QUANTITY,INCLAMP,INBUNDLE,BULKFACTOR,INORDERSTATUSREPORT,DELETEMARK,PARENTPRUN,PARENTSTYLE,INVENT_MIN,INVENT_MAX,INVENT_GROUP,ORDERNO) "
+ " VALUES(" + prunid + ", " + styldt.Rows[0]["SchemeNo"].ToString() + ", 0, 0, 0, 0, " + styldt.Rows[0]["order_qty"].ToString() + ", 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, '" + order_no + "') ";


                    ETArray.Add(insertPRUN);

                    #region 工序款式对照

                    string oplisql = "SELECT pivottable.schemeno as STYLE,RANK() over(order by GST_xh ) as LISTINDEX,isnull([1],0) as [RAIL0],isnull([2],0) as [RAIL1],isnull([3],0) as [RAIL2],isnull([4],0) as [RAIL3],isnull([5],0) as [RAIL4],isnull([6],0) as [RAIL5],isnull([7],0) as [RAIL6],isnull([8],0) as [RAIL7],"
        + " MES_UPS_GST_operation.ETON_Opcodealphal as OPERATION,MES_operation_detail_type.op_type as OPTYPE,GST_xh,PivotTable.OpCodeAlpha1"
        + " from"
        + " (select convert(int, rank()over(partition by OpCodeAlpha1 order by Eton_Workstation)) as Num, SchemeNo, OpCodeAlpha1, Eton_Line, Eton_Workstation, GST_xh"
        + " from MES_station_operation_detail"
        + " where SchemeNo = (select top 1 SchemeNo from MES_order_master where order_no = '" + order_no + "') )  aaa"
        + " PIVOT("
        + " max(Eton_Workstation)"
        + " FOR num  IN( [0],[1],[2],[3],[4],[5],[6],[7],[8])"
        + " ) as PivotTable left join"
        + "  mes_order_master on pivottable.schemeno = mes_order_master.schemeno  left join"
        + "  MES_UPS_GST_operation on MES_UPS_GST_operation.OpCodeAlpha1 = PivotTable.OpCodeAlpha1 left join"
        + "  MES_operation_detail_type on PivotTable.SchemeNo = MES_operation_detail_type.SchemeNo and PivotTable.OpCodeAlpha1 = MES_operation_detail_type.OpCodeAlpha1";

                    DataTable oplidt = DBConn.DataAcess.SqlConn.Query(oplisql).Tables[0];
                    int LISTINDEXend = 0;
                    foreach (DataRow PCDR in oplidt.Rows)
                    {
                        LISTINDEXend = Convert.ToInt32(PCDR["LISTINDEX"].ToString())+1;
                        string insertrout = "INSERT INTO USERROUT (STYLE,LISTINDEX,ROUTEINDEX,BLOCKFLAGS,RAIL0,RAIL1,RAIL2,RAIL3,RAIL4,RAIL5,RAIL6,RAIL7)"
            + " VALUES(" + PCDR["STYLE"].ToString() + "," + PCDR["LISTINDEX"].ToString() + ",0,0," + PCDR["RAIL0"].ToString() + "," + PCDR["RAIL1"].ToString() + "," + PCDR["RAIL2"].ToString() + "," + PCDR["RAIL3"].ToString() + ","
            + " " + PCDR["RAIL4"].ToString() + "," + PCDR["RAIL5"].ToString() + "," + PCDR["RAIL6"].ToString() + "," + PCDR["RAIL7"].ToString() + ")";
                        string insertopli = "INSERT INTO USEROPLI (STYLE,LISTINDEX,OPERATION,SAM,ADTYPE,OPTYPE,PRATE)"
            + " VALUES(" + PCDR["STYLE"].ToString() + "," + PCDR["LISTINDEX"].ToString() + "," + PCDR["OPERATION"].ToString() + ",0,19," + PCDR["OPTYPE"].ToString() + ",0)";

                        ETArray.Add(insertrout);
                        ETArray.Add(insertopli);
                    }
                    ///返回空吊架
                    string endrout = "INSERT INTO USERROUT (STYLE,LISTINDEX,ROUTEINDEX,BLOCKFLAGS,RAIL0,RAIL1,RAIL2,RAIL3,RAIL4,RAIL5,RAIL6,RAIL7)"
+ " VALUES(" + oplidt.Rows[0]["STYLE"].ToString() + "," + LISTINDEXend + ",0,0," + oplidt.Rows[0]["RAIL0"].ToString() + "," + oplidt.Rows[0]["RAIL1"].ToString() + "," + oplidt.Rows[0]["RAIL2"].ToString() + "," + oplidt.Rows[0]["RAIL3"].ToString() + ","
+ " " + oplidt.Rows[0]["RAIL4"].ToString() + "," + oplidt.Rows[0]["RAIL5"].ToString() + "," + oplidt.Rows[0]["RAIL6"].ToString() + "," + oplidt.Rows[0]["RAIL7"].ToString() + ")";
                    string endopli = "INSERT INTO USEROPLI (STYLE,LISTINDEX,OPERATION,SAM,ADTYPE,OPTYPE,PRATE)"
        + " VALUES(" + oplidt.Rows[0]["STYLE"].ToString() + "," + LISTINDEXend + ",9999,0,19,2,0)";
                    ///
                    ETArray.Add(endrout);
                    ETArray.Add(endopli);


                    #endregion


                }
                else
                {
                    string insertPRUN = "insert into USERPRUN (ID,STYLE,SIZENO,COLOUR,CUSTOMER,FREECRIT,QUANTITY,INCLAMP,INBUNDLE,BULKFACTOR,INORDERSTATUSREPORT,DELETEMARK,PARENTPRUN,PARENTSTYLE,INVENT_MIN,INVENT_MAX,INVENT_GROUP,ORDERNO) "
  + " VALUES(" + prunid + ", " + styldt.Rows[0]["SchemeNo"].ToString() + ", 0, 0, 0, 0, " + styldt.Rows[0]["order_qty"].ToString() + ", 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, '" + order_no + "') ";


                    ETArray.Add(insertPRUN);
                }
            }
            else
            {
                return "false";
            }
            #endregion

            

            //DBConn.DataAcess.SqlConn.ExecuteSqlTran(MEArray, "测试", "song");
            DBConn.DataAcess.OdbcConn.ExecuteSqlTran(ETArray);



            return  prunid;
        }

        [WebMethod]
        public bool ToGX(string order_no)
        {
            ArrayList ETArray = new ArrayList();
            ArrayList MEArray = new ArrayList();

            #region 工序
            ///工序同步
            string GXsql = "select OpCodeAlpha1,left(operation_addr, 16) 工序描述,工序类型 from "
+ "(select a.OpCodeAlpha1, b.operation_addr, 2 工序类型 "
+ "from"
+ " (select opcodealpha1, max(id) as id "
+ " from MES_order_detail_operation where  order_no = '" + order_no + "'"
+ " group by opcodealpha1) a inner join "
+ " MES_order_detail_operation b on a.opcodealpha1 = b.OpCodeAlpha1 and a.id = b.id) t1"
+ "   where  t1.OpCodeAlpha1 not in (select OpCodeAlpha1 from MES_UPS_GST_operation)";


            DataTable GXDT = DBConn.DataAcess.SqlConn.Query(GXsql).Tables[0];//获取新增工序列表

            string maxETXHsql = " select max(ETON_Opcodealphal) from MES_UPS_GST_operation";

            object maxETXH = DBConn.DataAcess.SqlConn.GetSingle(maxETXHsql);
            int ETON_Opcodealphal = 0;
            if (maxETXH == null)
            {
                ETON_Opcodealphal = 50000;
            }
            //else
            //{
            //    ETON_Opcodealphal = Convert.ToInt32(maxETXH) + 1;
            //}

            foreach (DataRow GXDR in GXDT.Rows)
            {
                ETON_Opcodealphal = ETON_Opcodealphal + 1;
                ///插入本地工序表
                string insmesql = "INSERT INTO MES_UPS_GST_operation ([OpCodeAlpha1],[ETON_Opcodealphal],[input_date])  VALUES ('" + GXDR["OpCodeAlpha1"].ToString() + "'," + ETON_Opcodealphal + ", GETDATE())";

                //插入ETON数据库
                string insetgxgr = "insert into USEROPGR (ID,TEXT,PRODUCTGROUP,USEDINTARGET,CHKPNT,SKILLTYPE,OPTYPE,ADDRTYPE) VALUES(" + ETON_Opcodealphal + ", '" + GXDR["工序描述"].ToString() + "', 1, 1, 0, 0, 0, 0) ";
                string insertoper = "insert into USEROPER (ID,OPGROUP,TEXT,SAM,OPTYPE,ADDRTYPE,SAMPLING,CYCLES,PRATE,SAMPLING2) VALUES(" + ETON_Opcodealphal + ", " + ETON_Opcodealphal + ",'" + GXDR["工序描述"].ToString() + "', 0, 2, 19, 0, 1, 0, 0)";
                //string insetgxgr = "insert into USEROPGR (ID,TEXT,PRODUCTGROUP,USEDINTARGET,CHKPNT,SKILLTYPE,OPTYPE,ADDRTYPE) VALUES(" + ETON_Opcodealphal + ", '" + ETON_Opcodealphal + "', 1, 1, 0, 0, 0, 0) ";
                //string insertoper = "insert into USEROPER (ID,OPGROUP,TEXT,SAM,OPTYPE,ADDRTYPE,SAMPLING,CYCLES,PRATE,SAMPLING2) VALUES(" + ETON_Opcodealphal + ", " + ETON_Opcodealphal + ",'" + ETON_Opcodealphal + "', 0, 2, 19, 0, 1, 0, 0)";

                MEArray.Add(insmesql);
                ETArray.Add(insetgxgr);
                ETArray.Add(insertoper);

            }
            #endregion

            DBConn.DataAcess.OdbcConn.ExecuteSqlTran(ETArray);
            DBConn.DataAcess.SqlConn.ExecuteSqlTran(MEArray, "测试", "song");
            



            return true;
        }
    }
    }
