using System;

namespace SharpInnkeepersLegacy
{
    class GetIntInRange
    {
        
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
