using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;


namespace c_
{
    public class OOP1
    {
        static void Main()
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                System.Console.WriteLine("Enter the score:");
                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    System.Console.WriteLine("==================================");
                    double average = (double)total / (double)(count);
                    System.Console.WriteLine($"Average:{average}");
                    Console.ReadKey();

                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        System.Console.WriteLine("Please enter a value between 1 and 20!");
                        System.Console.WriteLine("If you want to finish adding scores, enter '-1'");
                    }
                    continue;
                }
                count++;
            }
        }
    }
}