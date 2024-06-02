﻿using System;
using System.Collections.Generic;

namespace JourneyThroughLegendaryLands
{
    class Card
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Card> cards = new List<Card>
            {
                new Card { Type = "Местность", Description = "Вы стоите перед величественными воротами древнего храма. Стены покрыты руническими символами, а в воздухе царит загадочная атмосфера." },
                new Card { Type = "Действие", Description = "Вам предстоит сразиться с огненой чудовищем, чтобы спасти деревню от его ярости. Соберите свое оружие и готовьтесь к битве!" },
                new Card { Type = "Действие", Description = "Вы нашли сундук с сокровищами! Отгадайте загадку, чтобы открыть его." },
                new Card { Type = "Местность", Description = "Вы попали в темный лес, где живут опасные существа. Найдите выход, прежде чем станет слишком поздно." },
                new Card { Type = "Действие", Description = "Вам нужно пройти испытание лабиринта. Найдите правильный путь к центру источника магии." },
                new Card { Type = "Местность", Description = "Вы прибыли на древний кладбище. Исследуйте его и найдите утерянные древние артефакты." },
                new Card { Type = "Действие", Description = "Ваш персонаж заблудился в пустыне. Найдите оазис, чтобы восстановить запасы воды." },
                new Card { Type = "Местность", Description = "Вы попали в горную пещеру, где обитают драконы. Будьте осторожны и найдите выход." },
                new Card { Type = "Действие", Description = "Вы вызваны на поединок с могучим воином. Победите его, чтобы продвинуться дальше." },
                new Card { Type = "Местность", Description = "Вы прибыли в мистический лес, где время искажено. Решите головоломки, чтобы вернуться в реальность." },
                new Card { Type = "Действие", Description = "Вам нужно спасти затерянную деревню от нападения орков. Соберите союзников и обороняйтесь!" },
                new Card { Type = "Местность", Description = "Вы попали в забытый храм бога мудрости. Решите его загадки, чтобы получить дары знаний." },
                new Card { Type = "Действие", Description = "Вам предстоит пройти через опасное болото. Найдите безопасный путь, избегая опасностей." },
                new Card { Type = "Местность", Description = "Вы оказались на обрывистом утесе. Найдите способ спуститься вниз, чтобы обнаружить тайны морских пещер." },
                new Card { Type = "Действие", Description = "Вам нужно найти древний артефакт, спрятанный в глубинах подземелья. Будьте готовы к испытаниям!" },
                new Card { Type = "Местность", Description = "Вы прибыли на волшебный остров, где царит вечное лето. Исследуйте его, чтобы найти сокровища." },
                new Card { Type = "Действие", Description = "Вам предстоит разгадать древние руны, чтобы активировать магический портал и перейти на следующий уровень." }


            };

            int playerScore = 0;

            foreach (Card card in cards)
            {
                Console.WriteLine($"Тип: {card.Type}");
                Console.WriteLine($"Описание: {card.Description}");

                if (card.Type == "Действие")
                {
                    Console.WriteLine("Выполняйте задание или вызов!");

                    // Логика выполнения задания и увеличения счета игрока
                    Console.Write("Введите 'выполнено', если задание выполнено: ");
                    string response = Console.ReadLine();

                    if (response.ToLower() == "выполнено")
                    {
                        playerScore++; // Увеличение счета игрока после выполнения задания
                        Console.WriteLine("Задание выполнено! Ваш счет увеличен.");
                    }
                    else
                    {
                        Console.WriteLine("Задание не выполнено. Продолжайте игру.");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Игра окончена. Ваш итоговый счет: {playerScore}");
        }
    }

}
