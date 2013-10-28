using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TcpIpCore
{
    public class BasicServer
    {
        private Socket _Socketlistener = null;
        private IPEndPoint _EndPoint;
        private string _Host = "127.0.0.1";
        private int _Port = 8888;
        private int _BlockLog = 5;      
        private int _ServerState;
        private Thread _ThreadServerListen;        

        public void StartServer()
        {
            
            _Socketlistener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(_Host);
            _EndPoint = new IPEndPoint(ip, _Port);

            _Socketlistener.Bind(_EndPoint);
            _Socketlistener.Listen(_BlockLog);

            _ThreadServerListen = new Thread(new ThreadStart(Listening));
            _ThreadServerListen.Start();

            _ServerState = 1;
        }

        public void StopServer()
        {
            _ServerState = -1;
        }

        void Listening()
        {
            while (_ServerState > 0)
            {
                _Socketlistener.BeginAccept(new AsyncCallback(HandleAccept), _Socketlistener);

            }
        }

        void HandleAccept(IAsyncResult ar)
        {
            Socket handle = _Socketlistener.EndAccept(ar);   

        }

        void HandleReceive()
        {

        }
    }
}
