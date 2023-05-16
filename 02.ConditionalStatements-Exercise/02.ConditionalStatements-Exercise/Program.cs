using System;

namespace _02.ConditionalStatements_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int firstCompetitor = int.Parse(Console.ReadLine());    
            int secondCompetitor = int.Parse(Console.ReadLine());    
            int thirdCompetitor = int.Parse(Console.ReadLine());    
            //Calculations
            int totalTimeInSeconds = firstCompetitor + secondCompetitor + thirdCompetitor;
            //mins
            int minutes = totalTimeInSeconds / 60;
            //seconds
            int seconds = totalTimeInSeconds % 60;
            //Output
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}" );
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
