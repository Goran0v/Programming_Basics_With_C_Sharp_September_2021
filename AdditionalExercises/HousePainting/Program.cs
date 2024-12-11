using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            const double GREEN_PAINT = 3.4;
            const double RED_PAINT = 4.3;

            double height = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontAndRearWalls = height * height + (height * height - 2.4);
            double sideWalls = 2 * (height * length - 1.5 * 1.5);
            double roof = height * h + 2 * (height * length);

            double litersGreenPaint = (frontAndRearWalls + sideWalls) / GREEN_PAINT;
            double litersRedPaint = roof / RED_PAINT;

            Console.WriteLine($"{litersGreenPaint:f2}");
            Console.WriteLine($"{litersRedPaint:f2}");
        }
    }
}
