using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        string shop = "";
        if (day == "Sunday")
        {
            shop = "closed";
        }
        else
        {
            if (number >= 10 && number <= 18)
            {
                shop = "open";
            }
            else
            {
                shop = "closed";
            }
        }
        Console.WriteLine(shop);
    }
}