using System;
using System.Xml.Linq;

namespace _05.GreetingByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете от конзолата текст(име на човек) 
            //и отпечатва "Hello, <name>!", където<name> е въведеното име от конзолата.
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
