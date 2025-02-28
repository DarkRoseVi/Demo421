using Demo_Korbanov.db;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo_Korbanov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static demo421Entities db = new demo421Entities();
        public static MainWindow frame;
    }
}
