using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string nameOfProduct = Console.ReadLine();
            double priceOfProduct = 0;
            int counterOfProducts = 0;
            double allPrice = 0;

            while (nameOfProduct != "Stop")
            {
                priceOfProduct = double.Parse(Console.ReadLine());
                counterOfProducts++;
                if (counterOfProducts % 3 == 0)
                {
                    priceOfProduct /= 2;
                }
                allPrice += priceOfProduct;
                if (allPrice > budget)
                {
                    double moneyNeeded = allPrice - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
                    break;
                }
                nameOfProduct = Console.ReadLine();
            }

            if (budget >= allPrice)
            {
                Console.WriteLine($"You bought {counterOfProducts} products for {allPrice:f2} leva.");
            }
        }
    }
}
