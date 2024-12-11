using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthOfFreeSpace = int.Parse(Console.ReadLine());
            int lengthOfFreeSpace = int.Parse(Console.ReadLine());
            int heightOfFreeSpace = int.Parse(Console.ReadLine());
            int freeSpace = widthOfFreeSpace * lengthOfFreeSpace * heightOfFreeSpace;
            int sumOfCubicMeters = 0;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int currentCubicMeters = int.Parse(input);
                sumOfCubicMeters += currentCubicMeters;
                if (freeSpace < sumOfCubicMeters)
                {
                    int neededCubicMeters = sumOfCubicMeters - freeSpace;
                    Console.WriteLine($"No more free space! You need {neededCubicMeters} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                int freeCubicMeters = freeSpace - sumOfCubicMeters;
                Console.WriteLine($"{freeCubicMeters} Cubic meters left.");
            }
        }
    }
}
