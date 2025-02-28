using HabibyLLin421P.MainBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HabibyLLin421P
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HabibyLLin421PBaseEntities myBase = new HabibyLLin421PBaseEntities();
        public static Frame mainFrame;
    }
}
