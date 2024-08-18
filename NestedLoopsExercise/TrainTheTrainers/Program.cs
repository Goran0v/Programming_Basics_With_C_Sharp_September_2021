using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            int gradeCount = 0;
            double sum = 0;
            while (nameOfPresentation != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 1; i <= jury; i++)
                {
                    double marks = double.Parse(Console.ReadLine());
                    sumOfGrades += marks;
                    gradeCount++;
                    sum += marks;
                }
                double average = sumOfGrades / jury;
                Console.WriteLine($"{nameOfPresentation} - {average:f2}.");
                nameOfPresentation = Console.ReadLine();
            }
            double finalAverage = sum / gradeCount;
            Console.WriteLine($"Student's final assessment is {finalAverage:f2}.");
        }
    }
}
