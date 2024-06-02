using System;

namespace SharpInnkeepersLegacy
{
    

    class TavernRenovation
    {
        internal class Tavern
        {
            public int LoyaltyPoints { get; set; }

            public Tavern()
            {
                LoyaltyPoints = 0;
            }

            public void RepairKitchen()
            {
                Console.WriteLine("Кухня отремонтирована.\n");
                LoyaltyPoints += 10;
                tavernRenovation();
            }

            public void RepairFurniture()
            {
                Console.WriteLine("Мебель отремонтирована.\n");
                LoyaltyPoints += 15;
                tavernRenovation();
            }

            public void RepairGrill()
            {
                Console.WriteLine("Гриль отремонтирован.\n");
                LoyaltyPoints += 5;
                tavernRenovation();
            }

            public void RepairBarCounter()
            {
                Console.WriteLine("Барная стойка отремонтирована.\n");
                LoyaltyPoints += 20;
                tavernRenovation();
            }
        }

        public static void tavernRenovation() // Ремонт таверны
        {
            Tavern tavern = new Tavern();
            
            Console.WriteLine("Таверна в плачевном состоянии. Дедушка следил за ней как мог, а нас не было рядом когда ему нужна была помощь." +
                "Чтож, пришла и моя очедь следить за ней. С чего же начать?");
            Console.WriteLine("Чем лучше у вас товерна, чем больше у вас Очки лояльности");

            Console.WriteLine("\nМеню ремонта:");
            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. Отремонтировать кухню");
            Console.WriteLine("3. Отремонтировать мебель");
            Console.WriteLine("4. Отремонтировать гриль");
            Console.WriteLine("5. Отремонтировать барную стойку");
            Console.WriteLine("6. Текущее количество Очков лояльности");

            Console.Write("Введите число: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlaySister.playForYourSister();
                    break;
                case 2:
                    tavern.RepairKitchen();
                    break;
                case 3:
                    tavern.RepairFurniture();
                    break;
                case 4:
                    tavern.RepairGrill();
                    break;
                case 5:
                    tavern.RepairBarCounter();
                    break;
                case 6:
                    Console.WriteLine($"Текущее количество Очков лояльности: {tavern.LoyaltyPoints}");
                    tavernRenovation();
                    Console.WriteLine("");
                    break;
                
                default:
                    Console.WriteLine("Вы ввели некорректное число!");
                    break;
            }
        }
    }
}
