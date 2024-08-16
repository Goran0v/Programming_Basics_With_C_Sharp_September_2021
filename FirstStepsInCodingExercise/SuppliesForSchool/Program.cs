using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int packetsPens = int.Parse(Console.ReadLine());
            int packetsMarkers = int.Parse(Console.ReadLine());
            int littersDetergent = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double discount = procent / 100;

            double money = (packetsPens * 5.8 + packetsMarkers * 7.2 + littersDetergent * 1.2);
            double moneyWithDiscount = money - money * discount;
            Console.WriteLine(moneyWithDiscount);
        }
    }
}
