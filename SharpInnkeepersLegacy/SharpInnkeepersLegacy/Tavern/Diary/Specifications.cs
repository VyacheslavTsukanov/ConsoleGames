using System;

namespace SharpInnkeepersLegacy
{
    class Specifications
    {
        private int number;
        public void show()
        {
            Console.WriteLine("Характеристика персонажа: " + number);
        }
        public void set(int specifications)
        {
            number = specifications;
        }
    }
}
