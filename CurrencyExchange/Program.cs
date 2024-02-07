using System;

namespace CurrencyExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandConversionXtoY = "1";
            const string CommandConversionYtoX = "2";
            const string CommandExit = "3";

            int balanceOfCurrencyX = 1000;
            int balanceOfCurrencyY = 1000;
            int conversionRate_X_To_Y = 20;
            int conversionRate_Y_To_X = 25;
            string userInput;
            int amountForConversion;
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"Текущий баланс: валюта X = {balanceOfCurrencyX}, валюта Y = {balanceOfCurrencyY}.");

                Console.WriteLine("Введите код операции: ");
                Console.WriteLine($"{CommandConversionXtoY} - Конвертация валюты X в валюту Y.");
                Console.WriteLine($"{CommandConversionYtoX} - Конвертация валюты Y в X.");
                Console.WriteLine($"{CommandExit} - Выход из программы.");
                userInput = Console.ReadLine();

                switch ( userInput )
                {
                    case CommandConversionXtoY:

                        Console.WriteLine("Сколько вы хотите обменять? ");
                        amountForConversion = Convert.ToInt32(Console.ReadLine());

                        balanceOfCurrencyX -= conversionRate_X_To_Y * amountForConversion;
                        balanceOfCurrencyY += conversionRate_X_To_Y * amountForConversion;
                        break;
                    case CommandConversionYtoX:

                        Console.WriteLine("Сколько вы хотите обменять? ");
                        amountForConversion = Convert.ToInt32(Console.ReadLine());

                        balanceOfCurrencyY -= conversionRate_Y_To_X * amountForConversion;
                        balanceOfCurrencyX += conversionRate_Y_To_X * amountForConversion;
                        break;
                    case CommandExit:
                        Console.WriteLine("Выход из программы.");
                        isWork = false;
                        break;
                }
            }

            Console.WriteLine($"Итоговый баланс: валюта X = {balanceOfCurrencyX}, валюта Y = {balanceOfCurrencyY}.");
        }
    }
}
