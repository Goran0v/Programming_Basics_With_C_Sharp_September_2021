using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine("{0:F3}", area);
            }
            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine("{0:F3}", area);
            }
            if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = r * r * Math.PI;
                Console.WriteLine("{0:F3}", area);
            }
            if (figure == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (b * h) / 2;
                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}
