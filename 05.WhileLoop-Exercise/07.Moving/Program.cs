using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            int freeSpace = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
            bool isDone = false;
            while (freeSpace > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    isDone = true;
                    break; 
                }
                else
                {
                    int boxSize = int.Parse(input);
                    freeSpace -= boxSize;
                }
            }
            if (isDone)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
        }
    }
}
