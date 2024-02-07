using System;

namespace CurrencyExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandConversionXtoY = "1";
            const string CommandConversionYtoX = "2";
            const string CommandConversionXtoZ = "3";
            const string CommandConversionZtoX = "4";
            const string CommandConversionYtoZ = "5";
            const string CommandConversionZtoY = "6";
            const string CommandExit = "7";

            int balanceOfCurrencyX = 1000;
            int balanceOfCurrencyY = 1000;
            int balanceOfCurrencyZ = 1000;
            int conversionRate_X_To_Y = 10;
            int conversionRate_Y_To_X = 12;
            int conversionRate_X_To_Z = 20;
            int conversionRate_Z_To_X = 23;
            int conversionRate_Y_To_Z = 30;
            int conversionRate_Z_To_Y = 32;
            string userInput;
            int amountForConversion;
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"Текущий баланс: валюта X = {balanceOfCurrencyX}, валюта Y = {balanceOfCurrencyY}, валюта Z = {balanceOfCurrencyZ}.");

                Console.WriteLine("Введите код операции: ");
                Console.WriteLine($"{CommandConversionXtoY} - Конвертация валюты X в Y.");
                Console.WriteLine($"{CommandConversionYtoX} - Конвертация валюты Y в X.");
                Console.WriteLine($"{CommandConversionXtoZ} - Конвертация валюты X в Z.");
                Console.WriteLine($"{CommandConversionZtoX} - Конвертация валюты Z в X.");
                Console.WriteLine($"{CommandConversionYtoZ} - Конвертация валюты Y в Z.");
                Console.WriteLine($"{CommandConversionZtoY} - Конвертация валюты Z в Y.");
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

                    case CommandConversionXtoZ:
                        Console.WriteLine("Сколько вы хотите обменять? ");
                        amountForConversion = Convert.ToInt32(Console.ReadLine());
                        balanceOfCurrencyX -= conversionRate_X_To_Z * amountForConversion;
                        balanceOfCurrencyZ += conversionRate_X_To_Z * amountForConversion;
                        break;

                    case CommandConversionZtoX:
                        Console.WriteLine("Сколько вы хотите обменять? ");
                        amountForConversion = Convert.ToInt32(Console.ReadLine());
                        balanceOfCurrencyZ -= conversionRate_Z_To_X * amountForConversion;
                        balanceOfCurrencyX += conversionRate_Z_To_X * amountForConversion;
                        break;

                    case CommandConversionYtoZ:
                        Console.WriteLine("Сколько вы хотите обменять? ");
                        amountForConversion = Convert.ToInt32(Console.ReadLine());
                        balanceOfCurrencyY -= conversionRate_Y_To_Z * amountForConversion;
                        balanceOfCurrencyZ += conversionRate_Y_To_Z * amountForConversion;
                        break;

                    case CommandConversionZtoY:
                        Console.WriteLine("Сколько вы хотите обменять? ");
                        amountForConversion = Convert.ToInt32(Console.ReadLine());
                        balanceOfCurrencyZ -= conversionRate_Z_To_Y * amountForConversion;
                        balanceOfCurrencyY += conversionRate_Z_To_Y * amountForConversion;
                        break;

                    case CommandExit:
                        Console.WriteLine("Выход из программы.");
                        isWork = false;
                        break;
                }

            }

            Console.WriteLine($"Итоговый баланс: валюта X = {balanceOfCurrencyX}, валюта Y = {balanceOfCurrencyY}, валюта Z = {balanceOfCurrencyZ}.");
        }
    }
}
