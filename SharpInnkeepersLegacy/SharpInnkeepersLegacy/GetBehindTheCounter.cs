using System;

namespace SharpInnkeepersLegacy
{
    class GetBehindTheCounter
    {
        public static void getBehindTheCounter() // Встать за стойку
        {
            Console.WriteLine("К вам подходят люди после рабочего дня!");
            Console.WriteLine("");

            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");

            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    PlaySister.playForYourSister(); // Вернуться назад
                    break;
                case 2:
                    //();   // 
                    break;
                case 3:
                    //();   // 
                    break;


                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    break;
            }
        }
    }
}
