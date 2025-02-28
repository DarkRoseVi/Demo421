using Demo_Korbanov.db;
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

namespace Demo_Korbanov.pages
{
    /// <summary>
    /// Логика взаимодействия для agent_full_info_page.xaml
    /// </summary>
    public partial class agent_full_info_page : Page
    {
        public agent_full_info_page(Agent agent)
        {
            InitializeComponent();
            KPP.Text = $"КПП {agent.KPP.ToString()}";
            INN.Text = $"ИНН {agent.INN.ToString()}";
            var type = App.db.AgentType.FirstOrDefault(c=> c.ID == agent.AgentTypeID);
            AgentTyp1e.Text = $"Тип: {type.Title}";
            DirectorTb.Text = $"Директор {agent.DirectorName}";
            emailtb.Text = $"Почта{agent.Email}";
            phoneTb.Text = $"Номер{agent.Phone}";
            priorit1y.Text = $"Приоритет {agent.Priority.ToString()}";
            AdressAgent.Text = $"{agent.Address}";
            if (agent.image_bun != null)
            {
                Logo.Source = Photo(agent.image_bun);
            }
            

        }
        private BitmapImage Photo(byte[] byteImage)
        {
            if (byteImage != null)
            {
                MemoryStream byteStream = new MemoryStream(byteImage);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                return image;
            }
            return new BitmapImage(new Uri(@"images\logo.png", UriKind.Relative));

        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new agents_list_page());
        }
    }
}
