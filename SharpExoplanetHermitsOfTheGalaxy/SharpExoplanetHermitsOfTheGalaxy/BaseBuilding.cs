using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExoplanetHermitsOfTheGalaxy
{
    interface IResourceManagement
    {
        void ManageResources();
    }

    class Material
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Material(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public void Gather(int amount)
        {
            Quantity += amount;
            Console.WriteLine($"Собрано {amount} единиц материала {Name}. Всего теперь у вас {Quantity} единиц.");
        }
    }
    public class BaseBuilding : IResourceManagement // Строительство базы
    {
        private void ShowErrorMessage(string message)
        {
            Console.WriteLine("Ошибка: " + message);
        }

        bool CheckResourceAvailability(int requiredResources, int availableResources)
        {
            if (requiredResources <= availableResources)
            {
                Console.WriteLine("Ресурсы доступны.");
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно ресурсов.");
                return false;
            }
        }

        int SubtractResources(int availableResources, int resourcesToSubtract)
        {
            if (resourcesToSubtract <= availableResources)
            {
                availableResources -= resourcesToSubtract;
                Console.WriteLine($"{resourcesToSubtract} ресурсов вычтено. Осталось {availableResources} ресурсов.");
                return availableResources;
            }
            else
            {
                Console.WriteLine("Невозможно вычесть указанное количество ресурсов.");
                return availableResources;
            }
        }

        public void ManageResources()
        {
            int food = 100;
            int water = 50;
            int minerals = 200;

            Material wood = new Material("wood", 0);
            Material stone = new Material("stone", 0);
            Material metal = new Material("metal", 0);
            Material crystals = new Material("crystals", 0);

            // Здесь можно добавить логику управления ресурсами для базы
            if (food < 20)
            {
                // Предпринять действия по обеспечению продовольствия
            }

            if (water < 10)
            {
                // Предпринять действия по обеспечению воды
            }

            if (minerals < 50)
            {
                // Предпринять действия по добыче минералов
            }
        }
    }
}
