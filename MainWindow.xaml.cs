using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GigaGame
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Connect(ip.Text.ToString());

            string mess = nik.Text.ToString();
            byte[] data = Encoding.Unicode.GetBytes(mess);
            client.stream.Write(data, 0, data.Length);

            var win = new Lobby();
            win.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
