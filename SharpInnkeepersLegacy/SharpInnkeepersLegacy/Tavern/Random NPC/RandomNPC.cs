using System;

namespace SharpInnkeepersLegacy.Random_NPC
{
    class RandomNPC
    {
        static bool drawing = false;

        public static void GiveQuest()
        {
            Console.WriteLine("NPC: Разгадай загадку");
            Console.WriteLine("NPC: Висит груша, нельзя скушать");

            string response = Console.ReadLine();

            if (response.ToLower() == "лампочка")
            {
                if (!drawing)
                {
                    Console.WriteLine("Ура я отгадал!");
                    drawing = true;
                    Console.WriteLine("Поздравляем! Вы получили чертеж.");
                    GetBehindTheCounter.NPCInventorOption();
                    Console.ReadLine();
                }
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
