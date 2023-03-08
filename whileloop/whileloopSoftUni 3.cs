using System;

namespace c_
{
    public class Tasks
    {
        static void Main()
        {
            int k = 1;
            int input = int.Parse(Console.ReadLine());

            while (k <= input)
            {
                System.Console.WriteLine(k);
                k = 2 * k + 1;
            }
        }
    }
}