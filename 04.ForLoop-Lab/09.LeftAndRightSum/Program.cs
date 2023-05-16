using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;
            for (int i = 1; i <= n * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    rightSum += number;
                }
                else 
                {
                    leftSum += number;
                }                
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
