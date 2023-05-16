using System;

namespace _11.OddOrEvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddNumbersSum = 0;
            double evenNumbersSum = 0;
            double minOddNumber = double.MaxValue;
            double minEvenNumber = double.MaxValue;
            double maxOddNumber = double.MinValue;
            double maxEvenNumber = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddNumbersSum += number;
                    if (number < minOddNumber) 
                    {
                        minOddNumber = number;
                    }
                    if (number > maxOddNumber)
                    {
                        maxOddNumber = number;
                    }
                }
                else
                {
                    evenNumbersSum+= number;
                    if (number < minEvenNumber)
                    {
                        minEvenNumber = number;
                    }
                    if (number > maxEvenNumber)
                    {
                        maxEvenNumber = number;
                    }
                }
            }
            //Odd
            Console.WriteLine($"OddSum={oddNumbersSum:F2},");
            if (minOddNumber != double.MaxValue)
            {
                Console.WriteLine($"OddMin={minOddNumber:F2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }
            if (maxOddNumber != double.MinValue)
            {
                Console.WriteLine($"OddMax={maxOddNumber:F2},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }
            //Even 
            Console.WriteLine($"EvenSum={evenNumbersSum:F2},");
            if (minEvenNumber != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={minEvenNumber:F2},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (maxEvenNumber != double.MinValue)
            {
                Console.WriteLine($"EvenMax={maxEvenNumber:F2}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }                        
        }
    }
}
