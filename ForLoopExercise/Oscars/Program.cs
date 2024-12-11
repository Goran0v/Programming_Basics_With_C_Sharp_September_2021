using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            const double NEEDED_POINTS_FOR_OSKAR = 1250.5;
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());

            double sumPoints = pointsFromAcademy;

            bool isActorFound = false;
            for (int i = 0; i < jury; i++)
            {
                string nameOfJury = Console.ReadLine();
                double givenPoints = double.Parse(Console.ReadLine());

                int lengthOfName = nameOfJury.Length;
                double momentPoints = (lengthOfName * givenPoints) / 2;
                sumPoints += momentPoints;

                if (sumPoints >= NEEDED_POINTS_FOR_OSKAR)
                {
                    isActorFound = true;
                    break;
                }
            }
            if (isActorFound)
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {sumPoints:f1}!");
            }
            else
            {
                double neededPoints = NEEDED_POINTS_FOR_OSKAR - sumPoints;
                Console.WriteLine($"Sorry, {nameOfActor} you need {neededPoints:f1} more!");
            }
        }
    }
}
