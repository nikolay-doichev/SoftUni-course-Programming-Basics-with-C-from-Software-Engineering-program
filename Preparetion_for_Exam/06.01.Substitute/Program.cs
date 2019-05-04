using System;

namespace _06._01.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberFirstPlayer = int.Parse(Console.ReadLine());
            int secondNumberFirstPlayer = int.Parse(Console.ReadLine());
            int firstNumberSecondPlayer = int.Parse(Console.ReadLine());
            int secondNumberSecondPlayer = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int k = firstNumberFirstPlayer; k <= 8; k++)
            {
                if (k%2!=0)
                {
                    continue;
                }
                for (int l = 9; l >= secondNumberFirstPlayer; l--)
                {
                    if (l%2==0)
                    {
                        continue;
                    }
                    for (int m = firstNumberSecondPlayer; m <= 8; m++)
                    {
                        if (m%2!=0)
                        {
                            continue;
                        }
                        for (int n = 9; n >= secondNumberSecondPlayer; n--)
                        {
                            if (n%2==0)
                            {
                                continue;
                            }
                            if (k==m && l==n)
                            {
                                Console.WriteLine($"Cannot change the same player.");
                                continue;
                            }
                            
                            Console.WriteLine($"{k}{l} - {m}{n}");
                            counter++;
                            if (counter==6)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
