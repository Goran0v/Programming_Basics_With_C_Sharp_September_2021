using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorNum = int.Parse(Console.ReadLine());
            int roomNum = int.Parse(Console.ReadLine());

            for (int floor = floorNum; floor >= 1; floor--)
            {
                for (int room = 0; room < roomNum; room++)
                {
                    if (floor == floorNum)
                    {
                        Console.Write($"L{floor}{room} ");
                        continue;
                    }

                    if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
