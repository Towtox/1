using System;
using System.Net;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        //private static string https;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите прямую ссылку на ресурс.");
            Console.WriteLine("Например ( https://github.com/Towtox/1/archive/refs/heads/master.zip )");
            string a = Console.ReadLine();
            
            WebClient client = new WebClient();

            client.DownloadFile(a, "test.zip");
            


        }
    }
}
