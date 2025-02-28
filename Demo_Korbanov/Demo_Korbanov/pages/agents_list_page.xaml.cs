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
            PriorityCb.SelectedIndex = 0;


        }
        public void Refresh()
        {
            if (agents_list_wp == null) return;
            string search = SerachTb.Text.ToLower();
            IEnumerable<Agent> list = App.db.Agent.ToList().OrderBy(c => c.Title);
            if (!string.IsNullOrEmpty(search))
            {
                list = list.Where(c =>
                    c.Title.ToLower().Contains(search) ||
                    
                    c.DirectorName.ToLower().Contains(search)
                );
            }

            if (PriorityCb.SelectedIndex == 1) list = list.OrderBy(c => c.Priority);
            if (PriorityCb.SelectedIndex == 2) list = list.OrderByDescending(c => c.Priority);


            agents_list_wp.Children.Clear();
            foreach (var agent in list) agents_list_wp.Children.Add(new agent_uc(agent));

        }

        private void SerachTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void PrirityCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
