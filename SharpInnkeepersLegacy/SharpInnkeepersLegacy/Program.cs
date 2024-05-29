using System;

namespace SharpInnkeepersLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Меню игры
            Menu menu = new Menu();
            Menu.menu();

            Console.ReadKey();
        }
    }
}
