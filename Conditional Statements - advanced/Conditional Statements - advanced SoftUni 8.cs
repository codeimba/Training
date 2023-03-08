using System;

public class Program
{
    public static void Main()
    {
        string day = Console.ReadLine();
        int priceTicket = 0;

        if (day == "Monday" || day == "Tuesday" || day == "Friday")
        {
            priceTicket = 12;
        }
        else if (day == "Wednesday" || day == "Thursday")
        {
            priceTicket = 14;
        }
        else
        {
            priceTicket = 16;
        }
        Console.WriteLine(priceTicket);
    }
}