using System;

namespace SharpInnkeepersLegacy
{
    class Menu
    {
        public static void menu() // Начало игры
        {
            
            Console.WriteLine("***Добро пожаловать в таверну Наследие владельцев гостиниц!***");
            Console.WriteLine("1. Описание игры!"); // Description of the game
            Console.WriteLine("2. Выбор героя!");   // Choosing a hero
            Console.WriteLine("3. Разработчик!");   // Developer
            int option = GetIntInRange.getIntInRange(3);

            if (option == 1) DescriptionOfTheGame();// Описание игры
            else if (option == 2) ChoosingHero();   // Выбор героя
            else Developer();                       // Разработчик
        }

        public static void DescriptionOfTheGame() // Описание игры
        {
            introduction();

            int option = GetIntInRange.getIntInRange(1);
            if (option == 1) menu(); // Вернуться в меню
        }

        public static void introduction()
        {
            Console.Clear();
            Console.WriteLine("У вас была большая дружная семья. Вы ни в чем не нуждались, но неожиданно для вас умирает " +
                           " ваш дедушка! И все что у вас осталось - это таверна и вы вынуждены работать на ней!");
            Console.WriteLine("1. Вернуться в меню");
        }

        public static void ChoosingHero() // Выбор героя
        {
            Console.Clear();
            Console.WriteLine("Вам доступны три героя на выбор");
            Console.WriteLine("Каждый герой имеет свой уровень развития");
            Console.WriteLine("1. Вернуться в меню");
            Console.WriteLine("2. Сестра - легкий уровень (вам сразу доступна таверна)");
            // Console.WriteLine("3. Младший брат - средний уровень (вы можите продать таверну и купить ");
            // Console.WriteLine("4. Старший брат - высокий уровень (вы вынужены продать таверну и на вырученные деньги купить ");

            int option = GetIntInRange.getIntInRange(2);

            if (option == 1)
            {
                menu(); // Вернуться в меню
            }
            else if (option == 2)
            {
                Loading.loading(); // Загрузка игры
                PlaySister.playForYourSister(); // Играем за сестру
            }
        }

        public static void Developer() // Разработчик
        {
            Console.Clear();
            Console.WriteLine("Vyacheslav Tsukanov");
            Console.WriteLine("1. Вернуться в меню");

            int option = GetIntInRange.getIntInRange(1);
            if (option == 1) menu(); // Вернуться в меню
        }
    }
}
