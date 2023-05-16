using System;

namespace _02.BraceletStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double totalExpenses = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            double allSavedMoney = pocketMoney * 5 + moneyPerDay * 5 - totalExpenses;
            
            if (allSavedMoney > presentPrice)
            {
                Console.WriteLine($"Profit: {allSavedMoney:F2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {Math.Abs(presentPrice - allSavedMoney):F2} BGN.");
            }
        }
    }
}
