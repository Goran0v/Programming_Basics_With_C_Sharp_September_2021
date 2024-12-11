using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());
            double moneyPerHour = (nylon * 1.5 + 2 * 1.5 + paint * 14.5 + paint * 0.1 * 14.5 + thinner * 5 + 0.4) * 0.3;
            double finalSum = (nylon * 1.5 + 2 * 1.5 + paint * 14.5 + paint * 0.1 * 14.5 + thinner * 5 + 0.4) + hoursWork * moneyPerHour;

            Console.WriteLine(finalSum);
        }
    }
}
