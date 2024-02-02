using System;

namespace CS_Module1_HW_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Сколько Вам лет? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой Ваш знак зодиака? ");
            string zodiacSign = Console.ReadLine();

            Console.Write("Кто вы по профессии? ");
            string profession = Console.ReadLine();

            Console.Write("В каком городе вы живете? ");
            string placeOfResidence = Console.ReadLine();

            Console.WriteLine("Ваше имя {0}, Вам {1} лет, {2} по гороскопу, живёте в городе {3}, по профессии Вы - {4}.", name, age, zodiacSign, placeOfResidence, profession);

            Console.ReadKey();
        }
    }
}
