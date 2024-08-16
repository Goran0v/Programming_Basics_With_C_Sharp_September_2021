using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double sneakers = 0.6 * taxPerYear;
            double outfit = 0.8 * sneakers;
            double ball = 0.25 * outfit;
            double accessories = 0.2 * ball;

            double price = taxPerYear + sneakers + outfit + ball + accessories;
            Console.WriteLine(price);
        }
    }
}
