using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Demo_Korbanov.db;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Demo_Korbanov.pages;

namespace Demo_Korbanov.ucs
{
    /// <summary>
    /// Логика взаимодействия для agent_uc.xaml
    /// </summary>
    public partial class agent_uc : UserControl
    {
        Agent agent;
        public agent_uc(Agent _agent)
        {
            InitializeComponent();
            agent = _agent;
            TitleTb.Text = $"Название: {agent.Title}";
            EmailTb.Text = $"Почта: {agent.Email}";
            PhoneTb.Text = $"Номер: {agent.Phone}";
            PriorityTb.Text = $"Приоритет: {agent.Priority.ToString()}";
            DirectorTb.Text = $"Директор: {agent.DirectorName}";
        }

        private void FullInfpBtn_Click(object sender, RoutedEventArgs e)
        {
            App.frame.MainFrame.Navigate(new agent_full_info_page(agent));
        }

        private void DelBTn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалено!");
            App.db.Agent.Remove(agent);
            App.db.SaveChanges();
            App.frame.MainFrame.Navigate(new agents_list_page());
        }
    }
}
