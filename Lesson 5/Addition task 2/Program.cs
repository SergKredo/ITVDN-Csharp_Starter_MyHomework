using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_task2
{ // Используя теорему Де Моргана  нужно преобразовать исходное выражение A|B в эквивалентное выражение
          class Program
          {
                    static void Main(string[] args)
                    {
                              bool A = true;
                              bool B = false;
                              bool C = false;

                              if (C = A || B)
                              {
                                        Console.WriteLine("Метод 1: {0} || {1} = {3} || {4} = {2} \n", 'A', 'B', C, A, B);
                              }
                              if (C = !(!A && !B))
                              { Console.WriteLine("Метод 2 по теореме Де Моргана: {0} || {1} = !(!{0} && !{1}) = !(!{3} && !{4}) = {2}", 'A', 'B', C, A, B); }

                              Console.ReadKey();




                    }
          }
}
