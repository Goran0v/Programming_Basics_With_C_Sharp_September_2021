using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double interest = depositSum * procent / 100;
            double interestForOneMonth = interest / 12;
            double sum = depositSum + term * interestForOneMonth;

            Console.WriteLine(sum);
        }
    }
}
