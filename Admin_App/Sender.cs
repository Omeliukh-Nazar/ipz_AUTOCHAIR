using Admin_App.Models;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace Admin_App
{
    public class Sender
    {
        public static string Server { get; set; } = "127.0.0.1";
        public static int Port { get; set; } = 3389;


        public TcpClient tcpClient { get; set; }
        public NetworkStream networkStream { get; set; }
        public Sender()
        {
            try
            {
                // Create a TcpClient.
                tcpClient = new TcpClient(Server, Port);
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
        public void SendSizeOfObject(int size)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(size.ToString());

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
        public int GetSizeOfObject<T>(T obj)
        {
            Byte[] data = JsonSerializer.SerializeToUtf8Bytes(obj);
            return data.Length;
        }
        public void SendChair(Chair chair)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = JsonSerializer.SerializeToUtf8Bytes(chair);

                // Send the message to the connected TcpServer.
                networkStream.Write(data, 0, data.Length);
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
        
    }
}
