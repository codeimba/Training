using System;

public class Program
{
    public static void Main()
    {
        string fruit = Console.ReadLine();
        string day = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        double result = 0;

        if (fruit == "banana")
        {
            if (day == "Saturday" || day == "Sunday")
            {
                result = 2.70 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                result = 2.50 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (fruit == "apple")
        {
            if (day == "Saturday" || day == "Sunday")
            {
                result = 1.25 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                result = 1.20 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (fruit == "orange")
        {
            if (day == "Saturday" || day == "Sunday")
            {
                result = 0.90 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                result = 0.85 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (fruit == "grapefruit")
        {
            if (day == "Saturday" || day == "Sunday")
            {
                result = 1.60 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                result = 1.45 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (fruit == "kiwi")
        {
            if (day == "Saturday" || day == "Sunday")
            {
                result = 3.00 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                result = 2.70 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (fruit == "pineapple")
        {
            if (day == "Saturday" || day == "Sunday")
            {
                result = 5.60 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                result = 5.50 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (fruit == "grapes")
        {
            if (day == "Saturday" || day == "Sunday")
            {
                result = 4.20 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                result = 3.85 * quantity;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}