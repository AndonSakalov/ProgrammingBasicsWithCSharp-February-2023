using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string pass = Console.ReadLine();
            while (pass != password)
            {
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
