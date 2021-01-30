using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява каква сума ще получите в края на депозитния период при определен лихвен процент.
            //Използвайте следната формула:
            //сума = депозирана сума + срок на депозита *((депозирана сума* годишен лихвен процент ) / 12)
            //Вход
            //От конзолата се четат 3 реда:
            //⦁	Депозирана сума – реално число в интервала[100.00 … 10000.00];
            double depositSum = double.Parse(Console.ReadLine());
            //⦁	Срок на депозита(в месеци) – цяло число в интервала[1…12];
            int termOfDeposit = int.Parse(Console.ReadLine());
            //⦁	Годишен лихвен процент – реално число в интервала[0.00 …100.00];
            double interest = double.Parse(Console.ReadLine());

            double accruedInterest = depositSum * (interest / 100);

            double interestPerMonth = accruedInterest / 12;


            //Изход
            //Да се отпечата на конзолата сумата в края на срока.
            double sum = depositSum + (termOfDeposit * interestPerMonth);
            Console.WriteLine(sum);
        }
    }
}
