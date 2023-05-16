using System;

namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double orderCost = magnoliasCount * 3.25 + hyacinthsCount * 4 + rosesCount * 3.50 + cactusesCount * 8;
            double orderProfit = orderCost * 0.95;

            if (presentPrice <= orderProfit)
            {
                Console.WriteLine($"She is left with {Math.Floor(orderProfit - presentPrice)} leva.");
            }
            else 
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - orderProfit)} leva.");
            }

            
        }
    }
}
