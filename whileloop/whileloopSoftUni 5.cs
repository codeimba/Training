using System;

namespace c_
{
    public class Tasks
    {
        static void Main()
        {
            double balance = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double income = double.Parse(input);
                if (income < 0)
                {
                    System.Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += income;
                System.Console.WriteLine($"Increase: {income:f2}");
            }
            System.Console.WriteLine($"Total: {balance:f2}");
        }
    }
}