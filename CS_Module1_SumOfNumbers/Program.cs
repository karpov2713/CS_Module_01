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
            number = random.Next(0, maxValue);
            int sumOfDivisible_3 = 0;
            int sumOfDivisible_5 = 0;
            int sumOfDiv3AndDiv5 = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    sumOfDivisible_3 += i;
                }
                else if (i % 5 == 0)
                {
                    sumOfDivisible_5 += i;
                }
                sumOfDiv3AndDiv5 = sumOfDivisible_3 + sumOfDivisible_5;
            }

            Console.WriteLine($"Случайное число = {number}.");
            Console.WriteLine($"Сумма чисел кратных 3 = {sumOfDivisible_3}.");
            Console.WriteLine($"Сумма чисел кратных 5 = {sumOfDivisible_5}.");
            Console.WriteLine($"Общая сумма кратных чисел = {sumOfDiv3AndDiv5}.");
        }
    }
}
