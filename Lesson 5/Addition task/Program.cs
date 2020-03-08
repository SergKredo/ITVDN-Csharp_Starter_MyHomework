using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task1
{     //Степень двойки
     class Program
     {
          static void Main(string[] args)
          {
               int a = 0;
               Console.WriteLine("Введите пожалуйста любое число, для того чтобы узнать является ли оно степенью двойки:");
               int b = Convert.ToInt32(Console.ReadLine());

                
                    a = b & (b - 1);

                    /* 1000 0000   - 128     1000 0000   - 128
                    &  0111 1111   - 127     0000 0001   - 1
                    --------------------------------------------
                       0000 0000   - 0       0111 1111   - 

                                        Иначе

                       1000 0001   - 129     1000 0001   - 129
                    &  1000 0000   - 128     0000 0001   - 1
                    --------------------------------------------
                       1000 0000   - 128     1000 0000   - 128
                    */

                    

                    if (a == 0)
                    {
                              Console.WriteLine("Число {0} является степенью двойки", b);
                    }
                    else { Console.WriteLine("Число {0} не является степенью двойки", b); }
                              
                    Console.ReadKey();



          }
     }
}
