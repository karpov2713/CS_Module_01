using System;

namespace CS_Module1_HW_ControlOfExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            string wordToExit;

            Console.WriteLine("Введите ваше сообщение.");
            message = Console.ReadLine();
            wordToExit = "exit";

            do
            {
                Console.WriteLine(message);
                Console.WriteLine("Введите ваше сообщение. Для выхода из программы введите: exit.");
                message = Console.ReadLine();

            } while (message != wordToExit);
        }
    }
}
