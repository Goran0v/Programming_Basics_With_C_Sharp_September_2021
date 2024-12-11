using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            int minNum = int.MaxValue;

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                if (minNum > currentNum)
                {
                    minNum = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
