using System;

namespace Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupMilliters = int.Parse(Console.ReadLine());
            int Easy = 50;
            int Medium = 100;
            int Hard = 200;
            int counter = 0;
            int sumMilliters = 0;

            while (true)
            {
                string botten = Console.ReadLine();
                if (botten=="Easy")
                {
                    sumMilliters += Easy;
                }
                else if (botten=="Medium")
                {
                    sumMilliters += Medium;
                }
                else if (botten== "Hard")
                {
                    sumMilliters += Hard;
                }                
                counter++;
                if (sumMilliters==cupMilliters)
                {
                    Console.WriteLine($"The dispenser has been tapped {counter} times.");
                    break;
                }
                else if (sumMilliters>cupMilliters)
                {
                    Console.WriteLine($"{sumMilliters-cupMilliters}ml has been spilled.");
                    break;
                }

            }
            
        }
    }
}
