using System;

public class Program
{
    public static void Main()
    {
        // входни данни 
        double budget = double.Parse(Console.ReadLine());
        double numbStatists = double.Parse(Console.ReadLine());
        double priceUniform = double.Parse(Console.ReadLine());

        // цени за декор и отсъпка за облеклото при условие
        double decorPrice = budget * 0.10;
        double priceStatistsUnifor = numbStatists * priceUniform;
        if (numbStatists >= 150)            // може да гръмне грешка за "=" (да се премахне)
        {
            priceStatistsUnifor = priceStatistsUnifor - (priceStatistsUnifor * 0.10);
        }
        double wholeSum = decorPrice + priceStatistsUnifor;
        if (budget >= wholeSum)
        {
            double newSum = budget - wholeSum;
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {String.Format("{0:0.00}", newSum)} leva left.");
        }
        else
        {
            double moneyNeeded = wholeSum - budget;
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {String.Format("{0:0.00}", moneyNeeded)} leva more.");
        }
    }
}