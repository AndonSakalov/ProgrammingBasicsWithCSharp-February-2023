using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());   
            int monthsOfDeposit = int.Parse(Console.ReadLine());    
            double yearlyInterest = double.Parse(Console.ReadLine());                                                     

            double sum = depositSum + monthsOfDeposit * ((depositSum * yearlyInterest * 0.01) / 12);
            Console.WriteLine(sum);
            
        }
    }
}
