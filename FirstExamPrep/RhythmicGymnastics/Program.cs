using System;

namespace RhythmicGymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();
            double judgeForBulgaria = 0;
            double judgeForRussia = 0;
            double judgeForItaly = 0;
            double percentForBg = 0;
            double percentForRu = 0;
            double percentForIta = 0;

            if (country == "Bulgaria")
            {
                if (instrument == "ribbon")
                {
                    judgeForBulgaria = 9.6 + 9.4;
                    percentForBg = ((20 - judgeForBulgaria) / 20) * 100;
                }
                else if (instrument == "hoop")
                {
                    judgeForBulgaria = 9.55 + 9.75;
                    percentForBg = ((20 - judgeForBulgaria) / 20) * 100;
                }
                else if (instrument == "rope")
                {
                    judgeForBulgaria = 9.5 + 9.4;
                    percentForBg = ((20 - judgeForBulgaria) / 20) * 100;
                }
            }
            else if (country == "Russia")
            {
                if (instrument == "ribbon")
                {
                    judgeForRussia = 9.1 + 9.4;
                    percentForRu = ((20 - judgeForRussia) / 20) * 100;
                }
                else if (instrument == "hoop")
                {
                    judgeForRussia = 9.3 + 9.8;
                    percentForRu = ((20 - judgeForRussia) / 20) * 100;
                }
                else if (instrument == "rope")
                {
                    judgeForRussia = 9.6 + 9;
                    percentForRu = ((20 - judgeForRussia) / 20) * 100;
                }
            }
            else if (country == "Italy")
            {
                if (instrument == "ribbon")
                {
                    judgeForItaly = 9.2 + 9.5;
                    percentForIta = ((20 - judgeForItaly) / 20) * 100;
                }
                else if (instrument == "hoop")
                {
                    judgeForItaly = 9.45 + 9.35;
                    percentForIta = ((20 - judgeForItaly) / 20) * 100;
                }
                else if (instrument == "rope")
                {
                    judgeForItaly = 9.7 + 9.15;
                    percentForIta = ((20 - judgeForItaly) / 20) * 100;
                }
            }

            if (country == "Bulgaria")
            {
                Console.WriteLine($"The team of {country} get {judgeForBulgaria:f3} on {instrument}.");
                Console.WriteLine($"{percentForBg:f2}%");
            }
            else if (country == "Russia")
            {
                Console.WriteLine($"The team of {country} get {judgeForRussia:f3} on {instrument}.");
                Console.WriteLine($"{percentForRu:f2}%");
            }
            else if (country == "Italy")
            {
                Console.WriteLine($"The team of {country} get {judgeForItaly:f3} on {instrument}.");
                Console.WriteLine($"{percentForIta:f2}%");
            }
        }
    }
}
