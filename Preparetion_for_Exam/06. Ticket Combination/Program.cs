using System;

namespace _06._Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (char a = 'B'; a <= 'L'; a++)
            {
                if (a%2!=0)
                {
                    continue;
                }
                for (char b = 'f'; b >= 'a'; b--)
                {
                    for (char c = 'A'; c <= 'C'; c++)
                    {
                        for (int d = 1; d <= 10; d++)
                        {
                            for (int e = 10; e >= 1; e--)
                            {
                                counter++;
                                if (counter==number)
                                {
                                    sum = a + b + c + d + e;
                                    Console.WriteLine($"Ticket combination: {a}{b}{c}{d}{e}");
                                    Console.WriteLine($"Prize: {sum} lv.");
                                    return;
                                } 
                            }
                        }
                    }
                }
            }
        }
    }
}
