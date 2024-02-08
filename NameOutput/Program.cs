using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            int lengthOfName;
            string compoundName;

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите символ: ");
            symbol = Convert.ToChar(Console.Read());

            lengthOfName = name.Length;
            compoundName = symbol + name + symbol;

            for (int i = 0; i < 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(compoundName);
                }
                else
                {
                    for (int j = 0; j < lengthOfName + 2; j++)
                    {
                        Console.Write(symbol);
                    }

                    Console.WriteLine();
                }

            }

        }
    }
}
