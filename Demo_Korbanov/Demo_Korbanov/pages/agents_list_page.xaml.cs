using Demo_Korbanov.db;
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
using Demo_Korbanov.ucs;
namespace Demo_Korbanov.pages
{
    /// <summary>
    /// Логика взаимодействия для agents_list_page.xaml
    /// </summary>
    public partial class agents_list_page : Page
    {
        public agents_list_page()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            if (agents_list_wp == null) return;

            IEnumerable<Agent> list = App.db.Agent.ToList().OrderBy(c => c.Title);
            agents_list_wp.Children.Clear();
            foreach (var agent in list) agents_list_wp.Children.Add(new agent_uc(agent));

        }
    }
}
