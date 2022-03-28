using MyContrals;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MES.form.CabinetLight
{
    public partial class CabinetMain : Form
    {
        public CabinetMain()
        {
            InitializeComponent();
        }

        int vv = 0;
        /// <summary>
        /// i=0车间组长 i=1设备
        /// </summary>
        /// <param name="i"></param>
        public CabinetMain(int v)
        {
            InitializeComponent();
            vv = v;
 
        }

        private void CabinetMain_Load(object sender, EventArgs e)
        {

            if (vv == 0)
            {
                this.Text = "灯箱管理-生产线";
                this.splitContainer2.Panel2.Hide();
                //this.splitContainer2.SplitterDistance = 0;
                this.splitContainer2.Panel2MinSize = 0;
                txButton1.Enabled = false;
                txButton2.Enabled = false;
                txButton3.Enabled = false;
                txButton4.Enabled = false;
                txButton5.Enabled = false;
                txButton6.Enabled = true;
            }
            else if (vv == 1)
            {

                this.Text = "灯箱管理-设备";

                txButton1.Enabled = true;
                txButton2.Enabled = false;
                txButton3.Enabled = true;
                txButton4.Enabled = true;
                txButton5.Enabled = false;
                txButton6.Enabled = true;
            }
            GetGridWorkSite();
        }
        int CabinetId = 0;

        //仅检测链接头，不会获取链接的结果。所以速度很快，超时的时间单位为毫秒
        public static string GetWebStatusCode(string url, int timeout)
        {
            HttpWebRequest req = null;
            try
            {
                req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
                req.Method = "HEAD";  //这是关键        
                req.Timeout = timeout;
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                return Convert.ToInt32(res.StatusCode).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (req != null)
                {
                    req.Abort();
                    req = null;
                }
            }

        }



        private void GetGridWorkSite()
        {
            string httpA = GetWebStatusCode("http://172.16.1.37/stoney/WebService1.asmx?op=HelloWorld", 500);
            if (httpA.Trim() != "200")
            {
                return;
            }
            string getWorkSitesmodel = "http://172.16.1.17:8004/api/WorkSite";          
            List<GetWorkSite> ws= DeserializeJsonToObject<List<GetWorkSite>>(CommonLib.HttpUtils.HttpGet(getWorkSitesmodel));


            GridWorkSite.DataSource = ws;
            
            if (this.GridWorkSite.Columns.Count == 0)
            {
                //加载WorkSite列
                //this.GridWorkSite.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridWorkSite.AddColumn("id", "ID", 40, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridWorkSite.AddColumn("SiteName", "站点名称", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridWorkSite.AddColumn("CabinetId", "柜子ID", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridWorkSite.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridWorkSite.AllowUserToResizeRows = false;
            }

            if (this.GridWorkSite.Rows.Count > 0)
            {
                this.GridWorkSite_CellClick(GridWorkSite, new DataGridViewCellEventArgs(0, 1));
            }



        }
        private void GetGridCabinetLight()
        {
            string getWorkSitesmodel = "http://172.16.1.17:8004/api/CabinetLight?CabinetId="+ CabinetId;
            List<GetCabinetLight> ws = DeserializeJsonToObject<List<GetCabinetLight>>(CommonLib.HttpUtils.HttpGet(getWorkSitesmodel));
            GridCabinetLight.DataSource = ws;
            

            if (this.GridCabinetLight.Columns.Count == 0)
            {
                //加载CabinetLight列
                //this.GridCabinetLight.AddColumn("check", "", 20, false, new DataGridViewCheckBoxColumn(), DataGridViewContentAlignment.MiddleLeft, null);
                this.GridCabinetLight.AddColumn("Id", "ID", 40, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCabinetLight.AddColumn("CabinetId", "柜子Id", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCabinetLight.AddColumn("ControlBoardAddress", "控制板地址", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCabinetLight.AddColumn("ControlPort", "控制板端口", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCabinetLight.AddColumn("ControlBoardModel", "控制板型号", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCabinetLight.AddColumn("LightName", "灯名称", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCabinetLight.AddColumn("Dirction", "方向", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);
                this.GridCabinetLight.AddColumn("TurnStatus", "TurnStatus", 100, true, null, DataGridViewContentAlignment.MiddleLeft, null, false);
                this.GridCabinetLight.AddColumn("StyleSize", "款号尺码(模板名) ", 180, true, null, DataGridViewContentAlignment.MiddleLeft, null, true);

                // 实现列的锁定功能  
                this.GridCabinetLight.Columns[1].Frozen = true;
                //禁止用户改变DataGridView1所有行的行高
                GridCabinetLight.AllowUserToResizeRows = false;
            }
        }



        public class GetWorkSite
        {
            #region 字段信息

            /// <summary>
            /// id
            /// </summary>
            public int id { get; set; }

            /// <summary>
            /// 站点名称
            /// </summary>
            public string siteName { get; set; }

            /// <summary>
            /// 柜子ID
            /// </summary>
            public int cabinetId { get; set; }

            #endregion
        }

        public class GetCabinetLight
        {
            #region 字段信息
            /// <summary>
            /// Id
            /// </summary>
            public int Id { get; set; }
            /// <summary>
            /// 柜子Id
            /// </summary>
            public int CabinetId { get; set; }

            /// <summary>
            /// 控制板地址 (目前只有HX16Port 和StandardModbus )
            /// </summary>
            public int ControlBoardAddress { get; set; }

            /// <summary>
            ///  控制板端口 (1~16)
            /// </summary>
            public int ControlPort { get; set; }
            /// <summary>
            /// 控制板型号
            /// </summary>
            public string ControlBoardModel { get; set; }

            /// <summary>
            /// 灯名称
            /// </summary>
            public string LightName { get; set; }

            /// <summary>
            /// 方向(true:放,false:取)
            /// </summary>
            public bool Dirction { get; set; }
            
            
            /// <summary>
            /// TurnStatus
            /// </summary>
            public bool TurnStatus { get; set; }

            /// <summary>
            /// 款号尺码(模板名)
            /// </summary>
            public string StyleSize { get; set; }

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

        private void GridWorkSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CabinetId = Convert.ToInt16( GridWorkSite.CurrentRow.Cells["CabinetId"].Value);
            GetGridCabinetLight();
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            //新增

            WorkSite s1 = new WorkSite();
            s1.ShowDialog();
            GetGridWorkSite();
            GetGridCabinetLight();
        }

        private void txButton3_Click(object sender, EventArgs e)
        {
            //修改
            List<string> selectlist = new List<string>();
            if (GridWorkSite.CurrentRow.Cells.Count > 0)
            {
                for (int i = 0; i < GridWorkSite.ColumnCount; i++)
                {
                    selectlist.Add(GridWorkSite.CurrentRow.Cells[i].Value.ToString().Trim());
                }
            }

            WorkSite s1 = new WorkSite(selectlist);
            s1.ShowDialog();
            GetGridWorkSite();
            GetGridCabinetLight();
        }

        private void txButton4_Click(object sender, EventArgs e)
        {
            //新增CabinetLight
            CabinetLight s1 = new CabinetLight();
            s1.ShowDialog();
            GetGridWorkSite();
            GetGridCabinetLight();
        }

        private void txButton6_Click(object sender, EventArgs e)
        {
            if (GridWorkSite.Rows.Count==0 || GridCabinetLight.Rows.Count == 0)
            {
                return;
            }
            int anotherID = 0;
            List<string> lista = new List<string>();

            if (GridCabinetLight.CurrentRow.Cells.Count>0)
            {
                for (int i = 0; i < GridCabinetLight.ColumnCount; i++)
                {
                    if (GridCabinetLight.CurrentRow.Cells[i].Value==null)
                    {
                        lista.Add("");
                    }
                    else
                    {
                        lista.Add(GridCabinetLight.CurrentRow.Cells[i].Value.ToString().Trim());
                    }
                }
            }

            //修改CabinetLight
            int v = 0;//生产线
            if (MDI_Class.RS_ID == 1)//生产线
            {
                v = 0;
                List<int> listb = new List<int>();
                for (int i = 0; i < GridCabinetLight.RowCount; i++)
                {
                    // string a= GridCabinetLight.Rows[i].Cells["LightName"].Value.ToString();
                    string selecta = GridCabinetLight.CurrentRow.Cells["LightName"].Value.ToString().Trim();
                    string selectid = GridCabinetLight.CurrentRow.Cells["Id"].Value.ToString().Trim();

                    if(GridCabinetLight.Rows[i].Cells["LightName"].Value.ToString().Trim() == selecta && GridCabinetLight.Rows[i].Cells["Id"].Value.ToString().Trim() != selectid)
                    {
                        listb.Add(Convert.ToInt16(GridCabinetLight.Rows[i].Cells["Id"].Value. ToString().Trim()));
                    }
                }
                if (listb.Count > 1)
                {
                    //一般不会出现大于两行的情况
                    MessageBox.Show("查找到了超过两个LightName相同的行", "提示"); return;
                }
                else if (listb.Count == 1)
                {
                    anotherID = listb[0];
                }

            }
            else
            //if (MDI_Class.RS_ID == 7)//设备
            {
                v = 1;//设备
                anotherID = 0;
            }



            CabinetLight s1 = new CabinetLight(v,lista,anotherID);

            s1.ShowDialog();
            GetGridCabinetLight();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txButton3_Click_1(object sender, EventArgs e)
        {
            List<string> ws = new List<string>();
            string id = GridWorkSite.CurrentRow.Cells["Id"].Value.ToString().Trim();


            if (GridWorkSite.CurrentRow.Cells.Count > 0)
            {
                for (int i = 0; i < GridWorkSite.ColumnCount; i++)
                {
                    if (GridWorkSite.CurrentRow.Cells[i].Value == null)
                    {
                        ws.Add("");
                    }
                    else
                    {
                        ws.Add(GridWorkSite.CurrentRow.Cells[i].Value.ToString().Trim());
                    }
                }
            }

            WorkSite s1 = new WorkSite(ws);
            s1.ShowDialog();
            GetGridCabinetLight();

        }

        private void txButton1_Click_1(object sender, EventArgs e)
        {
            WorkSite s1 = new WorkSite();
            s1.ShowDialog();
            GetGridCabinetLight();

        }

        private void txButton2_Click(object sender, EventArgs e)
        {

        }

        private void txButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
