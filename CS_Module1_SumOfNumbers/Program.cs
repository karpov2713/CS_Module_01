using System;

namespace CS_Module1_SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number;
            int maxValue = 101;
            int sumOfDivisibleNumbers = 0;
            int numberThree = 3;
            int numberFive = 5;

            number = random.Next(0, maxValue);

            for (int i = 0; i <= number; i++)
            {
                if (i % numberThree == 0 || i % numberFive == 0)
                {
                    sumOfDivisibleNumbers += i;
                }
            }

            Console.WriteLine($"Случайное число = {number}. Общая сумма кратных чисел = {sumOfDivisibleNumbers}.");
        }
    }
}
