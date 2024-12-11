using System;

namespace GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double quantityOfRakija = 0;
            double degreeOfRakija = 0;
            double allLiters = 0;
            double allDegrees = 0;
            double averageDegrees = 0;

            for (int i = 1; i <= days; i++)
            {
                quantityOfRakija = double.Parse(Console.ReadLine());
                degreeOfRakija = double.Parse(Console.ReadLine());
                allLiters += quantityOfRakija;
                allDegrees += quantityOfRakija * degreeOfRakija;
            }
            averageDegrees = allDegrees / allLiters;

            Console.WriteLine($"Liter: {allLiters:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");
            if (averageDegrees < 38)
            {
                Console.WriteLine($"Not good, you should baking!");
            }
            else if (averageDegrees >= 38 && averageDegrees <= 42)
            {
                Console.WriteLine($"Super!");
            }
            else if (averageDegrees > 42)
            {
                Console.WriteLine($"Dilution with distilled water!");
            }
        }
    }
}
