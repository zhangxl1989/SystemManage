using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SystemService
{
    public partial class SystemService : ServiceBase
    {
        public SystemService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            File.WriteAllText(path + "\\1.log", "打印服务");
        }

        protected override void OnStop()
        {
        }
    }
}
