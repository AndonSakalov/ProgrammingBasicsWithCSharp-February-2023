using System;

namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodPerDayKg = double.Parse(Console.ReadLine());
            double catFoodPerDayKg = double.Parse(Console.ReadLine());
            double turtleFoodPerDayGr = double.Parse(Console.ReadLine());
            double turtleFoodPerDayKg = turtleFoodPerDayGr / 1000;

            double dogFoodNeeded = dogFoodPerDayKg * days;
            double catFoodNeeded = catFoodPerDayKg * days;
            double turtleFoodNeeded = turtleFoodPerDayKg * days;
            double foodNeeded = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;
            if (food >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(food - foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - food)} more kilos of food are needed.");
            }
            
        }
    }
}
