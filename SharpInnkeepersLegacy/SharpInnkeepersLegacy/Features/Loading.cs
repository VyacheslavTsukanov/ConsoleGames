using System;
using System.Threading;

namespace SharpInnkeepersLegacy
{
    class Loading
    {
        public static void loading() // Загрузка игры
        {
            Console.Clear();
            string Loading = "Loading...";
            string ProgressBar = "";
            Console.WriteLine(Loading);
            int Counter = 20;
            while (Counter >= 0)
            {
                Console.Write("[{0}", ProgressBar);
                Console.SetCursorPosition(20 + 1, 1);
                Console.Write("] {0}%", 100 - Counter * 5);
                Console.SetCursorPosition(0, 1);
                ProgressBar += ".";
                Thread.Sleep(100);
                Counter--;
            }
            Console.SetCursorPosition(Loading.Length, 0);
            Console.WriteLine("OK\n");
            //Console.ReadKey(true);
        }
    }
}
