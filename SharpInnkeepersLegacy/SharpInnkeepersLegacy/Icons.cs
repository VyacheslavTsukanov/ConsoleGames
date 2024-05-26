﻿using System;
using System.Threading;

namespace SharpInnkeepersLegacy
{
    
    class Icons
    {
        
        public static void SisterIcon() // Иконка сестры
        {
            Console.WriteLine("Нарисована иконка сестры");

            BartenderSister spin = new BartenderSister();
            int i = 10;
            do
            {
                spin.Turn();
                Thread.Sleep(100);
                //Console.Clear();
                i--;
            }
            while (i < 6);

            

        }

        public static void TheHeartIcon() // Иконка игры сердце
        {
            Console.Title = "HABR @Frog_cry_too"; //TITTLE КОНСОЛИ
            Console.ForegroundColor = ConsoleColor.White; //ЦВЕТ ТЕКСТА В КОНСОЛЕ

            //ИНИЦИАЛИЗИРУЕМ МАССИВ
            int height = 10, width = 20;
            char[,] buffer = new char[height, width];



            //ЗАПОЛНЯЕМ МАССИВ
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //ВЫВОДИМ ТОЧКУ В ЦЕНТР БУФФЕРА
                    int x = j - width / 2;
                    int y = -1 * (i - height / 2); //ПО-СКОЛЬКУ РЯДЫ МАССИВА БУДУТ ИНИЦИАЛИЗИРОВАТЬСЯ СВЕРХУ ВНИЗ (ОТ 0 ДО 100), НАМ НАДО ДОМНОЖИТЬ НА -1

                    //ЗАДАЕМ УСЛОВИЕ ОТБОРА(ПИШЕМ ФУНКЦИИ ПО КОТОРОЙ БУДЕТ РИСОВАТЬСЯ ГРАФИК)
                    //ПО-СКОЛЬКУ ФУНКЦИЯ БОЛЬШАЯ, Я ДЕЛЮ ЕЕ НА ДВЕ ЧАСТИ
                    int firstPart = x * x;
                    int secondPart = (int)((y - Math.Sqrt(Math.Abs(x))) * (y - Math.Abs(x)));

                    int heartSize = 10; //Размер иконки

                    if (firstPart + secondPart <= heartSize)
                    {
                        buffer[i, j] = '.'; //ЗАПОЛНЯЕМ СЕРДЦЕ СИМВОЛОМ КОТОРЫМ ХОТИМ
                    }
                    else
                    {
                        buffer[i, j] = ' '; //ЗАПОЛНЯЕМ НЕ НУЖНУЮ НАМ ЧАСТЬ БУФФЕРА СИМВОЛОМ КОТОРЫМ ХОТИМ
                    }
                }
            }

            //ВЫВОДИМ МАССИВ
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(buffer[i, j]);
                }
                Console.WriteLine();
            }

            //ЧТОБ НЕ ВЫВОДИЛСЯ ТЕКСТ ЗАВЕРШЕНИЯ ПРОГРАММЫ
            //Console.ReadLine();
        }
    }
}
