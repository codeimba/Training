using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int sleepingNights = int.Parse(Console.ReadLine());

            int allExpenses = 0;
            int pricePerNight = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    pricePerNight = 30;
                }
                else if (dates == "24-27")
                {
                    pricePerNight = 35;
                }
                else
                {
                    pricePerNight = 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    pricePerNight = 28;
                }
                else if (dates == "24-27")
                {
                    pricePerNight = 32;
                }
                else
                {
                    pricePerNight = 39;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    pricePerNight = 32;
                }
                else if (dates == "24-27")
                {
                    pricePerNight = 37;
                }
                else
                {
                    pricePerNight = 43;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid city.Choose between: France/Italy/Germany.");
            }
            allExpenses = pricePerNight * sleepingNights;
            System.Console.WriteLine($"Easter trip to {destination} : {allExpenses:f2} leva.");
        }
    }
}