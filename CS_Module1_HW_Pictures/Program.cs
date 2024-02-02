using System;

namespace CS_Module1_HW_Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfImages = 52;
            int imagesInRow = 3;
            int amountOfFilledRows = amountOfImages / imagesInRow;
            int remainingImages = amountOfImages % imagesInRow;

            Console.WriteLine($"Полностью заполнено {amountOfFilledRows} рядов, сверх меры {remainingImages} картинка.");

        }
    }
}
