using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serv = new TcpListener(IPAddress.Any, 8888);
            Console.WriteLine("Server started");

            serv.Start();

           while(true)
            {    
            TcpClient user = serv.AcceptTcpClient();
                
                do
            {
                    NetworkStream stream = user.GetStream();
                    string response = "Hello";
                    byte[] data = Encoding.UTF8.GetBytes(response);

                    // отправка сообщения
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Отправлено сообщение: {0}", response);
                    stream.Close();
                    
                }
            while (user.Available > 0);

                serv.Stop();

            }
        
        }
    }
}