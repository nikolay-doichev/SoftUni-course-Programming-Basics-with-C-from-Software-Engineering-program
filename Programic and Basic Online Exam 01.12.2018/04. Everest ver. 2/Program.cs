using System;

namespace _04._Everest_ver._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startClimb = 5364;
            int counterDays = 1;
            string rest = Console.ReadLine();  

            while (rest!="END")
            {
                int climbMeters = int.Parse(Console.ReadLine());
                
                if (rest=="Yes")
                {
                    counterDays++;
                    if (counterDays>=5)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine($"{startClimb}");
                        return;
                    }
                    startClimb += climbMeters;
                }
                if (rest=="No")
                {
                    startClimb += climbMeters;
                }
                if (startClimb>=8848)
                {
                    Console.WriteLine($"Goal reached for {counterDays} days!");
                    return;
                }
                rest = Console.ReadLine();
            }
            if (startClimb>=8848)
            {
                Console.WriteLine($"Goal reached for {counterDays} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{startClimb}");
            }
        }
    }
}
