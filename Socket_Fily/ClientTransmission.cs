using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Fily
{
    public delegate void RecieveCallback(string recievecallback, string error);
    public class TransmissionClient
    {
        private Socket _socket;
        public Socket Socket { get { return _socket; } }
        private event RecieveCallback _recieveCallback;
        public TransmissionClient(Socket socket, RecieveCallback recieveCallback)
        {
            _socket = socket;
            _recieveCallback = recieveCallback;
        }
        public Task RecieveAsync()
        {
            return Task.Run(() => {
                try
                {
                    byte[] buffer = new byte[1024];
                    _socket.Receive(buffer);
                    _recieveCallback(Encoding.UTF8.GetString(buffer), null);
                    RecieveAsync();
                }
                catch (Exception ex)
                {
                    _recieveCallback(null, ex.Message);
                }
            });
        }
        public void Send(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                _socket.Send(Encoding.UTF8.GetBytes(message));
            }
            else
            {
                throw new Exception("message can not be null or empty");
            }

        }
    }
}
