using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfFilm = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceOfTicket = double.Parse(Console.ReadLine());
            int procentsForTheCinema = int.Parse(Console.ReadLine());

            double sumOfTickets = tickets * priceOfTicket;
            double allSum = sumOfTickets * days;
            double finalSum = ((100 - (double)procentsForTheCinema) / 100) * allSum;
            Console.WriteLine($"The profit from the movie {nameOfFilm} is {finalSum:f2} lv.");
        }
    }
}
