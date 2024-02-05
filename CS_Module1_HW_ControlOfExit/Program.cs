using System;

namespace CS_Module1_HW_ControlOfExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            Console.WriteLine("Введите ваше сообщение.");
            message = Console.ReadLine();

            do
            {
                Console.WriteLine(message);
                Console.WriteLine("Для выхода из программы введите : exit.");
                message = Console.ReadLine();

            }while (message != "exit");
        }
    }
}
