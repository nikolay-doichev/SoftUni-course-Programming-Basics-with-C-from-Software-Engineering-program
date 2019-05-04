using System;

namespace Programic_and_Basic_Online_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double pencils = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double washingUp = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double sum = 5.8 * pencils + 7.2 * markers + 1.2 * washingUp;
            double sumWithDiscaunt = sum - ((sum * discount) / 100);
            Console.WriteLine($"{sumWithDiscaunt:f3}");

        }
    }
}
