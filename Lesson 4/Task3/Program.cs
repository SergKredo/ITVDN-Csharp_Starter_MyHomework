using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Введите пожалуйста любое число для того чтобы узнать в каком промежутке чисел оно находится: ");
               string chisla = "12";
               double number = 0;
               number = Convert.ToDouble(chisla = Console.ReadLine());


               if (number >= 0)
               {
                    if (number <= 14)
                    {
                         Console.WriteLine("Ваше число {0} находится в числовом диапазоне [0-14]", number);
                    }
                    else if (number >= 15)
                    {
                         if (number <= 35)
                         {
                              Console.WriteLine("Ваше число {0} находится в числовом диапазоне [15-35]", number);
                         }
                         else if (number >= 36)
                         {
                              if (number <= 50)
                              {
                                   Console.WriteLine("Ваше число {0} находится в числовом диапазоне [36-50]", number);
                              }
                              else if (number > 50)
                              {
                                   if (number <= 100)
                                   {
                                        Console.WriteLine("Ваше число {0} находится в числовом диапазоне [50-100]", number);
                                   }
                                   else if (number > 100)
                                   { Console.WriteLine("Ваше число {0} выходит за числовой диапазон [0-100]. Введите пожалуйста другое число!", number); }
                              }
                         }
                    }
               }
                              

               else if (number < 0)
               { Console.WriteLine("Ваше число {0} выходит за числовой диапазон [0-100]. Введите пожалуйста другое число!", number); }

               int result = 0;
               for (int i = 1; i <= 10; i++)
               {
                    result += i;
               }
               
               Console.ReadKey();
               }
     }
}

