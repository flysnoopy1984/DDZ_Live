using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TcpIpCore;
using TcpIpCore.Entity;

namespace ClientDemo
{
    public partial class DDZClient : Form
    {
        private BasicClient _Client;

        public DDZClient()
        {
            InitializeComponent();

            _Client = new BasicClient();
        }

        private void bn_Connect_Click(object sender, EventArgs e)
        {
            _Client.Connect();
        }

        private void bn_Send_Click(object sender, EventArgs e)
        {
            byte[] bs = Encoding.Default.GetBytes(this.tb_SendInfo.Text);
            _Client.SendText(bs);
        }
    }
}
