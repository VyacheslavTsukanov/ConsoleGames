using System;
using System.Collections.Generic;

namespace SharpInnkeepersLegacy.Tavern.Diary
{
    class Character
    {
         public List<string> Inventory { get; set; }

        public Character()
        {
            Inventory = new List<string>();
        }
    }

    class Inventory
    {
        private Character player;

        public void InventoryDisplay()
        {
            foreach (var item in player.Inventory)
            {
                Console.WriteLine("- " + item);
            }
            Console.ResetColor();
        }
    }
}

