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
            int sumOfDivisible_3 = 0;
            int sumOfDivisible_5 = 0;
            int sumOfDiv3AndDiv5 = 0;
            int figure_3 = 3;
            int figure_5 = 5;

            number = random.Next(0, maxValue);

            for (int i = 0; i <= number; i++)
            {
                if (i % figure_3 == 0)
                {
                    sumOfDivisible_3 += i;
                }
                else if (i % figure_5 == 0)
                {
                    sumOfDivisible_5 += i;
                }

                sumOfDiv3AndDiv5 = sumOfDivisible_3 + sumOfDivisible_5;
            }

            Console.WriteLine($"Случайное число = {number}.");
            Console.WriteLine($"Общая сумма кратных чисел = {sumOfDiv3AndDiv5}.");
        }
    }
}
