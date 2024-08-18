using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumNeeded = double.Parse(Console.ReadLine());

            double shortPrice = 0.75 * tshirtPrice;
            double socksPrice = 0.2 * shortPrice;
            double shoesPrice = 2 * (tshirtPrice + shortPrice);

            double sum = 0.85 * (tshirtPrice + shortPrice + socksPrice + shoesPrice);

            if (sum >= sumNeeded)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sum:f2} lv.");
            }
            else
            {
                double moneyNeeded = sumNeeded - sum;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {moneyNeeded:f2} lv. more.");
            }
        }
    }
}
