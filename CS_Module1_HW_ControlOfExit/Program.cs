using System;

namespace CS_Module1_HW_ControlOfExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;

            while (true)
            {
                Console.WriteLine("Введите ваше сообщение.");
                Console.WriteLine("Для выхода из программы введите: \"exit\" или \"выход\".");
                message = Console.ReadLine();

                if (message == "exit" || message == "выход")
                {
                    break;
                }
            }
        }
    }
}
