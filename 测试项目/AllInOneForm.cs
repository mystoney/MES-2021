using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 测试项目
{
    public partial class AllInOneForm : Form
    {

        
        public AllInOneForm()
        {
            InitializeComponent();
        }

        private void AllInOneForm_Load(object sender, EventArgs e)
        {
            AllInOneBackgroundWorker.DoWork += new DoWorkEventHandler(AllInOneBackgroundWorker_DoWork);

            AllInOneBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(AllInOneBackgroundWorker_ProgressChanged);
            AllInOneBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AllInOneBackgroundWorker_RunWorkerCompleted);
            
            this.timer1.Start();


        }

        /// <summary>
        /// 添加启动后台线程事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtStart_Click(object sender, EventArgs e)
        {
            if (AllInOneBackgroundWorker.IsBusy != true)
            {
                AllInOneBackgroundWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        ///  添加后台需要做的处理，这里以for循环10个数，每次停止500毫秒，并在此报告进度。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllInOneBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker allInOneWorker = sender as BackgroundWorker;
            for (int i = 1; i <= 10; i++)
            {
                if (allInOneWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    allInOneWorker.ReportProgress(i * 10);
                }
            }

            
        }



        /// <summary>
        /// 添加进度更新操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllInOneBackgroundWorker_ProgressChanged(object sender,ProgressChangedEventArgs e)
        {
            LbTip.Text = (e.ProgressPercentage.ToString() + "%");
            AllInOneProgressBar.Value = e.ProgressPercentage;
        }


        /// <summary>
        ///  添加后台处理完成操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllInOneBackgroundWorker_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                LbTip.Text = "已取消!";
            }
            else if (e.Error != null)
            {
                LbTip.Text = "发生异常: " + e.Error.Message;
            }
            else
            {
                LbTip.Text = "已完成!";
            }
        }


        /// <summary>
        /// 添加停止后台线程事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtStop_Click(object sender, EventArgs e)
        {
            if (AllInOneBackgroundWorker.WorkerSupportsCancellation == true)
            {
                AllInOneBackgroundWorker.CancelAsync();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AllInOneBackgroundWorker.RunWorkerAsync();
            this.timer1.Enabled = false;
        }
    }
}
