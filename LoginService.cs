using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipz_AUTOCHAIR
{
    public class LoginService
    {
        public TcpClient _tcpClient { get; set; }
        public NetworkStream _networkStream { get; set; }

        public LoginService(NetworkStream networkStream, TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
            _networkStream = networkStream;
        }
        public void Login(User user)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = JsonSerializer.SerializeToUtf8Bytes(user);

                // Send the message to the connected TcpServer.
                _networkStream.Write(data, 0, data.Length);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show($"ArgumentNullException: {e}");
            }
            catch (SocketException e)
            {
                MessageBox.Show($"SocketException: {e}");
            }
        }
    }
}
