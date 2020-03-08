using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     class Program
     {
          static void Main(string[] args)
          {
               #region Первый способ определения четности и нечетности числа

               int a = 0;
               Console.WriteLine("Первый способ: \nВведите пожалуйста любое число:");
               int b = Convert.ToInt32(Console.ReadLine());

               a = b & 0x01;

               if (a == 0)
               { Console.WriteLine("Число {0} является четным, младший бит равен {1}\n", b, a); }

               else { Console.WriteLine("Число {0} является нечетным, младший бит равен {1}\n", b, a); }
               #endregion

               
               
               #region Второй способ определения четности и нечетности числа
               int c = 0;
               Console.WriteLine("Второй способ: \nВведите пожалуйста любое число:");
               int d = Convert.ToInt32(Console.ReadLine());

               c = d % 2; // Если числитель кратен двойке, то остаток должен быть равен нулю. Иначе единице.

               if (c == 0)
               { Console.WriteLine("Число {0} является четным, младший бит равен {1}\n", d, c); }

               else { Console.WriteLine("Число {0} является нечетным, младший бит равен {1}\n", d, c); }

               #endregion


               
               #region Третий способ определения четности и нечетности числа
               
               Console.WriteLine("Третий способ: \nВведите пожалуйста любое число:");
               int f = Convert.ToInt32(Console.ReadLine());

               int h = f << 0x07;


               /*
               0011 0101 - непарное число
               <<        - сдвиг бит влево на 7 позиций
               1000 0000 - число не равно нулю

               а если парное число

               0011 0100
               <<
               0000 0000 - число равно нулю и является кратным двойке, тоесть четным       
               */


                              if ((byte)h == 0)
                              { Console.WriteLine("Число {0} является четным и равно {1:X}\n", f, (byte)h); }

                              else { Console.WriteLine("Число {0} является нечетным и равно {1:X}\n", f, (byte)h); }

               #endregion


               Console.ReadKey();

          }
     }
}
