using System;

namespace SharpInnkeepersLegacy
{
    class Journal
    {
        public static void journal() // Журнал - в журнале будут отображаться все задания, Характеристики и Инвентарь
        {
            Console.WriteLine("Вы находитесь в журнале");
            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. Характеристики персонажа");
            Console.WriteLine("3. Инвентарь персонажа");
            Console.WriteLine("4. Деньги");
            Console.WriteLine("5. Очки лояльности");
            Console.WriteLine("6. Задания");

            int option = GetIntInRange.getIntInRange(6);

            if (option == 1)
            {
                Console.WriteLine("Вы закрываете журнал.");
                PlaySister.playForYourSister();                         // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Ваши характеристики.");
                Specifications specifications = new Specifications();   // Характеристика персонажа
                specifications.set(100);
                specifications.show();
                journal();                                              // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 3)
            {
                Console.WriteLine("Инвентарь персонажа.");
                Inventory();                                            // Инвентарь персонажа
                journal();
                Console.ReadLine();
            }
            else if (option == 4)
            {
                Console.WriteLine("Деньги персонажа.");
                Money money = new Money();                              // Деньги
                money.set(150);
                money.show();
                journal();                                              // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 5)
            {
                Console.WriteLine("Очки лояльности.");
                LoyaltyPoints LoyaltyPoints = new LoyaltyPoints();      // Очки лояльности
                LoyaltyPoints.set(100);
                LoyaltyPoints.show();
                journal();                                              // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 6)
            {
                Console.WriteLine("Сдесь вы можите выбрать задания которые вам оставили поситители.");
                Tasks();                                                // Задания
                Console.ReadLine();
            }
        }

        private static void Inventory()
        {
            Console.WriteLine("Инвентарь персонажа");
        }
        private static void Tasks()
        {
            Console.WriteLine("1. Вернуться в журнал");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");

            int option = GetIntInRange.getIntInRange(5);

            if (option == 1)
            {
                Console.WriteLine("Вы закрываете задания и возвращаетесь в журнал.");
                journal();                                              // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine(".");
                Console.ReadLine();
            }

        }
    }
}
