using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;

            for (int i = 1; i <= groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());
                if (climbers < 6)
                {
                    group1 += climbers;
                }
                else if (climbers < 13)
                {
                    group2 += climbers;
                }
                else if (climbers < 26)
                {
                    group3 += climbers;
                }
                else if (climbers < 41)
                {
                    group4 += climbers;
                }
                else
                {
                    group5 += climbers;
                }
            }
            int totalClimbers = group1 + group2 + group3 + group4 + group5;
            double convertGroup1 = 1.0 * group1 / totalClimbers * 100;
            double convertGroup2 = 1.0 * group2 / totalClimbers * 100;
            double convertGroup3 = 1.0 * group3 / totalClimbers * 100;
            double convertGroup4 = 1.0 * group4 / totalClimbers * 100;
            double convertGroup5 = 1.0 * group5 / totalClimbers * 100;

            Console.WriteLine($"{convertGroup1:f2}%");
            Console.WriteLine($"{convertGroup2:f2}%");
            Console.WriteLine($"{convertGroup3:f2}%");
            Console.WriteLine($"{convertGroup4:f2}%");
            Console.WriteLine($"{convertGroup5:f2}%");
        }
    }
}
