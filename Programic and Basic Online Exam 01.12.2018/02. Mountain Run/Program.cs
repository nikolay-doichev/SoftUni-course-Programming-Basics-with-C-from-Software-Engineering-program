using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double climbingTime = double.Parse(Console.ReadLine());

            double georgiTime = distanceInMeters * climbingTime;
            double slowingTime = Math.Floor((distanceInMeters / 50)) * 30;
            double totalTime = georgiTime + slowingTime;

            if (totalTime<recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime-recordInSeconds:F2} seconds slower.");
            }

        }
    }
}
