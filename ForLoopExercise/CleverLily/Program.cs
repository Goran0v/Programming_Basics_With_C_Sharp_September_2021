using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceForWashingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toyCount = 0;
            int moneyCount = 0;
            int totalMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                moneyCount += 5;
                if (i % 2 == 0)
                {
                    totalMoney += moneyCount - 1;
                }
                else
                {
                    toyCount++;
                }
            }
            totalMoney += toyCount * toyPrice;
            if (totalMoney >= priceForWashingMachine)
            {
                Console.WriteLine($"Yes! {totalMoney - priceForWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceForWashingMachine - totalMoney:f2}");
            }
        }
    }
}
