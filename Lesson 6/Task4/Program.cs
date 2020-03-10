using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /*Имеется N клиентов, которым компания производитель должна доставить товар. Сколько существует
возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных
вариантов доставки товара. Для решения задачи, используйте факториал N!, рассчитываемый с
помощью цикла do-while.*/


    class Program
    {
        static void Main(string[] args)
        {
            Again:   // Метка возврата

            Console.Write("Введите пожалуйста количество клиентов для доставки товаров: ");
            AgainTwo:  // Метка возврата
            decimal customer = Convert.ToUInt64(Console.ReadLine());
            decimal totalDelivery = 1;

            if (customer < 28)
            {
                do
                {
                    totalDelivery *= customer;
                    customer--;

                }
                while (customer != 0);

            Console.WriteLine("Общее число возможных вариантов доставок клиентам равно: {0}", totalDelivery + "\n");
            }
            else
            {
                Console.Write("\nВы ввели достаточно большое количество клиентов на одну машину!"+"\nВведите пожалуйста другое число меньшее 28: ");
                goto AgainTwo;
            }                
            
            goto Again;
           
        }
    }
}
