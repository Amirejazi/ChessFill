using Socket_Fily;
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
    /// Interaction logic for portipclientwindow.xaml
    /// </summary>
    public partial class portipclientwindow : Window
    {
        public static string port { get; set; }
        public static string ip { get; set; }
        public static string pass { get; set; }
        public portipclientwindow()
        {
            InitializeComponent();
            if (gameclientwindow.errorPass)
            {
                MessageBox.Show("Pass Not Corecct !!", "Connection Error", MessageBoxButton.OK);
            }
        }
        
        private void test2(object sender, RoutedEventArgs e)
        {
            gameclientwindow gameclientwindow = new gameclientwindow();
            this.Close();
            gameclientwindow.ShowDialog();
        }
        private void closee(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnstartclient_Click(object sender, RoutedEventArgs e)
        {
            port = Port.Text;
            ip = Ip.Text;
            pass = Pass.Text;
            gameclientwindow gameclientwindow = new gameclientwindow();
            this.Close();
            gameclientwindow.ShowDialog();
        }

        private void btnconnectclient_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
