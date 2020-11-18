using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GetNumber("m");
            var b = GetNumber("n");

            string answer = "Нет";

            if (EvaluateLogicalExpression(a, b))
                answer = "Да";

            Console.WriteLine("Верно ли, что хотя бы одно из чисел m или n положительное? - " + answer);

            Console.ReadKey();
        }

        static bool EvaluateLogicalExpression(int m, int n)
        {

            return m > 0 || n > 0;
        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine("Введите число " + numberName);
            return int.Parse(Console.ReadLine());
        }
    }
    
}
