using System;

namespace c_
{
    public class Tasks
    {
        static void Main()
        {
            string studentName = Console.ReadLine();
            double grades = 0;
            bool hasFailed = false;
            bool hasGraduated = true;

            int year = 1;
            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                grades += grade;

                if (grade < 4)
                {
                    if (hasFailed)
                    {
                        System.Console.WriteLine($"{studentName} has been excluded at {year} grade");
                        hasGraduated = false;
                        break;
                    }
                    hasFailed = true;
                    continue;
                }
                year++;
            }
            if (hasGraduated)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {(grades / 12):f2}");
            }


        }
    }
}