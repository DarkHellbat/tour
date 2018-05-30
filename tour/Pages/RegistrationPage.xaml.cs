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
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Client newClient = new Client();
            newClient.Email = email.Text;
            newClient.FirstName = fname.Text;
            newClient.Gender = gender.Text;
            newClient.LastName = lname.Text;
            newClient.PassportNum = Convert.ToInt32(passnum.Text);
            newClient.Phone = Convert.ToInt32(phone.Text);
            newClient.SecondName = sname.Text;
            context.Clients.Add(newClient);
            context.SaveChanges();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            variables.mnw.maincontainer.NavigationService.GoBack();
        }
    }
}
