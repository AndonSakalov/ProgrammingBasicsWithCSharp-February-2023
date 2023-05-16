using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double tripCost = double.Parse(Console.ReadLine()); 
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int teddyBearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            //Calculate price
            double totalCost = puzzleCount * 2.60 + dollCount * 3 + teddyBearCount * 4.10 + minionCount * 8.20 + truckCount * 2;
            int toyCount = puzzleCount + dollCount + teddyBearCount + minionCount + truckCount;
            if (toyCount >= 50)
            {
                totalCost = totalCost - totalCost * 0.25; 
            }
            
            //Extract rent money and find final money
            double finalMoney = totalCost - totalCost * 0.10;

            //Output-Y/N
            if (finalMoney >= tripCost)
            {
                Console.WriteLine($"Yes! {finalMoney-tripCost:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripCost-finalMoney:F2} lv needed.");
            }

        }
    }
}
