using SharpInnkeepersLegacy.Tavern.Diary;
using System;

namespace SharpInnkeepersLegacy
{
    class Journal
    {
        public static void journal() // Журнал - в журнале будут отображаться все задания, Характеристики и Инвентарь
        {
            Console.Clear();
            Console.WriteLine("Вы находитесь в журнале");
            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. Характеристики персонажа");
            Console.WriteLine("3. Инвентарь персонажа");
            Console.WriteLine("4. Очки лояльности");
            Console.WriteLine("5. Задания");

            int option = GetIntInRange.getIntInRange(5);

            if (option == 1)
            {
                Console.WriteLine("Вы закрываете журнал.");
                PlaySister.playForYourSister();                         // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Ваши характеристики.\n");
                Specifications specifications = new Specifications();   // Характеристика персонажа
                specifications.DisplayStats();
                Console.ReadLine();
                journal();                                              // Вернуться назад
               
            }
            else if (option == 3)
            {
                Console.WriteLine("Инвентарь персонажа.");
                Inventory inventory = new Inventory();                  // Инвентарь персонажа
                inventory.DisplayInventory();
                Console.ReadLine();
                journal();
               
            }
            else if (option == 4)
            {
                Console.WriteLine("Очки лояльности.\n");
                LoyaltyPoints loyaltyPoints = new LoyaltyPoints();      // Очки лояльности
                loyaltyPoints.DisplayStats();
                journal();                                              // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 5)
            {
                MailboxTasks mailboxTasks = new MailboxTasks();         // Задания
                mailboxTasks.mailboxTasks();
            }
        }
    }
}
