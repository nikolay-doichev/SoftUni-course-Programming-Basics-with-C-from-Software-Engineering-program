using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine())*0.01;
            double volume = length * width * height;
            double waterNeedToFill = volume * 0.001;
            double waterNeedToFillWithoutDecoration = waterNeedToFill * (1 - percent);
            Console.WriteLine($"{waterNeedToFillWithoutDecoration:F3}");
        }
    }
}
