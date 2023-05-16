using System;

namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());
            double transportMoney = 0;
            double ticketPrice = 0;

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                transportMoney = budget * 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                transportMoney = budget * 0.60;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                transportMoney = budget * 0.50;
            }
            else if (peopleCount >= 25 && peopleCount <=49)
            {
                transportMoney = budget * 0.40;
            }
            else if (peopleCount >= 50)
            {
                transportMoney = budget * 0.25;
            }

            if (transportMoney != 0)
            {
                if (ticketCategory == "VIP")
                {
                    ticketPrice = 499.99;
                }
                else if (ticketCategory == "Normal")
                {
                    ticketPrice = 249.99;
                }
                double moneyLeft = budget - transportMoney;
                if (moneyLeft >= ticketPrice * peopleCount)
                {
                    Console.WriteLine($"Yes! You have {moneyLeft - (ticketPrice * peopleCount):F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {(ticketPrice * peopleCount) - moneyLeft:F2} leva.");
                }
            }
        }
    }
}
