using System.Windows.Controls;

namespace LatypovDinar
{
    public static class Navigation
    {
        public static MainWindow MainWindow { get; private set; }
        public static void Initialize(MainWindow window)
        {
            MainWindow = window;
        }

        public static void NextPage(Page page)
        {
            if (MainWindow != null) MainWindow.MainFrame.Navigate(page);
        }

        public static void BackPage()
        {
            if (MainWindow != null && MainWindow.MainFrame.CanGoBack) MainWindow.MainFrame.GoBack();
        }
    }
}
