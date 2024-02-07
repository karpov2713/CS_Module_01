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
            /* Пример с IF
            int age;
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

            while (triesCount-- > 0)
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

            // Игра гладиаторские бои
            /*Random random = new Random();

            float health1 = random.Next(90, 110);
            int damage1 = random.Next(7, 35);
            int armor1 = random.Next(25, 100);

            float health2 = random.Next(80, 120);
            int damage2 = random.Next(5, 40);
            int armor2 = random.Next(65, 100);

            Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} наносимый урон, {armor1} защита.");
            Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} наносимый урон, {armor2} защита.");

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(random.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(random.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine("Здоровье гладиатора 1: " + health1);
                Console.WriteLine("Здоровье гладиатора 2: " + health2);
            }

            if (health1 <= 0 && health2 <=0)
            {
                Console.WriteLine("Ничья. Оба гладиатора погибли.");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Гладиатор 1 пал.");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор 2 пал.");
            }*/

            // Работа с консолью
            /*Console.SetCursorPosition(5, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.SetCursorPosition(2, 4);
            Console.WindowHeight = 20;
            Console.WindowWidth = 40;
            Console.WriteLine("Привет, Андрей!\nКуда ты вчера делся?\nЯ убежал к ...]/b /b");*/

            // ДЗ. Освоение циклов
            /*string message;
            int amountOfMessages;

            Console.Write("Добрый день. Какое сообщение вывести? ");
            message = Console.ReadLine();

            Console.Write("Сколько раз вывести сообщение? ");
            amountOfMessages = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amountOfMessages; i++)
            {
                Console.WriteLine(message);
            }*/

            // ДЗ. Контроль выхода из цикла.
            /*string message;
            string wordToExit;

            Console.WriteLine("Введите ваше сообщение.");
            Console.WriteLine("Для выхода введите \"exit\".");
            message = Console.ReadLine();
            wordToExit = "exit";

            while (message != wordToExit)
            {
                Console.WriteLine(message);
                message = Console.ReadLine();
            }*/

            // ДЗ. Последовательность.
            /*int firstNumber = 5;
            int step = 7;
            int lastNumber = 96;

            // Цикл FOR(){} выбран, т.к. является параметрическим.
            // В нашей задаче, четко указаны параметры и этот цикл наиболее подходящий.
            for (int i = firstNumber; i <= lastNumber; i += step)
            {
                Console.Write(i + " ");
            }*/

            // ДЗ. Сумма чисел
            /*Random random = new Random();

            int number;
            int maxValue = 100;
            int sumOfDivisibleNumbers = 0;
            int divider1 = 3;
            int divider2 = 5;

            number = random.Next(maxValue + 1);

            for (int i = 0; i <= number; i++)
            {
                if (i % divider1 == 0 || i % divider2 == 0)
                {
                    sumOfDivisibleNumbers += i;
                }
            }

            Console.WriteLine($"Случайное число = {number}. Общая сумма кратных чисел = {sumOfDivisibleNumbers}.");*/

            // ДЗ. Конвертер валют
            // См. Проект CW_Module1_HW_CurrencyExchange
            // Отличный результат по отзыву ментора.

            // ДЗ. Кратные числа
            /*int number;
            int startOfRange = 1;
            int finishOfRange = 28;
            int sumOfNumbers = 0;
            int firstNumber = 100;
            int lastNumber = 1000;

            Random random = new Random();

            number = random.Next(startOfRange, finishOfRange);
            Console.WriteLine("N = " + number);

            for (int i = 0; i < lastNumber; i += number)
            {

                if (i < firstNumber)
                {
                    Console.WriteLine("Число " + i + " - не трехзначное число.");
                }
                else if (i >= firstNumber)
                {
                    Console.WriteLine("Число " + i + " - трехзначное кратное число.");
                    sumOfNumbers++;
                }
            }
            Console.WriteLine($"Количество трехзначных натуральных чисел кратных {number} = {sumOfNumbers}.");*/

            // ДЗ. Степень двойки.
            /*Random random = new Random();
            int number = random.Next(0, 1000);
            int twoToDegree = 1;
            int powerOfTwo = 0;

            do
            {
                if (number == 0)
                {
                    break;
                }

                powerOfTwo++;
                twoToDegree *= 2;

            } while (number >= twoToDegree);

            Console.WriteLine($"Число = {number}, степень = {powerOfTwo}, 2**{powerOfTwo} = {twoToDegree}.");*/

            // ДЗ. Вывод имени
            /*int lengthOfName;
            string specialName;

            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введите символ: ");
            char symbol = Convert.ToChar(Console.Read());

            lengthOfName = name.Length;
            specialName = symbol + name + symbol;

            for (int i = 0; i < 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(specialName);
                }
                else
                {
                    for (int j = 0; j < lengthOfName + 2; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }*/

            // ДЗ. Скобочное выражение
            /*string expression;
            int leftSymbol = 0;
            int rightSymbol = 0;
            int enclousure = 0;
            bool isCorrect = true;

            Console.WriteLine("Введите скобочное выражение: ");
            expression = "(()()((())))(";

            foreach (var symbol in expression)
            {
                if (symbol == 40)
                {
                    enclousure++;
                }
                else if (symbol == 41)
                {
                    enclousure--;
                }
            }

            if (enclousure != 0) 
            { 
                isCorrect = false;
            }*/

            // ДЗ. Консольное меню
            // См. проект ConsoleMenu


        }
    }
}