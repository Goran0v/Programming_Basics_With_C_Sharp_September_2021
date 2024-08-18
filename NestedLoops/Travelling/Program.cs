using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            

            while (destination != "End")
            {
                double minimalBudget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < minimalBudget)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
