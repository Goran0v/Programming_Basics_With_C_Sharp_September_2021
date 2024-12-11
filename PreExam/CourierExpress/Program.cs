using System;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightOfShipment = double.Parse(Console.ReadLine());
            string typeOfService = Console.ReadLine();
            int kilometers = int.Parse(Console.ReadLine());
            double pricePerKilometer = 0;
            double morePriceForExpressKm = 0;
            double morePriceForExpressKg = 0;
            double allPrice = 0;

            if (typeOfService == "standard")
            {
                if (weightOfShipment < 1)
                {
                    pricePerKilometer = 0.03;
                    allPrice = kilometers * pricePerKilometer;
                }
                else if (weightOfShipment >= 1 && weightOfShipment < 10)
                {
                    pricePerKilometer = 0.05;
                    allPrice = kilometers * pricePerKilometer;
                }
                else if (weightOfShipment >= 10 && weightOfShipment < 40)
                {
                    pricePerKilometer = 0.1;
                    allPrice = kilometers * pricePerKilometer;
                }
                else if (weightOfShipment >= 40 && weightOfShipment < 90)
                {
                    pricePerKilometer = 0.15;
                    allPrice = kilometers * pricePerKilometer;
                }
                else if (weightOfShipment >= 90 && weightOfShipment < 150)
                {
                    pricePerKilometer = 0.2;
                    allPrice = kilometers * pricePerKilometer;
                }
            }
            else if (typeOfService == "express")
            {
                if (weightOfShipment < 1)
                {
                    pricePerKilometer = 0.03;
                    morePriceForExpressKg = 0.8 * pricePerKilometer;
                    morePriceForExpressKm = weightOfShipment * morePriceForExpressKg;
                    allPrice = kilometers * morePriceForExpressKm + pricePerKilometer * kilometers;
                }
                else if (weightOfShipment >= 1 && weightOfShipment < 10)
                {
                    pricePerKilometer = 0.05;
                    morePriceForExpressKg = 0.4 * pricePerKilometer;
                    morePriceForExpressKm = weightOfShipment * morePriceForExpressKg;
                    allPrice = kilometers * morePriceForExpressKm + pricePerKilometer * kilometers;
                }
                else if (weightOfShipment >= 10 && weightOfShipment < 40)
                {
                    pricePerKilometer = 0.1;
                    morePriceForExpressKg = 0.05 * pricePerKilometer;
                    morePriceForExpressKm = weightOfShipment * morePriceForExpressKg;
                    allPrice = kilometers * morePriceForExpressKm + pricePerKilometer * kilometers;
                }
                else if (weightOfShipment >= 40 && weightOfShipment < 90)
                {
                    pricePerKilometer = 0.15;
                    morePriceForExpressKg = 0.02 * pricePerKilometer;
                    morePriceForExpressKm = weightOfShipment * morePriceForExpressKg;
                    allPrice = kilometers * morePriceForExpressKm + pricePerKilometer * kilometers;
                }
                else if (weightOfShipment >= 90 && weightOfShipment < 150)
                {
                    pricePerKilometer = 0.2;
                    morePriceForExpressKg = 0.01 * pricePerKilometer;
                    morePriceForExpressKm = weightOfShipment * morePriceForExpressKg;
                    allPrice = kilometers * morePriceForExpressKm + pricePerKilometer * kilometers;
                }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {weightOfShipment:f3} kg. would cost {allPrice:f2} lv.");
        }
    }
}
