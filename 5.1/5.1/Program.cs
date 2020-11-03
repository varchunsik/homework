using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст: ");
            string lineEng = Console.ReadLine();

            string lineSymbolsandnumbers = LanguageLeet(lineEng);

            Console.WriteLine("Перевод: " + lineSymbolsandnumbers);

            Console.ReadKey();
        }
        static string LanguageLeet(string str)

        {
            str = str.Replace("A", "4");
            str = str.Replace("B", "8");
            str = str.Replace("C", "(");
            str = str.Replace("D", "|)");
            str = str.Replace("E", "3");
            str = str.Replace("F", "|=");
            str = str.Replace("G", "6");
            str = str.Replace("H", "|-|");
            str = str.Replace("I", "!");
            str = str.Replace("J", ")");
            str = str.Replace("K", "|<");
            str = str.Replace("L", "1");
            str = str.Replace("M", "|\/|");
            str = str.Replace("N", "|\|");
            str = str.Replace("O", "0");
            str = str.Replace("P", "|>");
            str = str.Replace("Q", "9");
            str = str.Replace("R", "|2");
            str = str.Replace("S", "5");
            str = str.Replace("T", "7");
            str = str.Replace("U", "|_|");
            str = str.Replace("V", "\/");
            str = str.Replace("X", "><");
            str = str.Replace("Y", "`/");
            str = str.Replace("Z", "2");

            str = str.Replace("a", "4");
            str = str.Replace("b", "8");
            str = str.Replace("c", "(");
            str = str.Replace("d", "|)");
            str = str.Replace("e", "3");
            str = str.Replace("f", "|=");
            str = str.Replace("g", "6");
            str = str.Replace("h", "|-|");
            str = str.Replace("i", "!");
            str = str.Replace("j", ")");
            str = str.Replace("k", "|<");
            str = str.Replace("l", "1");
            str = str.Replace("m", "|\/|");
            str = str.Replace("n", "|\|");
            str = str.Replace("o", "0");
            str = str.Replace("p", "|>");
            str = str.Replace("q", "9");
            str = str.Replace("r", "|2");
            str = str.Replace("s", "5");
            str = str.Replace("t", "7");
            str = str.Replace("u", "|_|");
            str = str.Replace("v", "\/");
            str = str.Replace("x", "><");
            str = str.Replace("y", "`/");
            str = str.Replace("z", "2");
            return str;
        }

    }
}
