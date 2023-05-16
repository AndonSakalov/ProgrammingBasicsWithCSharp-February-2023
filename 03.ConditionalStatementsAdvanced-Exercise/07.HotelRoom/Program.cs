using System;
using System.Diagnostics.CodeAnalysis;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioCostPerNight = 0;
            double apartmentCostPerNight = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioCostPerNight = 50;
                    apartmentCostPerNight = 65;
                    if (nightsCount > 7 && nightsCount <= 14)
                    {
                        studioCostPerNight = studioCostPerNight * 0.95;
                    }
                    else if (nightsCount > 14)
                    {
                        studioCostPerNight = studioCostPerNight * 0.70;
                        apartmentCostPerNight = apartmentCostPerNight * 0.9;
                    }
                    break;

                case "June":
                case "September":
                    studioCostPerNight = 75.20;
                    apartmentCostPerNight = 68.70;
                    if (nightsCount > 14)
                    {
                        studioCostPerNight = studioCostPerNight * 0.80;
                        apartmentCostPerNight = apartmentCostPerNight * 0.90;
                    }
                    break;

                case "July":
                case "August":
                    studioCostPerNight = 76;
                    apartmentCostPerNight = 77;
                    if (nightsCount > 14)
                    {
                        apartmentCostPerNight = apartmentCostPerNight * 0.90;
                    }
                    break;
            }
            if (studioCostPerNight != 0 && apartmentCostPerNight != 0)
            {
                Console.WriteLine($"Apartment: {apartmentCostPerNight * nightsCount:F2} lv.");
                Console.WriteLine($"Studio: {(studioCostPerNight * nightsCount):F2} lv.");
            }
            
        }
    }
}
