using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArraival = int.Parse(Console.ReadLine());
            int minutesArraival = int.Parse(Console.ReadLine());

            int examTimeinMin = (hourExam * 60) + minutesExam;
            int studentTimeInMin = (hourArraival * 60) + minutesArraival;
            double minutesDifference = studentTimeInMin - examTimeinMin;
            double secondDiff = examTimeinMin - studentTimeInMin;

            if (minutesDifference <= 59 && minutesDifference > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{minutesDifference} minutes after the start");
            }
            else if (minutesDifference >= 60)
            {
                double hour = minutesDifference / 60;
                double minutes = minutesDifference % 60;
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Floor(hour)}:{minutes:00} hours after the start");
            }
            else if (secondDiff == 0)
            {
                Console.WriteLine("On time");
            }
            else if (secondDiff <= 30 && secondDiff > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{secondDiff} minutes before the start");
            }
            else if (secondDiff > 30 && secondDiff < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{secondDiff} minutes before the start");
            }
            else if (secondDiff >= 60)
            {
                double hour = secondDiff / 60;
                double minutes = secondDiff % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{Math.Floor(hour)}:{minutes:00} hours before the start");
            }


        }
    }
}
