using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BAD_GRADE = 4;
            int badMarks = int.Parse(Console.ReadLine());
            int badGradesCount = 0;
            string currentProblem = Console.ReadLine();
            string lastProblem = "";
            int gradesSum = 0;
            int allGrades = 0;

            while (currentProblem != "Enough")
            {
                int currentGrade = int.Parse(Console.ReadLine());
                gradesSum++;
                allGrades += currentGrade;
                if (currentGrade <= BAD_GRADE)
                {
                    badGradesCount++;
                    if (badGradesCount == badMarks)
                    {
                        break;
                    }
                }
                lastProblem = currentProblem;
                currentProblem = Console.ReadLine();
            }
            if (currentProblem == "Enough")
            {
                double averageScore = 1.0 * allGrades / gradesSum;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {gradesSum}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
        }
    }
}
