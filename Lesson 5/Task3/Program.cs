using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{  /*Имеется 3 переменные типа int x = 5, y = 10, и z = 15;
     Выполните и рассчитайте результат следующих операций для этих переменных:
          x += y >> x++ * z;
          z = ++x & y* 5;
          y /= x + 5 | z;
          z = x++ & y* 5;
          x = y << x++ ^ z
*/
          class Program
          {
                    static void Main(string[] args)
                    {
                              int x = 5, y = 10, z = 15;
                              //x += y >> x++ * z;
                              Console.WriteLine("{0} += {1} >> {0}++ * {2} = {3}", 'x', 'y', 'z', x += y >> x++ * z);

                              x = 5;
                              y = 10;
                              z = 15;
                              //z = ++x & y * 5;
                              Console.WriteLine("{0} = ++{1} & {2} * 5 = {3}", 'z', 'x', 'y', z = ++x & y * 5);


                              x = 5;
                              y = 10;
                              z = 15;
                              //y /= x + 5 | z;
                              Console.WriteLine("{0} /= {1} + 5 | {2} = {3}", 'y', 'x', 'z', y /= x + 5 | z);


                              x = 5;
                              y = 10;
                              z = 15;
                              //z = x++ & y * 5;
                              Console.WriteLine("{0} = {1}++ & {2} * 5 = {3}", 'z', 'x', 'y', z = x++ & y * 5);


                              x = 5;
                              y = 10;
                              z = 15;
                              //x = y << x++ ^ z;
                              Console.WriteLine("{0} = {1} << {0}++ ^ {2} = {3}", 'x', 'y', 'z', x = y << x++ ^ z);

                              Console.ReadKey();



                    }
          }
}
