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
    /// Interaction logic for gameclientwindow.xaml
    /// </summary>
    public partial class gameclientwindow : Window
    {
        public gameclientwindow()
        {
            InitializeComponent();
            if (optionwindow.rbtncolor == "1")
            {
                flag = true;
                _1img.Source = new BitmapImage(new Uri(rokh_w));
                _2img.Source = new BitmapImage(new Uri(asb_w));
                _3img.Source = new BitmapImage(new Uri(fil_w));
                _4img.Source = new BitmapImage(new Uri(vazir_w));
                _5img.Source = new BitmapImage(new Uri(shah_w));
                _6img.Source = new BitmapImage(new Uri(fil_w));
                _7img.Source = new BitmapImage(new Uri(asb_w));
                _8img.Source = new BitmapImage(new Uri(rokh_w));
                _9img.Source = new BitmapImage(new Uri(sarbaz_w));
                _10img.Source = new BitmapImage(new Uri(sarbaz_w));
                _11img.Source = new BitmapImage(new Uri(sarbaz_w));
                _12img.Source = new BitmapImage(new Uri(sarbaz_w));
                _13img.Source = new BitmapImage(new Uri(sarbaz_w));
                _14img.Source = new BitmapImage(new Uri(sarbaz_w));
                _15img.Source = new BitmapImage(new Uri(sarbaz_w));
                _16img.Source = new BitmapImage(new Uri(sarbaz_w));
                _49img.Source = new BitmapImage(new Uri(sarbaz_b));
                _50img.Source = new BitmapImage(new Uri(sarbaz_b));
                _51img.Source = new BitmapImage(new Uri(sarbaz_b));
                _52img.Source = new BitmapImage(new Uri(sarbaz_b));
                _53img.Source = new BitmapImage(new Uri(sarbaz_b));
                _54img.Source = new BitmapImage(new Uri(sarbaz_b));
                _55img.Source = new BitmapImage(new Uri(sarbaz_b));
                _56img.Source = new BitmapImage(new Uri(sarbaz_b));
                _57img.Source = new BitmapImage(new Uri(rokh_b));
                _58img.Source = new BitmapImage(new Uri(asb_b));
                _59img.Source = new BitmapImage(new Uri(fil_b));
                _60img.Source = new BitmapImage(new Uri(vazir_b));
                _61img.Source = new BitmapImage(new Uri(shah_b));
                _62img.Source = new BitmapImage(new Uri(fil_b));
                _63img.Source = new BitmapImage(new Uri(asb_b));
                _64img.Source = new BitmapImage(new Uri(rokh_b));
            }
            if (optionwindow.rbtncolor == "2")
            {
                flag = false;
                _1img.Source = new BitmapImage(new Uri(rokh_b));
                _2img.Source = new BitmapImage(new Uri(asb_b));
                _3img.Source = new BitmapImage(new Uri(fil_b));
                _4img.Source = new BitmapImage(new Uri(shah_b));
                _5img.Source = new BitmapImage(new Uri(vazir_b));
                _6img.Source = new BitmapImage(new Uri(fil_b));
                _7img.Source = new BitmapImage(new Uri(asb_b));
                _8img.Source = new BitmapImage(new Uri(rokh_b));
                _9img.Source = new BitmapImage(new Uri(sarbaz_b));
                _10img.Source = new BitmapImage(new Uri(sarbaz_b));
                _11img.Source = new BitmapImage(new Uri(sarbaz_b));
                _12img.Source = new BitmapImage(new Uri(sarbaz_b));
                _13img.Source = new BitmapImage(new Uri(sarbaz_b));
                _14img.Source = new BitmapImage(new Uri(sarbaz_b));
                _15img.Source = new BitmapImage(new Uri(sarbaz_b));
                _16img.Source = new BitmapImage(new Uri(sarbaz_b));
                _49img.Source = new BitmapImage(new Uri(sarbaz_w));
                _50img.Source = new BitmapImage(new Uri(sarbaz_w));
                _51img.Source = new BitmapImage(new Uri(sarbaz_w));
                _52img.Source = new BitmapImage(new Uri(sarbaz_w));
                _53img.Source = new BitmapImage(new Uri(sarbaz_w));
                _54img.Source = new BitmapImage(new Uri(sarbaz_w));
                _55img.Source = new BitmapImage(new Uri(sarbaz_w));
                _56img.Source = new BitmapImage(new Uri(sarbaz_w));
                _57img.Source = new BitmapImage(new Uri(rokh_w));
                _58img.Source = new BitmapImage(new Uri(asb_w));
                _59img.Source = new BitmapImage(new Uri(fil_w));
                _60img.Source = new BitmapImage(new Uri(vazir_w));
                _61img.Source = new BitmapImage(new Uri(shah_w));
                _62img.Source = new BitmapImage(new Uri(fil_w));
                _63img.Source = new BitmapImage(new Uri(asb_w));
                _64img.Source = new BitmapImage(new Uri(rokh_w));
            }
        }
        public bool flag { get; set; }
        public string loc { get; set; }
        public string locationSaver { get; set; }
        public int indexg { get; set; }
        public static string rokh_b { get; set; }
        public static string asb_b { get; set; }
        public static string fil_b { get; set; }
        public static string vazir_b { get; set; }
        public static string shah_b { get; set; }
        public static string sarbaz_w { get; set; }
        public static string rokh_w { get; set; }
        public static string asb_w { get; set; }
        public static string fil_w { get; set; }
        public static string vazir_w { get; set; }
        public static string shah_w { get; set; }
        public static string sarbaz_b { get; set; }
    }
}
