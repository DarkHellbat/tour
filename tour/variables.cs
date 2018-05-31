using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class variables
    {
        public static MainWindow mnw = new MainWindow();
        public static Worker current = new Worker();
        public static Client client = new Client();
        public static List<Tour> TourList = new List<Tour>();
        public static Tour Buy = new Tour();

        public static void Redirect(string PageName)
        {
            string path = String.Format(@"\Pages\{0}.xaml", PageName);
            variables.mnw.maincontainer.NavigationService.Navigate(new Uri(path, UriKind.Relative));
        }
        public static void Exit ()
        {
            variables.current = null;
            variables.mnw.maincontainer.NavigationService.Navigate(new Uri(@"\Pages\LoginPage.xaml", UriKind.Relative));
        }
        
        public static void Entered_As()
        {
          //string greeting = String.Format("Вы вошли как {0}, {1}", current.LastName, current.FirstName);  
            
        }
    }
}
