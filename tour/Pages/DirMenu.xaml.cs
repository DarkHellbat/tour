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
    /// Interaction logic for DirMenu.xaml
    /// </summary>
    public partial class DirMenu : Page
    {
        public DirMenu()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        public List<Order> Orders = new List<Order>();
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            variables.Exit();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void orderreport_Checked(object sender, RoutedEventArgs e)
        {
            orderview.Visibility = Visibility.Visible;
            complview.Visibility = Visibility.Hidden;
            orderview.Items.Clear();
            foreach(var o in context.Orders.Include("Tour").Include("Worker"))
            {
                orderview.Items.Add(o);
                //Orders.Add(o);
            }
            //MessageBox.Show("На данный момент зарегистрированных заказов нет");
        }

        private void complreport_Checked(object sender, RoutedEventArgs e)
        {
            orderview.Visibility = Visibility.Hidden;
            complview.Visibility = Visibility.Visible;
            complview.Items.Clear();
            foreach(var c in context.Complains.Include("Tour"))
            {
                complview.Items.Add(c);
            }
            if(complview.Items.Count==0)
            MessageBox.Show("На данный момент зарегистрированных претензий нет");
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не подключен принтер. Пожалуйства, подключите принтер и повторите попытку");
        }
    }
}
