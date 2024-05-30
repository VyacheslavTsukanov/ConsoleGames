using System;
using System.Collections.Generic;

namespace SharpInnkeepersLegacy.Tavern.Diary
{
    class Inventory
    {
        private List<string> items;

        public Inventory()
        {
            items = new List<string>();
        }

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine($"Предмет \"{item}\" добавлен в инвентарь.");
        }

        public void RemoveItem(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"Предмет \"{item}\" удален из инвентаря.");
            }
            else
            {
                Console.WriteLine($"Предмет \"{item}\" не найден в инвентаре.");
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Инвентарь:");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void itemToCheck()
        {
            Inventory playerInventory = new Inventory();
            Console.WriteLine("\nВведите предмет для проверки наличия:");
            string itemToCheck = Console.ReadLine();

            if (playerInventory.CheckItem(itemToCheck))
            {
                Console.WriteLine($"Предмет \"{itemToCheck}\" есть в инвентаре.");
            }
            else
            {
                Console.WriteLine($"Предмет \"{itemToCheck}\" отсутствует в инвентаре.");
            }
        }

        public bool CheckItem(string item)
        {
            return items.Contains(item);
        }
    }
}

