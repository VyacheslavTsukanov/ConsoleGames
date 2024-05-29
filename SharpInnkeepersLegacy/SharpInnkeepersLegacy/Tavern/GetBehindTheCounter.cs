using System;

namespace SharpInnkeepersLegacy
{
    class GetBehindTheCounter
    {
        static int roomNumber = 1;
        public static void getBehindTheCounter() // Встать за стойку
        {
            Console.WriteLine("К вам подходят люди после рабочего дня!");
            Console.WriteLine("");

            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            int option = GetIntInRange.getIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Вы выходите назад.");
                PlaySister.playForYourSister(); // Вернуться назад
                roomNumber = 1;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine(".");
                roomNumber = 2;
                Console.ReadLine();
            }
            else
            {
                
            }
        }
    }
}
