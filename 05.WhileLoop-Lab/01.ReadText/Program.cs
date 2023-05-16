using System;

namespace _01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            while (name != "Stop")
            {
                Console.WriteLine(name);
                name = Console.ReadLine();
            }
        }
    }
}
