using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0.0;

            while (input != "NoMoreMoney")
            {
                double currentNum = double.Parse(input);
                if (currentNum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    //Console.WriteLine($"Total: {sum:f2}");
                    break;
                }
                else if (currentNum > 0)
                {
                    Console.WriteLine($"Increase: {currentNum:f2}");
                    sum += currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
