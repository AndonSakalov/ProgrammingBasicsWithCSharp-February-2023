using System;

namespace _05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0; int zeroToNine = 0; int tenToNineteen = 0; int twentyToTwentynine = 0; int thirtyToThirtynine = 0;
            int fortyToFifty = 0; int invalid = 0;
            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 50)
                {
                    invalid++;
                    result /= 2;
                }
                else if (number >= 0 && number <=9)
                {
                    zeroToNine++;
                    result += 0.2 * number;
                }
                else if (number <= 19)
                {
                    tenToNineteen++;
                    result += 0.3 * number;
                }
                else if (number <= 29)
                {
                    twentyToTwentynine++;
                    result += 0.4 * number;
                }
                else if (number <= 39)
                {
                    thirtyToThirtynine++;
                    result += 50;
                }
                else
                {
                    fortyToFifty++;
                    result += 100;
                }
            }
            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {(double) zeroToNine / moves * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {(double) tenToNineteen / moves * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {(double) twentyToTwentynine / moves * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {(double) thirtyToThirtynine / moves * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {(double) fortyToFifty / moves * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {(double) invalid / moves * 100:F2}%");
        }
    }
}
