using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Configuration.Install;
using System.Application;
using System.Reflection;
using System.Diagnostics;
using System.Collections;

namespace SystemForms
{
    public partial class SystemForm : Form
    {
        public SystemForm()
        {
            InitializeComponent();
        }

        private void tlsButSetup_Click(object sender, EventArgs e)
        {
            using (TransactedInstaller transactedInstaller = new TransactedInstaller())
            {
                var serverFilePath = tbx_ServicePath.Text.Trim();
                var serverName = tbx_DispName.Text.Trim();

                if (ServiceController.GetServices().Any(x => x.ServiceName == serverName))
                {
                    MessageBox.Show($"{serverName}服务以经安装。");
                    return;
                }
                if (!string.IsNullOrEmpty(tbx_ServicePath.Text))
                {
                    transactedInstaller.Installers.Add(new ServiceProcessInstaller
                    {
                        Account = ServiceAccount.LocalSystem
                    });
                    transactedInstaller.Installers.Add(new ServiceInstaller
                    {
                        ServiceName = serverName,
                        Description = tbx_Service_Content.Text,
                        DisplayName = serverName,
                        StartType = ServiceStartMode.Automatic
                    });
                    transactedInstaller.Context = new InstallContext();
                    transactedInstaller.Context.Parameters["assemblypath"] = "\"" + serverFilePath + "\" /service";
                    //transactedInstaller.Context.Parameters["assemblypath"] = "\"" + Assembly.GetEntryAssembly().Location + "\" /service";
                    transactedInstaller.Install(new Hashtable());

                    tbx_Content.Text = string.Empty;
                    tbx_Content.Text = $"安装服务成功。";
                }
                else
                {
                    MessageBox.Show("请先选择文件路径在安装服务。");
                }
            }
        }

        private void tlsButOpenDic_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "explorer.exe";
            ps.Arguments = AppDomain.CurrentDomain.BaseDirectory;
            Process.Start(ps);
        }

        private void OpenFileByButtion_Click(object sender, EventArgs e)
        {
            //openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.ShowDialog();

            string path = openFileDialog.FileName;

            if (path.Equals("openFileDialog1"))
            {
                return;
            }

            //获取服务名称
            tbx_ServicePath.Text = path;

            //获取服务名称
            Assembly asembly = Assembly.LoadFile(path);
            foreach (var type in asembly.GetTypes().Where(x => x.BaseType == typeof(System.ServiceProcess.ServiceBase)))
            {
                //var serverName = Activator.CreateInstance(type);
                tbx_DispName.Text = type.Name;
                break;
                //FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Default | BindingFlags.Instance | BindingFlags.Static);
                //foreach (FieldInfo myFieldInfo in fieldInfos)
                //{
                // if (myFieldInfo.FieldType == typeof(System.ServiceProcess.ServiceInstaller))
                //  {
                //      ServiceInstaller serviceInstaller = (ServiceInstaller)myFieldInfo.GetValue(Activator.CreateInstance(type));
                //       return serviceInstaller.ServiceName;
                //}
                //}
            }

        }

        private void btn_Ping_val_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化Ping服务
                using (PingService pingService = new PingService(tbx_Host.Text.Trim()))
                {
                    if (pingService.TTLStatus)
                    {
                        text_PingContent.Text = string.Empty;
                        text_PingContent.Text = $"访问花费时间(毫秒)：{pingService.PingTimeOut}，丢包数量：{pingService.TTL},此连接：{tbx_Host.Text.Trim()}状态良好！";
                    }
                    else
                    {
                        text_PingContent.Text = string.Empty;
                        text_PingContent.Text = $"访问花费时间(毫秒)：{pingService.PingTimeOut}，丢包数量：{pingService.TTL},此连接：{tbx_Host.Text.Trim()}状态缓慢，请检查相关网络！";
                    }
                }
            }
            catch (Exception ex)
            {
                text_PingContent.Text = string.Empty;
                text_PingContent.Text = $"测试连接异常，异常原因：{ex.Message}";
            }
        }

        private void tlsButExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tlsButDel_Click(object sender, EventArgs e)
        {
            using (TransactedInstaller transactedInstaller = new TransactedInstaller())
            {
                var serverFilePath = tbx_ServicePath.Text.Trim();
                var serverName = tbx_DispName.Text.Trim();

                if (!ServiceController.GetServices().Any(x => x.ServiceName == serverName))
                {
                    MessageBox.Show($"{serverName}服务没有安装。");
                    return;
                }
                if (!string.IsNullOrEmpty(tbx_ServicePath.Text))
                {
                    transactedInstaller.Installers.Add(new ServiceProcessInstaller
                    {
                        Account = ServiceAccount.LocalSystem
                    });
                    transactedInstaller.Installers.Add(new ServiceInstaller
                    {
                        ServiceName = serverName,
                        Description = tbx_Service_Content.Text,
                        DisplayName = serverName,
                        StartType = ServiceStartMode.Automatic
                    });
                    transactedInstaller.Context = new InstallContext();
                    transactedInstaller.Context.Parameters["assemblypath"] = "\"" + serverFilePath + "\" /service";
                    //transactedInstaller.Context.Parameters["assemblypath"] = "\"" + Assembly.GetEntryAssembly().Location + "\" /service";
                    transactedInstaller.Uninstall(null);

                    tbx_Content.Text = string.Empty;
                    tbx_Content.Text = $"卸载服务成功。";
                }
                else
                {
                    MessageBox.Show("请先选择文件路径在卸载服务。");
                }
            }
        }

        private void tlsButStart_Click(object sender, EventArgs e)
        {
            var serverName = tbx_DispName.Text.Trim();

            if (string.IsNullOrEmpty(serverName))
            {
                MessageBox.Show("显示服务名称不能为空！");
                tbx_DispName.Focus();
                return;
            }

            var server = ServiceController.GetServices().FirstOrDefault(x => x.ServiceName == serverName);

            if (server != null && server.Status != ServiceControllerStatus.Running)
            {
                server.Start();
                server.WaitForStatus(ServiceControllerStatus.Running);
                tbx_Content.Text = string.Empty;
                tbx_Content.Text = $"{serverName}服务启动成功。";
            }
            else
            {
                MessageBox.Show($"{serverName}服务不存在，请安装服务。");
            }
        }

        private void tlsButStop_Click(object sender, EventArgs e)
        {
            var serverName = tbx_DispName.Text.Trim();

            if (string.IsNullOrEmpty(serverName))
            {
                MessageBox.Show("显示服务名称不能为空！");
                tbx_DispName.Focus();
                return;
            }

            var server = ServiceController.GetServices().FirstOrDefault(x => x.ServiceName == serverName);

            if (server != null && server.Status == ServiceControllerStatus.Running)
            {
                server.Stop();
                server.WaitForStatus(ServiceControllerStatus.Stopped);
                tbx_Content.Text = string.Empty;
                tbx_Content.Text = $"{serverName}服务停止成功。";
            }
            else
            {
                MessageBox.Show($"{serverName}服务不存在，请安装服务。");
            }
        }

        private void tlsButClear_Click(object sender, EventArgs e)
        {
            tbx_Service_Content.Text = tbx_Content.Text = string.Empty;
        }
    }
}
