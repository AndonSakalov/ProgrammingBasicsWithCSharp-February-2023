using System;

namespace _04.Sequence2kPlus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            while (n >= number)
            {
                Console.WriteLine(number);
                number = 2 * number + 1;
            }
        }
    }
}
