using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerOneMeter = double.Parse(Console.ReadLine());
            double waterResistanceInSeconds = Math.Floor(meters / 15) * 12.5;
            
            //Calculate how much time took Ivan to try to beat the world record
            double ivanTime = meters * secondsPerOneMeter + waterResistanceInSeconds;

            //Conditional output
            if (ivanTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivanTime - worldRecord:F2} seconds slower.");
            }
        }
    }
}
