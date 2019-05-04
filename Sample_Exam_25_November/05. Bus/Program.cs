using System;

namespace _05._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPassengers = int.Parse(Console.ReadLine());
            int numberOfStops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfStops; i++)
            {
                int numberOfLeft = int.Parse(Console.ReadLine());
                int numberOfCame = int.Parse(Console.ReadLine());
                if (i%2!=0)
                {
                    numberOfPassengers += 2;
                }
                else if (i%2==0)
                {
                    numberOfPassengers -= 2;
                }
                numberOfPassengers = numberOfPassengers + (-numberOfLeft + numberOfCame);                
            }
            Console.WriteLine($"The final number of passengers is : { numberOfPassengers}");
        }
    }
}
