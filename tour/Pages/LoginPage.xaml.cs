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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        
        }
  public DatabaseContext context = new DatabaseContext();
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Position p = new Position { PositionName = "agent" };
            context.Positions.Add(p);
            Worker w = new Worker { FirstName = "1", LastName = "2", Login = "qwert", Password = "qwert", Position = p };
            context.Workers.Add(w);
            context.SaveChanges();
            MessageBox.Show("");
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            var с = context.Workers.Include("Position");

            foreach (var l in context.Workers.Include("Position"))
            {
                if (l.Login == login.Text && l.Password == password.Password)
                {
                    variables.current = l;
                    switch(l.Position.PositionName)
                    {
                        case ("agent"):
                            {
                                variables.Redirect("AgentMenu");
                                break;
                            }
                        case ("admin"):
                            {
                                variables.Redirect("AdminMenu");
                                break;
                            }
                        case ("dir"):
                            {
                                variables.Redirect("DirMenu");
                                break;
                            }
                    }
                  

                }
            }
        }
    }
}
