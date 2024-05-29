using System;

namespace SharpInnkeepersLegacy
{
    class TavernRenovation
    {
        public static void tavernRenovation() // Ремонт таверны
        {
            Console.WriteLine("Таверна в плачевном состоянии. Дедушка следил за ней как мог, а нас не было рядом когда ему нужна была помощь." +
                "Чтож, пришла и моя очедь следить за ней. С чего же начать?");
            Console.WriteLine("Чем лучше у вас товерна, чем больше у вас Очки лояльности");

            Console.WriteLine("1. Вернуться назад");
            Console.WriteLine("2. Отремонтировать кухню");
            Console.WriteLine("3. Отремонтировать мебель");
            Console.WriteLine("4. Отремонтировать гриль");
            Console.WriteLine("5. Отремонтировать барную стойку");
            Console.WriteLine("6. ");

            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    PlaySister.playForYourSister(); // Вернуться назад
                    break;
                case 2:
                    //();   // 
                    break;
                case 3:
                    //();   // 
                    break;
                case 4:
                    //();   // 
                    break;
                case 5:
                    //();   // 
                    break;
                case 6:
                    //();   // 
                    break;

                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    break;
            }
        }
    }
}
