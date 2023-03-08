using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            leftSum += int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            rightSum += int.Parse(Console.ReadLine());
        }
        if (leftSum == rightSum)
        {
            System.Console.WriteLine("Yes, sum = " + leftSum);
        }
        else
        {
            int difference = Math.Abs(rightSum - leftSum);
            System.Console.WriteLine("No, diff = " + difference);
        }
    }
}