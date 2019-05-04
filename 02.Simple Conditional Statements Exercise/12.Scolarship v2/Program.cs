using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarship_v2
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

            if (averageGrade < 4.5 )
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (averageGrade>=4.5 && averageGrade<5.5 && incomeInBgn <= minSalary)
            {                
               Console.WriteLine($"You get a Social scholarship {Math.Floor(socialSalary)} BGN");              
            }
            else if (averageGrade< 5.5 && incomeInBgn>minSalary)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else 
            {
                if (incomeInBgn<=minSalary)
                {
                    if (scolarShip>socialSalary)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scolarShip)} BGN ");
                    }
                    else 
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialSalary)} BGN");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scolarShip)} BGN ");
                }
                
            }
        }
    }
}
