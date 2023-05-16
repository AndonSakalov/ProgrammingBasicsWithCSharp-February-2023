using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int numbers = 0;
            int number = int.Parse(Console.ReadLine());
            numbers += number;
            while (maxNumber > numbers)
            { 
                number = int.Parse(Console.ReadLine());
                numbers += number;
            }
            Console.WriteLine(numbers);
        }
    }
}
