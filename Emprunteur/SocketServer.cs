using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class SocketServer
    {
        private Byte[] _buffer = new byte[1024];
        private  Socket _ServerSocket;
        private List<Socket> _clientSockets;
        public string data { get; set; }

        public SocketServer()
        {
            _ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _clientSockets = new List<Socket>();
        }
        public int Port { get; set; }

        public void SetupServer()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, Port);
            _ServerSocket.Bind(localEndPoint);
            _ServerSocket.Listen(5);
            _ServerSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private  void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _ServerSocket.EndAccept(AR);
            _clientSockets.Add(socket);
            socket.BeginReceive(_buffer,0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _ServerSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
            

        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState; ;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);
            string text = ASCIIEncoding.ASCII.GetString(dataBuf);
        }
    }
}
