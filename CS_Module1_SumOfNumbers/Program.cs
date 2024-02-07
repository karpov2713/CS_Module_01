using System;

namespace CS_Module1_SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            float number;
            int maxValue = 101;
            int sumOfDivisibleNumbers = 0;

            number = random.Next(0, maxValue);

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfDivisibleNumbers += i;
                }
            }

            Console.WriteLine($"Случайное число = {number}. Общая сумма кратных чисел = {sumOfDivisibleNumbers}.");
        }
    }
}
