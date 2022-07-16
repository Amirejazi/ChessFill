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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI_filly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string k = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\resorce\\logo_1.png");
            img1.Source = new BitmapImage(new Uri(k));

        }

        private void btnloadgame_click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
