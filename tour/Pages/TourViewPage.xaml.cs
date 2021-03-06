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
    /// Логика взаимодействия для TourViewPage.xaml
    /// </summary>
    public partial class TourViewPage : Page
    {
        public TourViewPage()
        {
            InitializeComponent();
        }
        public int num = 0;
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            name.Text = variables.TourList[num].TourName;
            rate.Text = variables.TourList[num].Rate + " звезд";
            days.Text = (variables.TourList[num].TourEnding - variables.TourList[num].TourBeginning).ToString() + " дней";
            cost.Text = variables.TourList[num].Cost.ToString();
            descr.Text = variables.TourList[num].Description;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {

            num++;
            Page_Loaded(sender, e);
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            variables.Buy = variables.TourList[num];
            variables.Redirect("BuyingPage");
        }
    }
}
