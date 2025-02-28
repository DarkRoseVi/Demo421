using LatypovDinar.Databases;
using System.Windows;

namespace LatypovDinar
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DemoDemoExzBaseEntities2 db = new DemoDemoExzBaseEntities2();
    }
}
