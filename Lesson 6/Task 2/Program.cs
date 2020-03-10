using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.*/
    class Program
    {
        static void Main(string[] args)
        {
            Again: //Метка возврата в первоначальное состояние

            #region Сумма чисел в диапазоне чисел от A до B

            Console.WriteLine("Введите пожалуйста два числа: A и B, чтобы A было меньше B");
            Console.Write("Число A равно: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число B равно: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            if (A < B)
            {
                for (++A; A < B; ++A)
                {
                    sum += A;
                }
                Console.WriteLine("\nСумма всех чисел между A и B равна: {0}\n", sum);
            }
            else
            {
                Console.WriteLine("\n!!!Введите пожалуйста другое число A, чтобы оно было меньше числа B!!!\n\n");
                goto Again;
            }

            #endregion

            #region Все нечетные числа в диапазоне чисел от A до B
            Console.Write("\nЧисло A равно: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число B равно: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВсе нечетные числа между A и В: ");

            if (A < B)
            {
                for (++A; A < B; ++A)
                {
                    {
                        if (A % 2 != 0)
                        {
                            Console.Write("{0}; ", A);
                        }
                    }
                    continue;
                }
            }
            else
            {
                Console.WriteLine("!!!Введите пожалуйста другое число A, чтобы оно было меньше числа B!!!");
            }
            Console.WriteLine("\n\n__________________________________________________________________\n\n");

            #endregion

            Console.ReadKey();
            goto Again;

            //Console.ReadKey();
        }
    
}
}
