using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
            /*Используя Visual Studio, создайте проект по шаблону Console Application.
        Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных
        значения и возвращает значение каждого аргумента деленного на 5.*/
    class Program
    { // 1-й спосок с использованием перегрузки метода
        static double Calculate(int number1)
        {
            return number1;
        }
        static double Calculate(double number2)
        {
            return number2;
        }
        static double Calculate(float number3)
        {
            return number3;
        }


        // 2-й способ с использованием передачи аргумента параметру вызываемого метода по ссылке

        static void Calculate(ref double numberOne, ref double numberTwo, ref double numberThree)
        {
            numberOne /= 5;
            numberTwo /= 5;
            numberThree /= 5;
        }
        static void Main(string[] args)
        {
            double numberOne = 25, numberTwo = 14, numberThree = 65;
            
            Console.WriteLine("1-й способ:\n" + "Число 1 = {0};", numberOne);
            Console.WriteLine("Число 2 = {0};", numberTwo);
            Console.WriteLine("Число 3 = {0};", numberThree);
            Console.WriteLine("Число number1/5 равно: "+Calculate(numberOne)/5);
            Console.WriteLine("Число number2/5 равно: " + Calculate(numberTwo) / 5);
            Console.WriteLine("Число number3/5 равно: " + Calculate(numberThree) / 5);

            Console.WriteLine("\n2-й способ:\n" + "Число 1 = {0};", numberOne);
            Console.WriteLine("Число 2 = {0};", numberTwo);
            Console.WriteLine("Число 3 = {0};", numberThree);

            Calculate(ref numberOne, ref numberTwo, ref numberThree);
            Console.WriteLine("Число number1/5 равно: {0}", numberOne);
            Console.WriteLine("Число number2/5 равно: {0}", numberTwo);
            Console.WriteLine("Число number3/5 равно: {0}", numberThree);
            Console.ReadKey();
        }
    }
}
