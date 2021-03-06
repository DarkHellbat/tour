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
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Page
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void clientlist_Click(object sender, RoutedEventArgs e)
        {
            variables.Redirect("ClientView");
        }

        private void findtour_Click(object sender, RoutedEventArgs e)
        {
            variables.Redirect("ChangeTourPage");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            variables.Exit();
        }
    }
}
