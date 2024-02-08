using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfName;
            string compoundName;

            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите символ: ");
            char symbol = Convert.ToChar(Console.Read());

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
