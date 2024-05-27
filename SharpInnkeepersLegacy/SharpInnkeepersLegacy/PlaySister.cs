using System;

namespace SharpInnkeepersLegacy
{
    class PlaySister
    {
        public static void playForYourSister() // Начало игры
        {
            // Playing for the bartender's sister
            Icons.SisterIcon();
            Console.WriteLine("Эх, таверна в плачевном состоянии! Нужно заработать денег и отремонтировать таверну. " +
                       "Ну как? У меня только 150 золотых и дедушка ничего не говорил... !");

            Console.WriteLine("\nОсмотреть таверну на предметы!\n");
            Console.WriteLine("1. Журнал");
            Console.WriteLine("2. Ремонт таверны");
            Console.WriteLine("3. Встать за стойку");

            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    //Journal journal = new Journal();
                    Journal.journal();  // Журнал - в журнале будут отображаться все задания, Характеристики, Инвентарь, деньги, Очки лояльности
                    break;
                case 2:
                    //TavernRenovation tavernRenovation = new TavernRenovation(); 
                    TavernRenovation.tavernRenovation(); // Ремонт таверны
                    break;
                case 3:
                    // GetBehindTheCounter getBehindTheCounter = new GetBehindTheCounter(); 
                    GetBehindTheCounter.getBehindTheCounter(); // Встать за стойку
                    break;

                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    break;
            }
        }
       

        
    }
}