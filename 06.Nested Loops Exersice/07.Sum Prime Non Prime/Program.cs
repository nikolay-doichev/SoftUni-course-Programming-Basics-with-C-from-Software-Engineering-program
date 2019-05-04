using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeNums = 0;
            double nonPrimeNums = 0;

            for (int i = 0; ; i++)
            {
                string input = Console.ReadLine();
                bool isPrime = true;
                if (input=="stop")
                {
                    break;
                }
                double num = double.Parse(input);
                if (num<0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    if (num<2)
                    {
                        nonPrimeNums += num;
                    }
                    for (int j = 2; j < num; j++)
                    {
                        if (num%j==0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime==true)
                    {
                        primeNums += num;
                    }
                    else
                    {
                        nonPrimeNums += num;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNums}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNums}");
        }
    }
}
