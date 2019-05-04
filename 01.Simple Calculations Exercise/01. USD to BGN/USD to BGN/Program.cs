using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double USDrate = 1.79549;
            double result = USD * USDrate;
            Console.WriteLine($"{result:f2} BGN");
           
        }
    }
}
