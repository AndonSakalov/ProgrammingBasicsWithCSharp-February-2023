using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1110; i <= 9999; i++)
            {
                bool isSpecial = true;
                int number = i;
                for (int j = 0; j < 4; j++)
                {
                  
                    int currentNum = 0;
                    currentNum = number % 10;
                    if (currentNum == 0 || n % currentNum != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    number /= 10;
                }
                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
            
        }
    }
}
