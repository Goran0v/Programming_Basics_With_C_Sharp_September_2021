using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOAL = 10000;
            int allSteps = 0;
            

            while (allSteps < GOAL)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    allSteps += stepsLeft;
                    break;
                }

                int currentSteps = int.Parse(command);
                allSteps += currentSteps;

            }
            if (allSteps >= GOAL)
            {
                Console.WriteLine("Goal reached! Good job!");
                int stepsOverTheGoal = allSteps - GOAL;
                Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");
            }
            else
            {
                int diff = GOAL - allSteps;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}
