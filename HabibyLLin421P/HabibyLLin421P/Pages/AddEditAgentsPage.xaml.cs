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
using EasyMCK;
using HabibyLLin421P.MainBase;
using HabibyLLin421P.Pages;

namespace HabibyLLin421P.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditAgentsPage.xaml
    /// </summary>
    public partial class AddEditAgentsPage : Page
    {
        Agent _agent;
        public AddEditAgentsPage(Agent agent)
        {
            InitializeComponent();
            _agent = agent;
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = ImageManager.ImageFromPC();
            MainImage.Source = bitmapImage;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new AgentListPage());
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
