using System.Collections.Generic;

namespace SharpPredator
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
            Money = 100;
            Inventory = new List<string>();
        }
    }
}
