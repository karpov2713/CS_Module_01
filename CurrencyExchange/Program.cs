using System;

namespace CurrencyExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balanceOfCurrencyX = 1000;
            int balanceOfCurrencyY = 1000;
            int conversionRate_X_To_Y = 20;
            int conversionRate_Y_To_X = 25;
            string operation;
            int amountForConversion;

            while (true)
            {
                Console.WriteLine($"Текущий баланс: валюта X = {balanceOfCurrencyX}, валюта Y = {balanceOfCurrencyY}.");
                Console.WriteLine("Введите код операции: 1 - обмен X на Y, 2 - обмен Y на X, exit - выход из программы.");
                operation = Console.ReadLine();

                if (operation == "1")
                {
                    Console.WriteLine("Какую сумму желаете обменять? ");
                    amountForConversion = Convert.ToInt32(Console.ReadLine());

                    balanceOfCurrencyX -= amountForConversion * conversionRate_X_To_Y;
                    balanceOfCurrencyY += amountForConversion * conversionRate_X_To_Y;
                }
                else if (operation == "2")
                {
                    Console.WriteLine("Какую сумму желаете обменять? ");
                    amountForConversion = Convert.ToInt32(Console.ReadLine());

                    balanceOfCurrencyY -= amountForConversion * conversionRate_Y_To_X;
                    balanceOfCurrencyX += amountForConversion * conversionRate_Y_To_X;
                }
                else if (operation == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Код операции введен неверно, попробуйте ещё раз!");
                }
            }

            Console.WriteLine($"Итоговый баланс: валюта X = {balanceOfCurrencyX}, валюта Y = {balanceOfCurrencyY}.");
        }
    }
}
