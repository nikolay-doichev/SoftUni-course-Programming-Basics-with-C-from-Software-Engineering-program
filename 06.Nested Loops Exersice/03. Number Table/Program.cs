using System;

namespace _03._Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;

            for (int row = 0; row < n; row++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    current = row + cols + 1;
                    if (current>n)
                    {
                        current = 2 * n - current;
                    }
                    Console.Write(current + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
