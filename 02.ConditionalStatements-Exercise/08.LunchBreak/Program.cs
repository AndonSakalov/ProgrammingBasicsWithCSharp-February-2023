using System;
using System.Diagnostics;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string seriesName = Console.ReadLine();
            int seriesDuration = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());
            double restAndEat = (lunchBreak * 0.125) + (0.25 * lunchBreak);
            //Calculations
            double freeTime = lunchBreak - restAndEat;
            //Conditional output
            if (freeTime >= seriesDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(lunchBreak - (seriesDuration + restAndEat))} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling((seriesDuration + restAndEat) - lunchBreak)} more minutes.");
            }
        }
    }
}
