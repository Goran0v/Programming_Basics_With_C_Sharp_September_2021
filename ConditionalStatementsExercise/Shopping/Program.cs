using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            const double videocardPrice = 250;

            double budget = double.Parse(Console.ReadLine());
            int numberOfVideoCards = int.Parse(Console.ReadLine());
            int numberOfProcessors = int.Parse(Console.ReadLine());
            int numberOfRamMemory = int.Parse(Console.ReadLine());

            double totalVideoCardPrice = numberOfVideoCards * videocardPrice;
            double totalProcessorsPrice = totalVideoCardPrice * 0.35;
            double totalRamMemoryPrice = totalVideoCardPrice * 0.1;

            double totalMoney = totalVideoCardPrice + totalProcessorsPrice * numberOfProcessors + totalRamMemoryPrice * numberOfRamMemory;

            if (numberOfVideoCards > numberOfProcessors)
            {
                totalMoney *= 0.85;
            }


            double difference = Math.Abs(totalMoney - budget);

            
            
            Console.WriteLine(budget >= totalMoney
            ? $"You have {difference:f2} leva left!"
            : $"Not enough money! You need {difference:f2} leva more!");
            
        }
    }
}
