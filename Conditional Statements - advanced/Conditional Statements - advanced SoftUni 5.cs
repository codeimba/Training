using System;

public class Program
{
    public static void Main()
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0;

        if (product == "coffee")
        {
            if (city == "Sofia")
            {
                price = quantity * 0.50;
            }
            else if (city == "Plovdiv")
            {
                price = quantity * 0.40;
            }
            else
            {
                price = quantity * 0.45;
            }
        }
        else if (product == "water")
        {
            if (city == "Sofia")
            {
                price = quantity * 0.80;
            }
            else
            {
                price = quantity * 0.70;
            }
        }
        else if (product == "beer")
        {
            if (city == "Sofia")
            {
                price = quantity * 1.20;
            }
            else if (city == "Plovdiv")
            {
                price = quantity * 1.15;
            }
            else
            {
                price = quantity * 1.10;
            }
        }
        else if (product == "sweets")
        {
            if (city == "Sofia")
            {
                price = quantity * 1.45;
            }
            else if (city == "Plovdiv")
            {
                price = quantity * 1.30;
            }
            else
            {
                price = quantity * 1.35;
            }
        }
        else
        {
            if (city == "Sofia")
            {
                price = quantity * 1.60;
            }
            else if (city == "Plovdiv")
            {
                price = quantity * 1.50;
            }
            else
            {
                price = quantity * 1.55;
            }
        }
        Console.WriteLine(price);
    }
}