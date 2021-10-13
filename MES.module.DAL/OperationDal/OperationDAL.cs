using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.module.DAL.OperationDal
{
    public class OperationDAL
    {


        /// <summary>
        /// 导入工序清单
        /// </summary>
        /// <param name="Combination_no">组合号</param>
        /// <param name="memo">清单备注</param>
        /// <param name="dt_OperationList">清单明细</param>
        /// <returns></returns>
        public int NewOperationList(int Combination_no, string memo, DataTable dt_OperationList)
        {
            //获取当前清单号最大值+1
            int n = 0;
            string sqlcmd = "SELECT case when max(OpListNo) is null then 0 else max(OpListNo) end OpListNo FROM nMES_OperationList_master";
            n = Convert.ToInt16(DBConn.DataAcess.SqlConn.GetSingle(sqlcmd));
            int OpListNo = n + 1;

            ArrayList SQLList = new ArrayList();

            StringBuilder sqlstr_master = new StringBuilder();
            sqlstr_master.Clear();
            sqlstr_master.AppendLine(" declare @OpListNo int ");
            sqlstr_master.AppendLine(" declare @Combination_no int ");
            sqlstr_master.AppendLine(" declare @memo nvarchar(50) ");
            sqlstr_master.AppendLine(" declare @apptime datetime ");
            sqlstr_master.AppendLine(" set @OpListNo=" + OpListNo + " ");
            sqlstr_master.AppendLine(" set @Combination_no=" + Combination_no + " ");
            sqlstr_master.AppendLine(" set @memo='" + memo + "' ");
            sqlstr_master.AppendLine(" set @apptime=getdate() ");
            sqlstr_master.AppendLine(" INSERT INTO nMES_OperationList_master ");
            sqlstr_master.AppendLine("            (OpListNo ");
            sqlstr_master.AppendLine("            ,Combination_no ");
            sqlstr_master.AppendLine("            ,memo ");
            sqlstr_master.AppendLine("            ,apptime,PushState_CAOBO) ");
            sqlstr_master.AppendLine("      VALUES ");
            sqlstr_master.AppendLine("            (@OpListNo ");
            sqlstr_master.AppendLine("            ,@Combination_no ");
            sqlstr_master.AppendLine("            ,@memo ");
            sqlstr_master.AppendLine("            ,@apptime,0) ");
            SQLList.Add(sqlstr_master.ToString());

            for (int i = 0; i < dt_OperationList.Rows.Count; i++)
            {
                StringBuilder sqlstr_detail = new StringBuilder();
                sqlstr_detail.Clear();
                sqlstr_detail.AppendLine(" declare @OpListNo int ");
                sqlstr_detail.AppendLine(" declare @OperationNo nvarchar(50) ");
                sqlstr_detail.AppendLine(" declare @OperationDes nvarchar(50) ");
                sqlstr_detail.AppendLine(" declare @manhour int ");
                sqlstr_detail.AppendLine(" declare @GST_xh int ");
                sqlstr_detail.AppendLine(" declare @OperationType nvarchar(50) ");
                sqlstr_detail.AppendLine(" set @OpListNo=" + OpListNo + "");
                sqlstr_detail.AppendLine(" set @OperationNo='" + dt_OperationList.Rows[i]["OperationNo"].ToString().Trim() + "' ");
                sqlstr_detail.AppendLine(" set @OperationDes='" + dt_OperationList.Rows[i]["OperationDes"].ToString().Trim() + "' ");
                sqlstr_detail.AppendLine(" set @manhour=" + dt_OperationList.Rows[i]["manhour"].ToString().Trim() + "");
                sqlstr_detail.AppendLine(" set @GST_xh= " + dt_OperationList.Rows[i]["GST_xh"].ToString().Trim() + " ");
                sqlstr_detail.AppendLine(" set @OperationType= '" + dt_OperationList.Rows[i]["OperationType"].ToString().Trim() + "' ");
                sqlstr_detail.AppendLine(" INSERT INTO nMES_OperationList_detail ");
                sqlstr_detail.AppendLine("            (OpListNo ");
                sqlstr_detail.AppendLine("            ,OperationNo ");
                sqlstr_detail.AppendLine("            ,OperationDes ");
                sqlstr_detail.AppendLine("            ,manhour ");
                sqlstr_detail.AppendLine("            ,OperationType ");
                sqlstr_detail.AppendLine("            ,GST_xh) ");
                sqlstr_detail.AppendLine("      VALUES ");
                sqlstr_detail.AppendLine("            (@OpListNo ");
                sqlstr_detail.AppendLine("            ,@OperationNo ");
                sqlstr_detail.AppendLine("            ,@OperationDes ");
                sqlstr_detail.AppendLine("            ,@manhour ");
                sqlstr_detail.AppendLine("            ,@OperationType ");
                sqlstr_detail.AppendLine("            ,@GST_xh) ");

                SQLList.Add(sqlstr_detail.ToString());
            }
            try
            {
                DBConn.DataAcess.SqlConn.ExecuteSqlTran(SQLList);
                return OpListNo;
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }


        public DataTable GetOpList(int OpListNo)
        {

            StringBuilder sqlstr_detail = new StringBuilder();
            sqlstr_detail.Clear();
            sqlstr_detail.AppendLine(" SELECT OpListNo,OperationNo,OperationDes,standard_time,GST_xh  FROM nMES_OperationList_detail where OpListNo='' ");

            DataTable dt_OpListNo = DBConn.DataAcess.SqlConn.Query(sqlstr_detail.ToString()).Tables[0];
            return dt_OpListNo;
        }

        public DataTable GetAllOperationList()
        {
            StringBuilder sqlstr = new StringBuilder();
            sqlstr.Clear();
            sqlstr.AppendLine(" SELECT a.id ");
            sqlstr.AppendLine("       ,OpListNo ");
            sqlstr.AppendLine(" 	  ,b.Style_no ");
            sqlstr.AppendLine("       ,a.Combination_no ");
            sqlstr.AppendLine(" 	  ,b.memo_name ");
            sqlstr.AppendLine("       ,memo ");
            sqlstr.AppendLine("       ,apptime ");
            sqlstr.AppendLine(" 	  ,PushState_CAOBO ");
            sqlstr.AppendLine("       ,case when a.PushState_CAOBO=0 then '待推送' else '已推送' end PushState ");
            sqlstr.AppendLine("   FROM nMES_OperationList_master a ");
            sqlstr.AppendLine("   left join nMES_Style_Combination_master b ");
            sqlstr.AppendLine("   on a.Combination_no=b.Combination_no ");

            DataTable dt= DBConn.DataAcess.SqlConn.Query(sqlstr.ToString()).Tables[0];
            return dt;
        }

        #region JSON新版-给曹博推送工单对应的工序清单
        /// <summary>
        /// JSON新版-给曹博推送工单对应的工序清单
        /// </summary>
        /// <param name="Order_no">工单号</param>
        /// <returns>Json</returns>
        public string GetJson_OperationList(int OpListNo)
        {
            string json = "";
            StringBuilder sqlstr = new StringBuilder();
            sqlstr.Clear();
            sqlstr.AppendLine(" SELECT OpListNo,OperationNo ");
            sqlstr.AppendLine(" ,OperationDes ");
            sqlstr.AppendLine(" ,OperationType ");
            sqlstr.AppendLine(" ,manhour ");
            sqlstr.AppendLine(" ,GST_xh  ");
            sqlstr.AppendLine(" FROM nMES_OperationList_detail  ");
            sqlstr.AppendLine(" where OpListNo='" + OpListNo + "'  ");
            sqlstr.AppendLine(" order by GST_xh  ");

            DataTable dt = DBConn.DataAcess.SqlConn.Query(sqlstr.ToString()).Tables[0];

            MyContrals.JSON js = new MyContrals.JSON();
            json = js.DataTableToJson(dt);
            return json;
        }
        #endregion

        public int UpdatePushState(int OpListNo)
        {
            string sqlstr="UPDATE nMES_OperationList_master   SET PushState_CAOBO=1 WHERE OpListNo= "+OpListNo; 
            try
            {
                DBConn.DataAcess.SqlConn.Query(sqlstr);
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }
}
