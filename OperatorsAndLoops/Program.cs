﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /*int age;
            Console.Write("Введите свой возраст? ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Добро пожаловать в наш бар.");
                Console.WriteLine("Что будете пить?");
            }
            else
            {
                Console.WriteLine("Вы слишком юны.");
                Console.WriteLine("Приходите к нам через: " + (18 - age) + " лет.");
            }

            Console.WriteLine("=====================================");*/

            // if ... else if
            /*string dayOfWeek;
            Console.Write("Введите день недели: ");
            dayOfWeek = Console.ReadLine();
            if (dayOfWeek == "понедельник") 
            {
                Console.WriteLine("Проходим курсы.");
            }
            else if (dayOfWeek == "вторник")
            {
                Console.WriteLine("Делаем домашнее задание");
            }

            Console.WriteLine("=====================================");*/

            // Логическое И и ИЛИ
            /*int money = 300;
            int level = 9;
            if (money >= 500 || level > 9)
            {
                Console.WriteLine("Проходи! Добро пожаловать в нашу гильдию.");
            }
            else
            {
                Console.WriteLine("Вас выпнули за дверь.");
            }*/

        }
    }
}
