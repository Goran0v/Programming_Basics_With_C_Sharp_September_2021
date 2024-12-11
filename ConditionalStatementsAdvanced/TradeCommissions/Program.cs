using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double trades = double.Parse(Console.ReadLine());
            double percent = 0;

            if (city == "Sofia")
            {
                if (trades >= 0 && trades <= 500)
                {
                    percent = 0.05;
                }
                else if (trades > 500 && trades <= 1000)
                {
                    percent = 0.07;
                }
                else if (trades > 1000 && trades <= 10000)
                {
                    percent = 0.08;
                }
                else if (trades > 10000)
                {
                    percent = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Varna")
            {
                if (trades >= 0 && trades <= 500)
                {
                    percent = 0.045;
                }
                else if (trades > 500 && trades <= 1000)
                {
                    percent = 0.075;
                }
                else if (trades > 1000 && trades <= 10000)
                {
                    percent = 0.1;
                }
                else if (trades > 10000)
                {
                    percent = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Plovdiv")
            {
                if (trades >= 0 && trades <= 500)
                {
                    percent = 0.055;
                }
                else if (trades > 500 && trades <= 1000)
                {
                    percent = 0.08;
                }
                else if (trades > 1000 && trades <= 10000)
                {
                    percent = 0.12;
                }
                else if (trades > 10000)
                {
                    percent = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }

            double commission = trades * percent;

            if (commission != 0)
            {
                Console.WriteLine($"{commission:f2}");
            }
            
        }
    }
}
