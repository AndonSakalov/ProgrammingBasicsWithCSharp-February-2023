using System;

namespace _01.ChristmasPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wrappingPaperCount = int.Parse(Console.ReadLine());
            int clothCount = int.Parse(Console.ReadLine());
            double glueLiters = double.Parse(Console.ReadLine());
            int discountPercentige = int.Parse(Console.ReadLine());

            double wrappingPaperPrice = 5.80;
            double clothPrice = 7.20;
            double gluePrice = 1.20;

            double priceWithoutDiscount = wrappingPaperPrice * wrappingPaperCount + clothPrice * clothCount + glueLiters * gluePrice;
            double discount = discountPercentige / 100.0;
            double priceWithDiscount = priceWithoutDiscount - (priceWithoutDiscount * discount);
            Console.WriteLine($"{priceWithDiscount:F3}");
        }
    }
}
