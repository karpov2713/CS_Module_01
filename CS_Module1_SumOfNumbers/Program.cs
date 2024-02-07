using System;

namespace CS_Module1_SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

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

            Console.WriteLine($"Случайное число = {number}. Общая сумма кратных чисел = {sumOfDivisibleNumbers}.");
        }
    }
}
