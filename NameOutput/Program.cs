using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            string middleLine;
            string frame = "";

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите символ: ");
            symbol = Convert.ToChar(Console.Read());

            middleLine = symbol + name + symbol;

            for (int i = 0; i < middleLine.Length; i++)
            {
                frame += symbol;
            }

            Console.WriteLine(frame);
            Console.WriteLine(middleLine);
            Console.WriteLine(frame);
        }
    }
}
