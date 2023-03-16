using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            double timeForFilming = int.Parse(Console.ReadLine());
            double sceneNum = int.Parse(Console.ReadLine());
            double timePerScene = int.Parse(Console.ReadLine());

            double terainSetUp = timeForFilming - (timeForFilming * 0.15);
            double sumForTimeFilming = 0;

            for (int i = 0; i < sceneNum; i++)
            {
                sumForTimeFilming += timePerScene;
                if ((timeForFilming - terainSetUp) < sumForTimeFilming)
                {
                    double neededTime = Math.Abs(timeForFilming - terainSetUp - sumForTimeFilming);
                    System.Console.WriteLine($"Time is up! To complete the movie you need {neededTime} minutes.");
                    break;
                }
                else
                {
                    double timeLeft = timeForFilming - terainSetUp - sumForTimeFilming;
                    System.Console.WriteLine($"You managed to finish the movie on time! You have {timeLeft} minutes left!");
                }
                Console.ReadKey();
            }
        }
    }
}