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
    /// Interaction logic for choose.xaml
    /// </summary>
    public partial class choose : Window
    {
        public choose()
        {
            InitializeComponent();
        }

        private void btnserver_Click(object sender, RoutedEventArgs e)
        {
            optionwindow optionwindow = new optionwindow();
            this.Close();
            optionwindow.ShowDialog();
        }

        private void btnclient_Click(object sender, RoutedEventArgs e)
        {
            portipclientwindow portipclientwindow = new portipclientwindow();
            this.Close();
            portipclientwindow.ShowDialog();
        }
    }
}
