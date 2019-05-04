using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int daysForLearning = int.Parse(Console.ReadLine());

            double stepsForADay = Math.Ceiling(((steps / daysForLearning) / steps)*100);
            double percentForADancer = stepsForADay / dancers;
            
            if (stepsForADay<=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentForADancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required" +
                    $" {percentForADancer:F2}% steps to be learned per day.");
            }
            
            
        }
    }
}
