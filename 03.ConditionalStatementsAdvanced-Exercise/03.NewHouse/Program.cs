using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double flowersCost = 0;

            switch (flowerType)
            {
                case "Roses":
                    flowersCost = flowerCount * 5;
                    if (flowerCount > 80)
                    {
                        flowersCost = 0.9 * flowersCost; 
                    }
                    break;
                case "Dahlias":
                    flowersCost = flowerCount * 3.80;
                    if (flowerCount > 90)
                    {
                        flowersCost = 0.85 * flowersCost;
                    }
                    break;
                case "Tulips":
                    flowersCost = flowerCount * 2.80;
                    if (flowerCount > 80)
                    {
                        flowersCost = 0.85 * flowersCost;
                    }
                    break;
                case "Narcissus":
                    flowersCost = flowerCount * 3;
                    if (flowerCount < 120)
                    {
                        flowersCost = 1.15 * flowersCost;
                    }
                    break;
                case "Gladiolus":
                    flowersCost = flowerCount * 2.50;
                    if (flowerCount < 80)
                    {
                        flowersCost = 1.20 * flowersCost;
                    }
                    break;

            }
            double absoluteValue = Math.Abs(budget - flowersCost);
            if (budget >= flowersCost)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {absoluteValue:F2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {absoluteValue:F2} leva more.");
            }
           
        }
    }
}
