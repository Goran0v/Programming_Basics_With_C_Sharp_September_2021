using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;
            double average = 0;
            while (num > 0)
            {
                int number = int.Parse(Console.ReadLine());
                counter++;
                sum += number;
                num--;
            }
            average = sum / counter;
            Console.WriteLine($"{average:f2}");
        }
    }
}
