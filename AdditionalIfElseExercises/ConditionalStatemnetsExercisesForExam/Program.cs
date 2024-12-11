using System;

namespace ConditionalStatemnetsExercisesForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int peopleWorkingOutOfSchedule = int.Parse(Console.ReadLine());

            double allHours = 0.9 * days * 8 + peopleWorkingOutOfSchedule * 2 * days;

            if (allHours >= hoursNeeded)
            {
                double diff = allHours - hoursNeeded;
                Console.WriteLine($"Yes!{Math.Floor(diff)} hours left.");
            }
            else
            {
                double diff = hoursNeeded - allHours;
                Console.WriteLine($"Not enough time!{Math.Ceiling(diff)} hours needed.");
            }
        }
    }
}
