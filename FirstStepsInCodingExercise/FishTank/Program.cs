using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeInLiters = volume / 1000;
            double litersNeeded = volumeInLiters * (1 - percent / 100);

            Console.WriteLine(litersNeeded);
        }
    }
}
