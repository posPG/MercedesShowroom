using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for user navigation
    /// </summary>
    public partial class Menu : System.Windows.Controls.Page
    {
        /// <summary>
        /// Menu initializer 
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Navigate to first Mercedes car configurations
        /// </summary>
        /// <param name="sender">Sender context</param>
        /// <param name="e">Event stack</param>
        public void toFirstCarConfig(object sender, RoutedEventArgs e)
        {
            using (StreamWriter ff = new StreamWriter("choice.txt"))
            {
                ff.Write("1");
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CarsConfigs.xaml", UriKind.RelativeOrAbsolute));

        }

        /// <summary>
        /// Navigate to second Mercedes car configurations
        /// </summary>
        /// <param name="sender">Sender context</param>
        /// <param name="e">Event stack</param>
        private void toSecondCarConfig(object sender, RoutedEventArgs e)
        {
            using (StreamWriter ff = new StreamWriter("choice.txt"))
            {
                ff.Write("2");
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CarsConfigs.xaml", UriKind.RelativeOrAbsolute));
        }

        /// <summary>
        /// Navigate to third Mercedes car configurations
        /// </summary>
        /// <param name="sender">Sender context</param>
        /// <param name="e">Event stack</param>
        private void toThirdCarConfig(object sender, RoutedEventArgs e)
        {
            using (StreamWriter ff = new StreamWriter("choice.txt"))
            {
                ff.Write("3");
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CarsConfigs.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
