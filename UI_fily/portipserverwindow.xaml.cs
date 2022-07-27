using Socket_Fily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Interaction logic for portipserverwindow.xaml
    /// </summary>
    public partial class portipserverwindow : Window
    {
        public static string port { get; set; }
        public static string ip { get; set; }
        public static string pass { get; set; }
        public portipserverwindow()
        {
            InitializeComponent();
        }
        
        private  void btnstart_Click(object sender, RoutedEventArgs e)
        {
            port = Port.Text;
            ip = Ip.Text;
            pass = Pass.Text;
            gameserverwindow gameServerwindow = new gameserverwindow();
            this.Close();
            gameServerwindow.ShowDialog();
        }
        private void closee(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btntest_Click(object sender, RoutedEventArgs e)
        {
            gameserverwindow gameserverwindow = new gameserverwindow();
            this.Close();
            gameserverwindow.ShowDialog();
        }

        private void btntest2_Click(object sender, RoutedEventArgs e)
        {
            gameclientwindow gameclientwindow = new gameclientwindow();
            this.Close();
            gameclientwindow.ShowDialog();
        }
    }
}
