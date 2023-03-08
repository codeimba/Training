using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n;i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += element;
                }
                else
                {
                    oddSum += element;
                }
            }
            if (evenSum == oddSum)
            {
                System.Console.WriteLine("Yes");
                System.Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                var difference = Math.Abs(oddSum - evenSum);
                System.Console.WriteLine("No");
                System.Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}