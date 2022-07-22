﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        void ResetBrush()
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
            loc = asb_b;
            indexg = index;
        }
        void Fil(int index)
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
            loc = fil_b;
            indexg = index;
        }
        void Rokh(int index)
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
            loc = rokh_b;
            indexg = index;
        }
        void Vazir(int index)
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
            loc = vazir_b;
            indexg = index;
        }
        void Shah(int index)
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
            loc = shah_b;
            indexg = index;
        }
        void Sarbaz_firstTime(int index)
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
            loc = sarbaz_b;
            indexg = index;
        }
        void Sarbaz(int index)
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
    }
}
