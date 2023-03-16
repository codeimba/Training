using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            double clientNumber = double.Parse(Console.ReadLine());

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double chocolateBunnyPrice = 7.00;
            string input = string.Empty;
            double sumForProducts = 0;
            double clientSum = 0;

            for (int i = 0; i < clientNumber; i++)
            {
                clientSum = 0;
                double productsCount = 0;
                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "Finish")
                    {
                        if (productsCount % 2 == 0)
                        {
                            clientSum -= clientSum * 0.20;
                        }
                        System.Console.WriteLine($"You purchased {productsCount} items for {clientSum:f2} leva.");
                        break;
                    }
                    else if (input == "basket")
                    {
                        productsCount++;
                        clientSum += basketPrice;
                    }
                    else if (input == "wreath")
                    {
                        productsCount++;
                        clientSum += wreathPrice;
                    }
                    else
                    {
                        productsCount++;
                        clientSum += chocolateBunnyPrice;
                    }
                }
                sumForProducts += clientSum;
            }
            double averageBill = sumForProducts / clientNumber;
            System.Console.WriteLine($"Average bill per client is: {averageBill:f2} leva.");
        }
    }
}