using System;

namespace For_Loop_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < number; i++)
            {
                double sungleNumber = double.Parse(Console.ReadLine());
                sum += sungleNumber;

            }
            Console.WriteLine(sum);
        }        
        
    }
}
