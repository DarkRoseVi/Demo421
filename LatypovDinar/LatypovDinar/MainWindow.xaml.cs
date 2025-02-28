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
        }
    }
}
