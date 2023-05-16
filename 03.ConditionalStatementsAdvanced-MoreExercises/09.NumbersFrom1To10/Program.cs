using System;

namespace _09.NumbersFrom1To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            do
            { 
                Console.WriteLine(num++); 
            } 
            while 
            (num >= 0 && num <= 10);
        }
    }
}
