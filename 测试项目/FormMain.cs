using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using System.Collections;

namespace 测试项目
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region 窗体自有函数 

        #region 显示子窗口函数
        /// <summary>
        /// 显示子窗口的方法
        /// </summary>
        /// <param name="SubForm">子窗体的名字</param>
        /// <param name="m">0表示最大化，1表示不最大化，并且是弹出窗体</param>
        private void ShowForm(Form SubForm,Int16 m=0)
        {
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name==SubForm.Name)
                {
                    SubForm.Activate();
                 
                    return;
                }
            }

            if (m==0)
            {
                SubForm.MdiParent = this;
                SubForm.WindowState = FormWindowState.Maximized;
                SubForm.Show();
            }
            else
            {
                SubForm.ShowDialog();
            }
        }
        #endregion


        #region 卸载窗体菜单函数
        /// <summary>
        /// 卸载窗体菜单
        /// </summary>
        /// <param name="Menu">菜单</param>
        private void UnloadMenuStrip(MenuStrip Menu)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
            {
                UnloadMenuItemStrip(item);
                item.Visible = false;
            }

        }

        private void UnloadMenuItemStrip(ToolStripMenuItem items)
        {


            for (int i = 0; i < items.DropDownItems.Count; i++)
            {
                items.DropDownItems[i].Visible = false;


                

                if (items.DropDownItems[i] is ToolStripMenuItem)
                {
                    UnloadMenuItemStrip((ToolStripMenuItem)items.DropDownItems[i]);
                }
            }


        }
        #endregion

        
        #region 显示窗体菜单函数
        /// <summary>
        /// 显示菜单
        /// </summary>
        /// <param name="dt">用户权限表</param>
        /// <param name="Menu">待显示的菜单</param>
        /// <param name="j">传入一个变量即可</param>
        private void ShowMenuStrip(ref DataTable dt, MenuStrip Menu,ref int j)
        {
            string s;
            Boolean T = true; //用来记录上一菜单是否则为分隔线(上来默认显示是分隔菜单，为了不显示第一个分隔菜单)
            int P = -1;

            for (int i = 0; i < Menu.Items.Count; i++)
            {
                if (dt.Rows.Count==j)
                {
                    return;
                }


                if (i < 10)
                {
                    s = "00" + i.ToString();
                }
                else if (i < 100)
                {
                    s = "0" + i.ToString();
                }
                else
                {
                    s = i.ToString();
                }


                //如果sys_menu中的menu_index项目与格式化后菜单的index相同则显示
                if (dt.Rows[j]["menu_id"].ToString().ToUpper()==Menu.Items[i].Name.ToString().ToUpper() )
                {
                    T = false; //表示最后一项不是分隔线
                    P = i; //记录最后一个显示的菜单的index
                    Menu.Items[i].Visible = true;
                    j = j + 1;


                    ShowMenuItemStrip(ref dt,(ToolStripMenuItem) Menu.Items[i], s, ref j);

                }
                else
                {
                    if (!(Menu.Items[i] is ToolStripMenuItem))
                    {
                        if (T==true) //如果上一个显示的菜单是分隔线则不显示分隔线
                        {
                            Menu.Items[i].Visible = false;
                        }
                        else
                        {
                            T = true;//表示最后一项是分隔线
                            P = i;//记录最后一个显示的菜单的index
                            Menu.Items[i].Visible = true;
                        }
                    }
                    else
                    {
                        Menu.Items[i].Visible = false;
                    }
            
                }
              


            }

            if (P != -1)
            {
                if (!(Menu.Items[P] is ToolStripMenuItem))
                {
                    Menu.Items[P].Visible = false;
                }
            }
            

        }

        private void ShowMenuItemStrip(ref DataTable dt,ToolStripMenuItem MenuItems,string s,ref int j)
        {
            Boolean T = true; //用来记录上一菜单是否则为分隔线(上来默认显示是分隔菜单，为了不显示第一个分隔菜单)
            int P = -1;

            string k;

            for (int i = 0; i < MenuItems.DropDownItems.Count; i++)
            {
                if (dt.Rows.Count==j)
                {
                    return;
                }

                //如果sys_menu中的menu_index项目与格式化后菜单的index相同则显示
                if (i < 10)
                {
                   k= s + "00" + i.ToString();
                }
                else if (i < 100)
                {
                    k=s + "0" + i.ToString();
                }
                else
                {
                    k=s+i.ToString();
                }

                //如果sys_menu中的menu_index项目与格式化后菜单的index相同则显示
                if (MenuItems.DropDownItems[i].Name.ToString().ToUpper()==dt.Rows[j]["menu_id"].ToString().ToUpper())
                {
                    T = false; //表示最后一项不是分隔线
                    P = i;    //记录最后一个显示的菜单的index
                    MenuItems.DropDownItems[i].Visible = true;
                    j = j + 1;
                    ShowMenuItemStrip(ref dt, (ToolStripMenuItem)MenuItems.DropDownItems[i], k, ref j);
                }
                else
                {
                    if (!(MenuItems.DropDownItems[i] is ToolStripMenuItem))
                    {
                        if (T == true) //如果上一个显示的菜单是分隔线则不显示分隔线
                        {
                            MenuItems.DropDownItems[i].Visible = false;
                        }
                        else
                        {
                            T = true; //表示最后一项是分隔线
                            P = i;//记录最后一个显示的菜单的index
                            MenuItems.DropDownItems[i].Visible = true;
                        }
                    }
                    else
                    {
                        MenuItems.DropDownItems[i].Visible = false;
                    }
                }


            }

            if (P != -1)
            {
                if (!(MenuItems.DropDownItems[P] is ToolStripMenuItem))
                {
                    MenuItems.DropDownItems[P].Visible = false;
                }

            }

     
        }

        #endregion


        #region 显示窗体全部菜单函数
        /// <summary>
        /// 显示所有菜单
        /// </summary>
        private void Show_Main_menustrip()
        {
            for (int i = 0; i <this.MenuStrip1.Items.Count; i++)
            {
                MenuStrip1.Items[i].Visible = true;
                Show_Main_item_menustrip((ToolStripMenuItem)MenuStrip1.Items[i]);
            }
            


        }

        private void Show_Main_item_menustrip(ToolStripMenuItem MenuItems)
        {

            MenuItems.Visible = true;

            if (MenuItems.DropDownItems.Count>0)
            {
                for (int i = 0; i < MenuItems.DropDownItems.Count; i++)
                {
                    if (MenuItems.DropDownItems[i] is ToolStripMenuItem)
                    {
                        Show_Main_item_menustrip((ToolStripMenuItem)MenuItems.DropDownItems[i]);
                    }
                    else
                    {
                        MenuItems.DropDownItems[i].Visible = true;
                    }


                }
            }
   

        }




        #endregion


        #region 得到菜单的menu_index用到的函数


        /// <summary>
        /// 将界面菜单按顺序写入sys_menu表的menu_index中
        /// </summary>
        /// <param name="Menu">需要写入数库的菜单</param>
        /// <param name="AL">返回SQL语句的ArrayList</param>
        private void GetMenuStrip (MenuStrip Menu,ref ArrayList AL)
        {
            string sql = "";
            string s = "";

            sql = "update sys_menu set menu_index=null where menu_no<>'0' ";
            AL.Add(sql);

            for (int i = 0; i < Menu.Items.Count; i++)
            {
                if (i < 10)
                {
                    s = "00" + i.ToString();
                }
                else if (i < 100)
                {
                    s = "0" + i.ToString();
                }
                else
                {
                    s = i.ToString();
                }

                sql= "update sys_menu set menu_index='"+ s + "' where menu_id='" +Menu.Items[i].Name + "' and menu_no=(select top 1 menu_no from sys_menu where menu_id='" + Menu.Items[i].Name + "' and (menu_index='' or menu_index is null) order by menu_no  ) ";
                AL.Add(sql);

                GetMenuItemStrip((ToolStripMenuItem)Menu.Items[i], s, ref AL);
            }


            sql = "delete  sys_menu where menu_index is null";
            AL.Add(sql);

            sql = "delete sys_role_right where menu_no not in (select menu_no from sys_menu)";
            AL.Add(sql);

            sql = "delete sys_user_right where menu_no not in (select menu_no from sys_menu)";
            AL.Add(sql);

        }


        private void GetMenuItemStrip(ToolStripMenuItem MenuItems, string s, ref ArrayList AL)
        {
            string sql = "";
            string k = "";

            for (int i = 0; i < MenuItems.DropDownItems.Count; i++)
            {
                if (i < 10)
                {
                    k=s + "00" + i.ToString();
                }
                else if (i < 100)
                {
                    k = s + "0" + i.ToString();
                }
                else
                {
                    k = s + i.ToString();
                }

                if (MenuItems.DropDownItems[i] is ToolStripMenuItem)
                {
                    sql = "update sys_menu set menu_index='" + k + "' where menu_id='" + MenuItems.DropDownItems[i].Name + "' and menu_no=(select top 1 menu_no from sys_menu where menu_id='" + MenuItems.DropDownItems[i].Name + "' and (menu_index='' or menu_index is null) order by menu_no  ) ";
                    AL.Add(sql);

                    GetMenuItemStrip((ToolStripMenuItem)MenuItems.DropDownItems[i], k, ref AL);
                }
            }
        }


        #endregion


        #region 重设置sys_menu中的menu_index
        /// <summary>
        /// 此方法用于重新生成sys_menu中的menu_index列 
        /// </summary>
        /// <returns>是否重建成功</returns>
        private Boolean ReBuild_Menu_index()
        {

            ArrayList AL = new ArrayList();



            GetMenuStrip(this.MenuStrip1, ref AL);

            try
            {
                DBConn.DataAcess.SqlConn.ExecuteSqlTran(AL);
            }
            catch (Exception ex)
            {

                throw ex;

            }

            return true;
        }
        #endregion



        #endregion


     

        private void FormMain_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            StringBuilder cmd = new StringBuilder();

            UnloadMenuStrip(this.MenuStrip1);

            LoginFrom loginform = new LoginFrom();
            if (loginform.ShowDialog(this)==DialogResult.Cancel)
            {
                System.Environment.Exit(0);
                
            }
            

            this.ToolStripStatusLabel1.Text =MDI_Class.login_id;
            this.ToolStripStatusLabel4.Text = MDI_Class.rs_name;

            if (MDI_Class.login_id=="admin")
            {
                Show_Main_menustrip();
            }
            else
            {
                cmd.Clear();
                cmd.Append("select b.* ");
                cmd.Append("from sys_user_right a left join  ");
                cmd.Append("	sys_menu b on a.menu_no=b.menu_no ");
                cmd.Append("where a.in_user=1 and b.in_user=1 and a.login_id='" +MDI_Class.login_id + "' and b.menu_no<>'0' and menu_index is not null ");
                cmd.Append("order by b.menu_index ");

                dt = DBConn.DataAcess.SqlConn.Query(cmd.ToString()).Tables[0];

                int j = 0;
                ShowMenuStrip(ref dt, this.MenuStrip1, ref j);

            }

            
