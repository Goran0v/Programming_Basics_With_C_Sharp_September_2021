using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i <= openTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }
                string openedTab = Console.ReadLine();
                if (openedTab == "Facebook")
                {
                    salary -= FACEBOOK;
                }
                else if (openedTab == "Instagram")
                {
                    salary -= INSTAGRAM;
                }
                else if (openedTab == "Reddit")
                {
                    salary -= REDDIT;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
