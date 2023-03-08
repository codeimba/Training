using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }

                int currentNumber = int.Parse(input);
                if (currentNumber < maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            System.Console.WriteLine(maxNumber);
        }
    }
}