using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberForDogs = int.Parse(Console.ReadLine());
            int numberForCats = int.Parse(Console.ReadLine());
            double sum = numberForDogs * 2.5 + numberForCats * 4;
            Console.WriteLine($"{sum} lv.");
        }
    }
}