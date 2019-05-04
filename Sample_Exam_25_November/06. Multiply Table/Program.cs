using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            int firstNumber = Number % 10;
            int middleNumber = (Number - firstNumber) / 10 % 10;
            int thirtNumber = (Number - middleNumber) / 100;
            int sum = 0;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= middleNumber; j++)
                {
                    for (int k = 1; k <= thirtNumber; k++)
                    {
                        sum = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {sum};");
                    }
                }
            }
        }
    }
}
