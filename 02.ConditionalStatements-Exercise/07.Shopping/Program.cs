using System;
using System.Runtime.ConstrainedExecution;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int GPUCount = int.Parse(Console.ReadLine());  
            int CPUCount = int.Parse(Console.ReadLine());    
            int RAMCount = int.Parse(Console.ReadLine());
            int GPUCost = GPUCount * 250;
            double CPUPrice = 0.35 * GPUCost;
            double RAMPrice = 0.10 * GPUCost;
            double finalPrice = GPUCost + CPUPrice * CPUCount + RAMPrice * RAMCount;
            
            if (GPUCount > CPUCount)
            {
                finalPrice = finalPrice - finalPrice * 0.15;
            }

            if (finalPrice <= budget)
            {
                Console.WriteLine($"You have {budget - finalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice - budget:F2} leva more!");
            }

        }
    }
}
