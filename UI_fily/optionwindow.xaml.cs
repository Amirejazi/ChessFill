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
using System.Windows.Shapes;

namespace UI_fily
{
    /// <summary>
    /// Interaction logic for optionwindow.xaml
    /// </summary>
    public partial class optionwindow : Window
    {
        public optionwindow()
        {
            InitializeComponent();
        }
        public static string rbtnground {get; set;}
        public void bordercollaps()
        {
            textureborder.Visibility = Visibility.Collapsed;
            informationborder.Visibility = Visibility.Collapsed;
            timerborder.Visibility = Visibility.Collapsed;
            soundborder.Visibility = Visibility.Collapsed;
            settingborder.Visibility = Visibility.Collapsed;
        }

        private void btntexture_Click(object sender, RoutedEventArgs e)
        {
            bordercollaps();
            textureborder.Visibility= Visibility.Visible;
            adresslabel.Content = "Texture";
        }

        private void btninformation_Click(object sender, RoutedEventArgs e)
        {
            bordercollaps();
            informationborder.Visibility = Visibility.Visible;
            adresslabel.Content = "Information";
        }

        private void btntimer_Click(object sender, RoutedEventArgs e)
        {
            bordercollaps();
            timerborder.Visibility = Visibility.Visible;
            adresslabel.Content = "Timer";
        }

        private void btnsound_Click(object sender, RoutedEventArgs e)
        {
            bordercollaps();
            soundborder.Visibility = Visibility.Visible;
            adresslabel.Content = "Sound";
        }

        private void btnsetting_Click(object sender, RoutedEventArgs e)
        {
            bordercollaps();
            settingborder.Visibility = Visibility.Visible;
            adresslabel.Content = "Setting";
        }

        private void btnnext_Click(object sender, RoutedEventArgs e)
        {
            portipserverwindow portipserverwindow = new portipserverwindow();
            this.Close();
            portipserverwindow.ShowDialog();
        }
        private void rbtngroundblue_Checked(object sender, RoutedEventArgs e)
        {
            rbtnground = "1";
        }

        private void rbtngroundblack_Checked(object sender, RoutedEventArgs e)
        {
            rbtnground = "2";
        }

        private void rbtngroundgreend_Checked(object sender, RoutedEventArgs e)
        {
            rbtnground = "3";
        }

        private void rbtngroundbrown_Checked(object sender, RoutedEventArgs e)
        {
            rbtnground = "4";
        }
        public static string rbtnnut { get; set; }

        private void rbtnnut1_Checked(object sender, RoutedEventArgs e)
        {
            rbtnnut = "1";
        }

        private void rbtnnut2_Checked(object sender, RoutedEventArgs e)
        {
            rbtnnut = "2";
        }

        private void rbtnnut3_Checked(object sender, RoutedEventArgs e)
        {
            rbtnnut = "3";
        }

        private void rbtnnut4_Checked(object sender, RoutedEventArgs e)
        {
            rbtnnut = "4";
        }

        public static string rbtncolor { get; set; }

        private void rbtnwhitecolor_Checked(object sender, RoutedEventArgs e)
        {
            rbtncolor = "1";
        }

        private void rbtnblackcolor_Checked(object sender, RoutedEventArgs e)
        {
            rbtncolor = "2";
        }
    }
    
}
