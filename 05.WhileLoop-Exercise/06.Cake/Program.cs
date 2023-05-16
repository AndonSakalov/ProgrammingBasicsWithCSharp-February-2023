using System;
using System.Diagnostics;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int totalPieces = cakeLength * cakeWidth;
            int cake = cakeLength * cakeWidth;
            bool isStopped = false;
            while (totalPieces > 0)
            {
                string pieces = Console.ReadLine();
                if (pieces == "STOP")
                {
                    isStopped = true;
                    break;
                }
                else
                {
                    int pieceNumber = int.Parse(pieces);
                    totalPieces -= pieceNumber;
                }
            }
            if (isStopped)
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
        }
    }
}
