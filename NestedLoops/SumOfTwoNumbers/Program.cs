using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int x = start; x <= end; x++)
            {
                
                for (int y = start; y <= end; y++)
                {
                    counter++;
                    if (x + y == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x} + {y} = {magicNum})");
                        return;
                    }

                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
