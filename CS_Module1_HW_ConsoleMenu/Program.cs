using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module1_HW_ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSetLogin = "1";
            const string CommandSetPassword = "2";
            const string CommandWriteLogin = "3";
            const string CommandWritePassword = "4";
            const string CommandClearConsole = "5";
            const string CommandExit = "6";

            bool isWork = true;
            string userLogin = "";
            string userPassword = "";
            string userInput;

            while (isWork)
            {
                Console.WriteLine($"{CommandSetLogin} - Ввод логина.");
                Console.WriteLine($"{CommandSetPassword} - Ввод пароля.");
                Console.WriteLine($"{CommandWriteLogin} - Просмотр логина.");
                Console.WriteLine($"{CommandWritePassword} - Просмотр пароля.");
                Console.WriteLine($"{CommandClearConsole} - Очистить консоль.");
                Console.WriteLine($"{CommandExit} - Выход.");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSetLogin:
                        Console.Write("Введите логин: ");
                        userLogin = Console.ReadLine();
                        break;
                    case CommandSetPassword:
                        Console.Write("Введите пароль: ");
                        userPassword = Console.ReadLine();
                        break;
                    case CommandWriteLogin:
                        Console.WriteLine($"Логин - {userLogin}");
                        break;
                    case CommandWritePassword:
                        Console.WriteLine($"Пароль - {userPassword}");
                        break;
                    case CommandClearConsole:
                        Console.Clear();
                        break;
                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Выход из программы");
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
        }
    }
}
