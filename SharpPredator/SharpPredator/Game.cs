using System;
using System.Collections.Generic;

namespace SharpPredator
{
    class Game
    {
        private Character player;
        private List<Item> shop;
        private List<string> maps;
        private int playerPosition;

        public Game()
        {
            player = new Character(100, 50, 10);
            shop = new List<Item>
        {
            new Item("Меч", 20),
            new Item("Зелье", 10)
        };
            maps = new List<string> { "Город", "Лес", "Поляна", "Пещера" };
            playerPosition = 0;
        }

        public void DisplayStats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Характеристики:");
            Console.WriteLine("Здоровье: " + player.Health);
            Console.WriteLine("Мана: " + player.Mana);
            Console.WriteLine("Сила: " + player.Strength);
            Console.WriteLine("Деньги: " + player.Money);
            Console.WriteLine("Инвентарь:");
            foreach (var item in player.Inventory)
            {
                Console.WriteLine("- " + item);
            }
            Console.ResetColor();
            Console.ReadKey();
        }

        public void DisplayMap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Вы находитесь в: " + maps[playerPosition]);
            Console.ResetColor();
            Console.ReadKey();
        }

        public void MovePlayer(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (playerPosition > 0)
                    {
                        playerPosition--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (playerPosition < maps.Count - 1)
                    {
                        playerPosition++;
                    }
                    break;
                default:
                    break;
            }
        }

        public void EnterShop()
        {
            if (maps[playerPosition] == "Город")
            {
                Console.WriteLine("Вы находитесь на главной площади города:");
                while (true)
                {
                    Console.Clear();
                    DisplayShop();

                    Console.WriteLine("1. Нажмите 'Q' для выхода:");
                    var key = Console.ReadKey().Key;

                    if (key == ConsoleKey.Q)
                    {
                        break;
                    }

                    int index = key - ConsoleKey.D1;

                    if (index >= 0 && index < shop.Count)
                    {
                        BuyItem(index);
                        Console.WriteLine("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                    }
                }
            }
        }

        public void BuyItem(int index)
        {
            Item item = shop[index];

            if (player.Money >= item.Price)
            {
                player.Money -= item.Price;
                player.Inventory.Add(item.Name);
                Console.WriteLine("Вы купили: " + item.Name);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Недостаточно денег!");
                Console.ReadKey();
            }
        }

        public void DisplayShop()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Магазин:");

            for (int i = 0; i < shop.Count; i++)
            {
                Item item = shop[i];

                Console.WriteLine($"{i + 1}. {item.Name} - Цена: {item.Price}");
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
