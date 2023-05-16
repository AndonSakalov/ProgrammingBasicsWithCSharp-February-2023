using System;

namespace _02.BeerAndChips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCansCount = int.Parse(Console.ReadLine());
            int packsOfChipsCount = int.Parse(Console.ReadLine());
            double beerCost = beerCansCount * 1.20;
            double chipsCostPerOne = beerCost * 0.45;
            double chipsCost = Math.Ceiling( chipsCostPerOne * packsOfChipsCount);
            double totalCost = beerCost + chipsCost;
            if (budget >= totalCost)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalCost:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {totalCost - budget:F2} more leva!");
            }
        }
    }
}
