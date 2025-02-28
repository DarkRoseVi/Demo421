using Demo_Korbanov.pages;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Demo_Korbanov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.frame = this;
            MainFrame.Navigate(new agents_list_page());
            //var path = @"C:\Users\212109\Desktop\КОД 1.2._ВАРИАНТ_7\Сессия 1\agents_import\";
            //foreach (var item in App.db.Agent.ToArray())
            //{
            //    if (item.Logo != null)
            //    {
            //        var fullPath = path + item.Logo;
            //        item.image_bun = File.ReadAllBytes(fullPath);
            //    }

            //}
            //App.db.SaveChanges();
        }

        private void agents_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new agents_list_page());
        }
    }
}
