using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Целочисленная_арифметика
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            int b;

            b = int.Parse(Console.ReadLine());
            Console.WriteLine("десятки числа - " + (b / 10).ToString());

            Console.WriteLine("единицы числа - " + (b % 10).ToString());

            int S;

            S = ((b / 10) + (b % 10));

            Console.WriteLine("Сумма - " + S.ToString());

            int P;

            P = ((b / 10) * (b % 10));
            Console.WriteLine("Произведение - " + P.ToString());

            Console.ReadKey();
            

        }
    }
}
