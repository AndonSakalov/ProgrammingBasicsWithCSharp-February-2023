using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (startingPoints <= 100)
            {
                bonusPoints += 5;
            }
            else if (startingPoints > 100 && startingPoints <= 1000)
            {
                bonusPoints = bonusPoints + 0.20 * startingPoints;
            }
            else if (startingPoints > 1000)
            {
                bonusPoints = bonusPoints + 0.10 * startingPoints;
            }
           
            if (startingPoints % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            if (startingPoints % 2 == 0)
            {
                bonusPoints++;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(startingPoints + bonusPoints);
        }
    }
}
