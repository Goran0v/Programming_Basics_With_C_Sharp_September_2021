using System;

namespace HairSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalOfTheDay = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string inputForSalon = "";
            double sum = 0;
            double allPrice = 0;

            while (input != "closed")
            {
                if (input == "haircut")
                {
                    inputForSalon = Console.ReadLine();
                    if (inputForSalon == "mens")
                    {
                        sum = 15;
                    }
                    else if (inputForSalon == "ladies")
                    {
                        sum = 20;
                    }
                    else if (inputForSalon == "kids")
                    {
                        sum = 10;
                    }
                }
                else if (input == "color")
                {
                    inputForSalon = Console.ReadLine();
                    if (inputForSalon == "touch up")
                    {
                        sum = 20;
                    }
                    else if (inputForSalon == "full color")
                    {
                        sum = 30;
                    }
                }
                allPrice += sum;
                if (allPrice >= goalOfTheDay)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {allPrice}lv.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (allPrice < goalOfTheDay)
            {
                double moneyNeeded = (double)goalOfTheDay - allPrice;
                Console.WriteLine($"Target not reached! You need {moneyNeeded}lv. more.");
                Console.WriteLine($"Earned money: {allPrice}lv.");
            }
        }
    }
}
