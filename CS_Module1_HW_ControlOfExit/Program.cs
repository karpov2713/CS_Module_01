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
            Console.WriteLine("Для выхода введите \"exit\".");
            message = Console.ReadLine();
            wordToExit = "exit";

            while (message != wordToExit)
            {
                Console.WriteLine(message);
                message = Console.ReadLine();
            }
        }
    }
}
