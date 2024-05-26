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

        public MapGame(int width, int height)
        {
            mapWidth = width;
            mapHeight = height;
            map = new char[mapWidth, mapHeight];
            playerX = 0;
            playerY = 0;
        }

        public void InitializeMap()
        {
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    map[i, j] = '.';
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
                        Console.Write('P');
                    }
                    else
                    {
                        Console.Write(map[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        public void MovePlayer(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (playerX > 0)
                    {
                        playerX--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (playerX < mapWidth - 1)
                    {
                        playerX++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (playerY > 0)
                    {
                        playerY--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (playerY < mapHeight - 1)
                    {
                        playerY++;
                    }
                    break;
            }
        }
    }
}
