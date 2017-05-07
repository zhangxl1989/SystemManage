using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace System.Application
{
    /// <summary>
    /// ping应用
    /// </summary>
    public class PingService : IDisposable
    {
        private Ping _Ping;
        private PingReply _PingReply;

        /// <summary>
        /// 一次Ping所需要的丢包数  
        /// <200 true 否则false
        /// </summary>
        public bool TTLStatus
        {
            get
            {
                return _PingReply.Options.Ttl < 200;
            }
        }
        /// <summary>
        /// 延时丢包数
        /// </summary>
        public int TTL
        {
            get
            {
                return _PingReply.Options.Ttl;
            }
        }
        /// <summary>
        /// 访问所需要时间
        /// </summary>
        public long PingTimeOut
        {
            get
            {
                return _PingReply.RoundtripTime;
            }
        }
        /// <summary>
        /// 初始化PingService
        /// </summary>
        /// <param name="host">访问地址</param>
        public PingService(string host)
        {
            _Ping = new Ping();
            _PingReply = _Ping.Send(host);
        }
        public void Dispose()
        {
            this._Ping.Dispose();
        }
    }
}
