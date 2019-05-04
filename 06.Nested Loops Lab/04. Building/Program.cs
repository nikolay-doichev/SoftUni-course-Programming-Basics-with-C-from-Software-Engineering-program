using System;

namespace _04._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloores = int.Parse(Console.ReadLine());
            int numberOfRooms = int.Parse(Console.ReadLine());

            for (int i = numberOfFloores; i >= 1; i--)
            {
                for (int j = 0; j < numberOfRooms; j++)
                {
                    if (i == numberOfFloores)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i%2!=0)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"O{i}{j} ");
                    }                 
                    
                }
                Console.WriteLine();
            }
        }
    }
}
