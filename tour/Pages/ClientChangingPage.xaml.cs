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
    /// Логика взаимодействия для ClientChangingPage.xaml
    /// </summary>
    public partial class ClientChangingPage : Page
    {
        public ClientChangingPage()
        {
            InitializeComponent();
        }
        public DatabaseContext context = new DatabaseContext();
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            email.Text= variables.client.Email;
            fname.Text = variables.client.FirstName;
            gender.SelectedItem = variables.client.Gender;
            lname.Text = variables.client.LastName;
           passnum.Text = variables.client.PassportNum.ToString();
           phone.Text = variables.client.Phone.ToString();
            sname.Text = variables.client.SecondName;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            variables.mnw.maincontainer.NavigationService.GoBack();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            variables.client.Email = email.Text;
            variables.client.FirstName = fname.Text;
            variables.client.Gender = gender.Text;
            variables.client.LastName = lname.Text;
            variables.client.PassportNum = Convert.ToInt32(passnum.Text);
            variables.client.Phone = Convert.ToInt32(phone.Text);
            variables.client.SecondName = sname.Text;
            //context.Clients.(newClient);
            context.SaveChanges();
        }
    }
}
