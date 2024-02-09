using System;

namespace CS_Module1_HW_DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int maxRange = 1000;
            int number = random.Next(maxRange);
            int numberInDegree = 1;
            int degree = 0;
            int step = 2;

            while (number >= numberInDegree)
            {
                degree++;
                numberInDegree *= step;
            } 

            Console.WriteLine($"Число = {number}, степень = {degree}, 2**{degree} = {numberInDegree}.");
        }
    }
}
