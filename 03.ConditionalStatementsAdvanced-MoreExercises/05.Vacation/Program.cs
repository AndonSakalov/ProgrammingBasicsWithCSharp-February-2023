using System;
using System.Reflection.PortableExecutable;

namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = string.Empty;
            string country = string.Empty;
            double vacationCost = 0;

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    country = "Alaska";
                    vacationCost = 0.65 * budget;
                }
                else if (season == "Winter")
                {
                    country = "Morocco";
                    vacationCost = 0.45 * budget;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    country = "Alaska";
                    vacationCost = 0.80 * budget;
                }
                else if (season == "Winter")
                {
                    country = "Morocco";
                    vacationCost = 0.60 * budget;
                }
            }
            else
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    country = "Alaska";
                    vacationCost = 0.90 * budget;
                }
                else if (season == "Winter")
                {
                    country = "Morocco";
                    vacationCost = 0.90 * budget;
                }
            }
            Console.WriteLine($"{country} - {place} - {vacationCost:F2}");
        }
    }
}
