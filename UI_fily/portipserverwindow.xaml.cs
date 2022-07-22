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
        ServerStartup _serverstartup;
        ServerTransmission _transmission;
        public string Recieve { get; set; }
        public string propSend { get; set; } = $"i:{optionwindow.rbtnground},{optionwindow.rbtnnut},{optionwindow.rbtncolor},{optionwindow.servername},{optionwindow.clientname},{optionwindow.rbtn1}";
        public portipserverwindow()
        {
            InitializeComponent();
        }
        private void ChangeState(string state, SolidColorBrush color)
        {
            btnstart.Content = state;
            btnstart.Foreground = color;
        }
        private void StartState(bool state)
        {
            btnstart.IsEnabled = state;
            //StopBtn.IsEnabled = !state;
            Port.IsEnabled = state;
        }
        private async void btnstart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangeState("Starting Server", new SolidColorBrush(Colors.Orange));
                _serverstartup = new ServerStartup(int.Parse(Port.Text), Ip.Text, acceptedCallback, acceptedErrorcallback); ;
                _serverstartup.InitServer();
                StartState(false);
                ChangeState("Accepting Client...", new SolidColorBrush(Colors.Blue));
                await _serverstartup.AcceptAsync();
                Send(Pass.Text);

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
                ChangeState("Connect to Client...", new SolidColorBrush(Colors.Orange));
            });
            _transmission = new ServerTransmission(acceptedsocket, recieveCallback, receiveErrorCallback);

            this.Dispatcher.Invoke(() =>
            {
                btnstart.IsEnabled = true;
            });
            await _transmission.RecieveAsync();
            
        }

        private async void receiveErrorCallback(string error)
        {

            this.Dispatcher.Invoke(() =>
            {
                btnstart.IsEnabled = false;
                ChangeState("Accepting Client...", new SolidColorBrush(Colors.Blue));
                MessageBox.Show(error + "\n try again", "RecieveError", MessageBoxButton.OK, MessageBoxImage.Error);
            });
            _serverstartup.CloseClient(_transmission.Socket);
            _transmission = null;
            await _serverstartup.AcceptAsync();
        }

        private void recieveCallback(string recieveMessage)
        {
            Recieve = "";
            for (int i = 0; i < recieveMessage.Length; i++)
            {
                if (recieveMessage[i] != '\0')
                {
                    Recieve += recieveMessage[i];
                }
            }
            this.Dispatcher.Invoke(() => {
                if(recieveMessage == "connected")
                {
                    Send(propSend);
                    gameserverwindow gameserverwindow = new gameserverwindow();
                    gameserverwindow.ShowDialog();
                }
            });
        }
        private void Send(string send)
        {
            try
            {
                _transmission.Send(send);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n try again", "sending error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
