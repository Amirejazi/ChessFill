using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Fily
{
    public delegate void AcceptedCallback(Socket acceptedsocket);
    public delegate void AcceptedErrorCallback(string error);
    public class ServerStartup
    {
        int _Port;
        string _Ip;
        Socket _ServerSocket;
        private event AcceptedCallback _acceptedcallback;
        private event AcceptedErrorCallback _acceptedErrorCallback;
        public ServerStartup(int port, string ip, AcceptedCallback acceptedcallback, AcceptedErrorCallback acceotederrorcallback)
        {
            _Port = port;
            _Ip = ip;
            _acceptedcallback = acceptedcallback;
            _acceptedErrorCallback = acceotederrorcallback;
        }
        public void InitServer()
        {
            _ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _ServerSocket.Bind(new IPEndPoint(IPAddress.Parse(_Ip), _Port));
            _ServerSocket.Listen(1);
        }
        public Task AcceptAsync()
        {
            return Task.Run(() => {
                try
                {
                    Socket AcceptedSocket = _ServerSocket.Accept();
                    _acceptedcallback(AcceptedSocket);
                }
                catch (Exception ex)
                {
                    _acceptedErrorCallback(ex.Message);
                }
            });

        }
        public void CloseClient(Socket Client)
        {
            Client.Close();
        }
        public void CloseServer()
        {
            _ServerSocket.Close();
        }
    }
}
