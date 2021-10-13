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
    public partial class WaitingForm : Form
    {
        private WaitingForm waitingForm = null;

        private delegate void SetTextCallBack(string text);
        private delegate void SetValueCallBack(int value);
        private delegate void CloseForm();

        public WaitingForm()
        {
            InitializeComponent();
        }

        private void WaitingForm_Load(object sender, EventArgs e)
        {

        }

        private void SetLabelText(String text)
        {
            waitingForm.LbWaitingTip.Text = text;
        }
        private void SetProgressValue(int value)
        {
            waitingForm.WaitingProgressBar.Value = value;
        }
        private void CloseWaitingForm()
        {
            waitingForm.Close();
        }

        private void WaitingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker WaitingWorker = sender as BackgroundWorker;
            for (int i = 1; i <= 10; i++)
            {
                if (WaitingWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    WaitingWorker.ReportProgress(i * 10);
                }
            }
        }


        private void WaitingBackgroundWorker_ProgressChanged(object sender,ProgressChangedEventArgs e)
        {
            this.Invoke(new SetTextCallBack(SetLabelText), e.ProgressPercentage.ToString() + "%");
            this.Invoke(new SetValueCallBack(SetProgressValue), e.ProgressPercentage);
        }


        private void WaitingBackgroundWorker_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            this.Invoke(new CloseForm(CloseWaitingForm));
        }
    }
}
