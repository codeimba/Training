using System;

public class Program
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int timeAfterFifteen = minutes + 15;

        if (timeAfterFifteen > 59)
        {
            hours++;
            if (hours > 23)
            {
                hours = 0;
            }
            timeAfterFifteen = timeAfterFifteen - 60;

        }
        Console.WriteLine($"{hours}:{timeAfterFifteen:D2}");

    }
}