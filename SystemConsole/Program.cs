using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Application;

namespace SystemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "61.135.169.121";
            int port = 80;
            int outTime = 5000;
            Task.Factory.StartNew(() =>
            {
                SystemStatus:
                Thread.Sleep(outTime);
                //循环验证是否服务可以访问
                var connectionStatus = SocketService.ConnectionStatus(host, port, outTime);
                //验证是否正常连接系统
                if (connectionStatus)
                {
                    Console.WriteLine(connectionStatus);
                }
                else
                {
                    Console.WriteLine(connectionStatus);
                }
                goto SystemStatus;
            });
            Console.ReadLine();
        }
    }
}
