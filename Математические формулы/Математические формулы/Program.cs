using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Математические_формулы
{
    class Program
    {
        static void Main(string[] args)
        {
                var x = GetValue();

                Console.WriteLine("x = " + x);

                Console.ReadKey();
            }

            static double GetValue()
            {

                return F(13, 5) + F(6, 2) + F(21, 3) + F(3969, 5);
            }
            /// <summary>
            /// Вычисление повторяющегося выражения
            /// </summary>
            /// <param name="a">Константа под корнем</param>
            /// <param name="b">Знаменатель дроби</param>
            /// <returns></returns>
            static double F(double a, double b)
            {
                return Math.Sqrt(a) / b;
            }
    }
}

