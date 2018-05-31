﻿using System;
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
    /// Interaction logic for CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
        }
        public List<int> rate;
        public DatabaseContext context = new DatabaseContext();
        private void find_Click(object sender, RoutedEventArgs e)
        {
           

           foreach (var t in context.Tours)
            {
                
              if(t.Destination==country.Text)
                {
                    for (int i = 0; i <= rate.Count; i++)//проверка соответствия рейтинга найденного тура
                    {

                    }
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var c in context.Countries)
            {
                country.Items.Add(c);
            }
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            rate.Add(2);
        }

        private void r2_Checked(object sender, RoutedEventArgs e)
        {
            rate.Add(3);
        }

        private void r3_Checked(object sender, RoutedEventArgs e)
        {
            rate.Add(4);
        }

        private void r4_Checked(object sender, RoutedEventArgs e)
        {
            rate.Add(5);
        }
    }
}
