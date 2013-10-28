using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace TcpIpCore
{
    public class BasicClient
    {
        private Socket _SocketConnect = null;
        private IPEndPoint _SrvEndPoint;
        private string _Host = "127.0.0.1";
        private int _Port = 8888;

        public void BasicClient()
        {
            InitClient();
        }

        private void InitClient()
        {

            _SocketConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(_Host);
            _SrvEndPoint = new IPEndPoint(ip, _Port);
        }

        public void Connect()
        {
            _SocketConnect.BeginConnect(_SrvEndPoint, new AsyncCallback(ConnectAsyncCallBack), _SocketConnect);            
        }

        void ConnectAsyncCallBack(IAsyncResult ar)
        {
            _SocketConnect.EndConnect(ar);
        }

    }

    
}
