using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int boxSpace = 0;
            //int boxcounter = 0;
            int apprtmentSpace = width * lenght * height;

            while (command!="Done")
            {
                boxSpace += int.Parse(command);                               
                if (boxSpace>=apprtmentSpace)
                {
                    Console.WriteLine($"No more free space! You need {boxSpace-apprtmentSpace} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
                if (command=="Done")
                {
                    Console.WriteLine($"{apprtmentSpace - boxSpace} Cubic meters left.");
                   
                }                
            }
        }
    }
}
