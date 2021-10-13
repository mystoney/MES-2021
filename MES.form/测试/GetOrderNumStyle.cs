using Newtonsoft.Json;
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

namespace MES.form.测试
{
    public partial class GetOrderNumStyle : txMainFormEnterTab
    {
        public GetOrderNumStyle()
        {
            InitializeComponent();
        }

        private void GetOrderNumStyle_Load(object sender, EventArgs e)
        {

        }
        public class GetJobModel
        {
            #region 字段信息

            /// <summary>
            /// 款号
            /// </summary>
            public string style { get; set; }

            /// <summary>
            /// 尺码
            /// </summary>
            public int num { get; set; }

            #endregion
        }
        /// <summary>
        /// 解析JSON字符串生成对象实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串(eg.{"ID":"112","Name":"石子儿"})</param>
        /// <returns>对象实体</returns>
        public static T DeserializeJsonToObject<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(@json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            T t = o as T;
            return t;
        }


        public static string HttpGetnew(string url)
        {

            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }

        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            string getordermodel = "http://172.16.1.34:9097/api/job_qty_Api/Get_Job_Qty?job_no=" + txTextBox1.Text.Trim();


            GetJobModel m = DeserializeJsonToObject<GetJobModel>(HttpGetnew(getordermodel));

            if (m.num == 0)
            {
                MessageBox.Show("没有找到对应的工单号，请核对后重试！", "温馨提示", MessageBoxButtons.OK);
            }
            else
            {
                Style.Text = m.style;
                Num.Text = Convert.ToString(m.num);
                //MessageBox.Show("款号 " + m.style + "   数量 " + m.num, "温馨提示", MessageBoxButtons.OK);
            }
        }
    }
}
