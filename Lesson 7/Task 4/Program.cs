using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{/*
             Используя Visual Studio, создайте проект по шаблону Console Application.
        Напишите метод, который будет определять:
        1) является ли введенное число положительным или отрицательным.
        2) Является ли оно простым (используйте технику перебора значений).
        (Простое число – это натуральное число, которое делится на 1 и само на себя. Чтобы определить
        простое число или нет, следует найти все его целые делители. Если делителей больше 2-х, значит оно не
        простое.)
        3) Делится ли на 2, 5, 3, 6, 9 без остатка.
         */
    class Program
    {
        static double Calculatesigh(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Такое число является отрицательным!"); 
                Console.WriteLine("Извините пожалуйста, данное число не является натуральным,\nего нельзя отнести к простым или составным числам!\nВведите пожалуйста другое положительное число!");
                return a;
            }

            else
            {
                Console.WriteLine("Такое число является положительным!");
            }
                Console.Write("Данное число имеет несколько целых делителей: ");
            if ((a / 1) == a && (a / a) == 1 && a > 0)
            {
                double b;
                int sum = 0;
                for (double i = 1; i > 0; i++)
                {
                    b = a / i;
                    //Console.Write(b + "; ");
                    if (b == 1)
                    {
                        //Console.WriteLine();
                        break;
                    }
                }
                for (int i = 1; i > 0; i++)
                {
                    b = a / i;
                    double p = b;
                    if (p == Convert.ToInt32(b))
                    {
                        for (int j = 1; j == 1; ++j)
                        {
                            sum += j;
                            Console.Write(p + "; ");
                        }
                    }
                    else { continue; };
                    if (b == 1)
                    {
                        if (sum == 2)
                        {
                            Console.WriteLine("\nЧисло {0} имеет только два делителя и является простым!", a);
                        }
                        else { Console.WriteLine("\nЧисло {0} имеет больше двух делителей и является составным!", a); }
                        break;
                    }
                }

            }
            
            return a;
        }
        static double DivSign(double a)
        {
            int q = 2, w = 5, e = 3, r = 6, t = 9;
            if (a % q == 0 && a % w == 0 && a % e == 0 && a % r == 0 && a % t == 0)
            {
                Console.WriteLine("Поздравляем! Число {0} можно разделить без остатка на числа {1}, {2}, {3}, {4}, {5};", a, q, w, e, r, t);
            }
            else
            {
                Console.WriteLine("Введенное Вами число нельзя разделить без остатка на все числа: 2, 5, 3, 6, 9;");
                Console.Write("Такое число можно разделить без остатка только на: ");
                for (int i = 1; i <= 5; ++i)
                {
                    if (i == 1 && (a % q) == 0)
                    {
                        Console.Write("{0}; ", q);
                    }
                    else if (i == 2 && (a % w) == 0)
                    {
                        Console.Write("{0}; ", w);
                    }
                    else if (i == 3 && (a % e) == 0)
                    {
                        Console.Write("{0}; ", e);
                    }
                    else if (i == 4 && (a % r) == 0)
                    {
                        Console.Write("{0}; ", r);
                    }
                    else if (i == 5 && (a % t) == 0)
                    {
                        Console.Write("{0}; ", t);
                    }
                }
                if (a % q != 0 && a % w != 0 && a % e != 0 && a % r != 0 && a % t != 0)
                {
                    Console.Write("ни на одно из указанных чисел!");
                }
                Console.WriteLine();
            }


            return a;
        }
        static double DivSignTwo(double a)
        {
            int q = 2, w = 5, e = 3, r = 6, t = 9;
            Console.Write("Числа, которые делятся без остатка: ");
            int i = 0;
            int sum = 0;

            for (i = 1; i <= a; ++i)
            {
                if (i % q == 0 && i % w == 0 && i % e == 0 && i % r == 0 && i % t == 0)
                {
                    sum += i;
                    Console.Write("{0}; ", i);
                }
            }

            if (sum == 0)
            {
                Console.WriteLine("ни одно из чисел в диапазоне\nот 0 до {0} не делится полностью на числа 2,5,3,6,9 без остатка!", a);
            }  
                 
          return a;
        }
        static void Main(string[] args)
        {   
            Again:
            Console.Write("Введите пожалуйста любое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double Method = Calculatesigh(a);
            if (a < 0)
            {
                Console.WriteLine();
                goto Again;
            }
            double result = DivSign(a);

            Console.Write("\nВы также можете узнать какие числа делятся на числа 2, 5, 3, 6, 9 без остатка. \nДля этого выберите пожалуйста диапазон чисел от 0 до ");
            double k = Convert.ToDouble(Console.ReadLine());
            double resultTwo = DivSignTwo(k);
            Console.WriteLine("\n");
            goto Again;

            Console.ReadKey();
        }
    }
}
