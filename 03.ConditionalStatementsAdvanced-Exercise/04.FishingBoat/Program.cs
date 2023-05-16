using System;
using System.Security;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMen = int.Parse(Console.ReadLine());
            double moneyRequared = 0;
           
            switch (season)
            {
                case "Spring":
                    moneyRequared = 3000;
                    if (fisherMen <= 6)
                    {
                        moneyRequared = moneyRequared * 0.90;
                    }
                    else if (fisherMen <= 11)
                    {
                        moneyRequared = moneyRequared * 0.85;
                    }
                    else if (fisherMen >= 12) 
                    {
                        moneyRequared = moneyRequared * 0.75;
                    }
                    break;

                case "Summer":
                case "Autumn":
                    moneyRequared = 4200;
                    if (fisherMen <= 6)
                    {
                        moneyRequared = moneyRequared * 0.90;
                    }
                    else if (fisherMen <= 11)
                    {
                        moneyRequared = moneyRequared * 0.85;
                    }
                    else if (fisherMen >= 12)
                    {
                        moneyRequared = moneyRequared * 0.75;
                    }
                    break;

                case "Winter":
                    moneyRequared = 2600;
                    if (fisherMen <= 6)
                    {
                        moneyRequared = moneyRequared * 0.90;
                    }
                    else if (fisherMen <= 11)
                    {
                        moneyRequared = moneyRequared * 0.85;
                    }
                    else if (fisherMen >= 12)
                    {
                        moneyRequared = moneyRequared * 0.75;
                    }
                    break;
            }
            if (fisherMen % 2 == 0 && season != "Autumn")
            {
                moneyRequared = moneyRequared * 0.95;
            }
            double moneyLeftOrNeeded = Math.Abs(budget - moneyRequared);
            if (budget >= moneyRequared)
            {
                Console.WriteLine($"Yes! You have {moneyLeftOrNeeded:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {moneyLeftOrNeeded:F2} leva.");
            }

        }
    }
}
