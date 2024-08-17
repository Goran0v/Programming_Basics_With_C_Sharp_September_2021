using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int iterator = 0; iterator < n; iterator++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double percentConP1 = 1.0 * p1 / n * 100;
            double percentConP2 = 1.0 * p2 / n * 100;
            double percentConP3 = 1.0 * p3 / n * 100;
            double percentConP4 = 1.0 * p4 / n * 100;
            double percentConP5 = (double) p5 / n * 100;

            Console.WriteLine($"{percentConP1:f2}%");
            Console.WriteLine($"{percentConP2:f2}%");
            Console.WriteLine($"{percentConP3:f2}%");
            Console.WriteLine($"{percentConP4:f2}%");
            Console.WriteLine($"{percentConP5:f2}%");
        }
    }
}
