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
    /// Логика взаимодействия для ClientView.xaml
    /// </summary>
    public partial class ClientView : Page
    {
        public ClientView()
        {
            InitializeComponent();
        }
        public List<Client> ClientList = new List<Client>();
        DatabaseContext context = new DatabaseContext();
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var c in context.Clients)
            {
                clientview.Items.Add(c);
                ClientList.Add(c);
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            variables.GoBack();
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            variables.Redirect("RegistrationPage");
        }

        private void clientview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            variables.client = ClientList[clientview.SelectedIndex];
        }
    }
}
