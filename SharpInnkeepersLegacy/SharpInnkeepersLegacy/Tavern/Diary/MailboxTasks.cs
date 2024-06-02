using SharpInnkeepersLegacy.Tavern.Random_NPC;
using System;

namespace SharpInnkeepersLegacy.Tavern.Diary
{
    class MailboxTasks
    {
        public void mailboxTasks()
        {
            Console.WriteLine("Сдесь вы можите выбрать задания которые вам оставили в почтовом ящике.");
            Console.WriteLine("1. Вернуться в журнал");
            Console.WriteLine("2. Выполнить задания");

            int option = GetIntInRange.getIntInRange(2);

            if (option == 1)
            {
                Console.WriteLine("Вы закрываете задания и возвращаетесь в журнал.");
                Journal.journal();                                              // Вернуться назад
                Console.ReadLine();
            }
            else if (option == 2)
            {
                TasksInTheMailbox();
            }

        }
        public static void TasksInTheMailbox()
        {
            string[] names = { "Дракон", "Фея", "Рыцарь", "Гоблин", "Волшебник" };
            string[] riddles = {
                "Что можно увидеть с двух сторон и всегда остаётся на месте?",
                "Что можно сломать, если произнести его имя?",
                "Что идёт вверх, но никогда не спускается?",
                "Что можно взять, но нельзя подержать?",
                "Что есть в конце каждой минуты и каждого мгновения, но не в конце каждого часа?"
            };
            string[] answers = {
                "монета", "молчание", "возраст", "фотографию", "буква 'е'"
            };
            string[] drawings = {
                "чертеж кухни", "чертеж мебели", "чертеж грили", "чертеж барной стойки", "чертеж 5"

            };

            RandomTask[] npcs = new RandomTask[names.Length];

            for (int i = 0; i < npcs.Length; i++)
            {
                npcs[i] = new RandomTask(names[i], riddles[i], answers[i], drawings[i]);
            }

            while (true)
            {
                Random random = new Random();
                int randomIndex = random.Next(npcs.Length);

                npcs[randomIndex].GiveQuest2();
            }
        }
    }
}
