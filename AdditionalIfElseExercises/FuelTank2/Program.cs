using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double GASOLINE = 2.22;
            const double DIESEL = 2.33;
            const double GAS = 0.93;

            string typeOfFuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double price = 0;

            if (typeOfFuel == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    if (litersFuel >= 20 && litersFuel <= 25)
                    {
                        price = 0.92 * ((DIESEL - 0.12) * litersFuel);
                    }
                    else if (litersFuel > 25)
                    {
                        price = 0.90 * ((DIESEL - 0.12) * litersFuel);
                    }
                    else
                    {
                        price = (DIESEL - 0.12) * litersFuel;
                    }
                }
                else if (clubCard == "No")
                {
                    if (litersFuel >= 20 && litersFuel <= 25)
                    {
                        price = 0.92 * (DIESEL * litersFuel);
                    }
                    else if (litersFuel > 25)
                    {
                        price = 0.90 * (DIESEL * litersFuel);
                    }
                    else
                    {
                        price = DIESEL * litersFuel;
                    }
                }
            }
            else if (typeOfFuel == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    if (litersFuel >= 20 && litersFuel <= 25)
                    {
                        price = 0.92 * ((GASOLINE - 0.18) * litersFuel);
                    }
                    else if (litersFuel > 25)
                    {
                        price = 0.90 * ((GASOLINE - 0.18) * litersFuel);
                    }
                    else
                    {
                        price = (GASOLINE - 0.18) * litersFuel;
                    }
                }
                else if (clubCard == "No")
                {
                    if (litersFuel >= 20 && litersFuel <= 25)
                    {
                        price = 0.92 * (GASOLINE * litersFuel);
                    }
                    else if (litersFuel > 25)
                    {
                        price = 0.90 * (GASOLINE * litersFuel);
                    }
                    else
                    {
                        price = GASOLINE * litersFuel;
                    }
                }
            }
            else if (typeOfFuel == "Gas")
            {
                if (clubCard == "Yes")
                {
                    if (litersFuel >= 20 && litersFuel <= 25)
                    {
                        price = 0.92 * ((GAS - 0.08) * litersFuel);
                    }
                    else if (litersFuel > 25)
                    {
                        price = 0.90 * ((GAS - 0.08) * litersFuel);
                    }
                    else
                    {
                        price = (GAS - 0.08) * litersFuel;
                    }
                }
                else if (clubCard == "No")
                {
                    if (litersFuel >= 20 && litersFuel <= 25)
                    {
                        price = 0.92 * (GAS * litersFuel);
                    }
                    else if (litersFuel > 25)
                    {
                        price = 0.90 * (GAS * litersFuel);
                    }
                    else
                    {
                        price = GAS * litersFuel;
                    }
                }
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
