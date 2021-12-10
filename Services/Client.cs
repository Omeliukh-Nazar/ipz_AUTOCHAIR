using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Text.Json;

namespace ipz_AUTOCHAIR
{
    public class Client
    {
        public static int ID { get; set; }
        public static string Server { get; set; } = "127.0.0.1";
        public static int Port { get; set; } = 3389;


        public TcpClient tcpClient { get; set; }
        public NetworkStream networkStream { get; set; }

        public Client()
        {
            try
            {
                // Create a TcpClient.
                tcpClient = new TcpClient(Client.Server, Client.Port);
                // Get a client stream for reading and writing.
                networkStream = tcpClient.GetStream();
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

        public void Close()
        {
            tcpClient.Close();
            networkStream.Close();
        }

        public void SendCommand(string command)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(command);

                // Send the message to the connected TcpServer.
                networkStream.Write(data, 0, data.Length);
                Thread.Sleep(100);
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
        public string GetResponce()
        {
            Byte[] bytes = new Byte[256];
            String data = null;
            int i = 0;
            while ((i = networkStream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
            }
            return data;
        }
        internal int GetSize()
        {
            Byte[] bytes = new Byte[256];
            String data = null;
            int i = 0;
            while ((i = networkStream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                return int.Parse(data);
            }
            return 256;
        }

        public T GetObject<T>(int size)
        {
            Byte[] bytes = new Byte[size];
            String data = null;
            int i = 0;
            while ((i = networkStream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                var deserialized = JsonSerializer.Deserialize<T>(System.Text.Encoding.ASCII.GetBytes(data));
                return deserialized;
            }
            var deserialized1 = JsonSerializer.Deserialize<T>(System.Text.Encoding.ASCII.GetBytes(data));
            return deserialized1;
        }

    }

}
