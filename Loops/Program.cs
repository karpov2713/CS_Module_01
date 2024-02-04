using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int messageCount;

            Console.Write("Добрый день. Какое сообщение вывести? ");
            message = Console.ReadLine();

            Console.Write("Сколько раз вывести сообщение? ");
            messageCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < messageCount; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
