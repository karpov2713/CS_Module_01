using System;

namespace CS_Module1_HW_Plases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string surName = "Валентин";
            string temString;
            Console.WriteLine($"Имя и Фамилия до перестановки: {name} {surName}.");
            temString = name;
            name = surName;
            surName = temString;
            Console.WriteLine($"Имя и Фамилия после перестановки: {name} {surName}.");
        }
    }
}
