using System;

namespace WhileCycleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int br = 0;

            while (currentBook != "No More Books")
            {
                if (currentBook == bookName)
                {
                    Console.WriteLine($"You checked {br} books and found it.");
                    break;
                }
                
                br++;
                currentBook = Console.ReadLine();
            }
            if (currentBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {br} books.");
            }
            
        }
    }
}
