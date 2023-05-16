using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeNumbers = 0;
            int nonPrimeNumbers = 0;
            while (input != "stop")
            {
                int currentNumber = int.Parse(input);
                bool isPrime = true;
                double upperLimit = Math.Sqrt(currentNumber);
                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i <= upperLimit; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (!isPrime)
                    {
                        nonPrimeNumbers += currentNumber;
                    }
                    else
                    {
                        primeNumbers += currentNumber;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbers}");
        }
    }
}
