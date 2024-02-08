using System;

namespace CS_Module1_HW_MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int startOfRange = 1;
            int finishOfRange = 27;
            int sumOfNumbers = 0;
            int firstNumber = 100;
            int lastNumber = 1000;

            Random random = new Random();

            number = random.Next(startOfRange, finishOfRange + 1);
            Console.WriteLine($"N = {number}.");

            for (int i = 0; i < lastNumber; i += number)
            {

                if (i >= firstNumber)
                {
                    sumOfNumbers++;
                }

            }

            Console.WriteLine($"Количество трехзначных натуральных чисел кратных {number} = {sumOfNumbers}.");
        }
    }
}
