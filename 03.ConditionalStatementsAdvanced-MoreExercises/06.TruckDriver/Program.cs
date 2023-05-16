using System;

namespace _06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double pricePerKm = 0;
                
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 0.75;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 0.95;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKm = 1.45;
                    }
                    break;
                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 0.90;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 1.10;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKm = 1.45;
                    }
                    break;
                case "Winter":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 1.05;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 1.25;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKm = 1.45;
                    }
                    break;
            }
            double wage = 0.90 * ((pricePerKm * kmPerMonth) * 4);
            Console.WriteLine($"{wage:F2}");
        }
    }
}
