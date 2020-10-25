using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите значение x: ");
                var x = double.Parse(Console.ReadLine());

                var y = F(x);

                Console.WriteLine("f(x) = " + y);
                Console.ReadKey();
            }

            static double F(double x)
            {
                return Math.Sqrt(x + (1 / (Math.Sqrt(Math.Pow(x, 2) + 4))));
            }
        }
    }
}
