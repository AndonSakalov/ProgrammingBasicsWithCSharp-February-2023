using System;

namespace _08.EqualPairsT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentPair = 0;
            bool isTrue = false;
            int maxDiff = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());
                if (numberOne + numberTwo != currentPair && i != 0)
                {
                    isTrue = true;
                    maxDiff = Math.Abs(currentPair - (numberOne + numberTwo));
                }
                currentPair = numberOne + numberTwo;               
            }
            if (!isTrue)
            {
                Console.WriteLine($"Yes, value={currentPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
