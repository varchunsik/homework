using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static int First(int x)
        {
            if (x > 0) return 1;
            if (x == 0) return 0;
            return -1;
        }
        static void Main()
        {
            First(1);
            Console.WriteLine("Значение функции:" + First(1) );
            Console.ReadKey();
        }
    }
}
