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
using HabibyLLin421P.Pages;
using HabibyLLin421P.MainBase;
using System.IO;

namespace HabibyLLin421P.MainControls
{
    /// <summary>
    /// Логика взаимодействия для AgentsControl.xaml
    /// </summary>
    public partial class AgentsControl : UserControl
    {
        Agent _agent;
        public AgentsControl(Agent agent)
        {
            InitializeComponent();
            _agent = agent;

            AgentName.Text = _agent.Title;
            if (_agent.LogoSource != null) LogoImage.Source = BinaryToImage(_agent.LogoSource);
            PhoneName.Text = _agent.Phone;
            TypeName.Text = _agent.AgentType.Title;
            PriorName.Text = _agent.Priority.ToString();
            if (_agent.LogoSource == null) LogoImage.Source = new BitmapImage(new Uri("\\Resources\\picture.png", UriKind.Relative));
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
        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            App.mainFrame.Navigate(new AddEditAgentsPage(_agent));
        }
    }
}
