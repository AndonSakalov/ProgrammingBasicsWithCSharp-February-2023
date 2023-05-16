using System;

namespace _06.GoldMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int locationsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < locationsCount; i++)
            {
                double expectedDailyGold = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double allGold = 0;
                for (int j = 0; j < days; j++)
                {
                    double goldThisDay = double.Parse(Console.ReadLine());
                    allGold += goldThisDay;
                }
                double averageGoldDaily = allGold / days;
                if (averageGoldDaily >= expectedDailyGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldDaily:F2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedDailyGold - averageGoldDaily:F2} gold.");
                }
            }
        }
    }
}
