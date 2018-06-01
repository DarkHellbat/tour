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
    /// Логика взаимодействия для TourView.xaml
    /// </summary>
    public partial class TourView : Page
    {
        public TourView()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
       public List<Tour> TourList = new List<Tour>();
        private void back_Click(object sender, RoutedEventArgs e)
        {
            variables.GoBack();
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            variables.Redirect("ChangeTourPage");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var t in context.Tours)
            {
                tourview.Items.Add(t);
                TourList.Add(t);
            }
        }

        private void tourview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //tourview.CurrentCell.Item.ToString()
            //string tourName = tourview.SelectedCells.ToString();
            variables.changing = TourList[tourview.SelectedIndex];
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            context.Tours.Remove(variables.changing);
        }
    }
}
