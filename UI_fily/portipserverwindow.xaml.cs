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
        public portipserverwindow()
        {
            InitializeComponent();
        }

        private async void btnstart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //ChangeState("Starting Server", new SolidColorBrush(Colors.Orange));
                _serverstartup = new ServerStartup(int.Parse(Port.Text), Ip.Text, acceptedCallback, acceptedErrorcallback); ;
                _serverstartup.InitServer();
                //StartState(false);
                //ChangeState("Accepting Client...", new SolidColorBrush(Colors.Blue));
                await _serverstartup.AcceptAsync();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n try again", "Init server error", MessageBoxButton.OK, MessageBoxImage.Error);
                //ChangeState("Stop Server", new SolidColorBrush(Colors.Red));
                //StartState(true);
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
                //ChangeState("Connect to Client...", new SolidColorBrush(Colors.Orange));
            });
            _transmission = new ServerTransmission(acceptedsocket, recieveCallback, receiveErrorCallback);
            
            //this.Dispatcher.Invoke(() => {
            //    SendBtn.IsEnabled = true;
            //});
            await _transmission.RecieveAsync();
            try
            {
                _transmission.Send(Pass.Text);
                //RecieveBox.Text += $"Me : {SendBox.Text}\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n try again", "sending error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void receiveErrorCallback(string error)
        {

            //this.Dispatcher.Invoke(() => {
            //    SendBtn.IsEnabled = false;
            //    ChangeState("Accepting Client...", new SolidColorBrush(Colors.Blue));
            //    MessageBox.Show(error + "\n try again", "RecieveError", MessageBoxButton.OK, MessageBoxImage.Error);
            //});
            _serverstartup.CloseClient(_transmission.Socket);
            _transmission = null;
            await _serverstartup.AcceptAsync();
        }

        private void recieveCallback(string recieveMessage)
        {
            this.Dispatcher.Invoke(() => {
                //RecieveBox.Text += $"Recieve : {recieveMessage}\n";
            });
        }

        private void btntest_Click(object sender, RoutedEventArgs e)
        {
            gameserverwindow gameserverwindow = new gameserverwindow();
            this.Close();
            gameserverwindow.ShowDialog();
        }
    }
}
