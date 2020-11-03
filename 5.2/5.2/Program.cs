using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "информатика";

            string word1 = word.Substring(2, 1) + word.Substring(0, 1) + word.Substring(4, 1) + word.Substring(5, 1) + word.Substring(10, 1);
            Console.WriteLine("Первое слово: " + word1);

            string word2 = word.Substring(9, 1) + word.Substring(3, 1) + word.Substring(4, 1) + word.Substring(5, 1) + word.Substring(10, 1);
            Console.WriteLine("Второе слово: " + word2);

            Console.ReadKey();
        }
    }
}
