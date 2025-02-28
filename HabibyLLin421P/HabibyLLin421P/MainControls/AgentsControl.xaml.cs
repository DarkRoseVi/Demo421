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
        }
    }
}
