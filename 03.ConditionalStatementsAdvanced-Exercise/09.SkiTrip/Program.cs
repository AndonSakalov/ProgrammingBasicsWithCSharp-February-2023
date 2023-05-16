using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stayingDays = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string atanasRating = Console.ReadLine();
            double pricePerNight = 0;
            int stayingNights = stayingDays - 1;
            double finalCost = 0;

            switch (roomType)
            {
                case "room for one person":
                    pricePerNight = 18.00;
                    finalCost = pricePerNight * stayingNights;
                    if (atanasRating == "positive")
                    {
                        finalCost = finalCost * 1.25;
                    }
                    else if (atanasRating == "negative")
                    {
                        finalCost = finalCost * 0.90;
                    }
                    break;
                case "apartment":
                    pricePerNight = 25.00;
                    finalCost = pricePerNight * stayingNights;
                    if (stayingDays < 10)
                    {
                        finalCost = 0.70 * finalCost;
                    }
                    else if (stayingDays >= 10 && stayingDays <= 15)
                    {
                        finalCost = 0.65 * finalCost;
                    }
                    else
                    {
                        finalCost = 0.50 * finalCost;
                    }
                    if (atanasRating == "positive")
                    {
                        finalCost = 1.25 * finalCost;
                    }
                    else if (atanasRating == "negative")
                    {
                        finalCost = 0.90 * finalCost;
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35.00;
                    finalCost = pricePerNight * stayingNights;
                    if (stayingDays < 10)
                    {
                        finalCost = 0.90 * finalCost;
                    }
                    else if (stayingDays >= 10 && stayingDays <= 15)
                    {
                        finalCost = 0.85 * finalCost;
                    }
                    else
                    {
                        finalCost = 0.80 * finalCost;
                    }
                    if (atanasRating == "positive")
                    {
                        finalCost = 1.25 * finalCost;
                    }
                    else if (atanasRating == "negative")
                    {
                        finalCost = 0.90 * finalCost;
                    }
                    break;
            }
            if (pricePerNight != 0)
            {
                Console.WriteLine($"{finalCost:F2}");
            }
        }
    }
}
