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
        public portipclientwindow()
        {
            InitializeComponent();
        }

        private void btnstartclient_Click(object sender, RoutedEventArgs e)
        {
            gameclientwindow gameclientwindow = new gameclientwindow();
            this.Close();
            gameclientwindow.ShowDialog();
        }
    }
}
