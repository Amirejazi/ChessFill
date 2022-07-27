using Socket_Fily;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for gameserverwindow.xaml
    /// </summary>
    public partial class gameserverwindow : Window
    {
        public gameserverwindow()
        {
            InitializeComponent();
            ResetBrush();
            servername.Content = optionwindow.servername;
            clientname.Content = optionwindow.clientname;
            entkhabsoundq.Open(new Uri(String.Format(@"{0}..\..\sorce\entekhab.mp3", AppDomain.CurrentDomain.BaseDirectory)));
            sendsound.Open(new Uri(String.Format(@"{0}..\..\sorce\harekat.mp3", AppDomain.CurrentDomain.BaseDirectory)));
            mediaplayer1.Open(new Uri(String.Format(@"{0}..\..\Sound\1.mp3", AppDomain.CurrentDomain.BaseDirectory)));
            mediaplayer2.Open(new Uri(String.Format(@"{0}..\..\Sound\2.mp3", AppDomain.CurrentDomain.BaseDirectory)));
            mediaplayer3.Open(optionwindow.Urisound);
            mediaplayer1.MediaEnded += new EventHandler(Media_Ended);
            mediaplayer2.MediaEnded += new EventHandler(Media_Ended);
            mediaplayer3.MediaEnded += new EventHandler(Media_Ended);
            if (optionwindow.RbtnSound == "1") { mediaplayer1.Play(); }
            if (optionwindow.RbtnSound == "2") { mediaplayer2.Play(); }
            if (optionwindow.RbtnSound == "3") { mediaplayer3.Play(); }
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
            servername.Content = optionwindow.servername;
            clientname.Content = optionwindow.clientname;
            start_Server();
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
            Zadansarbazimages = new List<Image>();
            Zadansarbazimages.Add(imgz_1);
            Zadansarbazimages.Add(imgz_1);
            Zadansarbazimages.Add(imgz_2);
            Zadansarbazimages.Add(imgz_3);
            Zadansarbazimages.Add(imgz_4);
            Zadansarbazimages.Add(imgz_5);
            Zadansarbazimages.Add(imgz_6);
            Zadansarbazimages.Add(imgz_7);
            Zadansarbazimages.Add(imgz_8);
            ZadanOtherimages = new List<Image>();
            ZadanOtherimages.Add(imgz_9);
            ZadanOtherimages.Add(imgz_9);
            ZadanOtherimages.Add(imgz_10);
            ZadanOtherimages.Add(imgz_11);
            ZadanOtherimages.Add(imgz_12);
            ZadanOtherimages.Add(imgz_13);
            ZadanOtherimages.Add(imgz_14);
            ZadanOtherimages.Add(imgz_15);
            ZadanOtherimages.Add(imgz_16);
            Zadansarbazenemy = new List<Image>();
            Zadansarbazenemy.Add(imgzw_1);
            Zadansarbazenemy.Add(imgzw_1);
            Zadansarbazenemy.Add(imgzw_2);
            Zadansarbazenemy.Add(imgzw_3);
            Zadansarbazenemy.Add(imgzw_4);
            Zadansarbazenemy.Add(imgzw_5);
            Zadansarbazenemy.Add(imgzw_6);
            Zadansarbazenemy.Add(imgzw_7);
            Zadansarbazenemy.Add(imgzw_8);
            ZadanOtherenemy = new List<Image>();
            ZadanOtherenemy.Add(imgzw_9);
            ZadanOtherenemy.Add(imgzw_9);
            ZadanOtherenemy.Add(imgzw_10);
            ZadanOtherenemy.Add(imgzw_11);
            ZadanOtherenemy.Add(imgzw_12);
            ZadanOtherenemy.Add(imgzw_13);
            ZadanOtherenemy.Add(imgzw_14);
            ZadanOtherenemy.Add(imgzw_15);
            ZadanOtherenemy.Add(imgzw_16);
            if (optionwindow.rbtnplaywithtime == true)
            {
                System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
                minute.Content = optionwindow.timer;
                timer.Tick += Timer_tick;
                timer.Interval = new TimeSpan(0, 0, 1);
            }
            else if(optionwindow.rbtnplaywithtime == false)
            {
                minute.Content = "";
                second.Content = "";
                donoghte.Content = "";
            }
            if(optionwindow.rbtnshowtime == false)
            {
                minute.Visibility = Visibility.Collapsed;
                second.Visibility = Visibility.Collapsed;
                donoghte.Visibility = Visibility.Collapsed;
            }
        }
        string sanie = "";
        int saniee = 0;
        string daghighe = "";
        int daghighee = 0;
        private void Timer_tick(object sender, EventArgs e)
        {
            sanie = second.Content.ToString();
            saniee = Convert.ToInt32(sanie) - 1;
            sanie = saniee.ToString();
            second.Content = sanie;
            if(second.Content.ToString() == "0")
            {
                if (minute.Content.ToString() == "0")
                {
                    MessageBoxResult result;
                    result = MessageBox.Show("the game is over", ":)", MessageBoxButton.OK);
                    if (result == MessageBoxResult.OK)
                    {
                        this.Close();
                    }
                }
                second.Content = "59";
                daghighe = minute.Content.ToString();
                daghighee = Convert.ToInt32(daghighe)-1;
                daghighe = daghighee.ToString();
                minute.Content = daghighe;
                
                    
                
            }


        }

        private void Media_Ended(object sender, EventArgs e)
        {
            if (optionwindow.RbtnSound == "1") { mediaplayer1.Position = TimeSpan.Zero; mediaplayer1.Play(); }
            if (optionwindow.RbtnSound == "2") { mediaplayer2.Position = TimeSpan.Zero; mediaplayer2.Play(); }
            if (optionwindow.RbtnSound == "3") { mediaplayer3.Position = TimeSpan.Zero; mediaplayer3.Play(); }
        }

        public bool flag { get; set; }
        public bool enable { get; set; } = false;
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
        public List<Image> images { get; set; }
        public List<Image> Zadansarbazimages { get; set; }
        public List<Image> ZadanOtherimages { get; set; }
        public List<Image> Zadansarbazenemy { get; set; }
        public List<Image> ZadanOtherenemy { get; set; }

        public string Recieve { get; set; }
        public string propSend { get; set; } = $"i:{optionwindow.rbtnground},{optionwindow.rbtnnut},{optionwindow.rbtncolor},{optionwindow.servername},{optionwindow.clientname},{optionwindow.rbtn1},{portipserverwindow.pass}";
        public static ServerStartup _serverstartup;
        public static ServerTransmission _transmission;
        private static MediaPlayer entkhabsoundq = new MediaPlayer();
        private MediaPlayer sendsound = new MediaPlayer();
        private MediaPlayer mediaplayer1 = new MediaPlayer();
        private MediaPlayer mediaplayer2 = new MediaPlayer();
        private MediaPlayer mediaplayer3 = new MediaPlayer();
        public void LocationSaver()
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
        public void RecieveLocation(string str)
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
            enable=true;
        }
        void Zadan()
        {
            string[] locations = locationSaver.Split(',');
            int sarbaz_bCounter = 0, rokh_bCounter = 0, fil_bCounter = 0, shah_bCounter = 0, vazir_bCounter = 0, asb_bCounter = 0;
            int sarbaz_wCounter = 0, rokh_wCounter = 0, fil_wCounter = 0, shah_wCounter = 0, vazir_wCounter = 0, asb_wCounter = 0;

            for (int i = 1; i < locations.Length; i++)
            {
                if(locations[i] == "sb")
                {
                    sarbaz_bCounter ++;
                }
                if (locations[i] == "rb")
                {
                    rokh_bCounter ++;
                }
                if (locations[i] == "fb")
                {
                    fil_bCounter ++;
                }
                if (locations[i] == "kb")
                {
                    shah_bCounter ++;
                }
                if (locations[i] == "vb")
                {
                    vazir_bCounter ++;
                }
                if (locations[i] == "ab")
                {
                    asb_bCounter ++;
                }
                if (locations[i] == "sw")
                {
                    sarbaz_wCounter++;
                }
                if (locations[i] == "rw")
                {
                    rokh_wCounter++;
                }
                if (locations[i] == "fw")
                {
                    fil_wCounter++;
                }
                if (locations[i] == "kw")
                {
                    shah_wCounter++;
                }
                if (locations[i] == "vw")
                {
                    vazir_wCounter++;
                }
                if (locations[i] == "aw")
                {
                    asb_wCounter++;
                }
                
            }
            if (flag)
            {
                for (int i = 1; i <= (8 - sarbaz_wCounter); i++)
                {
                    Zadansarbazimages[i].Source = new BitmapImage(new Uri(sarbaz_w));
                }
                for (int i = 1; i <= (2 - rokh_wCounter); i++)
                {
                    ZadanOtherimages[i].Source = new BitmapImage(new Uri(rokh_w));
                }
                for (int i = 2 - rokh_wCounter + 1; i <= 2 - rokh_wCounter + (2 - asb_wCounter); i++)
                {
                    ZadanOtherimages[i].Source = new BitmapImage(new Uri(asb_w));
                }
                for (int i = 2 - rokh_wCounter + (2 - asb_wCounter) + 1; i <= 2 - rokh_wCounter + (2 - asb_wCounter) + (2 - fil_wCounter); i++)
                {
                    ZadanOtherimages[i].Source = new BitmapImage(new Uri(fil_w));
                }
                if (vazir_wCounter != 1)
                {
                    ZadanOtherimages[2 - rokh_wCounter + (2 - asb_wCounter) + (2 - fil_wCounter)+1].Source = new BitmapImage(new Uri(vazir_w));
                }
                for (int i = 1; i <= (8 - sarbaz_bCounter); i++)
                {
                    Zadansarbazenemy[i].Source = new BitmapImage(new Uri(sarbaz_b));
                }
                for (int i = 1; i <= (2 - rokh_bCounter); i++)
                {
                    ZadanOtherenemy[i].Source = new BitmapImage(new Uri(rokh_b));
                }
                for (int i = 2 - rokh_bCounter + 1; i <= 2 - rokh_bCounter + (2 - asb_bCounter); i++)
                {
                    ZadanOtherenemy[i].Source = new BitmapImage(new Uri(asb_b));
                }
                for (int i = 2 - rokh_bCounter + (2 - asb_bCounter) + 1; i <= 2 - rokh_bCounter + (2 - asb_bCounter) + (2 - fil_bCounter); i++)
                {
                    ZadanOtherenemy[i].Source = new BitmapImage(new Uri(fil_b));
                }
                if (vazir_bCounter == 0)
                {
                    ZadanOtherenemy[2 - rokh_bCounter + (2 - asb_bCounter) + (2 - fil_bCounter) + 1].Source = new BitmapImage(new Uri(vazir_b));
                }
            }
            else
            {
                for (int i = 1; i <= (8 - sarbaz_wCounter); i++)
                {
                    Zadansarbazenemy[i].Source = new BitmapImage(new Uri(sarbaz_w));
                }
                for (int i = 1; i <= (2 - rokh_wCounter); i++)
                {
                    ZadanOtherenemy[i].Source = new BitmapImage(new Uri(rokh_w));
                }
                for (int i = 2 - rokh_wCounter + 1; i <= 2 - rokh_wCounter + (2 - asb_wCounter); i++)
                {
                    ZadanOtherenemy[i].Source = new BitmapImage(new Uri(asb_w));
                }
                for (int i = 2 - rokh_wCounter + (2 - asb_wCounter) + 1; i <= 2 - rokh_wCounter + (2 - asb_wCounter) + (2 - fil_wCounter); i++)
                {
                    ZadanOtherenemy[i].Source = new BitmapImage(new Uri(fil_w));
                }
                if (vazir_wCounter != 1)
                {
                    ZadanOtherenemy[2 - rokh_wCounter + (2 - asb_wCounter) + (2 - fil_wCounter) + 1].Source = new BitmapImage(new Uri(vazir_w));
                }
                for (int i = 1; i <= (8 - sarbaz_bCounter); i++)
                {
                    Zadansarbazimages[i].Source = new BitmapImage(new Uri(sarbaz_b));
                }
                for (int i = 1; i <= (2 - rokh_bCounter); i++)
                {
                    ZadanOtherimages[i].Source = new BitmapImage(new Uri(rokh_b));
                }
                for (int i = 2 - rokh_bCounter + 1; i <= 2 - rokh_bCounter + (2 - asb_bCounter); i++)
                {
                    ZadanOtherimages[i].Source = new BitmapImage(new Uri(asb_b));
                }
                for (int i = 2 - rokh_bCounter + (2 - asb_bCounter) + 1; i <= 2 - rokh_bCounter + (2 - asb_bCounter) + (2 - fil_bCounter); i++)
                {
                    ZadanOtherimages[i].Source = new BitmapImage(new Uri(fil_b));
                }
                if (vazir_wCounter == 0)
                {
                    ZadanOtherimages[2 - rokh_bCounter + (2 - asb_bCounter) + (2 - fil_bCounter) + 1].Source = new BitmapImage(new Uri(vazir_b));
                }
            }
        }
        void finalsbz()
        {
            for(int i = 56; i < 65; i++)
            {
                if (images[i].Source != null)
                {
                    if (SarbazChecker(flag, images[i].Source.ToString()))
                    {
                        MessageBoxResult res;
                        res = MessageBox.Show("choose vazir or rokh !", "?!", MessageBoxButton.YesNo);
                        if (res == MessageBoxResult.Yes)
                        {
                            if (flag)
                            {
                                images[i].Source = new BitmapImage(new Uri(vazir_w));
                                LocationSaver();
                                Zadan();
                            }
                            else
                            {
                                images[i].Source = new BitmapImage(new Uri(vazir_b));
                                LocationSaver();
                                Zadan();
                            }
                        }
                        else
                        {
                            if (flag)
                            {
                                images[i].Source = new BitmapImage(new Uri(rokh_w));
                                LocationSaver();
                                Zadan();
                            }
                            else
                            {
                                images[i].Source = new BitmapImage(new Uri(rokh_b));
                                LocationSaver();
                                Zadan();
                            }
                        }
                    }
                }
            }
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

        void Brush(int index)
        {
            try
            {
                Button[index].Background = new SolidColorBrush(Colors.YellowGreen);
            }
            catch
            {
            }
        }
        void Brushr(int index)
        {
            try
            {
                Button[index].Background = new SolidColorBrush(Colors.OrangeRed);
            }
            catch
            {
            }
        }
        void Asb(int index)
        {
            ResetBrush();
            entkhabsoundq.Position = TimeSpan.Zero;
            entkhabsoundq.Play();
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
        void Fil(int index)
        {
            ResetBrush();
            entkhabsoundq.Position = TimeSpan.Zero;
            entkhabsoundq.Play();
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
        void Rokh(int index)
        {
            ResetBrush();
            entkhabsoundq.Position = TimeSpan.Zero;
            entkhabsoundq.Play();
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
        void Vazir(int index)
        {
            ResetBrush();
            entkhabsoundq.Position = TimeSpan.Zero;
            entkhabsoundq.Play();
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
        void Shah(int index)
        {

            ResetBrush();
            entkhabsoundq.Position = TimeSpan.Zero;
            entkhabsoundq.Play();
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
        void Sarbaz_firstTime(int index)
        {
            ResetBrush();
            entkhabsoundq.Position = TimeSpan.Zero;
            entkhabsoundq.Play();
            int brush = index + 8;
            bool flagc = true;
            if (brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
                else
                {
                    flagc = false;
                }
            }
            brush = index + 16;
            if (brush < 65 && flagc)
            {
                if (images[brush].Source == null)
                    Brush(brush);
            }
            brush = index + 9;
            if (brush % 8 != 1 && brush < 65 && images[brush].Source != null)
            {
                if (ColorChecker(!flag, images[brush].Source.ToString()))
                   Brushr(brush);
            }
            brush = index + 7;
            if (brush % 8 != 0 && brush < 65 && images[brush].Source != null)
            {
                if (ColorChecker(!flag, images[brush].Source.ToString()))
                   Brushr(brush);
            }
            if (flag)
                loc = sarbaz_w;
            else
                loc = sarbaz_b;
            indexg = index;
        }
        void Sarbaz(int index)
        {
            ResetBrush();
            entkhabsoundq.Position = TimeSpan.Zero;
            entkhabsoundq.Play();
            int brush = index + 8;
            if (brush < 65)
            {
                if (images[brush].Source == null)
                    Brush(brush);
            }
            brush = index + 9;
            if (brush % 8 != 1 && brush < 65 && images[brush].Source != null)
            {
                if (ColorChecker(!flag, images[brush].Source.ToString()))
                    Brushr(brush);
            }
            brush = index + 7;
            if (brush % 8 != 0 && brush < 65 && images[brush].Source != null)
            {
                if (ColorChecker(!flag, images[brush].Source.ToString()))
                    Brushr(brush);
            }
            if (flag)
                loc = sarbaz_w;
            else
                loc = sarbaz_b;
            indexg = index;
        }
        bool RokhChecker(bool flagc, string img)
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
        bool AsbChecker(bool flagc, string img)
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
        bool FilChecker(bool flagc, string img)
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
        bool SarbazChecker(bool flagc, string img)
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
        bool VazirChecker(bool flagc, string img)
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
        bool ShahChecker(bool flagc, string img)
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

        bool ColorChecker(bool flag, string img)
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
        void EventOfButtons(int index)
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
                    Zadan();
                    finalsbz();
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
        private void ChangeState(string state, SolidColorBrush color)
        {
            State.Content = state;
            State.Foreground = color;
        }
        private void StartState(bool state)
        {
            //btnstart.IsEnabled = state;
            //StopBtn.IsEnabled = !state;
            //Port.IsEnabled = state;
        }

        private async void start_Server()
        {
            try
            {
                ChangeState("Starting Server", new SolidColorBrush(Colors.Orange));
                _serverstartup = new ServerStartup(int.Parse(portipserverwindow.port), portipserverwindow.ip, acceptedCallback, acceptedErrorcallback); ;
                _serverstartup.InitServer();
                StartState(false);
                ChangeState("Connecting to Client...", new SolidColorBrush(Colors.Blue));
                await _serverstartup.AcceptAsync();
                timer.Start();
                if (optionwindow.rbtncolor == "1")
                    enable=true;
                _transmission.Send(propSend);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n try again", "Init server error", MessageBoxButton.OK, MessageBoxImage.Error);
                ChangeState("Stop Server", new SolidColorBrush(Colors.Red));
                StartState(true);
            }
        }
        private void acceptedErrorcallback(string error)
        {
            this.Dispatcher.Invoke(() => {
                MessageBox.Show(error + "\n try again", "AcceptedError", MessageBoxButton.OK, MessageBoxImage.Error);
            });
        }
        private async void acceptedCallback(Socket acceptedsocket)
        {
            this.Dispatcher.Invoke(() => {
                ChangeState("Connected to Client :)", new SolidColorBrush(Colors.Green));
            });
            _transmission = new ServerTransmission(acceptedsocket, recieveCallback, receiveErrorCallback);

            this.Dispatcher.Invoke(() =>
            {
                //btnstart.IsEnabled = true;
            });
            await _transmission.RecieveAsync();

        }
        private async void receiveErrorCallback(string error)
        {

            this.Dispatcher.Invoke(() =>
            {
                //btnstart.IsEnabled = false;
                ChangeState("Connecting to Client...", new SolidColorBrush(Colors.Blue));
                MessageBox.Show(error + "\n try again", "RecieveError", MessageBoxButton.OK, MessageBoxImage.Error);
            });
            _serverstartup.CloseClient(_transmission.Socket);
            _transmission = null;
            await _serverstartup.AcceptAsync();
        }
        private void recieveCallback(string recieveMessage)
        {
            this.Dispatcher.Invoke(() => {
                
                Recieve = "";
                for (int i = 0; i < recieveMessage.Length; i++)
                {
                    if (recieveMessage[i] != '\0')
                    {
                        Recieve += recieveMessage[i];
                    }
                }
                RecieveLocation(Recieve);
                LocationSaver();
                Zadan();
            });
        }
        public  void Send(string send)
        {
            try
            {
                sendsound.Position = TimeSpan.Zero;
                sendsound.Play();
                _transmission.Send(send);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n try again", "sending error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void closee(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private static bool sound = true;
        private void soundchecker_click(object sender, RoutedEventArgs e)
        {
            if (sound)
            {
                if (optionwindow.RbtnSound == "1") { mediaplayer1.Position = TimeSpan.Zero; mediaplayer1.Stop(); }
                if (optionwindow.RbtnSound == "2") { mediaplayer2.Position = TimeSpan.Zero; mediaplayer2.Stop(); }
                if (optionwindow.RbtnSound == "3") { mediaplayer3.Position = TimeSpan.Zero; mediaplayer3.Stop(); }
                sound = false;

            }
            else
            {
                if (optionwindow.RbtnSound == "1") { mediaplayer1.Position = TimeSpan.Zero; mediaplayer1.Play(); }
                if (optionwindow.RbtnSound == "2") { mediaplayer2.Position = TimeSpan.Zero; mediaplayer2.Play(); }
                if (optionwindow.RbtnSound == "3") { mediaplayer3.Position = TimeSpan.Zero; mediaplayer3.Play(); }
                sound = true;
            }
        }
    }

}