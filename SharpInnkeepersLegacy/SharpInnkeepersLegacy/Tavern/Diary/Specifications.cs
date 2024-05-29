using System;
using System.Collections.Generic;

namespace SharpInnkeepersLegacy
{

    class Character
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Money { get; set; }
        public List<string> Inventory { get; set; }

        public Character(int health, int mana, int strength)
        {
            Health = health;
            Mana = mana;
            Strength = strength;
            Money = 150;
            // Inventory = new List<string>();
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
            //Console.WriteLine("Инвентарь:");
            //foreach (var item in player.Inventory)
            //{
            //    Console.WriteLine("- " + item);
            //}
            Console.ResetColor();
        }

    }
}
