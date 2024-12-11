using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());
            double tax = 0;
            double allPrice = 0;
            double priceForTheDay = 0;
            int counter = 0;
            double taxSum = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hoursPerDay; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        tax = 2.5;
                        taxSum += tax;
                        counter++;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        tax = 1.25;
                        taxSum += tax;
                        counter++;
                    }
                    else
                    {
                        tax = 1;
                        taxSum += tax;
                        counter++;
                    }
                    allPrice += tax;
                }
                if (counter == hoursPerDay)
                {
                    priceForTheDay = taxSum;
                    counter = 0;
                    taxSum = 0;
                }
                
                Console.WriteLine($"Day: {i} - {priceForTheDay:f2} leva");
            }

            Console.WriteLine($"Total: {allPrice:f2} leva");
        }
    }
}
