using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Fily
{
    public class ServerTransmission
    {
        public delegate void RecieveCallback(string recievecallback);
        public delegate void ReceiveErrorCallback(string error);
        private readonly Socket _socket;
        public Socket Socket { get { return _socket; } }
        private event RecieveCallback _recieveCallback;
        private event ReceiveErrorCallback _receiveErrorCallback;
        public ServerTransmission(Socket socket, RecieveCallback recieveCallback, ReceiveErrorCallback receiveErrorCallback)
        {
            _socket = socket;
            _recieveCallback = recieveCallback;
            _receiveErrorCallback = receiveErrorCallback;
        }
        public Task RecieveAsync()
        {
            return Task.Run(() => {
                try
                {
                    byte[] buffer = new byte[1024];
                    _socket.Receive(buffer);
                    _recieveCallback(Encoding.UTF8.GetString(buffer));
                    RecieveAsync();
                }
                catch (Exception ex)
                {
                    _receiveErrorCallback(ex.Message);
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
