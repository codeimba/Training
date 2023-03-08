using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        System.Console.WriteLine(sum);
    }
}