using SharpInnkeepersLegacy.Tavern.Diary;
using System;

namespace SharpInnkeepersLegacy.Tavern.Random_NPC
{
    public class RandomTask
    {
        public string Name { get; set; }
        public string Riddle { get; set; }
        public string Answer { get; set; }
        public string Drawing { get; set; }

        public RandomTask(string name, string riddle, string answer, string drawing)
        {
            Name = name;
            Riddle = riddle;
            Answer = answer;
            Drawing = drawing;
        }

        public void GiveQuest2()
        {
            MailboxTasks mailboxTasks = new MailboxTasks();
            Console.WriteLine($"NPC {Name}: Выполни задачу");
            Console.WriteLine($"NPC {Name}: {Riddle}");

            string response = Console.ReadLine();

            if (response.ToLower() == Answer.ToLower())
            {
                Console.WriteLine("Ура я отгадал!");
                Console.WriteLine($"Поздравляем! Вы получили {Drawing}.");
                mailboxTasks.mailboxTasks();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Главный герой: Я пока не готов для этого вызова.");
                Console.ReadLine();
            }

            Console.WriteLine("NPC: Будь осторожен, путник. Удачи в твоем приключении!");
            mailboxTasks.mailboxTasks();
            Console.ReadLine();
        }
    }
}