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
    /// Логика взаимодействия для ChangeTourPage.xaml
    /// </summary>
    public partial class ChangeTourPage : Page
    {
        public ChangeTourPage()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var c in context.Countries)
            {
                dest.Items.Add(c);
            }
            if (variables.changing!=null)
            {
                tourname.Text = variables.changing.TourName;
                beginning.SelectedDate = variables.changing.TourBeginning;
                ending.SelectedDate = variables.changing.TourEnding;
                descr.Text = variables.changing.Description;
                dest.SelectedItem = variables.changing.Destination;
                rate.Value = variables.changing.Rate;
                cost.Text = variables.changing.Cost.ToString();
            }

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            variables.changing.TourName  = tourname.Text;
               variables.changing.TourBeginning =Convert.ToDateTime( beginning.SelectedDate) ;
              variables.changing.TourEnding = Convert.ToDateTime(ending.SelectedDate);
              variables.changing.Description = descr.Text;
              variables.changing.Destination = dest.SelectedItem.ToString();
              variables.changing.Rate =Convert.ToInt32( rate.Value);
              variables.changing.Cost = Convert.ToDecimal(cost.Text) ;
            if (variables.changing == null)
            {
                context.Tours.Add(variables.changing);
            }
            context.SaveChanges();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            variables.GoBack();
        }
    }
}
