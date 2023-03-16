using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            int numbPaintedEggs = int.Parse(Console.ReadLine());
            int greenEggs = 0;
            int redEggs = 0;
            int blueEggs = 0;
            int orangeEggs = 0;

            for (int i = 0; i < numbPaintedEggs; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    redEggs++;
                }
                else if (color == "orange")
                {
                    orangeEggs++;
                }
                else if (color == "blue")
                {
                    blueEggs++;
                }
                else
                {
                    greenEggs++;
                }
            }
            System.Console.WriteLine($"Red eggs: {redEggs}");
            System.Console.WriteLine($"Orange eggs: {orangeEggs}");
            System.Console.WriteLine($"Blue eggs: {blueEggs}");
            System.Console.WriteLine($"Green eggs: {greenEggs}");
            if (greenEggs > blueEggs && greenEggs > orangeEggs && greenEggs > redEggs)
            {
                System.Console.WriteLine($"Max eggs: {greenEggs} -> green");
            }
            else if (orangeEggs > blueEggs && orangeEggs > greenEggs && orangeEggs > redEggs)
            {
                System.Console.WriteLine($"Max eggs: {orangeEggs} -> orange");
            }
            else if (redEggs > blueEggs && redEggs > orangeEggs && redEggs > greenEggs)
            {
                System.Console.WriteLine($"Max eggs: {redEggs} -> red");
            }
            else
            {
                System.Console.WriteLine($"Max eggs: {blueEggs} -> blue");
            }

        }
    }
}