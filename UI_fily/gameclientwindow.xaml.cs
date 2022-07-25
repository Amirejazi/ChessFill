using Socket_Fily;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
    /// Interaction logic for gameclientwindow.xaml
    /// </summary>
    public partial class gameclientwindow : Window
    {
        public gameclientwindow()
        {
            InitializeComponent();
            startclient();
            MessageBoxResult res;
            res = MessageBox.Show("Are you ready ?", "?!", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                ResetBrush();
                if (optionwindow.rbtnnut == "1")
                {
                    rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_1.png");
                    asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_1.png");
                    fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_1.png");
                    vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_1.png");
                    shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_1.png");
                    sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_1.png");
                    rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_1.png");
                    asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_1.png");
                    fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_1.png");
                    vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_1.png");
                    shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_1.png");
                    sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_1.png");
                }
                else if (optionwindow.rbtnnut == "2")
                {
                    rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_2.png");
                    asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_2.png");
                    fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_2.png");
                    vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_2.png");
                    shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_2.png");
                    sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_2.png");
                    rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_2.png");
                    asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_2.png");
                    fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_2.png");
                    vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_2.png");
                    shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_2.png");
                    sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_2.png");
                }
                else if (optionwindow.rbtnnut == "3")
                {
                    rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_3.png");
                    asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_3.png");
                    fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_3.png");
                    vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_3.png");
                    shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_3.png");
                    sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_3.png");
                    rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_3.png");
                    asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_3.png");
                    fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_3.png");
                    vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_3.png");
                    shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_3.png");
                    sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_3.png");
                }
                else if (optionwindow.rbtnnut == "4")
                {
                    rokh_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_white_4.png");
                    asb_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_white_4.png");
                    fil_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_white_4.png");
                    vazir_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_white_4.png");
                    shah_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_white_4.png");
                    sarbaz_w = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_white_4.png");
                    rokh_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\rokh_black_4.png");
                    asb_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\asb_black_4.png");
                    fil_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\fil_black_4.png");
                    vazir_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\vazir_black_4.png");
                    shah_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\shah_black_4.png");
                    sarbaz_b = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sorce\\sarbaz_black_4.png");
                }
                if (optionwindow.rbtncolor == "2")
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
                if (optionwindow.rbtncolor == "1")
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
            else
            {
                portipclientwindow portipclientwindow=new portipclientwindow();
                this.Close();
                portipclientwindow.ShowDialog();
            }
            Button = new List<Button>();
            Button.Add(_1);
            Button.Add(_1);
            Button.Add(_2);
            Button.Add(_3);
            Button.Add(_4);
            Button.Add(_5);
            Button.Add(_6);
            Button.Add(_7);
            Button.Add(_8);
            Button.Add(_9);
            Button.Add(_10);
            Button.Add(_11);
            Button.Add(_12);
            Button.Add(_13);
            Button.Add(_14);
            Button.Add(_15);
            Button.Add(_16);
            Button.Add(_17);
            Button.Add(_18);
            Button.Add(_19);
            Button.Add(_20);
            Button.Add(_21);
            Button.Add(_22);
            Button.Add(_23);
            Button.Add(_24);
            Button.Add(_25);
            Button.Add(_26);
            Button.Add(_27);
            Button.Add(_28);
            Button.Add(_29);
            Button.Add(_30);
            Button.Add(_31);
            Button.Add(_32);
            Button.Add(_33);
            Button.Add(_34);
            Button.Add(_35);
            Button.Add(_36);
            Button.Add(_37);
            Button.Add(_38);
            Button.Add(_39);
            Button.Add(_40);
            Button.Add(_41);
            Button.Add(_42);
            Button.Add(_43);
            Button.Add(_44);
            Button.Add(_45);
            Button.Add(_46);
            Button.Add(_47);
            Button.Add(_48);
            Button.Add(_49);
            Button.Add(_50);
            Button.Add(_51);
            Button.Add(_52);
            Button.Add(_53);
            Button.Add(_54);
            Button.Add(_55);
            Button.Add(_56);
            Button.Add(_57);
            Button.Add(_58);
            Button.Add(_59);
            Button.Add(_60);
            Button.Add(_61);
            Button.Add(_62);
            Button.Add(_63);
            Button.Add(_64);
            images = new List<Image>();
            images.Add(_1img);
            images.Add(_1img);
            images.Add(_2img);
            images.Add(_3img);
            images.Add(_4img);
            images.Add(_5img);
            images.Add(_6img);
            images.Add(_7img);
            images.Add(_8img);
            images.Add(_9img);
            images.Add(_10img);
            images.Add(_11img);
            images.Add(_12img);
            images.Add(_13img);
            images.Add(_14img);
            images.Add(_15img);
            images.Add(_16img);
            images.Add(_17img);
            images.Add(_18img);
            images.Add(_19img);
            images.Add(_20img);
            images.Add(_21img);
            images.Add(_22img);
            images.Add(_23img);
            images.Add(_24img);
            images.Add(_25img);
            images.Add(_26img);
            images.Add(_27img);
            images.Add(_28img);
            images.Add(_29img);
            images.Add(_30img);
            images.Add(_31img);
            images.Add(_32img);
            images.Add(_33img);
            images.Add(_34img);
            images.Add(_35img);
            images.Add(_36img);
            images.Add(_37img);
            images.Add(_38img);
            images.Add(_39img);
            images.Add(_40img);
            images.Add(_41img);
            images.Add(_42img);
            images.Add(_43img);
            images.Add(_44img);
            images.Add(_45img);
            images.Add(_46img);
            images.Add(_47img);
            images.Add(_48img);
            images.Add(_49img);
            images.Add(_50img);
            images.Add(_51img);
            images.Add(_52img);
            images.Add(_53img);
            images.Add(_54img);
            images.Add(_55img);
            images.Add(_56img);
            images.Add(_57img);
            images.Add(_58img);
            images.Add(_59img);
            images.Add(_60img);
            images.Add(_61img);
            images.Add(_62img);
            images.Add(_63img);
            images.Add(_64img);

        }

        public bool flag { get; set; }
        public bool enable { get; set; }=false;
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
        public List<Button> Button { get; set; }
        public static List<Image> images { get; set; }
        public static ClientStartup _client;
        public static TransmissionClient _transmission;
        public string Recieve { get; set; }
        void LocationSaver()
        {
            locationSaver = "-,";
            for (int i = 1; i < 65; i++)
            {
                if (images[i].Source == null)
                    locationSaver += "-,";
                else
                {
                    if (RokhChecker(false, images[i].Source.ToString()))
                        locationSaver += "rb,";
                    else if (SarbazChecker(false, images[i].Source.ToString()))
                        locationSaver += "sb,";
                    else if (AsbChecker(false, images[i].Source.ToString()))
                        locationSaver += "ab,";
                    else if (FilChecker(false, images[i].Source.ToString()))
                        locationSaver += "fb,";
                    else if (VazirChecker(false, images[i].Source.ToString()))
                        locationSaver += "vb,";
                    else if (ShahChecker(false, images[i].Source.ToString()))
                        locationSaver += "kb,";
                    else if (RokhChecker(true, images[i].Source.ToString()))
                        locationSaver += "rw,";
                    else if (SarbazChecker(true, images[i].Source.ToString()))
                        locationSaver += "sw,";
                    else if (AsbChecker(true, images[i].Source.ToString()))
                        locationSaver += "aw,";
                    else if (FilChecker(true, images[i].Source.ToString()))
                        locationSaver += "fw,";
                    else if (VazirChecker(true, images[i].Source.ToString()))
                        locationSaver += "vw,";
                    else if (ShahChecker(true, images[i].Source.ToString()))
                        locationSaver += "kw,";
                }
            }
            locationSaver = locationSaver.Remove(locationSaver.Length - 1);
        }
        void RecieveLocation(string str)
        {
            string[] locations = str.Split(',');
            for (int i = 1; i < locations.Length; i++)
            {
                if (locations[i] == "rb")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(rokh_b));
                }
                else if (locations[i] == "ab")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(asb_b));
                }
                else if (locations[i] == "fb")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(fil_b));
                }
                else if (locations[i] == "sb")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(sarbaz_b));

                }
                else if (locations[i] == "vb")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(vazir_b));
                }
                else if (locations[i] == "kb")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(shah_b));
                }
                else if (locations[i] == "-")
                {
                    images[65 - i].Source = null;
                }
                else if (locations[i] == "rw")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(rokh_w));
                }
                else if (locations[i] == "aw")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(asb_w));
                }
                else if (locations[i] == "fw")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(fil_w));
                }
                else if (locations[i] == "sw")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(sarbaz_w));
                }
                else if (locations[i] == "vw")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(vazir_w));
                }
                else if (locations[i] == "kw")
                {
                    images[65 - i].Source = new BitmapImage(new Uri(shah_w));
                }
            }
            enable = true;
        }
        public void ResetBrush()
        {
            if (optionwindow.rbtnground == "1")
            {
                _1.Background = new SolidColorBrush(Color.FromRgb(0, 101, 153));
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
                // button haye bala blue kamrang shodand --------------------------
            }
            if (optionwindow.rbtnground == "2")
            {
                _1.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _3.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _5.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _7.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _10.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _12.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _14.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _16.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _17.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _19.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _21.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _23.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _26.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _28.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _30.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _32.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _33.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _35.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _37.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _39.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _42.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _44.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _46.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _48.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _49.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _51.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _53.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _55.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _58.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _60.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _62.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                _64.Background = new SolidColorBrush(Color.FromRgb(23, 23, 23));
                // button haye bala black shodand -------------------------------
                _2.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _4.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _6.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _8.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _9.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _11.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _13.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _15.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _18.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _20.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _22.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _24.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _25.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _27.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _29.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _31.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _34.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _36.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _38.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _40.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _41.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _43.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _45.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _47.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _50.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _52.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _54.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _56.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _57.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _59.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _61.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                _63.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                // button haye bala blue kamrang shodand --------------------------
            }
            if (optionwindow.rbtnground == "3")
            {
                _1.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _3.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _5.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _7.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _10.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _12.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _14.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _16.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _17.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _19.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _21.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _23.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _26.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _28.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _30.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _32.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _33.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _35.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _37.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _39.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _42.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _44.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _46.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _48.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _49.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _51.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _53.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _55.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _58.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _60.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _62.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                _64.Background = new SolidColorBrush(Color.FromRgb(125, 148, 92));
                // button haye bala green shodand -------------------------------
                _2.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _4.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _6.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _8.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _9.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _11.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _13.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _15.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _18.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _20.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _22.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _24.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _25.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _27.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _29.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _31.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _34.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _36.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _38.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _40.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _41.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _43.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _45.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _47.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _50.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _52.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _54.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _56.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _57.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _59.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _61.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                _63.Background = new SolidColorBrush(Color.FromRgb(238, 238, 214));
                // button haye bala green kam rang kamrang shodand ----------------
            }
            if (optionwindow.rbtnground == "4")
            {
                _1.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _3.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _5.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _7.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _10.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _12.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _14.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _16.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _17.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _19.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _21.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _23.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _26.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _28.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _30.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _32.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _33.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _35.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _37.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _39.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _42.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _44.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _46.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _48.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _49.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _51.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _53.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _55.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _58.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _60.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _62.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                _64.Background = new SolidColorBrush(Color.FromRgb(182, 136, 100));
                // button haye bala brown shodand -------------------------------
                _2.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _4.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _6.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _8.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _9.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _11.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _13.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _15.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _18.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _20.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _22.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _24.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _25.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _27.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _29.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _31.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _34.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _36.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _38.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _40.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _41.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _43.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _45.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _47.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _50.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _52.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _54.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _56.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _57.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _59.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _61.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                _63.Background = new SolidColorBrush(Color.FromRgb(241, 219, 182));
                // button haye bala brown kam rang kamrang shodand ----------------
            }
        }
        private static MediaPlayer entkhabsound = new MediaPlayer();

        public void Brush(int index)
        {
            try
            {
                Button[index].Background = new SolidColorBrush(Colors.YellowGreen);
                entkhabsound.Open(new Uri(String.Format(@"{0}..\..\sorce\entekhab.mp3", AppDomain.CurrentDomain.BaseDirectory)));
                entkhabsound.Position = TimeSpan.Zero;
                entkhabsound.Play();
            }
            catch
            {
            }
        }
        public void Brushr(int index)
        {
            try
            {
                Button[index].Background = new SolidColorBrush(Colors.OrangeRed);
                entkhabsound.Open(new Uri(String.Format(@"{0}..\..\sorce\entekhab.mp3", AppDomain.CurrentDomain.BaseDirectory)));
                entkhabsound.Position = TimeSpan.Zero;
                entkhabsound.Play();
            }
            catch
            {
            }
        }
        public void Asb(int index)
        {
            ResetBrush();
            int brush = index + 10;
            if (brush % 8 != 1 && brush % 8 != 2 && brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            brush = index + 6;
            if (brush % 8 != 0 && brush % 8 != 7 && brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            brush = index + 15;
            if (brush % 8 != 0 && brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            brush = index + 17;
            if (brush % 8 != 1 && brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            brush = index - 15;
            if (brush % 8 != 1 && brush > 0)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            brush = index - 17;
            if (brush % 8 != 0 && brush > 0)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            brush = index - 6;
            if (brush % 8 != 1 && brush % 8 != 2 && brush > 0)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            brush = index - 10;
            if (brush % 8 != 0 && brush % 8 != 7 && brush > 0)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            if (flag)
                loc = asb_w;
            else
                loc = asb_b;
            indexg = index;
        }
        public void Fil(int index)
        {
            ResetBrush();
            int brush = index;
            while (true)
            {
                brush += 7;
                if (index % 8 == 1)
                    break;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 1)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 0)
                    break;
                brush += 9;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 0)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 1)
                    break;
                brush -= 9;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 1)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 0)
                    break;
                brush -= 7;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 0)
                        break;
                }
                else
                    break;
            }
            if (flag)
                loc = fil_w;
            else
                loc = fil_b;
            indexg = index;
        }
        public void Rokh(int index)
        {
            ResetBrush();
            int brush = index;
            while (true)
            {
                brush += 8;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                brush -= 8;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 1)
                    break;
                brush--;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 1)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 0)
                    break;
                brush++;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 0)
                        break;
                }
                else
                    break;
            }
            if (flag)
                loc = rokh_w;
            else
                loc = rokh_b;
            indexg = index;
        }
        public void Vazir(int index)
        {
            ResetBrush();
            int brush = index;
            while (true)
            {
                brush += 7;
                if (index % 8 == 1)
                    break;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 1)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 0)
                    break;
                brush += 9;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 0)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 1)
                    break;
                brush -= 9;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 1)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 0)
                    break;
                brush -= 7;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 0)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                brush += 8;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                brush -= 8;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 1)
                    break;
                brush--;
                if (brush > 0)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 1)
                        break;
                }
                else
                    break;
            }
            brush = index;
            while (true)
            {
                if (index % 8 == 0)
                    break;
                brush++;
                if (brush < 65)
                {
                    if (images[brush].Source == null)
                        Brush(brush);
                    else
                    {
                        if (ColorChecker(!flag, images[brush].Source.ToString()))
                        {
                            Brushr(brush);
                            break;
                        }
                        else
                            break;
                    }
                    if (brush % 8 == 0)
                        break;
                }
                else
                    break;
            }
            if (flag)
                loc = vazir_w;
            else
                loc = vazir_b;
            indexg = index;
        }
        public void Shah(int index)
        {

            ResetBrush();
            int brush = index + 8;
            if (brush < 65)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            brush = index - 8;
            if (brush > 0)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            brush = index + 7;
            if (brush % 8 != 0 && brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            brush = index + 9;
            if (brush % 8 != 1 && brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            brush = index + 1;
            if (brush % 8 != 1 && brush < 65)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            brush = index - 1;
            if (brush % 8 != 0 && brush > 0)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            brush = index - 7;
            if (brush % 8 != 1 && brush > 0)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            brush = index - 9;
            if (brush % 8 != 0 && brush > 0)
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            if (flag)
                loc = shah_w;
            else
                loc = shah_b;
            indexg = index;
        }
        public void Sarbaz_firstTime(int index)
        {
            ResetBrush();
            int brush = index + 8;
            bool flagc = true;
            if (brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                    else
                        flagc = false;
                }
            }
            brush = index + 16;
            if (brush < 65 && flagc)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            if (flag)
                loc = sarbaz_w;
            else
                loc = sarbaz_b;
            indexg = index;
        }
        public void Sarbaz(int index)
        {
            ResetBrush();
            int brush = index + 8;
            if (brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    if (ColorChecker(!flag, images[brush].Source.ToString()))
                        Brushr(brush);
                }
            }
            if (flag)
                loc = sarbaz_w;
            else
                loc = sarbaz_b;
            indexg = index;
        }
        public bool RokhChecker(bool flagc, string img)
        {
            string pattern;
            if (flagc)
                pattern = @"^.{0,}rokh_w.{0,}$";
            else
                pattern = @"^.{0,}rokh_b.{0,}$";
            Regex t = new Regex(pattern);
            if (t.IsMatch(img))
                return true;
            else
                return false;
        }
        public bool AsbChecker(bool flagc, string img)
        {
            string pattern;
            if (flagc)
                pattern = @"^.{0,}asb_w.{0,}$";
            else
                pattern = @"^.{0,}asb_b.{0,}$";
            Regex t = new Regex(pattern);
            if (t.IsMatch(img))
                return true;
            else
                return false;
        }
        public bool FilChecker(bool flagc, string img)
        {
            string pattern;
            if (flagc)
                pattern = @"^.{0,}fil_w.{0,}$";
            else
                pattern = @"^.{0,}fil_b.{0,}$";
            Regex t = new Regex(pattern);
            if (t.IsMatch(img))
                return true;
            else
                return false;
        }
        public bool SarbazChecker(bool flagc, string img)
        {
            string pattern;
            if (flagc)
                pattern = @"^.{0,}sarbaz_w.{0,}$";
            else
                pattern = @"^.{0,}sarbaz_b.{0,}$";
            Regex t = new Regex(pattern);
            if (t.IsMatch(img))
                return true;
            else
                return false;
        }
        public bool VazirChecker(bool flagc, string img)
        {
            string pattern;
            if (flagc)
                pattern = @"^.{0,}vazir_w.{0,}$";
            else
                pattern = @"^.{0,}vazir_b.{0,}$";
            Regex t = new Regex(pattern);
            if (t.IsMatch(img))
                return true;
            else
                return false;
        }
        public bool ShahChecker(bool flagc, string img)
        {
            string pattern;
            if (flagc)
                pattern = @"^.{0,}shah_w.{0,}$";
            else
                pattern = @"^.{0,}shah_b.{0,}$";
            Regex t = new Regex(pattern);
            if (t.IsMatch(img))
                return true;
            else
                return false;
        }
        public bool ColorChecker(bool flag, string img)
        {
            string pattern;
            if (flag)
                pattern = @"^.{0,}white.{0,}$";
            else
                pattern = @"^.{0,}black.{0,}$";
            Regex t = new Regex(pattern);
            if (t.IsMatch(img))
                return true;
            else
                return false;
        }
        public void EventOfButtons(int index)
        {
            if (enable)
            {
                if (images[index].Source != null)
                {
                    if (RokhChecker(flag, images[index].Source.ToString()))
                        Rokh(index);
                    else if (AsbChecker(flag, images[index].Source.ToString()))
                        Asb(index);
                    else if (FilChecker(flag, images[index].Source.ToString()))
                        Fil(index);
                    else if (ShahChecker(flag, images[index].Source.ToString()))
                        Shah(index);
                    else if (VazirChecker(flag, images[index].Source.ToString()))
                        Vazir(index);
                    if (index > 8 && index < 17)
                    {
                        if (SarbazChecker(flag, images[index].Source.ToString()))
                            Sarbaz_firstTime(index);
                    }
                    else if (index > 16)
                    {
                        if (SarbazChecker(flag, images[index].Source.ToString()))
                            Sarbaz(index);
                    }
                }
                string colorback = Button[index].Background.ToString();
                if (colorback == "#FF9ACD32" || colorback == "#FFFF4500")
                {
                    images[index].Source = new BitmapImage(new Uri(loc));
                    images[indexg].Source = null;
                    ResetBrush();
                    LocationSaver();
                    Send(locationSaver);
                    enable = false;
                }
            }
        }
        private void _1b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(1);
        }
        private void _2b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(2);
        }
        private void _3b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(3);
        }
        private void _4b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(4);
        }
        private void _5b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(5);
        }
        private void _6b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(6);
        }
        private void _7b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(7);
        }
        private void _8b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(8);
        }
        private void _9b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(9);
        }
        private void _10b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(10);
        }
        private void _11b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(11);
        }
        private void _12b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(12);
        }
        private void _13b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(13);
        }
        private void _14b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(14);
        }
        private void _15b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(15);
        }
        private void _16b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(16);
        }
        private void _17b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(17);
        }
        private void _18b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(18);
        }
        private void _19b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(19);
        }
        private void _20b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(20);
        }
        private void _21b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(21);
        }
        private void _22b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(22);
        }
        private void _23b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(23);
        }
        private void _24b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(24);
        }
        private void _25b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(25);
        }
        private void _26b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(26);
        }
        private void _27b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(27);
        }
        private void _28b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(28);
        }
        private void _29b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(29);
        }
        private void _30b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(30);
        }
        private void _31b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(31);
        }
        private void _32b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(32);
        }
        private void _33b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(33);
        }
        private void _34b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(34);
        }
        private void _35b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(35);
        }
        private void _36b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(36);
        }
        private void _37b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(37);
        }
        private void _38b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(38);
        }
        private void _39b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(39);
        }
        private void _40b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(40);
        }
        private void _41b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(41);
        }
        private void _42b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(42);
        }
        private void _43b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(43);
        }
        private void _44b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(44);
        }
        private void _45b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(45);
        }
        private void _46b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(46);
        }
        private void _47b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(47);
        }
        private void _48b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(48);
        }
        private void _49b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(49);
        }
        private void _50b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(50);
        }
        private void _51b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(51);
        }
        private void _52b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(52);
        }
        private void _53b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(53);
        }
        private void _54b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(54);
        }
        private void _55b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(55);
        }
        private void _56b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(56);
        }
        private void _57b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(57);
        }
        private void _58b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(58);
        }
        private void _59b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(59);
        }
        private void _60b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(60);
        }
        private void _61b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(61);
        }
        private void _62b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(62);
        }
        private void _63b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(63);
        }
        private void _64b(object sender, RoutedEventArgs e)
        {
            EventOfButtons(64);
        }

        //private void startclient(object sender, RoutedEventArgs e)
        //{
        //    if (Recieve == Pass.Text)
        //    {
        //        Send("connected");
        //    }
        //    else
        //    {
        //        MessageBox.Show("hammalak");
        //    }
        //}

        private async void startclient()
        {
            try
            {
                //ConnectBtnEnable(false);
                //ChangeState("InitClient...", new SolidColorBrush(Colors.Orange));
                _client = new ClientStartup(int.Parse(portipclientwindow.port), portipclientwindow.ip, connectcallbak1);
                _client.InitClient();
                //ChangeState("Connecting to server...", new SolidColorBrush(Colors.Orange));
                await _client.ConnectAsync();
                if (optionwindow.rbtncolor == "2")
                    enable = true;
            }
            catch (Exception ex)
            {
                //ChangeState("Connected to server...", new SolidColorBrush(Colors.Red));
                MessageBox.Show(ex.Message + "\n try again", "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //ConnectBtnEnable(true);

            }
        }
        private async void connectcallbak1(string error)
        {
            if (string.IsNullOrEmpty(error))
            {
                this.Dispatcher.Invoke(() =>
                {
                    //ChangeState(" Connected to server...", new SolidColorBrush(Colors.Green));
                });
                _transmission = new TransmissionClient(_client.ClientSocket, recieveCallback);
                this.Dispatcher.Invoke(() =>
                {
                    //SendBtn.IsEnabled = true;
                });
                await _transmission.RecieveAsync();
            }
            else
            {
                this.Dispatcher.Invoke(() =>
                {
                    //ChangeState("not connect...", new SolidColorBrush(Colors.Red));
                    MessageBox.Show(error + "\ntry again", "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    //ConnectBtnEnable(true);
                });
            }
        }

        private void recieveCallback(string recieveMessage, string error)
        {
            if (string.IsNullOrEmpty(error))
            {
                this.Dispatcher.Invoke(() =>
                {
                    Recieve=recieveMessage;
                    if (Recieve[0] == 'i')
                    {
                        Recieve = Recieve.Remove(0, 2);
                        string[] items = Recieve.Split(',');
                        optionwindow.rbtnground = items[0];
                        optionwindow.rbtnnut = items[1];
                        optionwindow.rbtncolor = items[2];
                        optionwindow.servername = items[3];
                        optionwindow.clientname = items[4];
                        optionwindow.rbtn1 = items[5];
                    }
                    else
                        RecieveLocation(Recieve);
                });
            }
            else
            {
                _client.Close();
                this.Dispatcher.Invoke(() =>
                {
                    //ChangeState("not connect...", new SolidColorBrush(Colors.Red));
                    //ConnectBtnEnable(true);
                    MessageBox.Show(error, "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    //SendBtn.IsEnabled = false;
                    _transmission = null;
                });
            }
        }
        private static MediaPlayer sendsound = new MediaPlayer();
        public static void Send(string send)
        {
            try
            {
                sendsound.Open(new Uri(String.Format(@"{0}..\..\sorce\harekat.mp3", AppDomain.CurrentDomain.BaseDirectory)));
                sendsound.Position = TimeSpan.Zero;
                sendsound.Play();
                _transmission.Send(send);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n try again", "sending error", MessageBoxButton.OK, MessageBoxImage.Error);
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

    }
}
