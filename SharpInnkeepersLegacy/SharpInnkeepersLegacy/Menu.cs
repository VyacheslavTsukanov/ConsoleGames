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



            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    DescriptionOfTheGame();
                    break;
                case 2:
                    ChoosingHero();
                    break;
                case 3:
                    Developer();
                    break;

                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    menu();
                    break;
            }
        }

        public static void DescriptionOfTheGame() // Описание игры
        {
            introduction();

            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            
            switch (a)
            {
                case 1:
                    menu(); // Вернуться в меню
                    break;

                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    DescriptionOfTheGame();
                    break;
            }
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
            // Console.WriteLine("2. Младший брат - средний уровень (вы можите продать таверну и купить ");
            // Console.WriteLine("3. Старший брат - высокий уровень (вы вынужены продать таверну и на вырученные деньги купить ");

            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    menu(); // Вернуться в меню
                    break;

                case 2:
                    Loading.loading(); // Загрузка игры
                    PlaySister.playForYourSister(); // Играем за сестру
                    break;

                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    ChoosingHero();
                    break;
            }

        }

       

        public static void Developer() // Разработчик
        {
            Console.Clear();
            Console.WriteLine("Vyacheslav Tsukanov");
            Console.WriteLine("1. Вернуться в меню");

            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    menu(); // Вернуться в меню
                    break;
               
                default:
                    Console.WriteLine("Вы ввели некоректное число!");
                    Developer();
                    break;
            }
        }
    }
}
