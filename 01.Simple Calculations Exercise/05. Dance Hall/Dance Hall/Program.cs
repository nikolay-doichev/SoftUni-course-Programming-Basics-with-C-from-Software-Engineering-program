using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthOfTheHall = double.Parse(Console.ReadLine())*100;
            double widthOfTheHall = double.Parse(Console.ReadLine())*100;
            double wardrobeSide = double.Parse(Console.ReadLine())*100;
            double totalAreaoftheHall = lengthOfTheHall * widthOfTheHall;
            double areaofthewardrobe = wardrobeSide * wardrobeSide;
            double areaofbench = totalAreaoftheHall / 10;
            double freeSpace = totalAreaoftheHall - (areaofbench + areaofthewardrobe);
            double dancerSpace = 40 + 7000;
            double dancers = freeSpace / dancerSpace;
            Console.WriteLine(Math.Floor(dancers));
            
        }
    }
}
