using System;

namespace CS_Module1_HW_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int step = 7;
            int lastNumber = 96;

            // Цикл FOR(){} выбран, т.к. является параметрическим.
            // В нашей задаче, четко указаны параметры и этот цикл наиболее подходящий.
            for (int i = firstNumber; i <= lastNumber; i += step)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
