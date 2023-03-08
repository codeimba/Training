using System;

public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        double episodeDuration = double.Parse(Console.ReadLine());
        double breakDuration = double.Parse(Console.ReadLine());


        double lunchDuration = breakDuration / 8;
        double restDuration = breakDuration / 4;

        double remainingTime = breakDuration - lunchDuration - restDuration;
        if (remainingTime >= episodeDuration)
        {
            double timeAfterEpisode = remainingTime - episodeDuration;
            Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeAfterEpisode)} minutes free time.");
        }
        else
        {
            double timeNeeded = episodeDuration - remainingTime;
            Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeNeeded)} more minutes.");
        }
    }
}