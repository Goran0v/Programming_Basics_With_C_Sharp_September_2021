using System;

namespace SwimmingWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double timePerOneMinute = double.Parse(Console.ReadLine());

            double swimming = length * timePerOneMinute;
            double additionalTime = ((int)length / 15) * 12.5;
            double totalTime = swimming + additionalTime;

            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

            else
            {
                double timeSlow = totalTime - worldRecord;
                Console.WriteLine($"No, he failed! He was {timeSlow:f2} seconds slower.");
            }
        }
    }
}
