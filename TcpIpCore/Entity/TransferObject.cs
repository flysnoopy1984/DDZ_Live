using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace TcpIpCore.Entity
{
    public class TransferObject
    {
        public const int BufferSize = 2048;

        public Socket HandlingStock { get; set; }

        public byte[] Buffer = new byte[BufferSize];

    }
}
