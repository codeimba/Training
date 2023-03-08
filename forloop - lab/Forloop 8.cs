using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > max)
            {
                max = input;
            }
            else if (input < min)
            {
                min = input;
            }
        }
        System.Console.WriteLine($"Max number: {max}");
        System.Console.WriteLine($"Min number: {min}");
    }
}