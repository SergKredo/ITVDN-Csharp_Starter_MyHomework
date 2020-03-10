using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{/*
             Используя Visual Studio, создайте проект по шаблону Console Application.
        Напишите метод, который будет определять:
        Ряд всех простых и составных чисел в заданном диапазоне чисел!
         */
    class Program
    {
        static double Calculatesigh(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Числа в этом диапазоне являются отрицательными!");
                Console.WriteLine("Числа в этом диапазоне не являются натуральными,\nих нельзя отнести к простым или составным числам!\nВведите пожалуйста другой диапазон, отвечающий положительным числам!");
                return a;
            }

            else
            {
                Console.WriteLine("Числа в этом диапазоне являются положительными!");
            }
            Console.WriteLine("Пожалуйста, обратите внимание, что 1 является ни простым, ни составным числом!");
            for (double s = 2; s <= a; ++s)
            {
                //Console.Write("Данное число {0} в диапазоне от 0 до {1} имеет несколько целых делителей: ", s, a);

                double b;
                int sum = 0;
                if ((s / 1) == s && (s / s) == 1 && s > 0)
                {
                    //for (double i = 1; i > 0; i++)
                    //{
                    //    b = s / i;
                    //    Console.Write(b + "; ");
                    //    if (b == 1)
                    //    {
                    //        Console.WriteLine();
                    //        break;
                    //    }
                    //}
                    for (int i = 1; i > 0; i++)
                    {
                        b = s / i;
                        double p = b;
                        if (p == Convert.ToInt32(b))
                        {
                            for (int j = 1; j == 1; ++j)
                            {
                                sum += j;
                                //Console.Write(p + "; ");
                            }
                        }
                        else { continue; };
                        if (b == 1)
                        {
                            if (sum == 2)
                            {
                                //Console.WriteLine("{0} является простым числом;", s);
                            }
                            else { //Console.WriteLine("{0} является составным числом;", s); 
                            }
                            break;
                        }
                    }

                }
            }

            Console.Write("\nВсе простые числа в заданном диапазоне: ");
            for (double s = 2; s <= a; ++s)
            {
                //Console.Write("Данное число {0} в диапазоне от 0 до {1} имеет несколько целых делителей: ", s, a);

                double b;
                int sum = 0;
                if ((s / 1) == s && (s / s) == 1 && s > 0)
                {
                    //for (double i = 1; i > 0; i++)
                    //{
                    //    b = s / i;
                    //    Console.Write(b + "; ");
                    //    if (b == 1)
                    //    {
                    //        Console.WriteLine();
                    //        break;
                    //    }
                    //}
                    for (int i = 1; i > 0; i++)
                    {
                        b = s / i;
                        double p = b;
                        if (p == Convert.ToInt32(b))
                        {
                            for (int j = 1; j == 1; ++j)
                            {
                                sum += j;
                                //Console.Write(p + "; ");
                            }
                        }
                        else { continue; };
                        if (b == 1)
                        {
                            if (sum == 2)
                            {
                                Console.Write(s + "; ");
                            }
                            else {}
                            break;
                        }
                    }

                }
            }

            Console.Write("\n\nВсе составные числа в заданном диапазоне: ");
            for (double s = 2; s <= a; ++s)
            {
                //Console.Write("Данное число {0} в диапазоне от 0 до {1} имеет несколько целых делителей: ", s, a);

                double b;
                int sum = 0;
                if ((s / 1) == s && (s / s) == 1 && s > 0)
                {
                    //for (double i = 1; i > 0; i++)
                    //{
                    //    b = s / i;
                    //    Console.Write(b + "; ");
                    //    if (b == 1)
                    //    {
                    //        Console.WriteLine();
                    //        break;
                    //    }
                    //}
                    for (int i = 1; i > 0; i++)
                    {
                        b = s / i;
                        double p = b;
                        if (p == Convert.ToInt32(b))
                        {
                            for (int j = 1; j == 1; ++j)
                            {
                                sum += j;
                                //Console.Write(p + "; ");
                            }
                        }
                        else { continue; };
                        if (b == 1)
                        {
                            if (sum != 2)
                            {
                                Console.Write(s + "; ");
                            }
                            else { }
                            break;
                        }
                    }

                }
            }
            return a;
        }
        
        
        static void Main(string[] args)
        {
        Again:
            Console.Write("Введите пожалуйста любое число, отвечающее диапазону от 0 до ");
            double a = Convert.ToDouble(Console.ReadLine());
            double Method = Calculatesigh(a);
            if (a < 0)
            {
                Console.WriteLine();
                goto Again;
            }
            

            

            Console.ReadKey();
        }
    }
}
