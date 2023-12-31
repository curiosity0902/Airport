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

namespace Airport.Pages
{
    /// <summary>
    /// Логика взаимодействия для AllWorkersPage.xaml
    /// </summary>
    public partial class AllWorkersPage : Page
    {
        public static AddWorkerPage 
        public AllWorkersPage()
        {
            InitializeComponent();
        }

        private void AddWorkerBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddWorkerPage());
        }

        private void EditWorkerBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditWorkerPage());
        }

        private void DeleteWorkerBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddWorkerPage());
        }
    }
}
