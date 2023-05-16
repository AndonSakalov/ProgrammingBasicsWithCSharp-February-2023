using System;
using System.Diagnostics;

namespace _05.ExcursionSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaExcursions = int.Parse(Console.ReadLine());
            int mountainExcursions = int.Parse(Console.ReadLine());
            string typeOfExcursion = Console.ReadLine();
            double seaExcursionPrice = 680;
            double mountainExcusionPrice = 499;
            double totalMoney = 0;
            bool isSold = false;
            while (typeOfExcursion != "Stop")
            {
                if (typeOfExcursion == "sea")
                {
                    if (seaExcursions > 0)
                    {
                        totalMoney += seaExcursionPrice;
                        seaExcursions--;
                    }            
                }
                else if (typeOfExcursion == "mountain")
                {
                    if (mountainExcursions > 0)
                    {
                        totalMoney += mountainExcusionPrice;
                        mountainExcursions--;
                    }
                }
                if (seaExcursions == 0 && mountainExcursions == 0)
                {
                    isSold = true;  
                    break;
                }
                typeOfExcursion = Console.ReadLine();
            }
            if (isSold)
            {
                Console.WriteLine("Good job! Everything is sold.");
                Console.WriteLine($"Profit: {totalMoney} leva.");
            }
            else 
            {
                Console.WriteLine($"Profit: {totalMoney} leva.");
            }
        }
    }
}
