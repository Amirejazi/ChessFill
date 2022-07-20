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
    /// Interaction logic for gameserverwindow.xaml
    /// </summary>
    public partial class gameserverwindow : Window
    {
        public gameserverwindow()
        {
            InitializeComponent();
            if (optionwindow.rbtnground == "1")
            {
                _1.Background = new SolidColorBrush(Color.FromRgb(0,101,153));
                _3.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _5.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _7.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _10.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _12.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _14.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _16.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _17.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _19.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _21.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _23.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _26.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _28.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _30.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _32.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _33.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _35.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _37.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _39.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _42.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _44.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _46.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _48.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _49.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _51.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _53.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _55.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _58.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _60.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _62.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                _64.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
                // button haye bala blue shodand --------------------------------
                _2.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _4.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _6.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _8.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _9.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _11.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _13.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _15.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _18.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _20.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _22.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _24.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _25.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _27.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _29.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _31.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _34.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _36.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _38.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _40.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _41.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _43.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _45.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _47.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _50.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _52.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _54.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _56.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _57.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _59.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _61.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));
                _63.Background = new SolidColorBrush(Color.FromRgb(152, 205, 255));

            }
        }
        
    }
}
