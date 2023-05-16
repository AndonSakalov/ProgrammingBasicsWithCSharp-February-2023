using System;

namespace _08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int totalSum = 0;
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            int maxDiff = 0; 
            for (int i = 1; i <= 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;                
                if (i % 2 == 0)
                {
                    int lastNum = i;
                    totalSum += sum;                    
                    if (sum < minValue)
                    {
                        minValue = sum;
                    }
                    if (sum > maxValue)
                    {
                        maxValue = sum;
                    }
                    maxDiff = maxValue - minValue;
                    sum = 0;                    
                }
       
                if (maxValue - minValue > maxDiff)
                {
                    maxDiff = maxDiff - minValue;                    
                }
                
            }
            if (totalSum % n == 0)
            {
                if (totalSum == 0)
                {
                    Console.WriteLine($"No, maxdiff={(maxDiff)}");

                }
                else
                {
                       Console.WriteLine($"Yes, value={totalSum / n}");
                }     
            }
            else
            {
                Console.WriteLine($"No, maxdiff={(maxDiff)}");
            }
        }
    }
}
