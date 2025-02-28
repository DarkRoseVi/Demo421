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
    }
}
