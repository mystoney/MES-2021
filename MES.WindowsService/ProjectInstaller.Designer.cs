
namespace MES.WindowsService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerGetOrder = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerGetOrder = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerGetOrder
            // 
            this.serviceProcessInstallerGetOrder.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerGetOrder.Password = null;
            this.serviceProcessInstallerGetOrder.Username = null;
            this.serviceProcessInstallerGetOrder.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstaller1_AfterInstall);
            // 
            // serviceInstallerGetOrder
            // 
            this.serviceInstallerGetOrder.Description = "获取和刷新订单";
            this.serviceInstallerGetOrder.DisplayName = "MyService2021110900001";
            this.serviceInstallerGetOrder.ServiceName = "ServiceGetOrder";
            this.serviceInstallerGetOrder.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceInstaller1_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerGetOrder,
            this.serviceInstallerGetOrder});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerGetOrder;
        private System.ServiceProcess.ServiceInstaller serviceInstallerGetOrder;
    }
}