#if (DEBUG)

            重设系统菜单Menu_indexToolStripMenuItem.Visible = true;
#else
            重设系统菜单Menu_indexToolStripMenuItem.Visible = false;
#endif

        }



        #region 系统
        private void ID_公司基本信息_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            ShowForm(f1, 0);

        }

        private void ID_月结日期设定_Click(object sender, EventArgs e)
        {

        }

        private void ID_系统角色权限_Click(object sender, EventArgs e)
        {
            测试项目.系统.系统角色权限.sys_role_right sys_role_right = new 系统.系统角色权限.sys_role_right();
            ShowForm(sys_role_right);
        }

        private void ID_系统用户权限_Click(object sender, EventArgs e)
        {
            测试项目.系统.系统用户权限.sys_user_right sys_user_right = new 系统.系统用户权限.sys_user_right();
            ShowForm(sys_user_right);
        }

        #endregion


        #region 人事
        private void ID_部门资料维护_Click(object sender, EventArgs e)
        {
            测试项目.人事.部门资料维护.department department = new 测试项目.人事.部门资料维护.department();
            ShowForm(department);
        }
        private void ID_员工资料维护_Click(object sender, EventArgs e)
        {

            测试项目.人事.人员资料维护.employee employee = new 人事.人员资料维护.employee();
            ShowForm(employee);
        }
        #endregion


        #region 视图
        private void ID_更改密码_Click(object sender, EventArgs e)
        {
            测试项目.视图.newpassword newpassword = new 视图.newpassword();
            ShowForm(newpassword);

        }
        private void ID_注销_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            StringBuilder cmd = new StringBuilder();

            foreach (Form CForm in this.MdiChildren)
            {
                CForm.Close();
            }

            UnloadMenuStrip(this.MenuStrip1);

            LoginFrom loginform = new LoginFrom();

            loginform.UsernameTextBox.Text = "";
            loginform.PasswordTextBox.Text = "";

            loginform.ShowDialog();

            this.ToolStripStatusLabel1.Text = MDI_Class.login_id;
            this.ToolStripStatusLabel4.Text = MDI_Class.rs_name;


            if (MDI_Class.login_id=="admin")
            {
                Show_Main_menustrip();
            }
            else
            {
                cmd.Clear();
                cmd.Append("select b.* ");
                cmd.Append("from sys_user_right a left join  ");
                cmd.Append("sys_menu b on a.menu_no=b.menu_no ");
                cmd.Append("where a.in_user=1 and b.in_user=1 and a.login_id='" +MDI_Class.login_id + "' and b.menu_no<>'0' and menu_index is not null ");
                cmd.Append("order by b.menu_index ");

                dt.Clear();
                dt=DBConn.DataAcess.SqlConn.Query(cmd.ToString()).Tables[0];

                int j = 0;
                ShowMenuStrip(ref dt, this.MenuStrip1, ref j);
            }
            
        }

        private void ID_退出_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        #endregion


        #region 窗口
        private void ID_水平平铺_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ID_垂直平铺_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ID_层叠_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ID_排列窗口_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion


        #region 重设系统菜单
        private void 重设系统菜单Menu_indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReBuild_Menu_index();
        }
        #endregion

   
    }
}
