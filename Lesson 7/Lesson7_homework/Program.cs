using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_homework
/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение, Sub –
вычитание, Mul – умножение, Div – деление. Каждый метод должен принимать два целочисленных
аргумента и выводить на экран результат выполнения арифметической операции соответствующей
имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль.
Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак
арифметической операции, для выполнения вычислений.
 */

{
    class Program
    {
        #region Сложение
        static float Add(float a, float b)  // Операция сложения двух чисел
        {
            return a + b;
        }
        #endregion

        #region Вычитание
        static float Sub(float a, float b)  // Операция вычитания двух чисел
        {
            return a - b;
        }
        #endregion

        #region Умножение
        static float Mul(float a, float b)  // Операция умножения двух чисел
        {
            return a * b;
        }
        #endregion
        
        #region Деление
        static float Div(float a, float b)  // Операция деления двух чисел
        {   
            return a / b;
        }
        #endregion
        static void Main(string[] args)
        {
            //Вывод значения после операции сложения a+b
            Again:   // Метка возврата после операций над двумя числами
            Console.WriteLine("Введите пожалуйста любые два числа:");
            Console.Write("a = ");  
            float a = Convert.ToSingle(Console.ReadLine()); // Ввод перовго числа с клавиатуры
            Console.Write("Знак арифметической операции = ");
            char sign; 
            sign = Convert.ToChar(Console.ReadLine());  // Задание знака операции
            Againtwo: // Метка возврата, после ввода числа b = 0
            Console.Write("b = ");
            float b = Convert.ToSingle(Console.ReadLine());  // Ввод второго числа с клавиатуры

            #region Условные конструкции над арифметическими операциями двух чисел
            // Условные конструкции для выполнения арифметических операций над двумя числами
            if (sign == '+')
            {
                float resultOne = Add(a, b);
                Console.Write("Результат операции: ");
                Console.Write(" a" + " + " + "b" + " = " + resultOne + "\n\n\n");
                goto Again;
            }
            else if (sign == '-')
            {
                float resultOne = Sub(a, b);
                Console.Write("Результат операции: ");
                Console.Write(" a" + " - " + "b" + " = " + resultOne + "\n\n\n");
                goto Again;
            }
            else if (sign == '*')
            {
                float resultOne = Mul(a, b);
                Console.Write("Результат операции: ");
                Console.Write(" a" + " * " + "b" + " = " + resultOne + "\n\n\n");
                goto Again;
            }
            else if (sign == '/' && b != 0)
            {
                float resultOne = Div(a, b);
                Console.Write("Результат операции: ");
                Console.Write(" a" + " / " + "b" + " = " + resultOne + "\n\n\n");
                goto Again;
            }
            else {
                Console.WriteLine("Введите пожалуйста другое число b, отличное от нуля!");
                goto Againtwo;
            }
            #endregion

            Console.ReadKey();
        }
    }
}
