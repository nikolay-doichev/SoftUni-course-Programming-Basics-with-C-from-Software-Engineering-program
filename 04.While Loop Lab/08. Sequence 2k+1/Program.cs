using System;

namespace _08._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            

            while (sum<=number)
            {
                Console.WriteLine(sum);
                sum = 2 * sum + 1;
                
            }
        }
    }
}
