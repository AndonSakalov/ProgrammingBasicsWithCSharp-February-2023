using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sum = pens * 5.80 + markers * 7.20 + cleaner * 1.20;
            double finalSum = sum - (discount * 0.01 * sum);
            Console.WriteLine(finalSum);

        }
    }
}
