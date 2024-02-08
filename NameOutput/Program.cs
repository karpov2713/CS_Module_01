using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            string compoundName;
            int numberOfRows = 3; 

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите символ: ");
            symbol = Convert.ToChar(Console.Read());

            compoundName = symbol + name + symbol;

            for (int i = 0; i < numberOfRows; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(compoundName);
                }
                else
                {
                    for (int j = 0; j < compoundName.Length; j++)
                    {
                        Console.Write(symbol);
                    }

                    Console.WriteLine();
                }

            }

        }
    }
}
