using System;

namespace CS_Module1_HW_Crystals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goldInWallet;
            int priceForOneCrystal = 5;
            int amountOfCrystals;
            int costOfCrystals;

            Console.Write("Сколько у вас золота? ");
            goldInWallet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Цена одного кристалл {priceForOneCrystal}.");
            Console.Write("Сколько кристаллов вы хотите купить? ");
            amountOfCrystals = Convert.ToInt32(Console.ReadLine());

            costOfCrystals = priceForOneCrystal * amountOfCrystals;
            goldInWallet -= costOfCrystals;
            Console.WriteLine($"Вы приобрели {amountOfCrystals} кристаллов, у вас осталось {goldInWallet} золотых.");
        }
    }
}
