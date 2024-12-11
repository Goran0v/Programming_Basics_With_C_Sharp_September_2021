using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAGN = 3.25;
            const int BLUEBELLS = 4;
            const double ROSES = 3.5;
            const int CACTUS = 8;

            int magn = int.Parse(Console.ReadLine());
            int bluebells = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double priceOfPresent = double.Parse(Console.ReadLine());

            double sum = 0.95 * (magn * MAGN + bluebells * BLUEBELLS + roses * ROSES + cactuses * CACTUS);

            if (sum >= priceOfPresent)
            {
                double moneyLeft = sum - priceOfPresent;
                Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
            }
            else
            {
                double moneyNeeded = priceOfPresent - sum;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyNeeded)} leva.");
            }
        }
    }
}
