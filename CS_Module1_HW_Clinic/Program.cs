using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module1_HW_Clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesForOneClient = 10;
            int amountPeopleInClinic;
            int hoursToStay;
            int minutesToStay;
            int minutesInOneHour = 60;
            int totalTimeInMinutes;

            Console.Write("Сколько людей в очереди вы видите? ");
            amountPeopleInClinic = Convert.ToInt32(Console.ReadLine());

            totalTimeInMinutes = amountPeopleInClinic * minutesForOneClient;
            hoursToStay = totalTimeInMinutes / minutesInOneHour;
            minutesToStay = totalTimeInMinutes % minutesInOneHour;

            Console.WriteLine($"Вы должны простоять в очереди {hoursToStay} часа и {minutesToStay} минут.");
        }
    }
}
