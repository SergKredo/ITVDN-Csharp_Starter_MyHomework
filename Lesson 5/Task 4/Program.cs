using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
          {/*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
          Напишите программу расчета начисления премий сотрудникам. Премии рассчитываются согласно
          выслуге лет.
          Если выслуга до 5 лет, премия составляет 10% от заработной платы.
          Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы.
          Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы.
          Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы.
          Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы.
          Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы.
          Результаты расчета, выведите на экран.*/
          class Program
          {
                    static void Main(string[] args)
                    {
                             
                    double zarplataSotrudnika = 10000;
                    Console.WriteLine("Введите пожалуйста, количество лет, которое отработал сотрудник на фирме (при фиксированной заработной плате сотрудника в {0} гривен:", zarplataSotrudnika);
                    double yearWork = Convert.ToDouble(Console.ReadLine());

                    if (yearWork >= 0 && yearWork < 5)
                    { Console.WriteLine("Заработная плата сотрудника при выслуге до 5 лет равна: {0:F2} гривен.", (0.1f * zarplataSotrudnika) + zarplataSotrudnika); }

                    if (yearWork >= 5 && yearWork < 10)
                    { Console.WriteLine("Заработная плата сотрудника при выслуге от 5 лет до 10 лет равна: {0:F2} гривен.", (0.15f * zarplataSotrudnika) + zarplataSotrudnika); }
                              
                    if (yearWork >= 10 && yearWork < 15)
                    { Console.WriteLine("Заработная плата сотрудника при выслуге от 10 лет до 15 лет равна: {0:F2} гривен.", (0.25f * zarplataSotrudnika) + zarplataSotrudnika);}

                    if (yearWork >= 15 && yearWork < 20)
                    { Console.WriteLine("Заработная плата сотрудника при выслуге от 15 лет до 20 лет равна: {0:F2} гривен.", (0.35f * zarplataSotrudnika) + zarplataSotrudnika); }

                    if (yearWork >= 20 && yearWork < 25)
                    { Console.WriteLine("Заработная плата сотрудника при выслуге от 20 лет до 25 лет равна: {0:F2} гривен.", (0.45f * zarplataSotrudnika) + zarplataSotrudnika); }

                    if (yearWork >= 25)
                    { Console.WriteLine("Заработная плата сотрудника при выслуге от 25 лет и более равна: {0:F2} гривен.", (0.50f * zarplataSotrudnika) + zarplataSotrudnika); }


                    Console.ReadKey();





                    }


          }
}
