using System;

namespace BarCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int fourthDigit1 = start % 10;
            int fourthDigit2 = end % 10;
            start /= 10;
            end /= 10;

            int thirdDigit1 = start % 10;
            int thirdDigit2 = end % 10;
            start /= 10;
            end /= 10;

            int secondDigit1 = start % 10;
            int secondDigit2 = end % 10;
            start /= 10;
            end /= 10;

            for (int i = start; i <= end; i++)
            {
                for (int j = secondDigit1; j <= secondDigit2; j++)
                {
                    for (int k = thirdDigit1; k <= thirdDigit2; k++)
                    {
                        for (int l = fourthDigit1; l <= fourthDigit2; l++)
                        {
                            if (l % 2 != 0 || k % 2 != 0 || j % 2 != 0 || i % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
