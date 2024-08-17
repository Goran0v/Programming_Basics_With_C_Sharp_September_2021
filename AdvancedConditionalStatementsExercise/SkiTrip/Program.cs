using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_FOR_ROOM_FOR_ONE_PERSON = 18;
            const double PRICE_FOR_APARTMENT = 25;
            const double PRICE_FOR_PRESIDENT_APARTMENT = 35;

            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = days - 1;
            double totalPrice = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    totalPrice = nights * PRICE_FOR_ROOM_FOR_ONE_PERSON;
                    break;
                case "apartment":
                    totalPrice = nights * PRICE_FOR_APARTMENT;
                    if (days > 15)
                    {
                        totalPrice *= 0.5;
                    }
                    else if (days >= 10)
                    {
                        totalPrice *= 0.65;
                    }
                    else
                    {
                        totalPrice *= 0.6;
                    }
                    break;
                case "president apartment":
                    totalPrice = nights * PRICE_FOR_PRESIDENT_APARTMENT;
                    if (days > 15)
                    {
                        totalPrice *= 0.8;
                    }
                    else if (days >= 10)
                    {
                        totalPrice *= 0.85;
                    }
                    else
                    {
                        totalPrice *= 0.9;
                    }
                    break;
            }
            switch (rating)
            {
                case "positive":
                    totalPrice *= 1.25;
                    break;
                case "negative":
                    totalPrice *= 0.9;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
