using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeftForPets = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            if (dogFoodPerDay >= 100 && dogFoodPerDay <= 999)
            {
                dogFoodPerDay /= 1000;
            }
            else if (dogFoodPerDay >= 1000)
            {
                dogFoodPerDay /= 1000;
            }

            if (catFoodPerDay >= 100 && catFoodPerDay <= 999)
            {
                catFoodPerDay /= 1000;
            }
            else if (catFoodPerDay >= 1000)
            {
                catFoodPerDay /= 1000;
            }

            if (turtleFoodPerDay >= 100 && turtleFoodPerDay <= 999)
            {
                turtleFoodPerDay /= 1000;
            }
            else if (turtleFoodPerDay >= 1000)
            {
                turtleFoodPerDay /= 1000;
            }

            double allFoodForDog = dogFoodPerDay * days;
            double allFoodForCat = catFoodPerDay * days;
            double allFoodForTurtle = turtleFoodPerDay * days;
            double allFood = allFoodForDog + allFoodForCat + allFoodForTurtle;

            if (allFood <= foodLeftForPets)
            {
                double foodLeft = foodLeftForPets - allFood;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodNeeded = allFood - foodLeftForPets;
                Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }
        }
    }
}
