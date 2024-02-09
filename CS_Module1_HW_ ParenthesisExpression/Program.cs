using System;

internal class Program
{
    static void Main(string[] args)
    {
        int enclosure = 0;
        int maxEnclosure = 0;
        char symbol1 = '(';
        char symbol2 = ')';
        string text;
        bool isCorrect = true;

        Console.WriteLine("Введите строку из символов '(' и ')'");
        text = Console.ReadLine();

        foreach (char symbol in text)
        {
            if (symbol == symbol1)
            {
                enclosure++;

                if (enclosure > maxEnclosure)
                {
                    maxEnclosure = enclosure;
                }
            }
            else if (symbol == symbol2)
            {
                enclosure--;

                if (enclosure < 0)
                {
                    isCorrect = false;
                }
            }
        }

        if (isCorrect && enclosure == 0)
        {
            Console.WriteLine($"Строка {text} - корректная, глубина вложенности = {maxEnclosure}.");
        }
        else
        {
            Console.WriteLine($"Строка {text} - некорректная");
        }
    }
}
