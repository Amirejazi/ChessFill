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

namespace UI_fily
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnloadgame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coming soon", ":)", MessageBoxButton.OK);
        }

        private void btnnewgame_Click(object sender, RoutedEventArgs e)
        {
            choose choose = new choose();
            this.Close();
            choose.ShowDialog();
        }

        private void closee(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
