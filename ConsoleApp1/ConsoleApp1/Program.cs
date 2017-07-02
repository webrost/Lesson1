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

        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Hello, World Mikha!!!");
            Console.WriteLine("========================================");

            Console.WriteLine("Введите число");
            x = Console.Read();
            Console.WriteLine("Вы ввели: " + x);
            Console.WriteLine("Введите второе число");
            y = Console.Read();
            Console.WriteLine("Вы ввели: " + y);
            Console.WriteLine("Сумма чисел: " + (y+x).ToString());
        }
    }
}
