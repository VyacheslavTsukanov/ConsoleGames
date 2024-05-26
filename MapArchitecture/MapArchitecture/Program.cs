using System;

namespace MapArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            MapGame gameMap = new MapGame(10, 10);
            gameMap.InitializeMap();

            while (true)
            {
                gameMap.DrawMap();

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                gameMap.MovePlayer(keyInfo.Key);
            }
        }
    }
}
