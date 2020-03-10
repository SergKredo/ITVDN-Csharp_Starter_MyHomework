using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static float ObligatoryPaymenth(float creditmoney, float creditMonth, float interestPerMonth, float x, int add, float result, float Money)
        {
            float interestMonth = interestPerMonth / 100;
            float sum = 0;
            for (x = 0; x <= creditmoney; )
            {  if (creditmoney >= 1000000)
                {
                    x += 1f;
                }
                else if (creditmoney >= 10000 && creditmoney < 1000000)
                {
                    x += 0.1f;
                }
                else if (creditmoney > 0 && creditmoney < 10000)
                {
                    x += 0.00001f;
                }
                sum = x;
                for (int i = 1; i <= creditMonth; i++)
                {
                    result = 0;
                    result = ((creditmoney - x) * interestMonth) + (creditmoney - x);
                    creditmoney = result;
                    if (result != 0 && result > 0)
                    {
                        continue;
                    }
                    else
                    {
                        goto Break;
                    }
                }
                result = 0;
                creditmoney = Money;
                continue;
                Break: break;
            }
                return sum;
        }
        static void Main(string[] args)
        {
        Again:
            Console.Write("Сумма кредитных денег (гривен): ");
            float creditMoney = Convert.ToSingle(Console.ReadLine());
            float Money = creditMoney;

            Console.Write("Проценты кредитного займа в месяц (%): ");
            float interestPerMonth = Convert.ToSingle(Console.ReadLine());

            Console.Write("Количество месяцев кредитного займа (мес.): ");
            int creditMonth = Convert.ToInt32(Console.ReadLine());
            float x = 0f;
            int add = 0;
            float result = 0;
            
            float obligatoryPaymenth = ObligatoryPaymenth(creditMoney, creditMonth, interestPerMonth, x, add, result, Money);
            Console.Write("Автоматический расчет обязательного платежа в месяц по кредитному займу: {0} гривен.", obligatoryPaymenth);
            Console.Write("\n\n");
                       
            goto Again;
        }
    }
}
