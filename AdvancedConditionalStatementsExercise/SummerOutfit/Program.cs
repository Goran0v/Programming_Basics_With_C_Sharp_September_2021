using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (degrees >= 10 && degrees <= 18)
            {
                if (day == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (day == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (day == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }

            else if (degrees > 18 && degrees <= 24)
            {
                if (day == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (day == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (day == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }

            else if (degrees >= 25)
            {
                if (day == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (day == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                }
                else if (day == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
