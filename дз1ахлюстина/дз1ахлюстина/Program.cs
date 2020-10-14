using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз1ахлюстина
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите длину ребра октаэдра:");
            x = double.Parse(Console.ReadLine());

            double S;
            S = 2 * Math.Pow(x,2) * Math.Sqrt(3);
            S = Math.Round(S, 3);
            Console.WriteLine("Площадь поверхности октаэдра:" + S);

            double V;
            V = 0.333 * Math.Sqrt(2) * Math.Pow(x,3);
            V = Math.Round(V, 3);
            Console.WriteLine("Объем октаэдра:" + V);

            Console.ReadKey();
        }
    }
}
