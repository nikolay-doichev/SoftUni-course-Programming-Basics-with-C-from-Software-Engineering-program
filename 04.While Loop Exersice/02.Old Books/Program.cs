using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int bookCount = 0;

            bool findTheBook = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input==book)
                {
                    findTheBook = true;
                    break;
                }
                bookCount++;
                if (capacity == bookCount)
                {
                    break;
                }
            }
            if (findTheBook)
            {
                Console.WriteLine($"You checked {bookCount} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
        }
    }
}
