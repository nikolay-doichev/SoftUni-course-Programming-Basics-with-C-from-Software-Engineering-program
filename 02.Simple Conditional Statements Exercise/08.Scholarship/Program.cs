using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeInBgn = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialSalary = Math.Floor(0.35 * minSalary);
            double scolarShip = Math.Floor(averageGrade * 25);

            if (averageGrade < 4.5)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (averageGrade < 5.5  && incomeInBgn > minSalary  )
            {
                Console.WriteLine($"You get a Social scholarship");
            }
            else
            {
                if (incomeInBgn<minSalary)
                {
                    if (scolarShip>socialSalary)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {scolarShip}");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship for excellent results {socialSalary");
                    }
                }
            }
            else
        	{
                Console.WriteLine($"You get a scholarship for excellent results {scolarShip} BGN");
            }

        }
    }
}
