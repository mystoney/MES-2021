using MES.module.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.form.测试
{
    public partial class ForStoney : Form
    {
        public ForStoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存组合时忘记复制item_name和option_name
            StringBuilder strsql = new StringBuilder();
            strsql.Clear();
            strsql.AppendLine("  update nMES_Style_Combination_detail ");
            strsql.AppendLine(" set nMES_Style_Combination_detail.Item_Name=ccc.Item_Name,nMES_Style_Combination_detail.Option_Name=ccc.Option_Name ");
            strsql.AppendLine(" from nMES_Style_Combination_detail, ");
            strsql.AppendLine(" ( select * from  ");
            strsql.AppendLine("  (select op.style_no,op.Item_No, op.Item_Name,op.Option_No,op.Option_Name,m.Combination_no ");
            strsql.AppendLine("  from nMES_Style_OptionList op ");
            strsql.AppendLine("  left join nMES_Style_Combination_master m ");
            strsql.AppendLine("  on op.style_no=m.Style_no) opm) ccc ");
            strsql.AppendLine("  where nMES_Style_Combination_detail.Combination_no=ccc.Combination_no and nMES_Style_Combination_detail.Item_No=ccc.Item_No and nMES_Style_Combination_detail.Option_No=ccc.Option_No ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperationBLL ob = new OperationBLL();
            string s_ToJingYuan = ob.OperationToJingYuan(0);
            if (s_ToJingYuan != "1")
            {
                MessageBox.Show("推送至JingYuan错误：" + s_ToJingYuan);
            }
        }

        private void ForStoney_Load(object sender, EventArgs e)
        {

        }
    }
}
