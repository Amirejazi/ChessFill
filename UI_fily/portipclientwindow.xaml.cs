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
        ClientStartup _client;
        TransmissionClient _transmission;
        public portipclientwindow()
        {
            InitializeComponent();
        }
        public  string Pas { get; set; }

        private void btnstartclient_Click(object sender, RoutedEventArgs e)
        {
            if (Pas == Pass.Text)
            {
                gameclientwindow gameclientwindow = new gameclientwindow();
                this.Close();
                gameclientwindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("hammalak");
            }
        }

        private async void btnconnectclient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //ConnectBtnEnable(false);
                //ChangeState("InitClient...", new SolidColorBrush(Colors.Orange));
                _client = new ClientStartup(int.Parse(Port.Text), Ip.Text, connectcallbak1);
                _client.InitClient();
                //ChangeState("Connecting to server...", new SolidColorBrush(Colors.Orange));
                await _client.ConnectAsync();
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
                    Pas = recieveMessage;
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
    }
}
