using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xVineYard = int.Parse(Console.ReadLine());
            double yGrapesPerSqrM = double.Parse(Console.ReadLine());
            double zLitersWineNeeded = double.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            double harvest = (yGrapesPerSqrM * xVineYard) * 0.4;
            double litersWine = harvest / 2.5;

            if (litersWine >= zLitersWineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersWine - zLitersWineNeeded)} liters left -> {Math.Ceiling((litersWine - zLitersWineNeeded) / workersCount)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(zLitersWineNeeded - litersWine)} liters wine needed.");
            }
        }
    }
}
