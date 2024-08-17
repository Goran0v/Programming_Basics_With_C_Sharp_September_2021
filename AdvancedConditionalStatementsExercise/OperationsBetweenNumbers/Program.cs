using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;

            if (op == "+")
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - odd");
                }
            }

            if (op == "-")
            {
                result = (double)N1 - (double)N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - odd");
                }
            }

            if (op == "*")
            {
                result = (double)N1 * (double)N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - odd");
                }
            }

            if (op == "/" && N2 != 0)
            {
                result = (double)N1 / (double)N2;
                Console.WriteLine($"{N1} {op} {N2} = {result:f2}");
            }
            else if (op == "/" && N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }

            if (op == "%" && N2 != 0)
            {
                result = N1 % N2;
                Console.WriteLine($"{N1} {op} {N2} = {result}");
            }
            else if (op == "%" && N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
        }
    }
}
