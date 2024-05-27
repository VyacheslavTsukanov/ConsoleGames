using System;

namespace SharpInnkeepersLegacy
{
    class Money
    {
        private int number;
        public void show()
        {
            Console.WriteLine("Деньги: " + number);
        }
        public void set(int money)
        {
            number = money;
        }
        
    }
}
