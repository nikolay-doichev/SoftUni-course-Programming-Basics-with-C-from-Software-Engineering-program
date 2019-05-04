using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cake = lenght * width;

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command!="STOP")
                {
                    cake -= int.Parse(command);
                }
                else
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    break;
                }
                if (cake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    break;
                }

            }
        }
    }
}
