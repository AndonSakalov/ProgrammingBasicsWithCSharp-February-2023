using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetableKilograms = int.Parse(Console.ReadLine());
            int fruitKilograms = int.Parse(Console.ReadLine());

            double priceInLevas = (vegetablePrice * vegetableKilograms) + (fruitPrice * fruitKilograms);
            double priceInEuros = priceInLevas / 1.94;

            Console.WriteLine($"{priceInEuros:f2}");

            
        }
    }
}
