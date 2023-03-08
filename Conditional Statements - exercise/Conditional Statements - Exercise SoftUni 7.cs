using System;

public class Program
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double numbVideoCards = double.Parse(Console.ReadLine());
        double numbProcessors = double.Parse(Console.ReadLine());
        double numbRam = double.Parse(Console.ReadLine());
        ;
        double videocardPrice = 250 * numbVideoCards;
        double proccessorPrice = (videocardPrice * 0.35) * numbProcessors;
        double ramPrice = (videocardPrice * 0.10) * numbRam;

        double wholeSum = videocardPrice + proccessorPrice + ramPrice;
        if (numbVideoCards > numbProcessors)
        {
            wholeSum = wholeSum - (wholeSum * 0.15);
        }
        else
        {
            wholeSum = wholeSum;
        }
        if (budget >= wholeSum)
        {
            double moneyLeft = budget - wholeSum;
            Console.WriteLine($"You have {moneyLeft:f2} leva left!");
        }
        else
        {
            double moneyNeeded = wholeSum - budget;
            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
        }
    }
}