using System;

namespace FamilyHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int overnights = int.Parse(Console.ReadLine());
            double priceForOvernight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (overnights > 7)
            {
                priceForOvernight = (priceForOvernight * 95) / 100;
            }

            double price = overnights * priceForOvernight;
            double additionalPercents = ((double)percent * budget) / 100;
            price += additionalPercents;

            if (budget >= price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else
            {
                double moneyNeeded = price - budget;
                Console.WriteLine($"{moneyNeeded:f2} leva needed.");
            }
        }
    }
}
