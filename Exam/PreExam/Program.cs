using System;

namespace PreExam
{
    class Program
    {
        static void Main(string[] args)
        {
            const double LEVA_TO_DOLLARS = 1.57;

            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int numOfRams = int.Parse(Console.ReadLine());
            double procentDiscount = double.Parse(Console.ReadLine());

            double price = cpuPrice * LEVA_TO_DOLLARS * (1 - procentDiscount) + gpuPrice * LEVA_TO_DOLLARS * (1 - procentDiscount) + ramPrice * LEVA_TO_DOLLARS * numOfRams;

            Console.WriteLine($"Money needed - {price:f2} leva.");
        }
    }
}
