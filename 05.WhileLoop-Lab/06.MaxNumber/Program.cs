using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int highestNumber = int.MinValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number > highestNumber) 
                {
                    highestNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(highestNumber);
        }
    }
}
