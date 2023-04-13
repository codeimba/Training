using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class TheMain
    {
        public static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> bestNumbers = new List<int>();

            for (var i = 0; i < arrayOne.Length; i++)
            {
                //int sum = arrayOne.Sum();
                int currentNum = arrayOne[i];
                int newBestNumber = int.MinValue;
                if (currentNum > arrayOne.Average())
                {
                    newBestNumber = currentNum;
                    bestNumbers.Add(newBestNumber);
                }
            }

            if (bestNumbers.Count < 0)
            {
                System.Console.WriteLine("No");
            }

            System.Console.WriteLine(string.Join(" ",
            bestNumbers.OrderByDescending(x => x).Take(5)));

            Console.ReadKey();

        }
    }
}