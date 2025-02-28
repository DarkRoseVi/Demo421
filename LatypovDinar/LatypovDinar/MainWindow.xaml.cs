using LatypovDinar.Pages;
using System.IO;
using System.Windows;

namespace LatypovDinar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.Initialize(this);
            Navigation.NextPage(new MainPage());
            Dinar();
        }

        private void Dinar()
        {
            string path = @"C:\Users\212111\Desktop\Демо\КОД 1.2._ВАРИАНТ_7\Сессия 1\agents_import";

            foreach(var a in App.db.Agent)
            {
                if(a.Logo != "" && a.Logo != null)
                {
                    a.LogoPhoto = File.ReadAllBytes(path + a.Logo);
                }
                
            }
            App.db.SaveChanges();
        }
    }
}
