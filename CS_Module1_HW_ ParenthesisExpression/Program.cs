using System;

internal class Program
{
    static void Main(string[] args)
    {
        int currentDepth = 0;
        int maxDepth = 0;
        char symbol1 = '(';
        char symbol2 = ')';
        bool isCorrect = true;
        string text = "((()))(())";

        foreach (char symbol in text)
        {
            if (symbol == symbol1)
            {
                currentDepth++;

                if (currentDepth > maxDepth)
                {
                    maxDepth = currentDepth;
                }
            }
            else if (symbol == symbol2)
            {
                currentDepth--;

                if (currentDepth < 0)
                {
                    isCorrect = false;
                }
            }
        }

        if (isCorrect && currentDepth == 0)
        {
            Console.WriteLine($"Строка {text} - корректная, глубина вложенности = {maxDepth}.");
        }
        else
        {
            Console.WriteLine($"Строка {text} - некорректная");
        }
    }
}
