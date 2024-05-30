using SharpInnkeepersLegacy.Random_NPC;
using SharpInnkeepersLegacy.Tavern.Diary;
using System;

namespace SharpInnkeepersLegacy
{
   
    class GetBehindTheCounter
    {
        public static void getBehindTheCounter() // Встать за стойку
        {
            Console.Clear();
            Console.WriteLine("К вам подходят люди после рабочего дня!");
            Console.WriteLine("Привет, налейка кружечку пивка.");
            Console.WriteLine("Или ты желаешь пошевелить мозгами и отгадать загадку.");

            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. Налить пиво");
            Console.WriteLine("3. Отгадать загадку");
            Console.WriteLine("4. Посмотреть инвентарь");

            int option = GetIntInRange.getIntInRange(4);

            if (option == 1)
            {
                Console.WriteLine("Вы выходите назад.");
                PlaySister.playForYourSister();         // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Ты наливаешь пиво.");
                GetBehindTheCounter.getBehindTheCounter();
                Console.ReadLine();
            }
            else if (option == 3)
            {
                RandomNPC.GiveQuest();
            }
            else if (option == 4)
            {
                Inventory inventory = new Inventory();  // Инвентарь персонажа
                inventory.DisplayInventory();
                
                Console.ReadLine();
                GetBehindTheCounter.getBehindTheCounter();
            }
        }

        public static void NPCInventorOption()
        {
            Inventory inventory = new Inventory();
            // В инвентарь добавляется предмет, но не остается в нем
            // Далее этот предмет может использоваться при ремонте таверны
            inventory.AddItem("Чертеж");

            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. Что вы хотите удалить?");
            Console.WriteLine("3. Проверить есть ли предмет в наличии");

            int option = GetIntInRange.getIntInRange(3);

            if (option == 1)
            {
                GetBehindTheCounter.getBehindTheCounter();
            }
            else if (option == 2)
            {
                Console.WriteLine("\nВведите предмет для удаления:");
                string itemToRemove = Console.ReadLine();
                inventory.RemoveItem(itemToRemove);
                inventory.DisplayInventory();
            }
            else if (option == 3)
            {
                inventory.itemToCheck();
            }
        }
    }
}
