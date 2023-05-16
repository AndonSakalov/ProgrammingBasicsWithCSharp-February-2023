using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsParticipation = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int allPoints = initialPoints;
            int tournamentsWon = 0;
            for (int i = 0; i < tournamentsParticipation; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    allPoints += 2000;
                    tournamentsWon++;
                }
                else if (result == "F")
                {
                    allPoints += 1200;
                }
                else if (result == "SF")
                {
                    allPoints += 720;
                }
            }
            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {(allPoints - initialPoints) / tournamentsParticipation}");
            Console.WriteLine($"{(double) tournamentsWon / tournamentsParticipation * 100:F2}%");
        }
    }
}
