using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int x, y;
        static string operation;

        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Hello, World Mikha!!!");
            Console.WriteLine("========================================");

            Console.WriteLine("Выберите операцию: +,-,*,/");
            operation = Console.ReadLine();
            if (operation == "+")
            {
            }
            if ()
            {
            }
            if ()
            {
            }
            if ()
            {
            }

            Console.WriteLine("Введите число");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + x);
            Console.WriteLine("Введите второе число");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + y);
            Console.WriteLine("Сумма чисел: " + (y+x).ToString());
            Console.WriteLine("Введите число");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + x);
            Console.WriteLine("Введите второе число");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + y);
            Console.WriteLine("Результат умножения: " + (y * x).ToString());
            Console.ReadLine();
        }
    }
}
