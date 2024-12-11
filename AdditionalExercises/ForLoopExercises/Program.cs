using System;

namespace ForLoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityOfStadium = int.Parse(Console.ReadLine());
            int allFans = int.Parse(Console.ReadLine());

            string input = "";
            double counterA = 0;
            double counterB = 0;
            double counterV = 0;
            double counterG = 0;

            double percentA = 0;
            double percentB = 0;
            double percentV = 0;
            double percentG = 0;
            double allPercent = 0;

            for (int i = allFans; i >= 1; i--)
            {
                input = Console.ReadLine();

                if (input == "A")
                {
                    counterA++;
                }
                else if (input == "B")
                {
                    counterB++;
                }
                else if (input == "V")
                {
                    counterV++;
                }
                else if (input == "G")
                {
                    counterG++;
                }

                percentA = counterA / allFans * 100;
                percentB = counterB / allFans * 100;
                percentV = counterV / allFans * 100;
                percentG = counterG / allFans * 100;
                allPercent = (double)allFans / (double)capacityOfStadium * 100;
            }

            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{allPercent:f2}%");
        }
    }
}
