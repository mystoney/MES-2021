using MES.module.BLL;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.form.Order
{
    public partial class OrderToUPS : txMainFormEnterTab
    {
        public OrderToUPS()
        {
            InitializeComponent();
        }
        public OrderToUPS(OrderBll.SelectOrderInfo soi_OrderSave)
        {
            soi = soi_OrderSave;
            InitializeComponent();
        }

        OrderBll.SelectOrderInfo soi = new OrderBll.SelectOrderInfo();

        private void OrderToUPS_Load(object sender, EventArgs e)
        {
            GetGridProductList();
            label_orderno.Text = soi.job_num + "-" + soi.suffix;
            label_styleno.Text = soi.Style_no;
            label_orderqty.Text = soi.job_qty.ToString().Trim();
            ChangeButton();

        }
        private void ChangeButton()
        {
            OrderBll ob = new OrderBll();
            List<int> L_ProductCode_ETON = new List<int>();
            L_ProductCode_ETON = ob.GetProductListNOTEton(soi.job_num, soi.suffix);
            if (L_ProductCode_ETON.Count == 0)
            {
                lable_TOMES.Text = "准备数据或完成";
                lable_TOMES.ForeColor = Color.Red;
                button_toMES.Enabled = false;
            }
            else
            {
                lable_TOMES.Text = "可推送";
                lable_TOMES.ForeColor = Color.Green;
                button_toMES.Enabled = true;
            }
            List<OrderBll.ProductUPS> L_ProductUPS_NOTJINGYUAN = new List<OrderBll.ProductUPS>();
            L_ProductUPS_NOTJINGYUAN = ob.GetProductList_NOTJINGYUAN(soi.job_num, soi.suffix);
            if (L_ProductUPS_NOTJINGYUAN.Count == 0)
            {
                label_toJINGYUAN.Text = "准备数据或完成";
                label_toJINGYUAN.ForeColor = Color.Red;
                button_toJINGYUAN.Enabled = false;
            }
            else
            {
                label_toJINGYUAN.Text = "可推送";
                label_toJINGYUAN.ForeColor = Color.Green;
                button_toJINGYUAN.Enabled = true;
            }
            List<OrderBll.ProductUPS> L_ProductUPS_NoCAOBO = new List<OrderBll.ProductUPS>();
            L_ProductUPS_NoCAOBO = ob.GetProductList_NOTCAOBO(soi.job_num, soi.suffix);
            if (L_ProductUPS_NoCAOBO.Count == 0)
            {
                lable_toCAOBO.Text = "准备数据或完成";
                lable_toCAOBO.ForeColor = Color.Red;
                button_toCAOBO.Enabled = false;
            }
            else
            {
                lable_toCAOBO.Text = "可推送";
                lable_toCAOBO.ForeColor = Color.Green;
                button_toCAOBO.Enabled = true;
            }
        }

        private void GetGridProductList()
        {
            OrderBll ob = new OrderBll();
            DataTable dt_ProductList = ob.GetProductListDT(soi.job_num,soi.suffix);
            GridProductList.DataSource = dt_ProductList;

            if (this.GridProductList.Columns.Count == 0)
            {
                this.GridProductList.AddColumn("id", "ID", 20, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProductList.AddColumn("ProductCode", "产品号", 200, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProductList.AddColumn("UPS_prun", "吊挂订单", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProductList.AddColumn("PushState_JINGYUAN", "推送UPS", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridProductList.AddColumn("PushState_CAOBO", "推送PAD", 90, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                // 实现列的锁定功能  
                this.GridProductList.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridProductList.AllowUserToResizeRows = false;
            }
        }

        private void PushToEton()
        {
            this.Enabled = false;





            OrderBll ob = new OrderBll();
            List<int> L_ProductCode_ETON = new List<int>();
            L_ProductCode_ETON = ob.GetProductListNOTEton(soi.job_num, soi.suffix);

            MyContrals.WaitFormService.Show(this);
            MyContrals.WaitFormService.SetLeftText("运行中");
            MyContrals.WaitFormService.SetProgressBarMax(L_ProductCode_ETON.Count+1, "正在推送到其他系统：");
            //MyContrals.WaitFormService.SetRightText("righttext");
            MyContrals.WaitFormService.SetTopText("请稍候......");


            //1 推送到吊挂

            if (L_ProductCode_ETON.Count != 0)
            {
                //如果工单中有没有成功推送到吊挂系统的，重推。

                try
                {
                    ////这里开始写循环L_ProductCode，调用吊挂接口                    

                    for (int k = 0; k < L_ProductCode_ETON.Count; k++)
                    {
                        OrderBll.ProductUPS ProductUPS1 = new OrderBll.ProductUPS();
                        ProductUPS1.id = L_ProductCode_ETON[k];
                        
                        string f = ProductUPS1.id.ToString().Trim();
                        string PostUPS_ToGX = $@"http://172.16.1.37/WebApi/api/ToGX";
                        string stoGX = Helper.Http.Http.HttpPost(PostUPS_ToGX, f, "POST", ""); ;



                        string PostUPS_ToMES = $@"http://172.16.1.37/WebApi/api/ToMes";
                        string stoMES = Helper.Http.Http.HttpPost(PostUPS_ToMES, f, "POST", ""); ;
                         
                        if (stoGX == "false" || stoMES == "false")
                        {

                            this.Enabled = true;
                            MyContrals.WaitFormService.Close();
                            //MessageBox.Show(L_ProductCode_ETON[k] + "推送到吊挂系统失败，请重新选择订单并提交", "提示");
                            //return;
                        }
                        else
                        {
                            string result = System.Text.RegularExpressions.Regex.Replace(stoMES, @"[^0-9]+", "");
                            int UPS_purn = 0;
                            if (int.TryParse(result, out UPS_purn))//如果转换失败（为false）时输出括号内容
                            {
                                UPS_purn = Convert.ToInt16(result);
                            }
                            if (ob.SaveUPS_purn(ProductUPS1.id, UPS_purn) != 1)
                            {
                                MessageBox.Show(L_ProductCode_ETON[k] + "保存吊挂系统订单号失败,吊挂订单号为" + UPS_purn + "，请记录后立即联系管理员", "提示");
                                MyContrals.WaitFormService.Close();
                                return;
                            }
                            ob.UpdateOrderInfo("OrderLock", 1, soi.job_num, soi.suffix);
                        }
                        MyContrals.WaitFormService.ProgressBarGrow();
                        GetGridProductList();
                    }


                    //检查此工单是否全部提交成功
                    List<int> L_ProductCode_final = new List<int>();
                    L_ProductCode_final = ob.GetProductListNOTEton(soi.job_num, soi.suffix);
                    MyContrals.WaitFormService.ProgressBarGrow();
                    if (L_ProductCode_final.Count == 0)
                    {
                        MyContrals.WaitFormService.Close();
                        MessageBox.Show("导入吊挂成功，请继续等待", "提示");

                        button_toMES.Enabled = false;

                    }
                    else
                    {
                        MyContrals.WaitFormService.Close();
                        MessageBox.Show("有订单未成功提交，请重试", "提示");
                        button_toMES.Enabled = true;

                    }

                }
                catch (Exception ex)
                {
                    MyContrals.WaitFormService.Close();
                    button_toMES.Enabled = true;
                    throw ex;
                }
                ChangeButton();
            }
            GetGridProductList();
        }

        private void PushToJINGYUAN()
        {
            this.Enabled = false;
            OrderBll ob = new OrderBll();
            //第二步 推送给敬元
            List<OrderBll.ProductUPS> L_ProductUPS_NOTJINGYUAN = new List<OrderBll.ProductUPS>();
            L_ProductUPS_NOTJINGYUAN = ob.GetProductList_NOTJINGYUAN(soi.job_num, soi.suffix);


            //2 推送给敬元

            //先判断是否有未推送的订单
            if (L_ProductUPS_NOTJINGYUAN.Count > 0)
            {
                this.Enabled = false;
                MyContrals.WaitFormService.Show(this);
                MyContrals.WaitFormService.SetLeftText("运行中");
                MyContrals.WaitFormService.SetProgressBarMax(2, "正在推送到其他系统：");
                //MyContrals.WaitFormService.SetRightText("righttext");
                MyContrals.WaitFormService.SetTopText("请稍候......");

                try
                {
                    string f = ob.GetJson_Order_Eton(L_ProductUPS_NOTJINGYUAN);
                    //调用敬元接口
                    OrderBll.Return_Message rm = new OrderBll.Return_Message();
                    string PostUPS = $@"http://172.16.1.83:7063/MesUpsToJob";
                    rm = Helper.Json.JsonHelper.DeserializeJsonToObject<OrderBll.Return_Message>(Helper.Http.Http.HttpPost(PostUPS, f, "POST", "")); ;
                    if (rm.State == OrderBll.Return_Message.Return_State.Error)
                    {
                        throw new Exception(rm.Message);
                    }
                    else
                    {
                        //推送成功后的操作
                        for (int k = 0; k < L_ProductUPS_NOTJINGYUAN.Count; k++)
                        {
                            int R_PushState_JINGYUAN = ob.UpdateProductListInfo("PushState_JINGYUAN", 1, L_ProductUPS_NOTJINGYUAN[k].id);
                            GetGridProductList();
                        }
                    }
                    MyContrals.WaitFormService.ProgressBarGrow();
                }
                catch (Exception ex)
                {
                    MyContrals.WaitFormService.Close();
                    this.Enabled = true;
                    throw ex;
                }
                ChangeButton();
                MyContrals.WaitFormService.Close();
                this.Enabled = true;
            }
            GetGridProductList();
        }

        private void PushToCAOBO()
        {
            this.Enabled = false;
            OrderBll ob = new OrderBll();





            //第三步 推送给曹博
            List<OrderBll.ProductUPS> L_ProductUPS_NoCAOBO = new List<OrderBll.ProductUPS>();
            L_ProductUPS_NoCAOBO = ob.GetProductList_NOTCAOBO(soi.job_num, soi.suffix);

            //先判断是否有未推送的订单
            if (L_ProductUPS_NoCAOBO.Count > 0)
            {
                MyContrals.WaitFormService.Show(this);
                MyContrals.WaitFormService.SetLeftText("运行中");
                MyContrals.WaitFormService.SetProgressBarMax(L_ProductUPS_NoCAOBO.Count+1, "正在推送到定制系统-PAD：");
                //MyContrals.WaitFormService.SetRightText("righttext");
                MyContrals.WaitFormService.SetTopText("请稍候......");
                try
                {
                    for (int k = 0; k < L_ProductUPS_NoCAOBO.Count; k++)
                    {



                        string url = "http://172.16.1.39:8005/api/TongBuGongDanGongXu";
                        string content = "[{ProductCode:\"" + L_ProductUPS_NoCAOBO[k].ProductCode + "\",OpListNo:" + soi.OpListNo + "}]";



                        string response = HttpPost(url, content);
                        ApiResonse apiResonse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResonse>(response);

                        if (apiResonse.state == 1)
                        {
                            ob.UpdateProductListInfo("PushState_CAOBO", 1, L_ProductUPS_NoCAOBO[k].id);
                            GetGridProductList();
                        }
                        else
                        {
                            MessageBox.Show(L_ProductUPS_NoCAOBO[k].ProductCode + "推送工序清单报错，错误：" + apiResonse.message, "出错啦", MessageBoxButtons.OK);

                            MyContrals.WaitFormService.Close();
                            this.Enabled = true;
                            return;
                        }
                        MyContrals.WaitFormService.ProgressBarGrow();
                    }


                }
                catch (Exception ex)
                {
                    MyContrals.WaitFormService.Close();
                    this.Enabled = true;
                    throw ex;
                }

                ChangeButton();
                MyContrals.WaitFormService.ProgressBarGrow();
                MyContrals.WaitFormService.Close();
            }
            GetGridProductList();
        }


        #region 曹博
            
        //public static string HttpPost(string url, string content)
        //{
        //    try
        //    {
        //        //获取提交的字节
        //        byte[] bs = Encoding.UTF8.GetBytes(content);
        //        //设置提交的相关参数
        //        HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
        //        req.Method = "POST";
        //        req.ContentType = "application/json";
        //        req.ContentLength = bs.Length;
        //        //提交请求数据
        //        using (Stream reqStream = req.GetRequestStream())
        //        {
        //            reqStream.Write(bs, 0, bs.Length);
        //            reqStream.Close();
        //        }
        //        //接收返回的页面，必须的，不能省略
        //        WebResponse wr = req.GetResponse();
        //        string responsestr = string.Empty;
        //        using (System.IO.Stream respStream = wr.GetResponseStream())
        //        {
        //            System.IO.StreamReader reader = new System.IO.StreamReader(respStream, System.Text.Encoding.GetEncoding("utf-8"));
        //            responsestr = reader.ReadToEnd();
        //            wr.Close();
        //        }
        //        return responsestr;
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message + ex.StackTrace;
        //    }
        //}

        public string HttpGet(string url)
        {
            string result = string.Empty;

                //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                Encoding encoding = Encoding.UTF8;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.ContentType = "application/json";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        result = reader.ReadToEnd();
                        reader.Close();
                    }
                    response.Close();
                }
            
            return result;
        }
        public string HttpPost(string url, string content)
        {
            string result = string.Empty;

                try
                {
                    //获取提交的字节
                    byte[] bs = Encoding.UTF8.GetBytes(content);
                    //设置提交的相关参数
                    HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                    req.Method = "POST";
                    req.ContentType = "application/json";
                    req.ContentLength = bs.Length;
                    //提交请求数据
                    using (Stream reqStream = req.GetRequestStream())
                    {
                        reqStream.Write(bs, 0, bs.Length);
                        reqStream.Close();
                    }
                    //接收返回的页面，必须的，不能省略
                    using (WebResponse wr = req.GetResponse())
                    {
                        string responsestr = string.Empty;
                        using (System.IO.Stream respStream = wr.GetResponseStream())
                        {
                            using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream, System.Text.Encoding.GetEncoding("utf-8")))
                            {
                                responsestr = reader.ReadToEnd();
                                reader.Close();
                            }
                            respStream.Close();
                        }
                        wr.Close();
                        result = responsestr;
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message + ex.StackTrace;
                }
            
            return result;
        }

        public class ApiResonse
        {
            public int state { get; set; }
            public string return_Value { get; set; }
            public string message { get; set; }
        }

        #endregion

        private void button_toMES_Click(object sender, EventArgs e)
        {
            PushToEton();

        }

        private void button_toJINGYUAN_Click(object sender, EventArgs e)
        {
            PushToJINGYUAN();

        }

        private void button_toCAOBO_Click(object sender, EventArgs e)
        {


            PushToCAOBO();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
