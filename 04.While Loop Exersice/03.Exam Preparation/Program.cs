using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFailers = int.Parse(Console.ReadLine());
            int fail = 0;
            int numberOfExam = 0;
            double totalGrade = 0;
            double averageGrade = 0;
            string lastproblem = string.Empty;
            
            while (true)
            {
                string nameOfExam = Console.ReadLine();
                
                
                if (nameOfExam == "Enough")
                {
                    averageGrade = totalGrade / numberOfExam;
                    Console.WriteLine($"Average score: {averageGrade:F2}");
                    Console.WriteLine($"Number of problems: {numberOfExam}");
                    Console.WriteLine($"Last problem: {lastproblem}");
                    break;
                }
                int examGrade = int.Parse(Console.ReadLine());

                if (examGrade<=4)
                {
                    fail++;
                }
                if (numberFailers==fail)
                {
                    Console.WriteLine($"You need a break, {fail} poor grades.");
                    break;
                }
                
                numberOfExam++;
                lastproblem = nameOfExam;
                totalGrade += examGrade;
            }
           
        }
    }
}
