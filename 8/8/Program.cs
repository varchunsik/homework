using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая вычисляет сумму кубов всех целых чисел от a до b включительно. Числа a и b вводятся с клавиатуры (0ab)
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var res = 0;
            while(a <= b)
            {
                res += a * a * a++;
            }

            Console.WriteLine("Результат:" + res);
            Console.ReadKey();
        }
    }
}
