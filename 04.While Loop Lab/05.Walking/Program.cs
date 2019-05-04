using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int stepsMake = 0;
            int stepsMakeGoHome = 0;
            int leftSteps = 0;

            while (true)
            {
                string command = Console.ReadLine();                
                if (command == "Going home")
                {
                    int stepsForGoHome = int.Parse(Console.ReadLine());
                    stepsMakeGoHome = stepsMake + stepsForGoHome;
                    if (stepsMakeGoHome>=10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    leftSteps = 10000 - stepsMakeGoHome;
                    Console.WriteLine($"{leftSteps} more steps to reach goal.");
                    break;
                }
                else
                {
                    int steps = int.Parse(command);
                    stepsMake += steps;
                    if (stepsMake>=10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                }
            }
            
        }
    }
}
