using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ПЕРЕМЕННЫЕ
            // Целочисленные типы
            /*byte b;     // 0 -> 255
            sbyte sb;   // -128 -> 127
            short s;    // -32768 -> 32767
            ushort us;  // 0 -> 65535
            int i;      // -2.147.483.648 -> 2.147.483.647
            uint ui;    // 0 -> 4.294.672.295
            long l;     // -9.223.372.036.854.775.808 -> 9.223.372.036.854.775.807
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            ulong ul;   // 0 -> 18.446.744.073.709.551.615
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            decimal dc; //-79.228.162.514.264.337.593.543.950.335 -> 79.228.162.514.264.337.593.543.950.335
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            // Числа с плавающей точкой

            float f = 5.7f; // Нужен суффикс - f, иначе неявно пытается конвертировать в double.
                            // -3,402823E+38 -> 3,402823E+38
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            double d; // -1,79769313486232E+308 -> 1,79769313486232E+308
                      // Нужен суффикс - m, иначе неявно пытается конвертировать в double.
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            // Символьный тип
            char c = 'a';

            // Строковый тип
            string str = "Привет, как дела?";

            // Логический тип
            bool bl = true;

            // Инициализация переменных
            int age = 27; // Создал и инициализировал переменную age = 27.
            int num; // Создали переменную num
            num = 199; // Инициализировали переменную num
            age = 10; // Меняем значение в переменной*/

            // АРИФМЕТИЧЕСКИЕ ОПЕРАЦИИ
            /*// + - * / вкл. C# Interective
            float result;
            int x, y;
            x = 5;
            y = 2;
            result = (float)x / y;
            Console.WriteLine(result);

            int timeInMinutes = 130;
            int hour;
            int minute;

            hour = timeInMinutes / 60;
            minute = timeInMinutes % 60;
            Console.WriteLine("hours: " + hour);
            Console.WriteLine("minutes: " + minute);*/

            // ЛОГИЧЕСКИЕ ОПЕРАЦИИ
            /*int age = 17;
            bool accessIsAllowed = age >= 18;
            Console.WriteLine(accessIsAllowed);*/

            // КОНКАТЕНАЦИЯ

            // ИНТЕРПОЛЯЦИЯ
            /*int age = 27;
            string name = "Dmitry";

            Console.WriteLine("Выше имя: " + name + ", вам " + age + " лет!");
            Console.WriteLine($"Ваше имя: {name}, вам {age} лет.");*/

            //КОНВЕРТАЦИЯ
            /*int age;
            string input = "15";
            age = Convert.ToInt32(input);
            Console.WriteLine(age);

            float result;
            int x = 5;
            int y = 2;
            result = (float)x / y;
            Console.WriteLine(result);

            int trigger = 10;
            bool triggerInBoolean = Convert.ToBoolean(trigger);
            Console.WriteLine(triggerInBoolean);
            int reconvert = Convert.ToInt32(triggerInBoolean);
            Console.WriteLine(reconvert);*/

            // РАБОТА С КОНСОЛЬЮ
            /*string name;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Ваше имя {name}.");
            int age;
            Console.WriteLine("Введите ваш возраст: ");
            age = int.Parse( Console.ReadLine());
            Console.WriteLine($"Вам {age} лет.");*/

            // ИНКРЕМЕНТ И ДЕКРЕМЕНТ
            /*int i = 0;
            i++;
            Console.WriteLine(i); // 1
            i--;
            Console.WriteLine(i); // 0
            Console.WriteLine(i++);// 0
            Console.WriteLine(i); //1*/

            // ПРАКТИКА. УРОН НАНОСИМЫЙ ИГРОКУ
            /*int health;
            int armor;
            int damage;
            int percentConverter = 100;

            Console.Write("Введите количество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage * armor / percentConverter;

            Console.WriteLine($"Вам нанесли {damage} урона. У вас осталось {health} здоровья.");*/

            //ПРАКТИКА. Покупка в магазине.
            /*int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.WriteLine($"Добро пожаловать в пекарню! Сегодня еда по {foodUnitPrice} монет.");
            Console.Write("Сколько у вас золота? ");
            money = int.Parse( Console.ReadLine() );
            Console.Write("Сколько еды вам нужно? ");
            food = int.Parse( Console.ReadLine() );
            
            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} единиц еды, и {money} монет.");*/

            // ДЗ Работа со строками
            string name;
            int age;
            string profittion;

        }
    }
}
