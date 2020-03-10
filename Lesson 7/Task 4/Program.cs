using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
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
            { Console.WriteLine("Такое число является отрицательным!"); }
            else
            { Console.WriteLine("Такое число является положительным!"); }
            Console.Write("Данное число имеет несколько целых делителей: ");
            if ((a / 1) == a && (a / a) == 1)
            {   double b;
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
                    {for (int j = 1; j == 1; ++j)
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
        static void Main(string[] args)
        {
            Console.Write("Введите пожалуйста любое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double Method = Calculatesigh(a);


            Console.ReadKey();
        }
    }
}
