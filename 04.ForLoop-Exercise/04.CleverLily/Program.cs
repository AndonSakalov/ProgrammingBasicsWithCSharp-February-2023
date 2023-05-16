using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double savedMoney = 0;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toys++; 
                }
                else
                {
                    savedMoney += i / 2 * 10;
                    savedMoney -= 1;
                }
            }
            double allMoney = savedMoney + (toys * toyPrice);
            if (allMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {allMoney - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - allMoney:F2}");
            }
            
        }
    }
}
