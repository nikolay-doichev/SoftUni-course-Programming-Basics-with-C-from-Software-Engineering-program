using System;

namespace _04._Everest
{
    class Program
    {
        static void Main(string[] args)
        {           
            int counterDays = 1;
            int meterSum = 5364;


            while (true)
            {
                string rest = Console.ReadLine();
                if (rest=="END")
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{meterSum}");
                    return;
                }
                int metersClimb = int.Parse(Console.ReadLine());
                if (rest=="Yes")
                {
                    counterDays++;                
                    if (counterDays>5)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine($"{meterSum}");
                        return;
                    }
                    meterSum += metersClimb;
                }
                if (rest=="No")
                {
                    meterSum += metersClimb;
                }
                if (meterSum>= 8848)
                {
                    Console.WriteLine($"Goal reached for {counterDays} days!");
                    return;
                }
            }
        }
    }
}
