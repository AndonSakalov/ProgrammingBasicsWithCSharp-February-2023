using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string income = Console.ReadLine();
            double totalSum = 0;
            while (income != "NoMoreMoney")
            {               
                double sum = double.Parse(income);
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {sum:F2}");
                totalSum += sum;
                income = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalSum:F2}");
        }
    }
}
