using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GigaGame
{
    public partial class App : Application
    {
        public static Client client = new("127.0.0.1");
    }
}
