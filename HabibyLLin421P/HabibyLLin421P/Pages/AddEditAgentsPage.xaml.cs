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
using HabibyLLin421P.MainBase;
using HabibyLLin421P.Pages;
using Microsoft.Win32;
using System.IO;

namespace HabibyLLin421P.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditAgentsPage.xaml
    /// </summary>
    public partial class AddEditAgentsPage : Page
    {
        Agent _agent;
        public static byte[] imageData = new byte[] { };
        public AddEditAgentsPage(Agent agent)
        {
            InitializeComponent();
            _agent = agent;
            TypeId.ItemsSource = App.myBase.AgentType.ToList().Select(x => x.Title);

            AdressTb.Text = _agent.Address;
            DirectorTb.Text = _agent.DirectorName;
            EmailTb.Text = _agent.Email;
            PhoneTb.Text = _agent.Phone;
            PriorutyTb.Text = _agent.Priority.ToString();
            TypeId.SelectedIndex = _agent.AgentTypeID-1;
            INNtb.Text = _agent.INN;
            KPPtb.Text = _agent.KPP;
            NameTb.Text = _agent.Title;
            if (_agent.LogoSource != null) MainImage.Source = BinaryToImage(_agent.LogoSource);
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = ImageFromPC();
            MainImage.Source = bitmapImage;
        }
        public static BitmapImage BinaryToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
            {
                return null;
            }

            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream streamSource = new MemoryStream(imageData))
            {
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = streamSource;
                bitmapImage.EndInit();
            }

            return bitmapImage;
        }
        public static BitmapImage ImageFromPC()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                if (string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    throw new ArgumentException("Имя файла не указано.");
                }

                if (!File.Exists(openFileDialog.FileName))
                {
                    throw new FileNotFoundException("Файл не найден.", openFileDialog.FileName);
                }

                imageData = File.ReadAllBytes(openFileDialog.FileName);
                return BinaryToImage(imageData);
            }

            return null;
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new AgentListPage());
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MainImage.Source = null;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_agent.ID == 0)
            {
                Agent newAgent = new Agent()
                {
                    Title = NameTb.Text,
                    Address = AdressTb.Text,
                    INN = INNtb.Text,
                    KPP = KPPtb.Text,
                    Phone = PhoneTb.Text,
                    Email = EmailTb.Text,
                    Priority = Convert.ToInt32(PriorutyTb.Text),
                    LogoSource = imageData,
                    AgentTypeID = TypeId.SelectedIndex + 2,
                    DirectorName = DirectorTb.Text,
                };
                App.myBase.Agent.Add(newAgent);
                App.myBase.SaveChanges();
            }
            else
            {
                _agent.Address = AdressTb.Text;
                _agent.DirectorName = DirectorTb.Text;
                _agent.Email = EmailTb.Text;
                _agent.Phone = PhoneTb.Text;
                _agent.Priority = Convert.ToInt32(PriorutyTb.Text);
                _agent.LogoSource = imageData;
                _agent.AgentTypeID = TypeId.SelectedIndex + 2;
                _agent.INN = INNtb.Text;
                _agent.KPP = KPPtb.Text;
                _agent.Title = NameTb.Text;
                App.myBase.SaveChanges();
            }
            App.mainFrame.Navigate(new AgentListPage());
            App.agentListPage.Refresh();
        }

        private void DeleteAgentBtn_Click(object sender, RoutedEventArgs e)
        {
            App.myBase.Agent.Remove(_agent);
            App.myBase.SaveChanges();
            App.mainFrame.Navigate(new AgentListPage());
            App.agentListPage.Refresh();
        }
    }
}
