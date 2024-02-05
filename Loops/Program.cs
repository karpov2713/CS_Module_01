using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int amountOfMessages;

            Console.Write("Добрый день. Какое сообщение вывести? ");
            message = Console.ReadLine();

            Console.Write("Сколько раз вывести сообщение? ");
            amountOfMessages = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amountOfMessages; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
