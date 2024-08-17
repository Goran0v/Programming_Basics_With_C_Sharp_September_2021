using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FINALIST_POINTS = 1200;
            const int WINNER_POINTS = 2000;
            const int SEMIFINALIST_POINTS = 720;

            int playedTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            string currentStage = string.Empty;
            int points = 0;
            double average = 0;
            double percents = 0;
            int numberOfWonTournaments = 0;
            points = startingPoints;

            for (int i = 0; i < playedTournaments; i++)
            {
                currentStage = Console.ReadLine();
                if (currentStage == "F")
                {
                    points += FINALIST_POINTS;
                }
                else if (currentStage == "W")
                {
                    points += WINNER_POINTS;
                    numberOfWonTournaments++;
                }
                else if (currentStage == "SF")
                {
                    points += SEMIFINALIST_POINTS;
                }
            }
            average = (points - startingPoints) / playedTournaments;
            percents = ((double)numberOfWonTournaments / playedTournaments) * 100;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percents:f2}%");
        }
    }
}
