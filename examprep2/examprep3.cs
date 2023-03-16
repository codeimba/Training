using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            string contractYears = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string mobileNet = Console.ReadLine();
            int monthsNum = int.Parse(Console.ReadLine());

            double pricePerMonth = 0;
            double wholeSum = 0;
            double discount = 3.75;

            double priceMobilenet = 0;

            if (typeContract == "Small")
            {
                if (contractYears == "one")
                {
                    pricePerMonth = 9.98;
                }
                else if (contractYears == "two")
                {
                    pricePerMonth = 8.58;
                }
            }
            else if (typeContract == "Middle")
            {
                if (contractYears == "one")
                {
                    pricePerMonth = 18.99;
                }
                else if (contractYears == "two")
                {
                    pricePerMonth = 17.09;
                }
            }
            else if (typeContract == "Large")
            {
                if (contractYears == "one")
                {
                    pricePerMonth = 25.98;
                }
                else if (contractYears == "two")
                {
                    pricePerMonth = 23.59;
                }
            }
            else
            {
                if (contractYears == "one")
                {
                    pricePerMonth = 35.99;
                }
                else if (contractYears == "two")
                {
                    pricePerMonth = 31.79;
                }
            }
            if (mobileNet == "yes")
            {
                if (pricePerMonth <= 10.00)
                {
                    priceMobilenet = 5.50;
                }
                else if (pricePerMonth <= 30.00)
                {
                    priceMobilenet = 4.35;
                }
                else
                {
                    priceMobilenet = 3.85;
                }
                wholeSum = monthsNum * (pricePerMonth + priceMobilenet);
            }
            else
            {
                wholeSum = monthsNum * pricePerMonth;
            }
            if (contractYears == "two")
            {
                double newSum = wholeSum - ((wholeSum * discount) / 100);
                System.Console.WriteLine($"{newSum:f2} lv.");
            }
            else
            {
                System.Console.WriteLine($"{wholeSum:f2} lv.");
            }
        }
    }
}