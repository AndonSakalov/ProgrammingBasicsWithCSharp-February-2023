using System;

namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritanceMoney = double.Parse(Console.ReadLine());
            int finalYear = int.Parse(Console.ReadLine());
            double moneySpent = 0;
            int currentAge = 18;
            for (int i = 1800; i <= finalYear; i++)
            {
                if (i % 2 != 0) //nech
                {
                    moneySpent += 12000 + 50 * currentAge; 
                }
                else
                {
                    moneySpent += 12000;
                }
                currentAge++;
            }
            if (inheritanceMoney >= moneySpent)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritanceMoney - moneySpent:F2} dollars left."); 
            }
            else
            {
                Console.WriteLine($"He will need {moneySpent - inheritanceMoney:F2} dollars to survive.");
            }
        }
    }
}
