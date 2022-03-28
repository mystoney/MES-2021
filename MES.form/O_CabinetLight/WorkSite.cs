using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.form.CabinetLight
{
    public partial class WorkSite : txMainFormEnterTab
    {
        

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="NewID">现有ID增1</param>
        public WorkSite()
        {
            InitializeComponent();
            newmodify = 0;
        }
        /// <summary>
        /// 接收修改时传入的值
        /// </summary>
        private List<string> ReseiveList = new List<string>();

        /// <summary>
        /// 异常-1 新增0,修改1
        /// </summary>
        private int newmodify=-1;

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="lst">传入选中行的值</param>
        public WorkSite(List<string> lst)
        {
            InitializeComponent();
            newmodify = 1;
            ReseiveList = lst;

        }
        

        private void WorkSite_Load(object sender, EventArgs e)
        {
            //异常 - 1 新增0,修改1
            if (newmodify == 0)
            {

                tbCabinetId.Text = "";
                tbSiteName.Text = "";
            }
            else if (newmodify == 1)
            {
            label1.Text = ReseiveList[0].ToString().Trim();
                tbSiteName.Text = ReseiveList[1].ToString().Trim();
                tbCabinetId.Text = ReseiveList[2].ToString().Trim();
            }
            else
            {
                MessageBox.Show("调用异常", "提示"); Close();
            }


        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            try
            {

                if (newmodify == 0)//新增
                {
                    string WorkSiteAddress = "http://172.16.1.17:8004/api/WorkSite?SiteName=" + tbSiteName.Text + "&CabinetId=" + tbCabinetId.Text;
                    string flagPost =CommonLib.HttpUtils.HttpPost(WorkSiteAddress, "", method: "POST");
                   
                }
                else if (newmodify == 1)
                {

                    string WorkSiteAddress = "http://172.16.1.17:8004/api/WorkSite?SiteId=" + label1.Text + "&SiteName=" + tbSiteName.Text + "&CabinetId=" + tbCabinetId.Text;
                    CommonLib.HttpUtils.HttpPost(WorkSiteAddress, "", method: "PUT");

                }
                MessageBox.Show("成功", "提示");
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
