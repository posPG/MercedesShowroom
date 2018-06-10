using System.IO;
using System.Windows;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for main window
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Window initializer
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Menu();
            using (StreamWriter f = new StreamWriter("shopping_cart.txt"))
            {
                f.Write("");
            }  
        }

        /// <summary>
        /// Navigating to shopping cart
        /// </summary>
        /// <param name="sender">Sender context</param>
        /// <param name="e">Events list</param>
        private void goToShoppingCart(object sender, RoutedEventArgs e)
        {
            ShoppingCart  newCart = new ShoppingCart();
            newCart.refresh_invoke();
            Main.Content = newCart;
        }
    }
}
