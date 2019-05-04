using System;

namespace _05._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine("min = " + min);
        }
    }
}
