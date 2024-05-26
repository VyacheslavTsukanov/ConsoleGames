using System;

namespace SharpInnkeepersLegacy
{
    class LoyaltyPoints
    {
        private int number;
        public void show()
        {
            Console.WriteLine("Очки лояльности: " + number);
        }
        public void set(int money)
        {
            number = money;
        }
    }
}
