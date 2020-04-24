using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace vkr
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        private NavigationWindow navigationWindow;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            navigationWindow = new NavigationWindow();
            navigationWindow.Height = 600;
            navigationWindow.Width = 900;
            var page = new Page1();
            navigationWindow.Navigate(page);
            navigationWindow.Show();
        }
    }
}
