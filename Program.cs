using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число от 1 до 1 млрд включительно");

            int n = new int();
            while (true)
            {
                var UserNumber = (Console.ReadLine());

                if (!int.TryParse(UserNumber, out n) || !(int.Parse(UserNumber) >= 1) || !((int.Parse(UserNumber)) <= 1000000000))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                else
                {
                    if (n == 1000000000)
                    {
                        Console.WriteLine("Один миллиард");
                    }
                    else
                    {
                        if ((int)(n / 1000000) != 0)
                        {
                            IntToText999((int)(n / 1000000), true);
                            if ((int)(n / 1000000) % 10 == 1)
                            {
                                Console.Write("Миллион ");
                            }
                            else if ((int)(n / 1000000) % 10 == 2 || (int)(n / 1000000) % 10 == 3 || (int)(n / 1000000) % 10 == 4)
                            {
                                Console.Write("Миллиона ");
                            }
                            else
                            {
                                Console.Write("Миллионов ");
                            }
                        }

                        int thousands = (int)(n / 1000) % 1000;

                        if (thousands != 0)
                        {

                            IntToText999(thousands, false);
                            if (thousands % 10 == 1)
                            {
                                Console.Write("Тысяча ");
                            }
                            else if (thousands % 10 == 2 || thousands % 10 == 3 || thousands % 10 == 4)
                            {
                                Console.Write("Тысячи ");
                            }
                            else
                            {
                                Console.Write("Тысяч ");
                            }
                        }

                        if (n % 1000 != 0)
                        {
                            IntToText999(n % 1000, true);
                        }

                    }
                }
                break;
            }
        }

            static void IntToText999(int inputnumber, bool rodflag)
            {
                if (inputnumber > 899)
                {
                    Console.Write("Девятьсот ");
                }
                else if (inputnumber > 799)
                {
                    Console.Write("Восемьсот ");
                }
                else if (inputnumber > 699)
                {
                    Console.Write("Семьсот ");
                }
                else if (inputnumber > 599)
                {
                    Console.Write("Шестьсот ");
                }
                else if (inputnumber > 499)
                {
                    Console.Write("Пятьсот ");
                }
                else if (inputnumber > 399)
                {
                    Console.Write("Четыреста ");
                }
                else if (inputnumber > 299)
                {
                    Console.Write("Триста ");
                }
                else if (inputnumber > 199)
                {
                    Console.Write("Двести ");
                }
                else if (inputnumber > 99)
                {
                    Console.Write("Сто ");
                }
                else
                {
                    Console.Write("");
                }

                if (inputnumber % 100 > 10 && inputnumber % 100 < 20)
                {
                    if (inputnumber % 100 == 11)
                    {
                        Console.Write("Одиннадцать ");
                    }
                    else if (inputnumber % 100 == 12)
                    {
                        Console.Write("Двенадцать ");
                    }
                    else if (inputnumber % 100 == 13)
                    {
                        Console.Write("Тринадцать ");
                    }
                    else if (inputnumber % 100 == 14)
                    {
                        Console.Write("Четырнадцать ");
                    }
                    else if (inputnumber % 100 == 15)
                    {
                        Console.Write("Пятнадцать ");
                    }
                    else if (inputnumber % 100 == 16)
                    {
                        Console.Write("Шестнадцать ");
                    }
                    else if (inputnumber % 100 == 17)
                    {
                        Console.Write("Семнадцать ");
                    }
                    else if (inputnumber % 100 == 18)
                    {
                        Console.Write("Восемнадцать ");
                    }
                    else if (inputnumber % 100 == 19)
                    {
                        Console.Write("Девятнадцать ");
                    }

                }
                else
                {
                    if ((int)(inputnumber / 10) % 10 == 2)
                    {
                        Console.Write("Двадцать ");
                    }
                    else if ((int)(inputnumber / 10) % 10 == 3)
                    {
                        Console.Write("Тридцать ");
                    }
                    else if ((int)(inputnumber / 10) % 10 == 4)
                    {
                        Console.Write("Сорок ");
                    }
                    else if ((int)(inputnumber / 10) % 10 == 5)
                    {
                        Console.Write("Пятьдесят ");
                    }
                    else if ((int)(inputnumber / 10) % 10 == 6)
                    {
                        Console.Write("Шестдесят ");
                    }
                    else if ((int)(inputnumber / 10) % 10 == 7)
                    {
                        Console.Write("Семьдесят ");
                    }
                    else if ((int)(inputnumber / 10) % 10 == 8)
                    {
                        Console.Write("Восемьдесят ");
                    }
                    else if ((int)(inputnumber / 10) % 10 == 9)
                    {
                        Console.Write("Девяносто ");
                    }
                    else
                    {
                        Console.Write("");
                    }
                    if (inputnumber % 10 == 1)
                    {
                        if (rodflag == true)
                        {
                            Console.Write("Один ");
                        }
                        else
                        {
                            Console.Write("Одна ");
                        }
                    }
                    else if (inputnumber % 10 == 2)
                    {
                        if (rodflag == true)
                        {
                            Console.Write("Два ");
                        }
                        else
                        {
                            Console.Write("Две ");
                        }

                    }
                    else if (inputnumber % 10 == 3)
                    {
                        Console.Write("Три ");
                    }
                    else if (inputnumber % 10 == 4)
                    {
                        Console.Write("Четыре ");
                    }
                    else if (inputnumber % 10 == 5)
                    {
                        Console.Write("Пять ");
                    }
                    else if (inputnumber % 10 == 6)
                    {
                        Console.Write("Шесть ");
                    }
                    else if (inputnumber % 10 == 7)
                    {
                        Console.Write("Семь ");
                    }
                    else if (inputnumber % 10 == 8)
                    {
                        Console.Write("Восемь ");
                    }
                    else if (inputnumber % 10 == 9)
                    {
                        Console.Write("Девять ");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
            }

        }
    }

