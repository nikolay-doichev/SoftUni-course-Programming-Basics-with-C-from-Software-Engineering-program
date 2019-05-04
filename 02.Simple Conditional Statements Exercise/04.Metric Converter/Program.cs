using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numForConvert = double.Parse(Console.ReadLine());
            string incomeUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            double firstunit = 0;
            double m = 1;
            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double @in = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;
            if (incomeUnit == "m")
            {
                firstunit = numForConvert / m;
            }
            else if (incomeUnit == "mm")
            {
                firstunit = numForConvert / mm;
            }
            else if (incomeUnit == "cm")
            {
                firstunit = numForConvert / cm;
            }
            else if (incomeUnit == "mi")
            {
                firstunit = numForConvert / mi;
            }
            else if (incomeUnit == "in")
            {
                firstunit = numForConvert / @in;
            }
            else if (incomeUnit == "km")
            {
                firstunit = numForConvert / km;
            }
            else if (incomeUnit == "ft")
            {
                firstunit = numForConvert / ft;
            }
            else if (incomeUnit == "yd")
            {
                firstunit = numForConvert / yd;
            }
            double result = 0;
            if (outputUnit == "m")
            {
                result = firstunit * m;
            }
            else if (outputUnit=="mm")
            {
                result = firstunit * mm;
            }
            else if (outputUnit=="cm")
            {
                result=firstunit*cm;
            }
            else if (outputUnit=="mi")
            {
                result = firstunit * mi;
            }
            else if (outputUnit=="in")
            {
                result = firstunit * @in;
            }
            else if (outputUnit=="km")
            {
                result = firstunit * km;
            }
            else if (outputUnit=="ft")
            {
                result = firstunit * ft;
            }
            else if (outputUnit=="yd")
            {
                result = firstunit * yd;
            }
            Console.WriteLine($"{result:f8}");
        }
    }
}
