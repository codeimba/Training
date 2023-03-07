using System;

namespace c_
{
    public class Tasks
    {
        static void Main()
        {
            int initualNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                int secondaryNumber = int.Parse(Console.ReadLine());
                sum += secondaryNumber;

                if (sum >= initualNumber)
                {
                    System.Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}