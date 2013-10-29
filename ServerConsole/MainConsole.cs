using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TcpIpCore;
using System.Net;
using System.Threading;
using TcpIpCore.Entity;

namespace ServerConsole
{
    public partial class MainConsole : Form
    {
        private BasicServer _Server;
       

        public MainConsole()
        {
            InitializeComponent();
            _Server = new BasicServer();
            _Server.AfterAccept += new BasicServer.AcceptConnectHandler(Server_AfterAccept);
            _Server.AfterReceive += new BasicServer.ReceiveHandler(Server_AfterReceive);

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }

        void Server_AfterReceive(TransferObject transObject)
        {
            string text = Encoding.Default.GetString(transObject.Buffer, 0, TransferObject.BufferSize);
            tb_Info.AppendText("新的消息："+text+"\n");
        }

        void Server_AfterAccept(EndPoint remotePoint)
        {
            tb_Info.AppendText("新客户链接\n");
        }

        private void bn_Start_Click(object sender, EventArgs e)
        {
            tb_Info.AppendText("服务器 127.0.0.1 开启\n");
            tb_Info.AppendText("端口:8888\n");
            int state = _Server.StartServer();
            if (state > 0)
            {
                tb_Info.AppendText("监听中......\n");
            }
            else
            {
                tb_Info.AppendText("Error:" + state+"\n");
            }
        }

        private void bn_End_Click(object sender, EventArgs e)
        {
            _Server.StopServer();
            tb_Info.AppendText("服务器 关闭");
        }
    }
}
