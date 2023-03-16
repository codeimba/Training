using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string bonus = string.Empty;
            double startingPoints = 301;
            double points = 0;
            int unsuccessfulHits = 0;
            int validShot = 0;

            while (true)
            {
                points = 0;
                bonus = Console.ReadLine();
                if (bonus == "Retire")
                {

                    System.Console.WriteLine($"{playerName} retired after {unsuccessfulHits} unsuccessful shots.");
                    break;
                }
                points = double.Parse(Console.ReadLine());

                if (bonus == "Double")
                {
                    points *= 2;
                }
                else if (bonus == "Triple")
                {
                    points *= 3;
                }
                if (points > startingPoints)
                {
                    unsuccessfulHits++;
                }
                else
                {
                    validShot++;
                    startingPoints -= points;
                    if (startingPoints == 0)
                    {
                        break;
                    }
                }

            }
            if (startingPoints == 0)
            {
                System.Console.WriteLine($"{playerName} won the leg with {validShot} shots.");
            }
        }
    }
}