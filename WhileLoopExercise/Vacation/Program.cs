using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendCount = 0;

            while (spendCount != 5)
            {
                string input = Console.ReadLine();
                double newMoney = double.Parse(Console.ReadLine());
                days++;
                if (input == "save")
                {
                    availableMoney += newMoney;
                    spendCount = 0;
                }
                else if (input == "spend")
                {
                    spendCount++;
                    if (newMoney > availableMoney)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney -= newMoney;
                    }
                }
                if (availableMoney >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
            if (spendCount == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}
