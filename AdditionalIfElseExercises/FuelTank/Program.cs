using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());

            if (typeOfFuel == "Diesel")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }
            }
            else if (typeOfFuel == "Gasoline")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
            }
            else if (typeOfFuel == "Gas")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
