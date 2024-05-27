using System;

namespace MapArchitecture
{
    class MapGame
    {
        private char[,] map;
        private int mapWidth;
        private int mapHeight;
        private int playerX;
        private int playerY;
        private int scoreApples;
        private int scorePears;
        private int level;

        public MapGame(int width, int height)
        {
            mapWidth = width;
            mapHeight = height;
            map = new char[mapWidth, mapHeight];
            playerX = 1;
            playerY = 1;
            scoreApples = 0;
            scorePears = 0;
            level = 1;
        }

        public void InitializeMap()
        {
            // Заполнение карты стенами и проходами
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if (i == 0 || j == 0 || i == mapWidth - 1 || j == mapHeight - 1)
                    {
                        map[i, j] = '#'; // Стена
                    }
                    else
                    {
                        map[i, j] = ' '; // Проход
                    }
                }
            }

            // Добавим дополнительные стены и проходы в зависимости от уровня
            if (level >= 2)
            {
                for (int i = 5; i < 15; i++)
                {
                    map[i, 10] = '#';
                }
            }

            if (level >= 3)
            {
                for (int i = 5; i < 15; i++)
                {
                    map[i, 15] = '#';
                }
            }

            // Размещение яблок и груш на карте
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(1, mapWidth - 1);
                int y = random.Next(1, mapHeight - 1);
                if (map[x, y] == ' ')
                {
                    if (random.Next(0, 2) == 0)
                    {
                        map[x, y] = 'A'; // Яблоко
                    }
                    else
                    {
                        map[x, y] = 'P'; // Груша
                    }
                }
            }
        }

        public void DrawMap()
        {
            Console.Clear();
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if (i == playerX && j == playerY)
                    {
                        Console.Write('P'); // Игрок
                    }
                    else
                    {
                        Console.Write(map[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Яблок собрано: " + scoreApples);
            Console.WriteLine("Груш собрано: " + scorePears);
            Console.WriteLine("Уровень: " + level);
        }

        public void MovePlayer(ConsoleKey key)
        {
            int newX = playerX;
            int newY = playerY;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    newX = playerX - 1;
                    break;
                case ConsoleKey.DownArrow:
                    newX = playerX + 1;
                    break;
                case ConsoleKey.LeftArrow:
                    newY = playerY - 1;
                    break;
                case ConsoleKey.RightArrow:
                    newY = playerY + 1;
                    break;
            }

            if (map[newX, newY] != '#') // Проверка на столкновение со стеной
            {
                if (map[newX, newY] == 'A')
                {
                    scoreApples++;
                    CheckLevelCompletion();
                }
                else if (map[newX, newY] == 'P')
                {
                    scorePears++;
                    CheckLevelCompletion();
                }
                playerX = newX;
                playerY = newY;
                map[newX, newY] = ' '; // Удаление фрукта после сбора
            }
        }

        private void CheckLevelCompletion()
        {
            if (scoreApples >= 2 && scorePears >= 3)
            {
                level++;
                scoreApples = 0;
                scorePears = 0;
                InitializeMap();
            }
        }
    }
}
