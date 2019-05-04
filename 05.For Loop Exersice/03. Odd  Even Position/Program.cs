using System;

namespace _03._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double evenSum = 0;
            double oddSum = 0;
            double maxEven = double.MinValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double minOdd = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i%2==0)
                {
                    evenSum += number;
                    if (number>maxEven)
                    {
                        maxEven = number;
                    }
                    if (number<minEven)
                    {
                        minEven = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum},");
            if (minOdd==double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd},");
            }
            if (maxOdd==double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd},");
            }         
            
            Console.WriteLine($"EvenSum={evenSum},");
            if (minEven==double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven},");
            }
            if (maxEven==double.MinValue)
            {
                Console.WriteLine($"EvenMax=No,");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven}");
            }
            
           
        }
    }
}
