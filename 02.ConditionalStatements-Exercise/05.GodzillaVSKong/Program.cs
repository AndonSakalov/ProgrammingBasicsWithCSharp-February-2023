using System;

namespace _05.GodzillaVSKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double costOfOutfitPerStatist = double.Parse(Console.ReadLine());
            double decor = 0.10 * budget;
            //Calculate the expenses for the movie
            if (statistsCount > 150)
            {
                costOfOutfitPerStatist = costOfOutfitPerStatist - costOfOutfitPerStatist * 0.10;
            }
            double totalExpenses = decor + statistsCount * costOfOutfitPerStatist;
            //Conditional Output
            if (budget >= totalExpenses)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalExpenses:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalExpenses - budget:F2} leva more."); 
            }
            
        }
    }
}
