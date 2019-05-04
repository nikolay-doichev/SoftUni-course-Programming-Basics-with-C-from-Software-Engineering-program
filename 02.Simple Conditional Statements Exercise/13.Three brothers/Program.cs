using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firsTBrother = double.Parse(Console.ReadLine());
            double seconDBrother = double.Parse(Console.ReadLine());
            double thirDBrother = double.Parse(Console.ReadLine());
            double fatheRTime = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / firsTBrother + 1 / seconDBrother + 1 / thirDBrother);
            double totalRelax = totalTime * 1.15;
            double leftTime = fatheRTime - totalRelax;
            Console.WriteLine($"Cleaning time: {totalRelax:f2}");
            if (leftTime > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(leftTime)} hours.");
            }
            else 
            {
                double needTime = totalRelax - fatheRTime;
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(needTime)} hours.");
            }
        }
    }
}
