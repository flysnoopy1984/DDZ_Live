using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using TcpIpCore.Entity;

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
        private Thread _ThreadReceive;

        public delegate void AcceptConnectHandler(EndPoint remotePoint);
        public event AcceptConnectHandler AfterAccept;

        public delegate void ReceiveHandler(TransferObject transObject);
        public event ReceiveHandler AfterReceive;
    
    

        private ManualResetEvent _AcceptSign = new ManualResetEvent(false);

        public void StartServer(string ip, int port)
        {
            _Host = ip;
            _Port = port;
        }        

        public int StartServer()
        {
            try
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
            catch
            {
                return -2;
            }
            return _ServerState;
        }

        public void StopServer()
        {
            _ServerState = -1;
        }

        void Listening()
        {
            while (_ServerState > 0)
            {
                _AcceptSign.Reset();
                _Socketlistener.BeginAccept(new AsyncCallback(HandleAcceptCallBack), _Socketlistener);
                _AcceptSign.WaitOne();
            }
        }

        void HandleAcceptCallBack(IAsyncResult ar)
        {
            Socket handle = _Socketlistener.EndAccept(ar);
            _AcceptSign.Set();
            if (AfterAccept != null)
            {
                AfterAccept(handle.RemoteEndPoint);
            }
            TransferObject transObj = new TransferObject();
            transObj.HandlingStock = handle;

            handle.BeginReceive(transObj.Buffer, 0, transObj.Buffer.Length, SocketFlags.None, new AsyncCallback(HandleReceiveCallBack), transObj);

        }

        void HandleReceiveCallBack(IAsyncResult ar)
        {
            TransferObject transObj = (TransferObject) ar.AsyncState;
            Socket recHandle = transObj.HandlingStock;

            int recSize = recHandle.EndReceive(ar);
            if (recSize > 0)
            {
                if (AfterReceive == null)
                {
                    AfterReceive(transObj);
                }
            }
        }
    }
}
