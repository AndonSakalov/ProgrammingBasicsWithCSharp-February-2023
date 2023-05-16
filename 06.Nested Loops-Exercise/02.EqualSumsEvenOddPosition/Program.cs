using System;
using System.Security;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            string allNumbers = string.Empty;
            for (int i = numberOne; i <= numberTwo; i++)
            {
                string currentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                int currentDigit = 0;
                int currentNum = int.Parse(currentNumber.ToString());
                for (int j = 1; j <= currentNumber.Length; j++)
                {                   
                    currentDigit = currentNum % 10;
                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                    currentNum = currentNum / 10;                   
                }
                if (evenSum == oddSum)
                {
                    allNumbers += currentNumber + " ";
                }
            }
            Console.WriteLine(allNumbers);            
        }
    }
}
