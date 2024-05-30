using System;

namespace SharpInnkeepersLegacy.Random_NPC
{
    public class RandomNPC
    {
        public string Name { get; set; }
        public string Riddle { get; set; }
        public string Answer { get; set; }
        public string Drawing { get; set; }

        public RandomNPC(string name, string riddle, string answer, string drawing)
        {
            Name = name;
            Riddle = riddle;
            Answer = answer;
            Drawing = drawing;
        }

        public void GiveQuest()
        {
            Console.WriteLine($"NPC {Name}: Разгадай загадку");
            Console.WriteLine($"NPC {Name}: {Riddle}");

            string response = Console.ReadLine();

            if (response.ToLower() == Answer.ToLower())
            {
                Console.WriteLine("Ура я отгадал!");
                Console.WriteLine($"Поздравляем! Вы получили {Drawing}.");
                GetBehindTheCounter.NPCInventorOption();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Главный герой: Я пока не готов для этого вызова.");
                Console.ReadLine();
            }

            Console.WriteLine("NPC: Будь осторожен, путник. Удачи в твоем приключении!");
            GetBehindTheCounter.getBehindTheCounter();
            Console.ReadLine();
        }
    }
}
