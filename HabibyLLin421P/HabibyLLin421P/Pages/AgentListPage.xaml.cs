using HabibyLLin421P.MainBase;
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
using HabibyLLin421P.MainControls;
using HabibyLLin421P.Pages;
using System.Windows.Shapes;

namespace HabibyLLin421P.Pages
{
    /// <summary>
    /// Логика взаимодействия для AgentListPage.xaml
    /// </summary>
    public partial class AgentListPage : Page
    {
        public AgentListPage()
        {
            InitializeComponent();
            LoadData();
            App.agentListPage = this;
            TypeSort.ItemsSource = App.myBase.AgentType.Select(x => x.Title).ToList();
            //TypeSort.ItemsSource.
        }
        public void LoadData()
        {
            List<Agent> agentList = App.myBase.Agent.ToList();

            foreach (Agent agent in agentList)
            {
                AgentPanel.Children.Add(new AgentsControl(agent));
            }
        }

        public void Refresh()
        {
            AgentPanel.Children.Clear();

            List<Agent> agentList = App.myBase.Agent.ToList();

            if (SortSort.SelectedIndex == 0) agentList = agentList.OrderBy(x => x.Title).ToList();
            if (SortSort.SelectedIndex == 1) agentList = agentList.OrderByDescending(x => x.Title).ToList();
            if (SortSort.SelectedIndex == 2) agentList = agentList.OrderBy(x => x.Title).ToList();
            if (SortSort.SelectedIndex == 3) agentList = agentList.OrderBy(x => x.Title).ToList();
            if (SortSort.SelectedIndex == 4) agentList = agentList.OrderBy(x => x.Priority).ToList();
            if (SortSort.SelectedIndex == 5) agentList = agentList.OrderByDescending(x => x.Priority).ToList();

            //if (SearchSort.Text != null) agentList = agentList.Where(x => x.Email.ToLower().Contains(SearchSort.Text.ToLower()));



            if (TypeSort.SelectedItem != null) agentList = agentList.Where(x => x.AgentTypeID == TypeSort.SelectedIndex+2).ToList();

            foreach (Agent agent in agentList)
            {
                AgentPanel.Children.Add(new AgentsControl(agent));
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new AddEditAgentsPage(new Agent()));
        }

        private void SortSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SearchSort_TextChanged(object sender, TextChangedEventArgs e)
        {

            Refresh();
        }

        private void TypeSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();

        }
    }
}
