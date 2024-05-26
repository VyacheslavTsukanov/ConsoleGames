using System;

namespace SharpAnOldRelic
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction();

            while (true)
            {
                if (roomNumber == 1) ActionStarship();
                if (roomNumber == 2) ActionStarship2();
                if (roomNumber == 3) ActionStarship3();
            }
        }

        static void Introduction()
        {

            Console.WriteLine("");
        }

        public static int getIntInRange(int optionsNumber)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isInRange = number >= 1 && number <= optionsNumber;

            while (!isConverted || !isInRange)
            {
                Console.WriteLine("Неверная опция, попробуй еще раз!");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isInRange = number >= 1 && number <= optionsNumber;
            }
            return number;
        }
    }
}
