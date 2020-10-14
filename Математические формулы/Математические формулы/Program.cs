using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Математические_формулы
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение x");
            var x = Double.Parse(Console.ReadLine());

            var y = F(x);

            Console.WriteLine("f(x)=" + y);
            Console.ReadKey();

        }

        


    }
}
