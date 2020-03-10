using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
                /*Используя Visual Studio, создайте проект по шаблону Console Application.
        Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент
        кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен
        выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по
        300 и 400 грн. закрыть весь долг.
        Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную
        экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма задолженности,
        сумма переплаты, сообщение об отсутствии долга).*/
    class Program
    {
        static double ObligatoryPaymenth(double creditmoney, double creditMonth, double interestPerMonth, double x, int add, double result, double Money)  //Метод для автоматического подсчета обязательного платежа в месяц
        {
            double interestMonth = interestPerMonth / 100;  //Перевод процентов в доли (безразмерные единицы)
            double sum = 0;  // Подсчет суммы всех итераций
            for (x = 0; x <= creditmoney;)  // Цикл для нахождения значения итераций "x", при которой выражение "result" будет равно нулю.
            {
                if (creditmoney >= 1000000)   // Условные конструкции определяющий точность нахождения значения x
                {
                    x += 0.01f;
                }
                else if (creditmoney >= 10000 && creditmoney < 1000000)
                {
                    x += 0.001f;
                }
                else if (creditmoney > 0 && creditmoney < 10000)
                {
                    x += 0.000001f;
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

        static double PaymentCalculation(double creditmoney, int creditMonth, double interestPerMonth, double obligatoryPaymenth)
        {
            double interestMonth = interestPerMonth / 100;
            double result = creditmoney;
            if (creditMonth != 1)
            {
                creditMonth--;
                return PaymentCalculation((result-obligatoryPaymenth)*interestMonth+(result-obligatoryPaymenth), creditMonth, interestPerMonth, obligatoryPaymenth);
            }
            return (result-obligatoryPaymenth)* interestMonth+(result-obligatoryPaymenth);
            
        }
        static double LoanOverpayment(double creditmoney, int creditMonth, double interestPerMonth, double obligatoryPaymenth, double sum)
        {
            double interestMonth = interestPerMonth / 100;
            double result = creditmoney;
            double Overplayment = (result - obligatoryPaymenth) * interestMonth;
            if (obligatoryPaymenth > result)
            {
                return sum;
            }
            if (creditMonth != 1)
            {
                creditMonth--;
                return LoanOverpayment((result - obligatoryPaymenth) * interestMonth + (result - obligatoryPaymenth), creditMonth, interestPerMonth, obligatoryPaymenth, sum += Overplayment);
            }
            return sum+Overplayment;

        }

        static double DepositCalculation(double creditmoney, ref int creditMonth, double interestPerMonth, double obligatoryPaymenth, double sum, int res, double deposit)
        {
            double interestMonth = interestPerMonth / 100;
            double result = creditmoney;
            double Overplayment = (result - obligatoryPaymenth) * interestMonth;
            if (obligatoryPaymenth > result)
            {
                double residue = obligatoryPaymenth - result;
                deposit += residue;
                for (int i = 1; i < creditMonth; i++)
                {
                    deposit += obligatoryPaymenth;
                }
            }
            else if (obligatoryPaymenth < result && creditMonth != 1)
            {
                creditMonth--;
                return DepositCalculation((result - obligatoryPaymenth) * interestMonth + (result - obligatoryPaymenth), ref creditMonth, interestPerMonth, obligatoryPaymenth, sum += Overplayment, res--, deposit);
            }
            return deposit;

        }

        static void Main(string[] args)
        {
            Again:
            Console.Write("Сумма кредитных денег (гривен): ");
            double creditMoney = Convert.ToDouble(Console.ReadLine());

            Console.Write("Проценты кредитного займа в месяц (%): ");
            double interestPerMonth = Convert.ToDouble(Console.ReadLine());
            AgainTwo:
            Console.Write("Количество месяцев кредитного займа (мес.): ");
            int creditMonth = Convert.ToInt32(Console.ReadLine());
            if (creditMonth <= 0)
            {
                Console.WriteLine("Внимание! Количество месяцев кредитного займа не может быть меньше нуля!");
                goto AgainTwo;
            }
            double Money = creditMoney;
            double x = 0;
            int add = 0;
            double result = 0;

            double obligatorypaymenth = ObligatoryPaymenth(creditMoney, creditMonth, interestPerMonth, x, add, result, Money);
            Console.WriteLine("Автоматический расчет банком обязательного платежа в месяц по кредитному займу: {0:F7} гривен.", obligatorypaymenth);
      
            Console.Write("Обязательный платеж (по желанию клиента) в месяц по кредитному займу (гривен/мес.): ");
            double obligatoryPaymenth = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            int res = creditMonth;
            double deposit = 0;
            double creditDebt = PaymentCalculation(creditMoney, creditMonth, interestPerMonth, obligatoryPaymenth);
            double loanOverplayment = LoanOverpayment(creditMoney, creditMonth, interestPerMonth, obligatoryPaymenth, sum);
            if (creditDebt >= 0)
            {
                Console.WriteLine("Клиенту останется вернуть банку: {0:F4} гривен.", creditDebt);
            }
            else
            {
            Console.WriteLine("Указанная сумма позволит клиенту в течение {0} месяцев\nполностью погасить кредитную задолженность!", creditMonth);
            //Console.WriteLine("В свою очередь, чистая прибыль банка от этой кредитной операции составит: {0} гривен;", LoanOverpayment(creditMoney, creditMonth, interestPerMonth, obligatoryPaymenth, sum));
            double calculateDeposit = DepositCalculation(creditMoney, ref creditMonth, interestPerMonth, obligatoryPaymenth, sum, res, deposit);
            Console.WriteLine("Стоит обратить внимание, что клиент внес значительно большую сумму денег по операции с кредитной задолженностью!\nЕго депозит сверх кредитной задолженности составит: {0:F1} гривен.", calculateDeposit);
            }
            Console.Write("В свою очередь, чистая прибыль банка от этой кредитной операции равна: {0:F4} гривен;\n\n", loanOverplayment);
            goto Again;

            //Console.ReadKey();
        }
    }
}
