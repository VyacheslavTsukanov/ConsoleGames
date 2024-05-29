using System;

namespace SharpPredator
{
    class Program
    {
        static int roomNumber = 1;
        static bool hasKey = false;
        static bool hasModule = false;

        static void Main(string[] args)
        {
            Game game = new Game();

            Introduction();
            Console.ReadLine();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Мы попадаем в статусы:");
                Console.WriteLine("2. Мы попадаем в карты:");
                Console.WriteLine("3. Мы попадаем в магазин:");
                Console.WriteLine("Используйте стрелки для перемещения по карте или нажмите 'Q' для выхода:");

                if (roomNumber == 1) game.DisplayStats();
                if (roomNumber == 2) game.DisplayMap();
                if (roomNumber == 3) game.EnterShop();

                Console.Clear();
               

                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.Q)
                {
                    break;
                }

                game.MovePlayer(key);

                // Дополнительный сюжет

                //if (game.player.Health <= 0)
                //{
                //    Console.WriteLine("Вы погибли! Игра окончена.");
                //    break;
                //}

                // Дополнение сбора ресурсов и боевки
                // Реализуйте сюжет с сбором ресурсов и боевку здесь

                // Пример:
                // - Добавление событий сбора ресурсов на определенных местах на карте
                // - Реализация боевых сценариев с врагами и возможностью использования навыков и предметов

                // После каждого шага игрока проверяйте условия победы или поражения

                // Пример:
                // if (game.player.Health <= 0) { ... }

                // Выводите информацию о текущем состоянии игры и продолжайте цикл

            }

            Console.WriteLine("Спасибо за игру!");

        }

        public static void Introduction()
        {
            Console.WriteLine("Нет конца и края для ваших фантазий!");
        }

        public static int getIntInRange(int optionsNumber)
            {
                string input = Console.ReadLine();
                int number = -1;
                bool isConverted = int.TryParse(input, out number);
                bool isInRange = number >= 1 && number <= optionsNumber;

                while (!isConverted || !isInRange)
                {
                    Console.WriteLine("Неверная опция, попробуй еще раз!");
                    input = Console.ReadLine();
                    isConverted = int.TryParse(input, out number);
                    isInRange = number >= 1 && number <= optionsNumber;
                }
                return number;
            }
    }
}