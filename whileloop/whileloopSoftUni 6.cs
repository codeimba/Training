using System;

namespace c_
{
    public class Tasks
    {
        static void Main()
        {
            int maxNumber = int.MinValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }

                int currentNumber = int.Parse(input);
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            System.Console.WriteLine(maxNumber);
        }
    }
}