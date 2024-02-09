using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module1_HW_DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 1000);
            int  numberInDegree = 1;
            int degree = 0;

            do
            {
                if (number == 0)
                {
                    break;
                }

                degree++;
                numberInDegree *= 2;

            } while (number >= numberInDegree);

            Console.WriteLine($"Число = {number}, степень = {degree}, 2**{degree} = {numberInDegree}.");
        }
    }
}
