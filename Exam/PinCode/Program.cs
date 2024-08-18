using System;

namespace PinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int l = 0;

            for (int i = 2; i <= firstNum; i += 2)
            {
                for (int j = 2; j <= secondNum; j++)
                {
                    for (int k = 2; k <= thirdNum; k += 2)
                    {
                        if (j % 4 == 0 || j % 6 == 0 || j % 8 == 0 || j % 9 == 0) 
                        {
                            continue;
                        }
                        if (j % 4 == 0 && j % 6 == 0 && j % 8 == 0 && j % 9 == 0)
                        {
                            continue;
                        }
                        if (j % 4 == 0 && j % 6 == 0)
                        {
                            continue;
                        }
                        if (j % 6 == 0 && j % 8 == 0)
                        {
                            continue;
                        }
                        if (j % 8 == 0 && j % 9 == 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}
