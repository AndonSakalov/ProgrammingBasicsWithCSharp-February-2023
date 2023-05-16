using System;

namespace _01.RoomPainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paintCansCount = int.Parse(Console.ReadLine());
            int tapetRollsCount = int.Parse(Console.ReadLine());
            double glovesCost = double.Parse(Console.ReadLine());   
            double brushCost = double.Parse(Console.ReadLine());
            double paintCanCost = 21.50;
            double tapetRollCost = 5.20;
            double glovesCount = Math.Ceiling(0.35 * tapetRollsCount);
            double brushCount = Math.Floor(0.48 * paintCansCount);
            double deliveryCost = 1 / 15.0;
            double allCost = paintCansCount * paintCanCost + glovesCost * glovesCount + brushCost * brushCount + tapetRollsCount * tapetRollCost;
            double delivery = deliveryCost * allCost;
            Console.WriteLine($"This delivery will cost {delivery:F2} lv.");
        }
    }
}
