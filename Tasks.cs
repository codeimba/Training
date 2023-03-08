using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var min = -2147483647;
        var max = 2147483647;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > min)
            {
                max = input;
            }
            else
            {
                min = input;
            }
        }
        System.Console.WriteLine($"Max number: {max}");
        System.Console.WriteLine($"Min number: {min}");
    }
}