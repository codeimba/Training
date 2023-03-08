using System;

public class Program
{
    public static void Main()
    {
        string city = Console.ReadLine();
        double number = double.Parse(Console.ReadLine());

        double result = 0;
        if (number >= 0 && number <= 500)
        {
            if (city == "Sofia")
            {
                result = number * 0.05;
            }
            else if (city == "Varna")
            {
                result = number * 0.045;
            }
            else if (city == "Plovdiv")
            {
                result = number * 0.055;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (number > 500 && number <= 1000)
        {
            if (city == "Sofia")
            {
                result = number * 0.07;
            }
            else if (city == "Varna")
            {
                result = number * 0.075;
            }
            else if (city == "Plovdiv")
            {
                result = number * 0.08;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (number > 1000 && number <= 10000)
        {
            if (city == "Sofia")
            {
                result = number * 0.08;
            }
            else if (city == "Varna")
            {
                result = number * 0.1;
            }
            else if (city == "Plovdiv")
            {
                result = number * 0.12;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (number > 10000)
        {
            if (city == "Sofia")
            {
                result = number * 0.12;
            }
            else if (city == "Varna")
            {
                result = number * 0.13;
            }
            else if (city == "Plovdiv")
            {
                result = number * 0.145;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (city != "Sofia" || city != "Varna" || city != "Plovdiv")
        {
            Console.WriteLine("error");
        }
        else if (number < 0)
        {
            Console.WriteLine("error");
        }
        if (result > 0)
        {
            Console.WriteLine("{0:f2}", result);
        }
    }
}