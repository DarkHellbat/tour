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

namespace tour.Pages
{
    /// <summary>
    /// Interaction logic for AgentMenu.xaml
    /// </summary>
    public partial class AgentMenu : Page
    {
        public AgentMenu()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            entered_as.Text = entered_as.Text + variables.current.ToString();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            variables.mnw.maincontainer.NavigationService.Navigate(new Uri(@"\Pages\RegistrationPage.xaml", UriKind.Relative));
        }

        private void findtour_Click(object sender, RoutedEventArgs e)
        {
            variables.mnw.maincontainer.NavigationService.Navigate(new Uri(@"\Pages\CatalogPage.xaml", UriKind.Relative));
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            variables.current = null;
            variables.mnw.maincontainer.NavigationService.Navigate(new Uri(@"\Pages\LoginPage.xaml", UriKind.Relative));
        }
    }
}
