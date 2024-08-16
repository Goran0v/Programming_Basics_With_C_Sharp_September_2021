using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                if (day == "Monday")
                {
                    Console.WriteLine("open");
                }
                if (day == "Tuesday")
                {
                    Console.WriteLine("open");
                }
                if (day == "Wednesday")
                {
                    Console.WriteLine("open");
                }
                if (day == "Thursday")
                {
                    Console.WriteLine("open");
                }
                if (day == "Friday")
                {
                    Console.WriteLine("open");
                }
                if (day == "Saturday")
                {
                    Console.WriteLine("open");
                }
                if (day == "Sunday")
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
