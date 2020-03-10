using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
        /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Требуется:
        Создать массив размера N элементов, заполнить его произвольными целыми значениями (размер
        массива задает пользователь).
        Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех
        элементов, среднее арифметическое всех элементов, вывести все нечетные значения.*/
    class Program
    {
       
        static void Main(string[] args)
        {
            double[] massive = {10, 5, 30, 455, 6, 1025, 1};
            int sum = 0;
            int sumTwo = 0;
            double total = 0;
            double highestNumber = 0, smallestNumber = 0;
            Console.Write("Все нечетные числа массива: ");
            for (int j = 0; j < massive.Length; j++)
            {
                for (int i = 0; i < massive.Length; i++)
                {
                    if (massive[j] > massive[i])
                    {
                        ++sum;
                    }
                    else
                    {
                        continue;
                    }
                }
                for (int l = 0; l < massive.Length; l++)
                {
                    if (massive[j] < massive[l])
                    {
                        ++sumTwo;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (sum == massive.Length-1)
                {
                    highestNumber = massive[j];
                }
                if (sumTwo == massive.Length - 1)
                {
                    smallestNumber = massive[j];
                }
                if ((massive[j] % 2) != 0)
                {
                    Console.Write(massive[j]+"; ");
                }
                sum = 0;
                sumTwo = 0;
                total += massive[j];
            }
            Console.WriteLine("\nНаибольшее число массива равно: {0}", highestNumber);
            Console.WriteLine("Наименьшее число массива равно: {0}", smallestNumber);
            Console.WriteLine("Общая сумма всех элементов равна: {0}", total);
            Console.WriteLine("Среднее арифметическое всех элементов равно: {0}", total/ massive.Length);
            Console.ReadKey();
        }
    }
}
