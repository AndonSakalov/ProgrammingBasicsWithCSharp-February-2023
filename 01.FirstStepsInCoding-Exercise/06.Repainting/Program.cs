using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double paintCost = 1.1 * paint * 14.50;
            double nylonCost = (2 + nylon) * 1.50;
            double diluentCost = diluent * 5.00;

            double materialCost = paintCost + nylonCost + diluentCost + 0.40;
            double workersWage = materialCost * hoursNeeded * 0.30;
            double totalSum = materialCost + workersWage;

            Console.WriteLine(totalSum);
        }
    }
}
