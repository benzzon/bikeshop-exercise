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

namespace bikeshop_exercise
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonContact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact.xaml", UriKind.Relative));
        }

        private void buttonDiscussion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Discussion.xaml", UriKind.Relative));
        }

        private void buttonProductsManagement_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ProductsManagement.xaml", UriKind.Relative));
        }

        private void buttonCurrencyConverter_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/CurrencyConverter.xaml", UriKind.Relative));
        }
    }
}
