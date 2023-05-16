using System;

namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            double detergentInMl = detergentBottles * 750;
            int detergentNeededForPlate = 5;
            int detergentNeededForPot = 15;
            int thirdTime = 0;
            int platesCount = 0;
            int potsCount = 0;
            bool isEnough = false;
            while (detergentInMl >= 0)
            {
                thirdTime++;
                string input = Console.ReadLine();
                if (input == "End")
                {
                    isEnough = true;
                    break;
                }
                else
                {
                    int utensils = int.Parse(input);
                    if (thirdTime % 3 == 0)
                    {
                        detergentInMl -= utensils * detergentNeededForPot;
                        potsCount += utensils;
                    }
                    else
                    {
                        detergentInMl -= utensils * detergentNeededForPlate;
                        platesCount += utensils;
                    }
                }
            }
            if (isEnough)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{platesCount} dishes and {potsCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentInMl} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergentInMl)} ml. more necessary!");
            }
        }
    }
}
