using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currNum = 0;
            int couple = 0;
            int couple2 = 0;
            int counter = 0;
            
            for (int i = 1; i <= 2 * num; i++)
            {
                currNum = int.Parse(Console.ReadLine());
                couple += currNum;
                if (i % 2 == 0)
                {
                    counter++;
                    couple2 += couple;
                    couple = 0;
                }
            }
            couple2 /= counter;
            if (couple2 == counter)
            {
                Console.WriteLine($"Yes, value={couple2}");
            }
            
        }
    }
}
