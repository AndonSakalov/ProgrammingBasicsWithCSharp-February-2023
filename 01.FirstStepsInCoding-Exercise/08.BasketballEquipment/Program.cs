using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyCost = int.Parse(Console.ReadLine());

            double shoeCost = 0.60 * yearlyCost;
            double outfitCost = 0.80 * shoeCost;
            double basketBallCost = 0.25 * outfitCost;
            double accessoriesCost = 0.20 * basketBallCost;

            double totalCost = yearlyCost + shoeCost + outfitCost + basketBallCost + accessoriesCost;

            Console.WriteLine(totalCost);
        }
    }
}
