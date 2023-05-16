using System;

namespace _10.Clock_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int minute = 0; minute <= 59; minute++)
                {
                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        Console.WriteLine($"{hour} : {minute} : {seconds}");
                    }
                }
            }
        }
    }
}
