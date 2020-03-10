using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Напишите программу, которая будет выполнять конвертирование валют.
    Пользователь вводит:
    сумму денег в определенной валюте.
    курс для конвертации в другую валюту.
    Организуйте вывод результата операции конвертирования валюты на экран.  
         */
    class Program
    {
        static float ExchangeMoney(float one, float two)  // Конвертация валют
        {
            return one * two;
        }
        static float ExchangeMoneyTwo(float two)     // Обратная конвертация валют
        {
            return (1/two);
        }
        static void Main(string[] args)
        {
            Again: // Метка возврата
            // Прямая конвертация валюты
            Console.Write("Конвертирование валют из долларов в гривну."+"\n"+"Сумма конвертации в валюту: ");
            float sumMoney = Convert.ToSingle(Console.ReadLine());
            Console.Write("Курс валют: ");
            float exchangeCurrency = Convert.ToSingle(Console.ReadLine());

            Console.Write("Результат операции: ");
            float resultExchangeMoney = ExchangeMoney(sumMoney,exchangeCurrency);
            Console.Write(resultExchangeMoney + " гривен."+ "\n\n");

            // Обратная конвертация валюты
            Console.Write("Конвертирование валют из гривны в доллары." + "\n" + "Сумма конвертации в валюту: ");
            float sumMoneyTwo = Convert.ToSingle(Console.ReadLine());
            Console.Write("Курс валют: ");
            float exchangeCurrencyTwo = ExchangeMoneyTwo(exchangeCurrency);
            Console.WriteLine(exchangeCurrencyTwo);

            Console.Write("Результат операции: ");
            float resultExchangeMoneyTwo = ExchangeMoney(sumMoneyTwo, exchangeCurrencyTwo);
            Console.WriteLine(resultExchangeMoneyTwo + " долларов."+"\n\n");
            goto Again;  // Возврат в начало операций программы



            Console.ReadKey();
        }
    }
}
