using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_6
            {   /*Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте две целочисленные переменные и задайте им некоторые значения. Применяя технику
            вложенных циклов, нарисуйте прямоугольник из звездочек. Используйте значения ранее созданных
            переменных для указания высоты и ширины прямоугольника.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нарисуйте пожалуйста прямоугольник из звездочек с заданной шириной и высотой:\n");

            Again: // Метка повторения задания
            Console.Write("Высота прямоугольника: ");
            int heightPraymougolnika = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ширина прямоугольника: ");
            int widhtPraymougolnika = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");


            for (int height = 0; height < heightPraymougolnika; height++)
            {
                for (int width = 0; width < widhtPraymougolnika; width++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            goto Again;
            //Console.ReadKey();
        }
    }
}
