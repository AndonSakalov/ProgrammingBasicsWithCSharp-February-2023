using System;

namespace _04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carType = string.Empty;
            string carClass = string.Empty;
            double carCost = 0;
            switch (season) 
            {
                case "Summer":
                    if (budget <= 100)
                    {
                        carType = "Cabrio";
                        carClass = "Economy class";
                        carCost = 0.35 * budget;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        carType = "Cabrio";
                        carClass = "Compact class";
                        carCost = 0.45 * budget;
                    }
                    else
                    {
                        carType = "Jeep";
                        carClass = "Luxury class";
                        carCost = 0.90 * budget;
                    }
                    break;

                case "Winter":
                    if (budget <= 100)
                    {
                        carType = "Jeep";
                        carClass = "Economy class";
                        carCost = 0.65 * budget;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        carType = "Jeep";
                        carClass = "Compact class";
                        carCost = 0.80 * budget;
                    }
                    else
                    {
                        carType = "Jeep";
                        carClass = "Luxury class";
                        carCost = 0.90 * budget;
                    }
                    break;
            }
            if (carType != string.Empty)
            {
                Console.WriteLine(carClass);
                Console.WriteLine($"{carType} - {carCost:F2}");
            }

        }
    }
}
