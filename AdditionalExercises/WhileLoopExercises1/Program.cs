using System;

namespace WhileLoopExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int platesAndPots = 0;
            int plates = 0;
            int pots = 0;
            int counter = 0;
            int platesCounter = 0;
            int potsCounter = 0;
            int detergent = bottles * 750; ;
            while (input != "End")
            {
                platesAndPots = int.Parse(input);
                counter++;
                if (counter % 3 != 0)
                {
                    plates = platesAndPots * 5;
                    pots = 0;
                    platesCounter += platesAndPots;
                }
                else if (counter % 3 == 0)
                {
                    pots = platesAndPots * 15;
                    plates = 0;
                    potsCounter += platesAndPots;
                }
                detergent -= plates;
                detergent -= pots;
                if (detergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (detergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{platesCounter} dishes and {potsCounter} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            };
        }
    }
}
