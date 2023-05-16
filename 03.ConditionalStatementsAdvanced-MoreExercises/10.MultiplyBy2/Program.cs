using System;

namespace _10.MultiplyBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            do 
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
                Console.WriteLine($"Result: {number * 2:F2}");
                num += number;   
            } 
            while (num >= 0);
        }
    }
}
