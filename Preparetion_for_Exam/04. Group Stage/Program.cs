using System;

namespace _04._Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int counter = 0;
            int difference = 0;
            int points = 0;
            
            while (counter<games)
            {
                int scoredGoals = int.Parse(Console.ReadLine());
                int recievedGoals = int.Parse(Console.ReadLine());

                if (scoredGoals>recievedGoals)
                {
                    points += 3;
                }
                else if (scoredGoals==recievedGoals)
                {
                    points += 1;
                }
                difference += scoredGoals - recievedGoals;

                counter++;
            }
            if (difference>=0)
            {
                Console.WriteLine($"{team} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {difference}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {difference}.");
            }
        }
    }
}
