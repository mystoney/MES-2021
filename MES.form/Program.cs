using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MES.form
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //FormMain form1 = FormMain.Instance;
            //Application.Run(form1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }


     
    }
}
