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

            int option = GetIntInRange.getIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Вы открываете журнал.");
                //Journal journal = new Journal();
                Journal.journal();                  // Журнал - в журнале будут отображаться все задания, Характеристики, Инвентарь, деньги, Очки лояльности
       
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Что будем изменять, добавлять.");
                //TavernRenovation tavernRenovation = new TavernRenovation(); 
                TavernRenovation.tavernRenovation();                                        // Ремонт таверны
                Console.ReadLine();
            }
            else
            {
                // GetBehindTheCounter getBehindTheCounter = new GetBehindTheCounter(); 
                GetBehindTheCounter.getBehindTheCounter();                                  // Встать за стойку
            }

        }
    }
}