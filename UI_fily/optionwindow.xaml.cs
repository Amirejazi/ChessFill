using System;
using System.Collections.Generic;
using System.IO;
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
            if (rbtnnut == "1")
            {
                gameserverwindow.rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_1.png");
                gameserverwindow.asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_1.png");
                gameserverwindow.fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_1.png");
                gameserverwindow.vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_1.png");
                gameserverwindow.shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_1.png");
                gameserverwindow.sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_1.png");
                gameserverwindow.rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_1.png");
                gameserverwindow.asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_1.png");
                gameserverwindow.fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_1.png");
                gameserverwindow.vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_1.png");
                gameserverwindow.shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_1.png");
                gameserverwindow.sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_1.png");
            }
            else if (rbtnnut == "2")
            {
                gameserverwindow.rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_2.png");
                gameserverwindow.asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_2.png");
                gameserverwindow.fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_2.png");
                gameserverwindow.vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_2.png");
                gameserverwindow.shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_2.png");
                gameserverwindow.sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_2.png");
                gameserverwindow.rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_2.png");
                gameserverwindow.asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_2.png");
                gameserverwindow.fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_2.png");
                gameserverwindow.vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_2.png");
                gameserverwindow.shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_2.png");
                gameserverwindow.sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_2.png");
            }
            else if (rbtnnut == "3")
            {
                gameserverwindow.rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_3.png");
                gameserverwindow.asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_3.png");
                gameserverwindow.fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_3.png");
                gameserverwindow.vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_3.png");
                gameserverwindow.shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_3.png");
                gameserverwindow.sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_3.png");
                gameserverwindow.rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_3.png");
                gameserverwindow.asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_3.png");
                gameserverwindow.fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_3.png");
                gameserverwindow.vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_3.png");
                gameserverwindow.shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_3.png");
                gameserverwindow.sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_3.png");
            }
            else if (rbtnnut == "4")
            {
                gameserverwindow.rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_4.png");
                gameserverwindow.asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_4.png");
                gameserverwindow.fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_4.png");
                gameserverwindow.vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_4.png");
                gameserverwindow.shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_4.png");
                gameserverwindow.sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_4.png");
                gameserverwindow.rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_4.png");
                gameserverwindow.asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_4.png");
                gameserverwindow.fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_4.png");
                gameserverwindow.vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_4.png");
                gameserverwindow.shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_4.png");
                gameserverwindow.sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_4.png");
            }
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
//public string rokh_b { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_1.png");