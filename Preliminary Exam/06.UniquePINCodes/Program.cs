using System;

namespace _06.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimitN1 = int.Parse(Console.ReadLine());
            int upperLimitN2 = int.Parse(Console.ReadLine());
            int upperLimitN3 = int.Parse(Console.ReadLine());
            for (int i1 = 1; i1 <= upperLimitN1; i1++)
            {
                if (i1 % 2 == 0)
                {
                    for (int i2 = 1; i2 <= upperLimitN2; i2++)
                    {
                        if (i2 == 2 || i2 == 3 || i2 == 5 || i2 == 7)
                        {
                            for (int i3 = 1; i3 <= upperLimitN3; i3++)
                            {
                                if (i3 % 2 == 0)
                                {
                                    Console.WriteLine($"{i1} {i2} {i3}");
                                }
                            }
                        }
                    }
                }
            }            
        }
    }
}
