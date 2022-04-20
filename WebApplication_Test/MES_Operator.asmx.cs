using MES.module.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication_Test
{
    /// <summary>
    /// MES_Operator 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class MES_Operator : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        //public OperatorBll.Return_Message OperatorLogin(string OperatorID, string OperatorPassword)
        //{
        //    //OperatorBll ob = new OperatorBll();
        //    //OperatorBll.Return_Message rm = new OperatorBll.Return_Message();

        //    //rm=ob.GetOperatorSingle(OperatorID);

        //    //rm = ob.OperatorInsert(oi);
        //    //if (rm.State == OperatorBll.Return_Message.Return_State.Error)
        //    //{
        //    //    MessageBox.Show(rm.Message, "提示", MessageBoxButtons.OK);
        //    //    textBox_OperatorPassword.Text = "";
        //    //    return;
        //    //    //throw new Exception(rm.Message);

        //    //}
        //    //else
        //    //{
        //    //    this.Close();
        //    //}




        //    /OperatorBll.OperatorInfo oi = ob.GetOperatorSingle(OperatorID);
        //    //if (oi is null)
        //    //{
        //    //    LoginOK = 2;
        //    //}
        //    //else if (oi.OperatorPassword == OperatorPassword)
        //    //{
        //    //    LoginOK = 1;
        //    //}
        //    //else
        //    //{
        //    //    LoginOK = 0;
        //    //}
        //    //return LoginOK;
        //}



    }
}
