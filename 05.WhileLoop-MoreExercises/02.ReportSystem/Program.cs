using System;

namespace _02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededSum = int.Parse(Console.ReadLine());
            int cashPaymentCount = 0; int cardPaymentCount = 0;
            int cashPaymentMoney = 0; int cardPaymentMoney = 0;
            bool isFailed = false;
            int n = 0;
            while (cashPaymentMoney + cardPaymentMoney < neededSum)
            {
                n++;
                string input = Console.ReadLine();
                if (input == "End")
                {
                    isFailed = true;
                    break;
                }
                else
                {
                    int itemCost = int.Parse(input);
                    if (n % 2 != 0) //Cash
                    {
                        if (itemCost > 100) //idk here
                        {
                            Console.WriteLine("Error in transaction!");
                        }
                        else
                        {
                            Console.WriteLine("Product sold!");
                            cashPaymentCount++;
                            cashPaymentMoney += itemCost;
                        }                
                    }
                    else //Credit card
                    {
                        if (itemCost < 10)
                        {
                            Console.WriteLine("Error in transaction!");
                        }
                        else
                        {
                            Console.WriteLine("Product sold!");
                            cardPaymentCount++;
                            cardPaymentMoney += itemCost;
                        }
                    }              
                }
            }
            if (isFailed)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {(double)cashPaymentMoney / cashPaymentCount:F2}");
                Console.WriteLine($"Average CC: {(double)cardPaymentMoney / cardPaymentCount:F2}");
            }
        }
    }
}
