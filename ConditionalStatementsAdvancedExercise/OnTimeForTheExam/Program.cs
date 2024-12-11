using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheExam = int.Parse(Console.ReadLine());
            int minuteOfTheExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            minuteOfTheExam += hourOfTheExam * 60;
            minuteOfArrival += hourOfArrival * 60;

            if (minuteOfArrival > minuteOfTheExam)
            {
                Console.WriteLine("Late");
                difference = minuteOfArrival - minuteOfTheExam;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (minuteOfArrival < minuteOfTheExam - 30)
            {
                Console.WriteLine("Early");
                difference = minuteOfTheExam - minuteOfArrival;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = minuteOfTheExam - minuteOfArrival;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
