using System;

namespace SharpAnOldRelic
{
    class Program
    {
        static int roomNumber = 1;
        static bool hasKey = false;
        static bool hasModule = false;

         static void Main(string[] args)
         {
            Introduction(); // Завязка

            while (true)
            {

                if (roomNumber == 1) Courtyard();               // Внутренний двор
                else if (roomNumber == 2) ActionTemple();       // Внутренняя комната (зал)
                else if (roomNumber == 3) ActionLivingRoom();   // Комната с ключом
                else if (roomNumber == 4) ActionDangenRoom();
                else if (roomNumber == 5) ActionQuestRoom();
                else if (roomNumber == 6) LockedRoom();

            }
         }

        private static void Courtyard() // Внутренний двор
        {
            Console.Clear();
            Console.WriteLine("Вы находитесь перед особняком.");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Зайти в дом.");
            int option;

            if (hasModule)
            {
                Console.WriteLine("2. Сесть в машину и уехать из этого особника.");
                option = getIntInRange(2);
                Console.ReadLine();
            }
            else option = getIntInRange(1);

            if(option == 1)
            {
                Console.WriteLine("Ты заходишь в дом.");
                roomNumber = 2;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Conclusion(); // Заключение
                Console.ReadLine();
            }

        }

        private static void ActionTemple()
        {
            Console.Clear();
            Console.WriteLine("Вы находитесь в просторном зале. Перед вами стоит мебель из прошлого века.");
            Console.WriteLine("Вы видите две двери. Одна чють дальше от стола приоткрытая. А вторая справа.");

            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Выйти из дома.");
            Console.WriteLine("2. Зайти в приоткрытую дверь.");
            Console.WriteLine("3. Подойти у двери справа.");

            int option = getIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Вы выходите из дома.");
                roomNumber = 1;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Вы входите в приоткрытую дверь.");
                roomNumber = 3;
                Console.ReadLine();
            }
            else
            {
                OpenOldDoor();
            }
        }

        static void OpenOldDoor() // Проверка есть ли ключ
        {
            Console.WriteLine("Вы дошли до двери справа. На двери висит замок (замочная скважина треугольной формы)");

            if (!hasKey)
            {
                Console.WriteLine("Пытаешься открыть дверь, но это тщетно. Нужно найти ключ от замка...");
                Console.WriteLine("Может посмотреть в другом месте...");
                Console.WriteLine("Возвращаемся в центр зала.");
            }
            else
            {
                Console.WriteLine("Не долго думая ты открываешь эту дверь и заходишь в нее");
                roomNumber = 4;
            }
            Console.ReadLine();
        }

        private static void ActionLivingRoom() // Комната с ключом
        {
            Console.Clear();
            Console.WriteLine("Открыв дверь, ты попадаешь в темную комнату, которую чувствуется по запаху давно не проветривали.");
            Console.WriteLine("В этом доме точно давно никого не было.");
            int option;
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно в зал.");

            if (!hasKey)
            {
                Console.WriteLine("2. Обыскать помещение.");
                option = getIntInRange(2);
            }
            else
            {
                option = getIntInRange(1);
            }

            if(option == 1)
            {
                Console.WriteLine("Возвращаемся обратно в зал.");
                roomNumber = 2;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Спустя несколько минут поисков ты находишь ключ треугольной формы.");
                hasKey = true;
                Console.ReadLine();
            }

        }

        private static void ActionDangenRoom()
        {
            Console.Clear();
            Console.WriteLine("Открыв дверь, ты попадаешь в просторную комнату.");
            Console.WriteLine("В темноте вы видите, что-то светится.");

            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно в зал.");
            Console.WriteLine("2. Добежать до света.");
            Console.WriteLine("3. Обследовать темные углы этого помещения.");

            int option = getIntInRange(3);

            if(option == 1)
            {
                Console.WriteLine("1. Возвращаемся обратно в зал.");
                roomNumber = 2;
                Console.ReadLine();
            }
            else if(option == 2)
            {
                Console.WriteLine("Подойдя ближе к свету, ты понял, что этот свет исходит из двери.");
                Console.WriteLine("Вы проходите дальше.");
                roomNumber = 5;
                Console.ReadLine();
            }
            else // Смерть
            {
                Death();
            }

        }

        static void Death()
        {
            Console.WriteLine("Вы погибли!!!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private static void ActionQuestRoom()
        {
            Console.Clear();
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно в просторную комнату.");
            Console.WriteLine("2. Подойти к двери с замком.");
            int option = getIntInRange(2);

            if (option == 1)
            {
                Console.WriteLine("Возвращаемся обратно в просторную комнату.");
                roomNumber = 4;
                Console.ReadLine();
            }
            else // Решить головоломку
            {
                CompleteQuest();
            }
        }

        static void CompleteQuest()
        {
            Console.WriteLine("Подойдя к двери вы видите кодовый замок.");
            Console.WriteLine("Чтобы открыть его нужно ввести кодовое слово.");
            Console.WriteLine("Хрустальное Платье");
            Console.WriteLine("Розу приняло в объятья.");

            Console.WriteLine("Теперь нужно ввести слово:");
            string answer = Console.ReadLine();

            while (answer.ToLower() != "ваза")
            {
                Console.WriteLine("Выввели неверное слово:");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Комната открылась, ты проходишь дальше.");
            roomNumber = 6;
            Console.WriteLine();

        }


        private static void LockedRoom()
        {
            Console.Clear();
            Console.WriteLine("В этой комнате довольно все чисто и уютно.");
            Console.WriteLine("В этом доме точно давно никого не было.");
            int option;
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно с комнатой с загаткой.");

            if (!hasModule)
            {
                Console.WriteLine("2. Обыскать помещение.");
                option = getIntInRange(2);
            }
            else
            {
                option = getIntInRange(1);
            }

            SelectOptionOnAnotherRoom(option);
        }


        static void SelectOptionOnAnotherRoom(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Возвращаемся обратно.");
                roomNumber = 5;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ты находишь вазу.");
                hasModule = true;
                Console.ReadLine();
            }
        }

        

        static void Introduction() // Завязка
        {
            Console.WriteLine("Добро пожаловать в игру!!!");
            Console.ReadLine();
            Console.WriteLine("Вы получили завещание от дедушки в котором было сказано, что все имущество было переписано на вас.");
            Console.WriteLine("Вы приехали в старый заброшенный дом своего дедушки, что бы забрать старую реликвию.");
            Console.ReadLine();
        }

        static void Conclusion() // Заключение
        {
            Console.WriteLine("Вы покидаете особняк с реликвией в руках.");
            Environment.Exit(0);
        }

        public static int getIntInRange(int optionsNumber)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isInRange = number >= 1 && number <= optionsNumber;

            while (!isConverted || !isInRange)
            {
                Console.WriteLine("Неверная опция, попробуй еще раз!");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isInRange = number >= 1 && number <= optionsNumber;
            }
            return number;
        }
    }
}
