using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional1
{
            /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте массив размерностью в 10 элементов, выведите на экран все элементы массива в обратном
            порядке.*/                      
    class Program
    {
        static void Main(string[] args)
        {
            byte[] massive = new byte[10];

            for (byte i = 0; i < 10; )
            {
                massive[i] = ++i;
            }
            Console.WriteLine(new string('-', 70));
            Console.Write("Числа массива в обратном порядке: ");
            for (byte i = 10; i > 0; i--)
            {
                Console.Write(massive[i-1]+"; ");
            }
            Console.ReadKey();
        }
    }
}
