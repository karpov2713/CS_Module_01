using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            // Условный оператор SWITCH
            /*string dayOfWeek;
            Console.Write("Какой сегодня день недели? ");
            dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "понедельник":
                case "суббота":
                    Console.WriteLine("Идем в кино");
                    Console.WriteLine("Едим попкорн");
                    break;
                case "вторник":
                    Console.WriteLine("Проходим курсы");
                    break;
                case "среда":
                    Console.WriteLine("Изучаем switch");
                    break;
                case "четверг":
                    Console.WriteLine("Проектируем приложение");
                    break;
                case "пятница":
                    Console.WriteLine("Выходной. Полный чилл.");
                    break;
                default: Console.WriteLine("Сиди дома!!!");
                    break;
            }*/

            // Использование констант в методе SWITCH
            /*const string CommandShowText = "1";
            const string CommandClearConsole = "2";
            const string CommandExit = "3";

            bool isWork = true;
            string userInput;

            while (isWork)
            {
                Console.WriteLine($"{CommandShowText} Показать текст");
                Console.WriteLine($"{CommandClearConsole} Очистить консоль");
                Console.WriteLine($"{CommandExit} Выход");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandShowText:
                        Console.WriteLine("Показ текста.");
                        break;
                    case CommandClearConsole:
                        Console.Clear();
                        break;
                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Программа завершена.");
                        break;

                    default: Console.WriteLine("Такой команды нет.");
                        break;
                }
            }*/

            // RANDOM
            /*Random random = new Random();
            int numberForExit;

            Console.Write("Введите число 0 до 9 для выхода из цикла: ");
            numberForExit = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                int value = random.Next(0, 10);
                Console.Write(value);
                Console.ReadKey(); // Прерываем цикл для новой итерации

                if (value == numberForExit)
                {
                    break; // Выходим из while при value = 7

                }
            }*/

            // Random с циклом FOR
            /*Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(0, 10));
            }*/

            // Игра УГАДАЙ ЧИСЛО
            /*Random random = new Random();
            int number;
            int lower;
            int higher;
            int triesCount = 5;
            int userInput;

            number = random.Next(0, 101);
            lower = random.Next(number - 10, number);
            higher = random.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, но меньше чем {higher}");
            Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать.");

            while (triesCount -- > 0)
            {
                Console.WriteLine("Ваш ответ: ");
                userInput = Convert.ToInt32( Console.ReadLine() );
                if(userInput == number)
                {
                    Console.WriteLine("Вы правы, это число " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно, попробуйте ещё раз.");
                }
            }
            Console.WriteLine("Это было число " + number + ".");*/
        }
    }
}
