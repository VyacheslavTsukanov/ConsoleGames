using System;

namespace SharpInnkeepersLegacy
{
    class GetBehindTheCounter
    {
        public static void getBehindTheCounter() // Встать за стойку
        {
            Console.WriteLine("К вам подходят люди после рабочего дня!");
            Console.WriteLine("Привет, налейка кружечку пивка.");

            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            int option = GetIntInRange.getIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Вы выходите назад.");
                PlaySister.playForYourSister(); // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine(".");
                Console.ReadLine();
            }
            else
            {
                
            }
        }
    }
}
