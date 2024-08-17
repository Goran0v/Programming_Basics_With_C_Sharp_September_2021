using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0.0;

            if (typeFlower == "Roses" && numOfFlowers <= 80)
            {
                sum = numOfFlowers * 5;
            }
            else if (typeFlower == "Dahlias" && numOfFlowers <= 90)
            {
                sum = numOfFlowers * 3.8;
            }
            else if (typeFlower == "Tulips" && numOfFlowers <= 80)
            {
                sum = numOfFlowers * 2.8;
            }
            else if (typeFlower == "Narcissus" && numOfFlowers >= 120)
            {
                sum = numOfFlowers * 3;
            }
            else if (typeFlower == "Gladiolus" && numOfFlowers >= 80)
            {
                sum = numOfFlowers * 2.50;
            }

            else if (typeFlower == "Roses" && numOfFlowers > 80)
            {
                sum = numOfFlowers * 5 * 0.9;
            }
            else if (typeFlower == "Dahlias" && numOfFlowers > 90)
            {
                sum = numOfFlowers * 3.8 * 0.85;
            }
            else if (typeFlower == "Tulips" && numOfFlowers > 80)
            {
                sum = numOfFlowers * 2.8 * 0.85;
            }
            else if (typeFlower == "Narcissus" && numOfFlowers < 120)
            {
                sum = numOfFlowers * 3 * 1.15;
            }
            else if (typeFlower == "Gladiolus" && numOfFlowers < 80)
            {
                sum = numOfFlowers * 2.50 * 1.2;
            }

            double difference = Math.Abs(budget - sum);

            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeFlower} and {difference:f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}
