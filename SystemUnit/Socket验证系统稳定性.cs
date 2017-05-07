using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Application;
using System.IO;

namespace SystemUnit
{
    [TestClass]
    public class Socket验证系统稳定性
    {
        [TestMethod]
        public void 业务系统服务器是否稳定()
        {
            var host = "www.baidu.com";

            using (PingService pingService = new PingService(host))
            {
                if (pingService.TTLStatus)
                {
                    Console.WriteLine(pingService.TTLStatus);
                }
            }
            
        }
        [TestMethod]
        public void 业务系统是否可以联接上()
        {
            string host = "www.baidu.com";
            int port = 80;
            //是否正常连接
            var resultStatus = SocketService.ConnectionStatus(host, port, 5000);
        }

        [TestMethod]
        public void 打印日志()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            File.WriteAllText(path + "\\1.log", "打印服务");
        }
    }
}
