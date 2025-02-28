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
        }
        public void LoadData()
        {
            List<Agent> agentList = App.myBase.Agent.ToList();

            foreach (Agent agent in agentList)
            {
                AgentPanel.Children.Add(new AgentsControl(agent));
            }
        }
    }
}
