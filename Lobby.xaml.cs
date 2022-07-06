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
using System.Windows.Shapes;

namespace GigaGame
{
    /// <summary>
    /// Логика взаимодействия для Lobby.xaml
    /// </summary>
    public partial class Lobby : Window
    {
        public Lobby()
        {
            InitializeComponent();
        }

        //Приглашение на игру
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //Обновление списка игроков
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Отправка сообщения о необходимости никнеймов
            byte[] nikNeed = Encoding.Unicode.GetBytes("1001");
            App.client.stream.Write(nikNeed, 0, nikNeed.Length);
            nikNeed = null;

            //Принятие никнеймов и запись его в литсбокс
            StringBuilder builder = new();
            byte[] data = new byte[1024];
            int bytes = 0;
            do
            {
                bytes = App.client.stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));

            } while (App.client.stream.DataAvailable);

            listOfPlayers.Items.Clear();
            string players = builder.ToString();
            string buffString = "";
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] != '\n')
                {
                    buffString += players[i];
                } 
                else
                {
                    listOfPlayers.Items.Add(buffString);
                    buffString = "";
                }
                
            }
        }
    }
}
