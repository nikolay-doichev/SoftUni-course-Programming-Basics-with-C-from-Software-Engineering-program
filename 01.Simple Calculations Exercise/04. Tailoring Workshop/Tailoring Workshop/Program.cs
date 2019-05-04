using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbeRoFtables = int.Parse(Console.ReadLine());
            double daljina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double totalareaofCovers = numbeRoFtables * (shirochina + 2 * 0.30) * (daljina + 2 * 0.3);
            double areaofkare = daljina / 2;
            double totalAreaofKare = numbeRoFtables * areaofkare * areaofkare;
            double totalUSD = totalareaofCovers * 7 + totalAreaofKare * 9;
            double totalBGN = totalUSD * 1.85;
            Console.WriteLine($"{totalUSD:f2} USD");
            Console.WriteLine($"{totalBGN:f2} BGN");
        }
    }
}
