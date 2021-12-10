using ipz_Server_AUTOCHAIR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading;

namespace ipz_Server_AUTOCHAIR
{
    class Server
    {
        public static void Main()
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 3389;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                Console.Write("Waiting for a connection... ");
                // Enter the listening loop.
                while (true)
                {
                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i = 0;
                    // Loop to receive all the data sent by the client.
                    data = GetCommand(stream, i, bytes, data);
                    switch (data)
                    {
                        case "[REGISTER]":
                            Register(stream);
                            break;
                        case "[LOGIN]":
                            Login(stream);
                            break;
                        case "[ADDCHAIR]":
                            AddChair(stream);
                            break;
                        case "[UPDATE]":
                            Update(stream);
                            break;
                        case "[ADDORDER]":
                            AddOrder(stream);
                            break;
                        case "[GETORDERS]":
                            SendOders(stream);
                            break;

                        default:
                            break;
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }

            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }

        private static void SendOders(NetworkStream stream)
        {
            int id = GetSizeOfObject(stream);
            List<Order> orders = new List<Order>();
            orders = Repository.GerOdersById(id);
            int size = SizeOf<List<Order>>(orders);
            SendSize(stream, size);
            SendObject<List<Order>>(stream, orders);
            Console.WriteLine($"Send orders to user {id}");
        }

        private static void AddOrder(NetworkStream stream)
        {
            int objSize = GetSizeOfObject(stream);
            List<Order> orders = GetObject<List<Order>>(stream, objSize);
            Console.WriteLine($"Order is added : ");
            foreach (var item in orders)
            {
                Console.WriteLine($"\nUserID = {item.UserId} \nChair Name = {item.Chair.Name} \nCount {item.Count}");
            }
            Repository.AddOrders(orders);
        }

        private static void Update(NetworkStream stream)
        {
            List<Chair> chairs = new List<Chair>();
            chairs.AddRange(Repository.GetAllChairs());
            int objSize = SizeOf<List<Chair>>(chairs);
            SendSize(stream, objSize);
            SendObject<List<Chair>>(stream, chairs);
        }

        private static void AddChair(NetworkStream stream)
        {
            int objSize = GetSizeOfObject(stream);
            Chair chair = GetObject<Chair>(stream, objSize);
            Console.WriteLine($"Chair is added :\nName = {chair.Name} \nDiscription = {chair.Discription}" +
                $"Prise = {chair.Prise} PhotoLen = {chair.Image.Length}");
            Repository.AddChair(chair);
        }

        private static int SizeOf<T>(T obj)
        {
            Byte[] data = JsonSerializer.SerializeToUtf8Bytes(obj);
            return data.Length;
        }

        private static void Login(NetworkStream stream)
        {
            User user = GetObject<User>(stream);
            int check = Repository.CheckLogin(user);
            if (check != -1)
            {
                Console.WriteLine($"User log in :\nLogin = {user.Login} \nPassword = {user.Password}");
                stream.Write(System.Text.Encoding.ASCII.GetBytes(check.ToString()));
            }
            else
            {
                Console.WriteLine($"No access " + check);
                string error = "Error : Incorect Login or(and) Password";
                stream.Write(System.Text.Encoding.ASCII.GetBytes(error));
            }
        }

        private static void Register(NetworkStream stream)
        {
            User user = GetObject<User>(stream);
            string check = Repository.CheckUser(user);
            if (check == "Correct")
            {
                Repository.AddUser(user);
                Console.WriteLine($"New user added : \nName = {user.Name} \nEmail = {user.Email} \nPhone = {user.Phone}" +
                    $"\nLogin = {user.Login} \nPassword = {user.Password}");
                string success = "User registered successfully";
                stream.Write(System.Text.Encoding.ASCII.GetBytes(success));
            }
            else
            {
                Console.WriteLine($"User is incorect " + check);
                string error = "Error : "+ check;
                stream.Write(System.Text.Encoding.ASCII.GetBytes(error));
            }
           
        }
      

        public static string GetCommand(NetworkStream stream, int i, Byte[] bytes, string data)
        {
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                Console.WriteLine("Received command:\n{0}", data);

                // Process the data sent by the client.
                data = data.ToUpper();
                if (data.Contains(']'))
                    break;
            }
            return data;
        }

        public static int GetSizeOfObject(NetworkStream stream)
        {
            Byte[] bytes = new Byte[256];
            String data = null;
            int i = 0;
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                Console.WriteLine("Received size of object :\n{0}", data);
                return int.Parse(data);
            }
            return int.Parse(data);

        }
        public static T GetObject<T>(NetworkStream stream)
        {
            Byte[] bytes = new Byte[256];
            String data = null;
            int i = 0;
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                var deserialized = JsonSerializer.Deserialize<T>(System.Text.Encoding.ASCII.GetBytes(data));
                return deserialized;
            }
            var deserialized1 = JsonSerializer.Deserialize<T>(System.Text.Encoding.ASCII.GetBytes(data));
            return deserialized1;
        }
        private static T GetObject<T>(NetworkStream stream, int objSize)
        {
            Byte[] bytes = new Byte[objSize];
            String data = null;
            int i = 0;
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                var deserialized = JsonSerializer.Deserialize<T>(System.Text.Encoding.ASCII.GetBytes(data));
                return deserialized;
            }
            var deserialized1 = JsonSerializer.Deserialize<T>(System.Text.Encoding.ASCII.GetBytes(data));
            return deserialized1;
        }
        private static void SendObject<T>(NetworkStream stream, T obj)
        {
            Byte[] data = JsonSerializer.SerializeToUtf8Bytes(obj);
            stream.Write(data, 0, data.Length);
        }
        private static void SendSize(NetworkStream stream, int size)
        {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(size.ToString());

                stream.Write(data, 0, data.Length);
                Thread.Sleep(100);
        }
    }
}
