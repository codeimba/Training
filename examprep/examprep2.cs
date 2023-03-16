using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            double timeForFilming = double.Parse(Console.ReadLine());
            double sceneNum = double.Parse(Console.ReadLine());
            double timePerScene = double.Parse(Console.ReadLine());

            double terainSetUp = timeForFilming * 0.15;
            double sumForTimeFilming = sceneNum * timePerScene;

            double timeAfterSetup = timeForFilming - terainSetUp;
            if (timeAfterSetup < sumForTimeFilming)
            {
                double neededTime = Math.Abs(timeAfterSetup - sumForTimeFilming);
                System.Console.WriteLine($"Time is up! To complete the movie you need {Math.Ceiling(neededTime)} minutes.");

            }
            else
            {
                double timeLeft = Math.Abs(timeAfterSetup - sumForTimeFilming);
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Ceiling(timeLeft)} minutes left!");
            }
        }
    }
}