using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Fily
{
    public delegate void ConnectCallback(string error);
    public class ClientStartup
    {
        int _serverPort;
        string _serverIp;
        Socket _clientsocket;
        public Socket ClientSocket { get { return _clientsocket; } }
        private event ConnectCallback _connectCallback;
        public ClientStartup(int serverport, string serverip, ConnectCallback connectcallbak)
        {
            _serverIp = serverip;
            _serverPort = serverport;
            _connectCallback = connectcallbak;
        }
        public void InitClient()
        {
            _clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }
        public Task ConnectAsync()
        {
            return Task.Run(() => {
                try
                {
                    _clientsocket.Connect(new IPEndPoint(IPAddress.Parse(_serverIp), _serverPort));
                    _connectCallback(null);
                }
                catch (Exception ex)
                {
                    _connectCallback(ex.Message);
                }
            });
        }
        public void Close()
        {
            _clientsocket.Close();
        }
    }
}
