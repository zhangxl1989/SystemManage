using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace System.Application
{
    /// <summary>
    /// Socket应用对象
    /// </summary>
    public class SocketService
    {
        public static bool ConnectionStatus(string host, int port, int millisecondsTimeout)
        {
            using (TcpClient client = new TcpClient())
            {
                //打开Socket连接
                var tcp = client.BeginConnect(host, port, null, null);
                //在一定时间类阻止当前线程直接获取得结果为止
                try
                {
                    tcp.AsyncWaitHandle.WaitOne(millisecondsTimeout);
                    return client.Connected;
                }
                catch (Exception ex)
                {
                    throw ex; 
                }
            }
        }
    }
}
