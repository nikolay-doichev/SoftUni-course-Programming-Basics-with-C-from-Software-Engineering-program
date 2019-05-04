using System;

namespace Graduation_pt._2_ver._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            double grades = 1;
            double sum = 0;

            while (grades<=12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    grades++;
                }
                else if (grade < 4)
                {

                    if (grade < 4)
                    {
                        break;
                    } 
                      
                    else if (grade>=4)
                    {
                        sum += grade;                        
                    }
                }
                
            }
            if (grades>=12)
            {
                double average = sum / 12;
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {average:F2}");
            }
            else
            {
                Console.WriteLine($"{nameOfStudent} has been excluded at {grades} grade");
            }
        }
    }
}
