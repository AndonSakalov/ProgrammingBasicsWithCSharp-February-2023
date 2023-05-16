using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int numbers = 1; numbers <= n && number <= n; numbers++)
            {                
                for (int red = 1; red <= numbers && number <= n; red++)
                {
                    Console.Write($"{number} ");
                    number++;                    
                }
                Console.WriteLine();
            }
        }
    }
}
