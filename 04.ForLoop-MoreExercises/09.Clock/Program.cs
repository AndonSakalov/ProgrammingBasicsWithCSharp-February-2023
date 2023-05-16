using System;

namespace _09.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int hour = 0; hour < 24; hour++)
            {               
                for (int minute = 0; minute <= 59; minute++)
                {
                    Console.WriteLine($"{hour} : {minute}");
                }               
            }
        }
    }
}
