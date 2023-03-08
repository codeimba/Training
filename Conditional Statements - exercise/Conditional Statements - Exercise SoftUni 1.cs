using System;

public class Program
{
    public static void Main()
    {
        // входни данни от потребителя
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        // сбор на секундите
        int totalTime = firstTime + secondTime + thirdTime;

        // изчисление на секунди и минут
        int minutes = totalTime / 60;
        int seconds = totalTime % 60;

        if (seconds < 10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}