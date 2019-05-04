using System;

namespace _04._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int prevSum = 0;
            int currentSum = 0;
            int maxDiff = 0;
            int currentDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                
                if (i==0)
                {
                    currentSum = firstNumber + secondNumber;
                    prevSum = currentSum;
                    continue;
                }
                prevSum = currentSum;
                currentSum = firstNumber + secondNumber;
                currentDiff = Math.Abs(currentSum - prevSum);

                if (currentDiff>maxDiff)
                {
                    maxDiff = currentDiff;
                }
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
