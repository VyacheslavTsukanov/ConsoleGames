using System;

namespace SharpInnkeepersLegacy
{

    class Character
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Money { get; set; }

        public Character(int health, int mana, int strength)
        {
            Health = health;
            Mana = mana;
            Strength = strength;
            Money = 150;
        }
    }

    class Specifications
    {
        private Character player;

        public Specifications()
                                
        {
            player = new Character(100, 50, 10);
        }

        public void DisplayStats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Характеристики:");
            Console.WriteLine("Здоровье: " + player.Health);
            Console.WriteLine("Мана: " + player.Mana);
            Console.WriteLine("Сила: " + player.Strength);
            Console.WriteLine("Деньги: " + player.Money);
            Console.ResetColor();
        }
    }
}
