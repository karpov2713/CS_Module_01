using System;

namespace CS_Module1_HW_Plases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string surName = "Валентин";
            string tempString;
            Console.WriteLine($"Имя и Фамилия до перестановки: {name} {surName}.");
            tempString = name;
            name = surName;
            surName = tempString;
            Console.WriteLine($"Имя и Фамилия после перестановки: {name} {surName}.");
        }
    }
}
