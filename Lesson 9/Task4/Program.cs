using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{       /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Требуется:
        Создать метод, который будет выполнять увеличение длины массива переданного в качестве аргумента,
        на 1 элемент. Элементы массива, должны сохранить свое значение и порядок индексов.
        Создайте метод, который принимает два аргумента, первый аргумент - типа int [] array, второй
        аргумент - типа int value. В теле метода реализуйте возможность добавления второго аргумента
        метода в массив по индексу – 0, при этом длина нового массива, должна увеличиться на 1 элемент, а
        элементы получаемого массива в качестве первого аргумента должны скопироваться в новый массив
        начиная с индекса - 1.*/
    class Program
    {
        static int[] AdditionArray(int[] array, int additionArray, int[] arrayTwo, int weightMassive)
        {
            for (int i = 0; i < weightMassive+additionArray; i++)
            {
                if (i < weightMassive)
                {
                    Console.Write("[{0}]: ", i);
                    Console.Write(array[i]+"; ");
                }
                else
                {
                    array = arrayTwo;
                    array[i] = i;
                    Console.Write("+ один элемент массива"+" [{0}]: ", i);
                    Console.Write(array[i] + ";\n\n\n");
                }

            }
            return array;
        }
        static int[] AdditionArrayTwo(int[] arrayThree, int additionArray, int weightMassive)
        {
            weightMassive = arrayThree.Length + additionArray;
            int[] arrayFive = new int[weightMassive];
            for (int i = 0; i < weightMassive; i++)
            {
                if (i != arrayThree.Length)
                {
                    arrayFive[i] = arrayThree[i];
                    Console.Write("[{0}]: ", i);
                    Console.Write(arrayFive[i] + "; ");
                }
                else
                {
                    arrayFive[i] = i;
                    Console.Write("+ один элемент массива" + " [{0}]: ", i);
                    Console.Write(arrayFive[i] + ";\n\n\n");
                }

            }
            return arrayFive;
        }
        static int[] AdditionArrayThree(int[] arraySix, int value)
        {
            int weightMassive = arraySix.Length + 1;
            int[] arraySeven = new int[weightMassive];
            for (int i = 0; i < weightMassive; i++)
            {
                if (i != 0)
                {
                    arraySeven[i] = arraySix[i-1];
                    Console.Write("[{0}]: ", i);
                    Console.Write(arraySeven[i] + "; ");
                }
                else
                {
                    arraySeven[i] = value;
                    Console.Write("\n[{0}]: ", i);
                    Console.Write(arraySeven[i] + "; " + "+ остальные элементы массива ");
                }
            }
            Console.WriteLine("\n\n");
            return arraySeven;
        }
        static void Main(string[] args)
        {
            Again:
            Console.WriteLine("1-е задание.");
            Console.Write("1- й способ.\nВведите пожалуйста разрядность массива: ");
            int weightMassive = Convert.ToInt32(Console.ReadLine());
            int additionArray = 1;
            int[] array = new int[weightMassive];
            int[] arrayTwo = new int[weightMassive+additionArray];
            for (int i = 0; i < weightMassive; i++)
            {
                array[i] = i;
                arrayTwo[i] = i;
            }
            AdditionArray(array, additionArray, arrayTwo, weightMassive);

            Console.Write("2- й способ.\nВведите пожалуйста разрядность массива: ");
            weightMassive = Convert.ToInt32(Console.ReadLine());
            int[] arrayThree = new int[weightMassive];
            for (int i = 0; i < weightMassive; i++)
            {
                arrayThree[i] = i;
            }
            AdditionArrayTwo(arrayThree, additionArray, weightMassive);

            Console.WriteLine("2-е задание.");
            Console.Write("Введите пожалуйста разрядность массива: ");
            weightMassive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пожалуйста значение [0] индекса массива: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int[] arraySix = new int[weightMassive];
            for (int i = 0; i < weightMassive; i++)
            {
                arraySix[i] = i;
            }
            AdditionArrayThree(arraySix, value);
            goto Again;

            Console.ReadKey();
        }
    }
}
