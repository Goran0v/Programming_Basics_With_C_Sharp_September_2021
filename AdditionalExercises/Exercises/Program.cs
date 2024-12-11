using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPerKilo = double.Parse(Console.ReadLine());
            double tsatsaPerKilo = double.Parse(Console.ReadLine());
            double palamudKilo = double.Parse(Console.ReadLine());
            double safridKilo = double.Parse(Console.ReadLine());
            double clamsKilo = double.Parse(Console.ReadLine());

            double palamudPrice = 1.6 * mackerelPerKilo * palamudKilo;
            double safridPrice = 1.8 * tsatsaPerKilo * safridKilo;
            double clamsPrice = 7.5 * clamsKilo;

            double allPrice = palamudPrice + safridPrice + clamsPrice;
            Console.WriteLine($"{allPrice:f2}");
        }
    }
}
