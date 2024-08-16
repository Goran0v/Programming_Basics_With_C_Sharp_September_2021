using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veggieMenu = int.Parse(Console.ReadLine());
            double desert = (chickenMenu * 10.35 + fishMenu * 12.40 + veggieMenu * 8.15) * 0.2;
            double price = (chickenMenu * 10.35 + fishMenu * 12.40 + veggieMenu * 8.15) + desert + 2.5;

            Console.WriteLine(price);
        }
    }
}
