using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    public class NetRemoteServer:Serveur
    {
        public TcpChannel channel { get; set; }
    }
}
