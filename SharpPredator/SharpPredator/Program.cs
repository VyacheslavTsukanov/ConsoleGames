using System;

namespace SharpPredator
{
    class Program
    {
        public static void Preface()
        {
            Console.WriteLine("Нет конца и края для ваших фонтазий!");
        }

        static void Main(string[] args)
        {
            Game game = new Game();

            Preface();
            Console.ReadLine();

            while (true)
            {
                Console.Clear();
               

                Console.WriteLine("1. Используйте стрелки для перемещения по карте или нажмите 'Q' для выхода:");
                //Console.WriteLine("2. Посмотреть статы");
                //Console.WriteLine("2. Посмотреть карты");


                Console.Clear();

                game.DisplayStats();
                Console.ReadLine();

                game.DisplayMap();
                Console.ReadLine();

                game.EnterShop();
                Console.ReadLine();

                Console.WriteLine("Используйте стрелки для перемещения по карте или нажмите 'Q' для выхода:");

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
    }
}