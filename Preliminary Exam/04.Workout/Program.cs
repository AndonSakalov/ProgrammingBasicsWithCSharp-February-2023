using System;

namespace _04.Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingDaysCount = int.Parse(Console.ReadLine());
            double kilometersRanFirstDay = double.Parse(Console.ReadLine());
            double allKilometersRan = kilometersRanFirstDay;
            double currentKilometers = kilometersRanFirstDay;
            for (int i = 0; i < trainingDaysCount; i++)
            {
                int percentigeIncrease = int.Parse(Console.ReadLine());
                double percentige = percentigeIncrease / 100.0;
                currentKilometers += currentKilometers * percentige;
                allKilometersRan += currentKilometers;
            }
            if (allKilometersRan >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(allKilometersRan - 1000)} more kilometers!");
            }
            else 
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - allKilometersRan)} more kilometers");
            }
        }
    }
}
