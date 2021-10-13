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
    public partial class CabinetLight : txMainFormEnterTab
    {
        /// <summary>
        /// 新增
        /// </summary>
        public CabinetLight()
        {

            InitializeComponent();
            modifyornew = 0;
        }

        
        /// <summary>
        /// 选中行的信息
        /// </summary>
        private List<string> lst = new List<string>();

        /// <summary>
        /// 0新增 1修改
        /// </summary>
        int modifyornew = -1;
        /// <summary>
        /// 身份识别v=0生产线 v=1设备
        /// </summary>
        int vv = -1;

        
        /// <summary>
        /// 生产线同时要更改的ID行
        /// </summary>
        int ReceiveanotherID = 0;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">v=0生产线 v=1设备</param>
        /// <param name="ReceiveList">选中行的数据</param>
        /// <param name="anotherID">生产线传另一个ID，设备传0</param>
        public CabinetLight(int v, List<string> ReceiveList, int anotherID)
        {
            modifyornew = 1;
           lst = ReceiveList;
            ReceiveanotherID = anotherID;
            InitializeComponent();
            if (v == 0)
            {
                vv = 0;
                tbCabinetId.Enabled = false;
                tbControlBoardAddress.Enabled = false;
                tbControlPort.Enabled = false;
                cbControlBoardModel.Enabled = false;
                tbLightName.Enabled = true;
                cbDirction.Enabled = false;
                tbStyleSize.Enabled = true;
            }
            else if (v == 1)
            {
                vv = 1;
                tbCabinetId.Enabled = false;
                tbControlBoardAddress.Enabled = true;
                tbControlPort.Enabled = true;
                cbControlBoardModel.Enabled = true;
                tbLightName.Enabled = true;
                cbDirction.Enabled = true;
                tbStyleSize.Enabled = true;
            }


        }


        

        private void CabinetLight_Load(object sender, EventArgs e)
        {
            LightId.Text = "";
            if (lst.Count == 0)
            {
                LightId.Text = "";
                tbCabinetId.Text = "";
                tbControlBoardAddress.Text = "";
                tbControlPort.Text = "";
                cbControlBoardModel.Text = "";
                tbLightName.Text = "";
                cbDirction.Text = "";
                tbStyleSize.Text = "";
            }
            else
            {
                //ReceiveList各列说明
                //ReceiveList[0]:id
                LightId.Text = lst[0];
                //ReceiveList[1]:CabinetId
                tbCabinetId.Text = lst[1];
                //ReceiveList[2]:ControlBoardAddress
                tbControlBoardAddress.Text = lst[2];
                //ReceiveList[3]:ControlPort
                tbControlPort.Text = lst[3];
                //ReceiveList[4]:ControlBoardModel
                cbControlBoardModel.Text = lst[4];
                //ReceiveList[5]:LightName
                tbLightName.Text = lst[5];
                //ReceiveList[6]:Dirction
                //if (lst[6] == "True")
                //{
                //    cbDirction.SelectedValue = true;
                //}
                //else
                //{
                //    cbDirction.SelectedValue = false;
                //}

                cbDirction.Text = lst[6];
                //ReceiveList[7]:TurnStatus
                //ReceiveList[8]:StyleSize
                tbStyleSize.Text = lst[8];
            }




        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            if (modifyornew == 1)
            {   
                string CabinetLightAddress = "http://172.16.1.17:8004/api/CabinetLight?LightId=";
                //车间修改：
                string CabinetLightLightName = "&LightName=" + tbLightName.Text.Trim();
                string CabinetLightStyleSize = "&StyleSize=" + tbStyleSize.Text.Trim();
                //设备增加修改：
                string CabinetLightControlBoardAddress = " & ControlBoardAddress = " + tbControlBoardAddress.Text.Trim();
                string CabinetLightControlPort = "& ControlPort="+tbControlPort.Text.Trim();
                string CabinetLightControlBoardModel = "&ControlBoardModel=" + cbControlBoardModel.Text.Trim();
                string CabinetLightDirction = "&Dirction=" + cbDirction.Text;


                if (vv == 0)//生产线修改
                {
                    string cmd0 = CabinetLightAddress + LightId.Text.Trim();//第一行
                    string cmd1= CabinetLightAddress + ReceiveanotherID;//第二行
                    if (tbLightName.Text.Trim() != lst[5])
                    {
                        cmd0 = cmd0 + CabinetLightLightName;
                        cmd1 = cmd1 + CabinetLightLightName;
                    }
                    if (tbStyleSize.Text.Trim() != lst[8])
                    {
                        cmd0 = cmd0 + CabinetLightStyleSize;
                        cmd1 = cmd1 + CabinetLightStyleSize;

                    }
                    if (cmd0 == CabinetLightAddress)
                    {
                        MessageBox.Show("没有更改任何内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //更改第一行
                    string answer = CommonLib.HttpUtils.HttpPost(cmd0, "", method: "PUT").ToString();
                    if (answer != "")
                    {
                        MessageBox.Show(answer, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //更改第二行
                    answer = CommonLib.HttpUtils.HttpPost(cmd1, "", method: "PUT").ToString();
                    if (answer != "")
                    {
                        MessageBox.Show(answer, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }




                }
                else if(vv == 1)//设备修改
                {
                    string cmd0 = CabinetLightAddress + LightId.Text.Trim();//第一行
                    if (tbLightName.Text.Trim() != lst[5])
                    {
                        cmd0 = cmd0 + CabinetLightLightName;
                    }
                    if (tbStyleSize.Text.Trim() != lst[8])
                    {
                        cmd0 = cmd0 + CabinetLightStyleSize;
                    }
                    cmd0 = cmd0 + CabinetLightControlBoardAddress + CabinetLightControlPort + CabinetLightControlBoardModel + CabinetLightDirction;
                    string answer = CommonLib.HttpUtils.HttpPost(cmd0, "", method: "PUT").ToString();
                    if (answer != "")
                    {
                        MessageBox.Show(answer, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            else if (modifyornew == 0)
            {
                string CabinetLightAddress = "http://172.16.1.17:8004/api/CabinetLight?CabinetId=" + tbCabinetId.Text.Trim() + "&ControlBoardAddress=" + tbControlBoardAddress.Text.Trim() + "&ControlPort="+tbControlPort.Text.Trim()+"&ControlBoardModel=" + cbControlBoardModel.Text.Trim() + "&LightName=" + tbLightName.Text.Trim() + "&Dirction=" + cbDirction.Text + "&StyleSize=" + tbStyleSize.Text.Trim();

                string answer = CommonLib.HttpUtils.HttpPost(CabinetLightAddress, "", method: "POST").ToString();

                if (answer != "")
                {
                    MessageBox.Show(answer, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            MessageBox.Show("成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();


        }
        private void GetComboDirction()
        {

        }

        private void tbCabinetId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbControlBoardAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbControlPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}


