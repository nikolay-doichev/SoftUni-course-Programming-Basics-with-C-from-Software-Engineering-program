using System;

namespace _06._Divane_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int divadeBy2 = 0;
            int divadeBy3 = 0;
            int divadeBy4 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number%2 == 0)
                {
                    divadeBy2++;
                }
                if (number%3 == 0)
                {
                    divadeBy3++;
                }
                if (number%4==0)
                {
                    divadeBy4++;
                }
            }
            Console.WriteLine($"{(divadeBy2*100.0/n):F2}%");
            Console.WriteLine($"{(divadeBy3*100.0/n):F2}%");
            Console.WriteLine($"{(divadeBy4*100.0/n):F2}%");
        }
    }
}
