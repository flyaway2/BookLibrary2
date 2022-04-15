using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class NETREMOTEClient:Client
    {
        public TcpChannel channel { get; set; }
    }
}
