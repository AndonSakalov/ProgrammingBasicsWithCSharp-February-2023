using System;

namespace _04.CatFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int catCount = int.Parse(Console.ReadLine());
            int smallCats = 0;
            int bigCats = 0;
            int largeCats = 0;
            double gramsFoodTotal = 0;
            for (int i = 0; i < catCount; i++)
            {
                double gramsFood = double.Parse(Console.ReadLine());
                if (gramsFood >= 100 && gramsFood < 200)
                {
                    smallCats++;
                }
                else if (gramsFood >= 200 && gramsFood < 300)
                {
                    bigCats++;
                }
                else if (gramsFood >= 300 && gramsFood < 400)
                {
                    largeCats++;
                }
                gramsFoodTotal += gramsFood;
            }
            double foodInKg = gramsFoodTotal / 1000.0;
            double foodCost = foodInKg * 12.45;
            Console.WriteLine($"Group 1: {smallCats} cats.");
            Console.WriteLine($"Group 2: {bigCats} cats.");
            Console.WriteLine($"Group 3: {largeCats} cats.");
            Console.WriteLine($"Price for food per day: {foodCost:F2} lv.");
        }
    }
}
