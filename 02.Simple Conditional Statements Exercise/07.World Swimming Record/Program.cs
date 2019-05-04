using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeFor1Meter = double.Parse(Console.ReadLine());

            double allTheSeconds = distanceInMeters * timeFor1Meter;
            double waterResistence = Math.Floor(distanceInMeters / 15);
            double resistenceTime = Math.Floor(waterResistence) * 12.5;
            double wholeTime = allTheSeconds + resistenceTime;

            if (wholeTime<recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {wholeTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(wholeTime-recordInSeconds):F2} seconds slower.");
            }
        }
    }
}
