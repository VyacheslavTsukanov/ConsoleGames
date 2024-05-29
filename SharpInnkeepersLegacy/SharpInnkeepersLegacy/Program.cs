using System;
using System.Collections.Generic;

namespace SharpInnkeepersLegacy
{
    class Program
    {
        class Character
        {
            public int Health { get; set; }
            public int Mana { get; set; }
            public int Strength { get; set; }
            public int Money { get; set; }
            public List<string> Inventory { get; set; }

            public Character(int health, int mana, int strength)
            {
                Health = health;
                Mana = mana;
                Strength = strength;
                Money = 0;
                Inventory = new List<string>();
            }
        }

        class Item
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public Item(string name, int price)
            {
                Name = name;
                Price = price;
            }
        }

        class Game
        {
            private Character player;
            private List<Item> shop;
            private List<string[,]> maps;
            private int currentMapIndex;
            private int playerPositionX;
            private int playerPositionY;

            public Game()
            {
                player = new Character(100, 50, 10);
                shop = new List<Item>
        {
            new Item("Меч", 20),
            new Item("Зелье", 10)
        };
                maps = new List<string[,]>
        {
            new string[,]
            {
                {"Город", "Лес", "Пещера"},
                {"Магазин", "Поляна", "Река"}
            },
            new string[,]
            {
                {"Деревня", "Горы", "Пещера"},
                {"Река", "Поляна", "Лес"}
            }
        };
                currentMapIndex = 0;
                playerPositionX = 0;
                playerPositionY = 0;
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
            }

            public void DisplayMap()
            {
                string[,] currentMap = maps[currentMapIndex];

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Карта:");

                for (int i = 0; i < currentMap.GetLength(0); i++)
                {
                    for (int j = 0; j < currentMap.GetLength(1); j++)
                    {
                        if (i == playerPositionY && j == playerPositionX)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("X\\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(currentMap[i, j] + "\\t");
                        }
                    }
                    Console.WriteLine();
                }

                Console.ResetColor();
            }

            public void MovePlayer(ConsoleKey key)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (playerPositionY > 0)
                        {
                            playerPositionY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (playerPositionY < maps[currentMapIndex].GetLength(0) - 1)
                        {
                            playerPositionY++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (playerPositionX > 0)
                        {
                            playerPositionX--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (playerPositionX < maps[currentMapIndex].GetLength(1) - 1)
                        {
                            playerPositionX++;
                        }
                        break;
                    default:
                        break;
                }
            }

            public void EnterShop()
            {
                if (maps[currentMapIndex][playerPositionY, playerPositionX] == "Магазин")
                {
                    while (true)
                    {
                        Console.Clear();
                        DisplayShop();

                        Console.WriteLine("Выберите предмет для покупки или нажмите 'Q' для выхода:");
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
                }
                else
                {
                    Console.WriteLine("Недостаточно денег!");
                }
            }

            public void ChangeMap()
            {
                if (maps[currentMapIndex][playerPositionY, playerPositionX] == "Город")
                {
                    currentMapIndex = 1;
                    playerPositionX = 0;
                    playerPositionY = 0;
                    Console.WriteLine("Вы покинули город и отправились в деревню.");
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
                else if (maps[currentMapIndex][playerPositionY, playerPositionX] == "Деревня")
                {
                    currentMapIndex = 0;
                    playerPositionX = 0;
                    playerPositionY = 0;
                    Console.WriteLine("Вы покинули деревню и вернулись в город.");
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
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
            }
        }
        static void Main(string[] args)
        {
            //// Меню игры
            //Menu menu = new Menu();
            //Menu.menu();

            Game game = new Game();

            while (true)
            {
                Console.Clear();

                game.DisplayStats();
                game.DisplayMap();

                game.EnterShop();

                Console.WriteLine("Используйте стрелки для перемещения по карте или нажмите 'Q' для выхода:");

                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.Q)
                {
                    break;
                }

                if (key == ConsoleKey.Enter || key == ConsoleKey.Spacebar)
                {
                    game.ChangeMap();
                }

                game.MovePlayer(key);
            }

            Console.WriteLine("Спасибо за игру! Нажмите любую клавишу для выхода...");

            Console.ReadKey();
        }
    }
}
