using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isFound = false;
            string searchedBook = Console.ReadLine();
            string bookName = Console.ReadLine();
            int booksSearched = 0;
            while (bookName != "No More Books")
            {
                if (bookName == searchedBook)
                {
                    isFound = true;
                    break;
                }
                booksSearched++;
                bookName = Console.ReadLine();
            }
            if (isFound == true)
            {
                Console.WriteLine($"You checked {booksSearched} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksSearched} books.");
            }
        }
    }
}
