using System;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int debitPipe1 = int.Parse(Console.ReadLine());
            int debitPipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double poolLevel = debitPipe1 * hours + debitPipe2 * hours;
            if (poolLevel <= v)
            {
                Console.WriteLine($"The pool is {poolLevel / v * 100}% full. Pipe 1: {(debitPipe1 * hours) / poolLevel * 100.0}%. Pipe 2: {(debitPipe2 * hours) / poolLevel * 100.0}%.");
            }
            else 
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {poolLevel - v} liters.");
            }
        }//660 / 1000 * 0,01
    }
}
