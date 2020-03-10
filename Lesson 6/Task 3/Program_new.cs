using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{         /* Используя Visual Studio, создайте проект по шаблону Console Application.
            Используя циклы и метод:
            Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую строку).*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bыведите на экран: ");
            Console.WriteLine("   # прямоугольник");
            Console.WriteLine("   # прямоугольный треугольник");
            Console.WriteLine("   # равносторонний треугольник");
            Console.WriteLine("   # ромб");

            #region Прямоугольник
            Console.WriteLine("\n1. Нарисуйте прямоугольник.");
            Console.Write("Высота прямоугольника: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина прямоугольника: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < h; i++)
            {
                for (int k = 0; k < 50; k++)    // Отступ от левого края консоли
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < l; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion

            #region Прямоугольный треугольник
            Console.WriteLine("\n\n2. Нарисуйте прямоугольный треугольник.");
            Console.Write("Высота прямоугольного треугольника: ");
            h = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ширина прямоугольного треугольника: ");
            //l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < h; i++)
            {

                for (int k = 80; k > i; k--)   // Отступ от левого края консоли на 80 единиц
                {
                    Console.Write(" ");

                }
                for (int f = 0; f < i; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Равносторонний треугольник
            Console.WriteLine("\n\n3. Нарисуйте равносторонний треугольник.");
            Console.Write("Высота равностороннего треугольника: ");
            h = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ширина равностороннего треугольника: ");
            //l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < h; i++)
            {

                for (int k = 70; k > i; k--)   // Отступ от левого края консоли
                {
                    Console.Write(" ");

                }

                for (int j = 0; j < (2 * i - 1); ++j)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion

            #region Ромб
            Console.WriteLine("\n\n3. Нарисуйте Ромб.");
            Console.Write("Высота ромба: ");
            h = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ширина ромба: ");
            //int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            for (int i = 0; i < h; i++)
            {
                if (i >= 0 && i < h / 2)  // Верхняя часть ромба
                 {
                           for (int k = 70; k > i; k--)     // Отступ от левого края консоли
                    {
                                     Console.Write(" ");

                           }

                           for (int j = 0; j < (2 * i - 1); ++j)
                           {
                                     Console.Write("*");
                           }
                 }


                                 if (i >= 0 && i == h / 2)  // Средняя часть ромба
                 {                
                           for (int k = 70; k > i; k--)     // Отступ от левого края консоли
                    {
                                    
                                     Console.Write(" ");

                           }

                           for (int j = 0; j < (2 * i - 1); ++j)
                           {
                                     Console.Write("*");

                           }
                 }


                if (i >= 0 && i > h / 2 && i < h)  // Нижняя часть ромба
                {

                    for (int k = h / 2; k < (70-(h/2)+i); k++)     // Отступ от левого края консоли
                    {
                        Console.Write(" ");

                    }
                    if (h % 2 == 0)  // Для четных значений высоты ромба
                    {
                        for (int j = 2 * h - 2; j > (i * 2 - 1); --j)
                        {
                            Console.Write("*");

                        }
                    }
                    else             // Для нечетных значений высоты ромба
                    {
                        for (int j = 2 * h - 4; j > (i * 2 - 1); --j)
                        {
                            Console.Write("*");

                        }

                    }
                }
                                
                    Console.WriteLine();
                #endregion
            }
                Console.ReadKey();

        }
    }
}
                


