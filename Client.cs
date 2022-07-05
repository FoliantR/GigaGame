using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace GigaGame
{
    internal class Client
    {
        TcpClient tcpClient = new();
        IPEndPoint IPEndPoint;
        public NetworkStream stream;
        public bool isConnected = false;

        public int Connect(string ip)
        {
            IPEndPoint = new IPEndPoint(IPAddress.Parse(ip), 8888);
            tcpClient.Connect(IPEndPoint);
            stream = tcpClient.GetStream();
            isConnected = true;
            return 0;
        }

        public int Disconnect()
        {
            tcpClient.Close();
            return 0;
        }
    }
}