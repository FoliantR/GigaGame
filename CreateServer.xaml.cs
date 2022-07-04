using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GigaGame
{
    /// <summary>
    /// Логика взаимодействия для CreateServer.xaml
    /// </summary>
    public partial class CreateServer : Window
    {
        public CreateServer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TcpListener serverSocket = new(IPAddress.Any, int.Parse(port.Text));
            MessageBox.Show("Server started");
            serverSocket.Start();

            serverSocket.Stop();
        }
    }
}
