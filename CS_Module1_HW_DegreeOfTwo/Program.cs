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
            int twoToDegree = 1;
            int powerOfTwo = 0;

            do
            {
                if (number == 0)
                {
                    break;
                }

                powerOfTwo++;
                twoToDegree *= 2;

            } while (number >= twoToDegree);

            Console.WriteLine($"Число = {number}, степень = {powerOfTwo}, 2**{powerOfTwo} = {twoToDegree}.");
        }
    }
}
