using System;

namespace SharpExoplanetHermitsOfTheGalaxy
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("В галактике, где правят хаос и опасность, вы оказываетесь на планете, которая кажется идеальным местом для колонизации. Ваша задача - построить базу, обеспечить выживание колонистов, исследовать технологии и прокладывать путь к процветанию в этом безжалостном мире.");

            BaseBuilding baseBuilding = new BaseBuilding();
            Survival survival = new Survival();
            Research research = new Research();
            RandomEvents randomEvents = new RandomEvents();
            GameLoop gameLoop = new GameLoop();

            // Здесь можно добавить цикл игры, в котором будут вызываться методы классов для управления игровым процессом

            Material wood = new Material("wood", 0);
            Material stone = new Material("stone", 0);
            Material metal = new Material("metal", 0);
            Material crystals = new Material("crystals", 0);

            wood.Gather(10);
            stone.Gather(5);
            metal.Gather(3);
            crystals.Gather(8);

        }
    }
}
