using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneySpent = 0;
            string destination = string.Empty;
            string tripType = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                
                if (season == "summer")
                {
                    moneySpent = 0.3 * budget;
                    tripType = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpent = 0.7 * budget;
                    tripType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    moneySpent = 0.4 * budget;
                    tripType = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpent = 0.8 * budget;
                    tripType = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                moneySpent = budget * 0.9;
                tripType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{tripType} - {moneySpent:F2}");
        }        
    }
}
