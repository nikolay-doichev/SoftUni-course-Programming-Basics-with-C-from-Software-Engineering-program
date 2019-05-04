using System;

namespace _05._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int numberTo200 = 0;
            int numbersFrom200To399 = 0;
            int numbersFrom400To599 = 0;
            int numbersFrom600To799 = 0;
            int numbers800 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    numberTo200++;
                }
                else if (number<400)
                {
                    numbersFrom200To399++;
                }
                else if (number<600)
                {
                    numbersFrom400To599++;
                }
                else if (number<800)
                {
                    numbersFrom600To799++;
                }
                else
                {
                    numbers800++;
                }
            }
            Console.WriteLine($"{(numberTo200 * 100.0 / n):F2}%");
            Console.WriteLine($"{(numbersFrom200To399 * 100.0 / n):F2}%");
            Console.WriteLine($"{(numbersFrom400To599 * 100.0 / n):F2}%");
            Console.WriteLine($"{(numbersFrom600To799 * 100.0 / n):F2}%");
            Console.WriteLine($"{(numbers800 * 100.0 / n):F2}%");

        }
    }
}
