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
    public class Client
    {
        public TcpClient tcpClient = new();
        public IPEndPoint IPEndPoint;
        public NetworkStream stream;
        public bool isConnected = false;

        // Присоединение по айпи, который написан в App.cs с помощью конструктора 

        public Client(string ip)
        {
            IPEndPoint = new IPEndPoint(IPAddress.Parse(ip), 8888);
            tcpClient.Connect(IPEndPoint);
            stream = tcpClient.GetStream();
            isConnected = true;
        }

        // Присоедениение по ip

        //public void Connect(string ip)
        //{
        //    IPEndPoint = new IPEndPoint(IPAddress.Parse(ip), 8888);
        //    tcpClient.Connect(IPEndPoint);
        //    stream = tcpClient.GetStream();
        //    isConnected = true;
        //}

        public int Disconnect()
        {
            tcpClient.Close();
            return 0;
        }
    }
}