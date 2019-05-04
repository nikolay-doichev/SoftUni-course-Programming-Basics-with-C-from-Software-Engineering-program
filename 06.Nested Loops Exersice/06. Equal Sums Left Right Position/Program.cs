using System;

namespace _06._Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int current = i;
                int rightSum = 0;
                int leftSum = 0;
                int middleSum = 0;
                for (int j = 1; j <= 5; j++)
                {
                    if (j<3)
                    {
                        rightSum += current % 10;
                    }
                    else if (j==3)
                    {
                        middleSum += current % 10;
                    }
                    else
                    {
                        leftSum += current % 10;
                    }
                    current /= 10;
                }
                if (leftSum==rightSum)
                {
                    Console.Write(i + " ");
                }
                else if (leftSum<rightSum)
                {
                    if (leftSum+middleSum == rightSum)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if (rightSum + middleSum == leftSum)
                    {
                        Console.Write(i + " ");
                    }
                    
                }
                
            }
        }
    }
}
