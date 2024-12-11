using System;

namespace FilmRating
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFilms = int.Parse(Console.ReadLine());
            double highestRating = double.MinValue;
            double lowestRating = double.MaxValue;
            string nameOfFilmWithHighestRating = "";
            string nameOfFilmWithLowestRating = "";
            double averageRating = 0;
            int counter = 0;
            double allRating = 0;

            for (int i = 1; i <= numberOfFilms; i++)
            {
                string nameOfFilm = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                counter++;
                allRating += rating;

                if (highestRating < rating)
                {
                    highestRating = rating;
                    nameOfFilmWithHighestRating = nameOfFilm;
                }
                if (lowestRating > rating)
                {
                    lowestRating = rating;
                    nameOfFilmWithLowestRating = nameOfFilm;
                }
            }
            averageRating = allRating / counter;
            Console.WriteLine($"{nameOfFilmWithHighestRating} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{nameOfFilmWithLowestRating} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
