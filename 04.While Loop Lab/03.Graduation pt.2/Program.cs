using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace Graduation
    {
        class Program
        {
            static void Main(string[] args)
            {
                string nameOfStudent = Console.ReadLine();
                double grades = 1;
                double sum = 0;

                while (grades <= 12)
                {
                    double grade = double.Parse(Console.ReadLine());
                    if (grade >= 4.00)
                    {
                        sum += grade;
                        grades++;
                    }
                    else if (grade<4)
                    {
                        ++grades;
                    }
                    else if (grade<4)
                    {
                        Console.WriteLine($"{nameOfStudent} has been excluded at {grades} grade");
                    }
                }
                double average = sum / 12;
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {average:F2}");
            }
        }
    }

}
   
