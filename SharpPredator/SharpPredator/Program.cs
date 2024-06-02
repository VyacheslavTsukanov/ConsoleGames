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

                Console.WriteLine("1. Мои статусы:");
                Console.WriteLine("2. Моя карта:");
                Console.WriteLine("3. Мой магазин:");
                int option = getIntInRange(3);

                if (option == 1)
                {
                    game.DisplayStats();
                    Console.WriteLine();
                }
                else if (option == 2)
                {
                    game.DisplayMap();
                    Console.WriteLine();
                }
                else
                {
                    game.EnterShop();
                    Console.WriteLine();
                }

                // game.MovePlayer(key);

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