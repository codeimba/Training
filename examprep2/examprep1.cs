using System;

public class Program
{
    public static void Main()
    {
        int easterBreadNum = int.Parse(Console.ReadLine());
        int eggBoxNum = int.Parse(Console.ReadLine());
        int biscuitsKilos = int.Parse(Console.ReadLine());

        /* double priceEasterBread = 3.20;
        double priceEggBox = 4.35;
        double priceBiscuitsPerKilo = 5.40;
        double priceEggPaint = 0.15; // per one egg 
        */

        double priceEasterBread = easterBreadNum * 3.20;
        double priceEggBox = eggBoxNum * 4.35;
        double priceBiscuitsPerKilo = biscuitsKilos * 5.40;
        double priceEggPaint = (eggBoxNum * 12) * 0.15;

        double wholeSum = priceBiscuitsPerKilo + priceEasterBread + priceEggBox + priceEggPaint;

        string newSum = wholeSum.ToString("0.0.0");

        System.Console.WriteLine(newSum);
    }
}