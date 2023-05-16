using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lowestNumber = int.MaxValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number < lowestNumber)
                {
                    lowestNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(lowestNumber);
        }
    }
}
