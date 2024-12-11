using System;

namespace WheatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "sunny":
                    Console.WriteLine("It's warm outside!");
                    break;
                case "cloudy":
                    Console.WriteLine("It's cold outside!");
                    break;
                case "snowy":
                    Console.WriteLine("It's cold outside!");
                    break;
                default:
                    Console.WriteLine("It's cold outside!");
                    break;
            }
        }
    }
}
