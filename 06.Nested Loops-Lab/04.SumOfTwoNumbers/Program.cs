using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool isFound = false;
            int combinations = 0;
            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    combinations++;
                    if (i + j == magicNumber)
                    {   
                        isFound = true;
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        break;
                    }                    
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
