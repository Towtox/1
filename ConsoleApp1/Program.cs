using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {

            string txt = @"C:\NvutiLog.txt";

            Random rnd = new Random();
            const int rad = 999999;
            bool win = false;
            int c, proc, pop, k = 0;
            Console.WriteLine("Процент:");
            proc = int.Parse(Console.ReadLine());
            Console.WriteLine("Мин. кол-во попыток для победы:");
            pop = int.Parse(Console.ReadLine());
            int a = proc * 10000;
            Console.WriteLine("Go! Go! Go!");
            while (true)
            {
                while (!win)
                {
                    c = rnd.Next(0, rad);
                    if (c <= a)
                    {
                        using (StreamWriter sw = new StreamWriter(txt, true, System.Text.Encoding.Default))
                        {
                            await sw.WriteLineAsync(Convert.ToString(k));
                        }
                        win = true;
                    }
                    else
                    {
                        k++;
                    }
                }
                if (k >= pop)
                {
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine(k);
                    using (StreamWriter sw = new StreamWriter(txt, true, System.Text.Encoding.Default))
                    {
                        await sw.WriteLineAsync("Congratulations!");
                    }
                    Console.ReadLine();
                    k = 0;
                }
                else
                {
                    win = false;
                    k = 0;
                }
            }
        }
    }
}
