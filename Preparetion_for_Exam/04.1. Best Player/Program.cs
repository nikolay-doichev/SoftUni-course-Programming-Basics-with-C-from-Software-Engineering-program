using System;

namespace _04._1._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxGoals = int.MinValue;
            string bestPlayer = string.Empty;

            while (true)
            {
                string footballPlayer = Console.ReadLine();
                if (footballPlayer == "END")
                {
                    if (maxGoals >= 3)
                    {
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        Console.WriteLine($"He has scored {maxGoals} goals.");
                        break;
                    }
                }

                int goals = int.Parse(Console.ReadLine());
                if (goals>=10)
                {
                    Console.WriteLine($"{footballPlayer} is the best player!");
                    Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
                    break;
                }
                
                if (goals>maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = footballPlayer;
                }

            }
        }
    }
}
