using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
            {/*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Требуется:
            1) Создать метод MyReverse(int [] array), который принимает в качестве аргумента массив
            целочисленных элементов и возвращает инвертированный массив (элементы массива в обратном
            порядке).
            2) Создайте метод int [] SubArray(int [] array, int index, int count). Метод возвращает
            часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index,
            размерностью, которая соответствует значению аргумента count.
            Если аргумент count содержит значение больше чем количество элементов, которые входят в
            выбираемую часть исходного массива (от указанного индекса index, до индекса последнего элемента),
            то при формировании нового массива размерностью в count, заполните единицами те элементы,
            которые не были скопированы из исходного массива.*/

    class Program
    {
        static void MyReverse(int[] array, int count)
        {
            for (int i = --count; i >= 0; i--)
            {
                Console.Write(array[i]+"; ");
            }
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            for (int i = --count; i >= 0; i--)
            {
                if (i < index)
                {
                    array[i] = 1;
                    Console.Write(array[i] + "; ");
                }
                else
                {
                    Console.Write(array[i] + "; ");
                }
            }
            return array;
        }
        static void Main(string[] args)
        {   Again:
            int count = 0;
            int index = 0;
            Console.Write("Введите пожалуйста размерность массива: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пожалуйста ограничивающий диапазон массива от X до {0}, где X равен: ", count);
            index = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                    array[i] = i;
            }
            Console.WriteLine("\n1-й случай. Числа массива в обратном порядке: ");
            MyReverse(array, count);
            
            Console.WriteLine("\n\n2-й случай. Числа массива в ограничивающем диапазоне: ");
            SubArray(array, index, count);
            Console.WriteLine("\n\n");
            goto Again;
        }
    }
}
