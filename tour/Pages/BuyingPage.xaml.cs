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
    /// Логика взаимодействия для BuyingPage.xaml
    /// </summary>
    public partial class BuyingPage : Page
    {
        public BuyingPage()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        private void buy_Click(object sender, RoutedEventArgs e)
        {
            string l = client.SelectedItem.ToString();
               string[] ln = l.Split(',');
            Order newOrder = new Order()
            {
                Client = context.Clients.Where(c=>c.LastName==ln[0]&&c.FirstName==ln[1]).FirstOrDefault(),
                Worker = variables.current,
                OrderDate=DateTime.Now,
                Payment = context.Payments.Where(p=>p.PStatusName==payType.Text).FirstOrDefault(),
                Tour = variables.Buy 
            };
            context.Orders.Add(newOrder);
            context.SaveChanges();
            MessageBox.Show("Тур добавлен в заказы");
            variables.Redirect("AgentMenu");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var c in context.Clients)
            {
                client.Items.Add(c);
            }
            foreach(var p in context.Payments)
            {
                payType.Items.Add(p);
            }
        }
    }
}
