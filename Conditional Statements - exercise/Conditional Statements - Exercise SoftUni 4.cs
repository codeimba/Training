using System;

public class Program
{
    public static void Main()
    {
        // цени на играчките
        double puzzle = 2.60;
        double talkingDoll = 3;
        double stuffedBear = 4.10;
        double minion = 8.20;
        double toyTruck = 2;

        // входни данни
        double vacationPrice = double.Parse(Console.ReadLine());
        double numbPuzzle = double.Parse(Console.ReadLine());
        double numbTalkingDoll = double.Parse(Console.ReadLine());
        double numbStuffedBear = double.Parse(Console.ReadLine());
        double numbMinion = double.Parse(Console.ReadLine());
        double numbToyTruck = double.Parse(Console.ReadLine());

        // цени на играчките според количеството въведено от потребителя
        double pricePuzzle = numbPuzzle * puzzle;
        double priceTalkingDoll = numbTalkingDoll * talkingDoll;
        double priceStuffedBear = numbStuffedBear * stuffedBear;
        double priceMinion = numbMinion * minion;
        double priceToyTruck = numbToyTruck * toyTruck;

        //цена на общата поръчка
        double wholePrice = pricePuzzle + priceTalkingDoll + priceStuffedBear + priceMinion + priceToyTruck;

        // общ брой на поръчаната стока
        double numbCount = numbPuzzle + numbTalkingDoll + numbStuffedBear + numbMinion + numbToyTruck;
        if (numbCount >= 50)
        {
            wholePrice = wholePrice - (wholePrice * 0.25);
        }
        else
        {
            wholePrice = wholePrice;
        }

        double rentPrice = wholePrice * 0.10;

        double newPrice = wholePrice - rentPrice;
        if (newPrice >= vacationPrice)
        {
            double priceAfterPayment = newPrice - vacationPrice;
            Console.WriteLine($"Yes! {String.Format("{0:0.00}", priceAfterPayment)} lv left.");
        }
        else
        {
            double neededMoney = vacationPrice - newPrice;
            Console.WriteLine($"Not enough money! {String.Format("{0:0.00}", neededMoney)} lv needed.");
        }
    }
}