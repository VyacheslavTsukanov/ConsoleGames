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

            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    PlaySister.playForYourSister(); // Вернуться назад
                    break;
                case 2:
                    Specifications specifications = new Specifications();   // Характеристика персонажа
                    specifications.set(100);
                    specifications.show();
                    journal(); // Вернуться назад
                    break;
                case 3:
                    Inventory();                    // Инвентарь персонажа
                    break;
                case 4:
                    Money money = new Money();      // Деньги
                    money.set(150);
                    money.show();
                    journal(); // Вернуться назад
                    break;
                case 5:
                    LoyaltyPoints LoyaltyPoints = new LoyaltyPoints();      // Очки лояльности
                    LoyaltyPoints.set(100);
                    LoyaltyPoints.show();
                    journal(); // Вернуться назад
                    break;
                case 6:
                    Tasks();                    // Задания
                    break;

                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    break;
            }

            
        }

        private static void Inventory()
        {
            Console.WriteLine("Инвентарь персонажа");
        }
        private static void Tasks()
        {
            Console.WriteLine("Задания");
        }
    }
}
