using System;

public class Program
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        if (number >= -100 && number <= 100 && number != 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}