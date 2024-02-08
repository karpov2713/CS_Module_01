using System;

namespace ProgramPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "qwer1234";
            int attempts = 3;
            string secretMessage = "Hello world!";

            for (int i = attempts; i > 0; i--)
            {
                Console.Write($"У вас осталось {i} попытки.\t");
                Console.Write("Введите пароль: ");

                if (password == Console.ReadLine())
                {
                    Console.WriteLine($"Пароль принят! {secretMessage}");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль!");
                }

            }

        }
    }
}
