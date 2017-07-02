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

            //----Использование оператора switch
            switch(operation)
            {
                case "-":
                    break;
                default:
                    Console.WriteLine("Неправильная операция.");
                    break;
            }

            if (operation == "+")
            {
                Console.WriteLine("Введите число");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + x);
                Console.WriteLine("Введите второе число");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + y);
                Console.WriteLine("Сумма чисел: " + (y + x).ToString());
            }
            if (operation == "-")
            {
                Console.WriteLine("Введите число");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + x);
                Console.WriteLine("Введите второе число");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + y);
                Console.WriteLine("Разность чисел: " + (x - y).ToString());
            }
            if (operation == "*")
            {
                Console.WriteLine("Введите число");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + x);
                Console.WriteLine("Введите второе число");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + y);
                Console.WriteLine("Результат умножения чисел: " + (x * y).ToString());
            }
            if (operation == "/")
            {
                Console.WriteLine("Введите число");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + x);
                Console.WriteLine("Введите второе число");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + y);
                Console.WriteLine("Результат деления чисел: " + (x / y).ToString());
            }
            Console.ReadLine();

        }
    }
}
