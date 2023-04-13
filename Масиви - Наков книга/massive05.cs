using System.Diagnostics;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;



/* Напишете програма,
която намира максималната редица от последова­телни нараст­ващи елементи в масив.
Пример: {3, 2, 3, 4, 2, 2, 4} à {2, 3, 4}. */

namespace c_
{
    public class OOP1
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());

            int[] arr = new int[lenght];
            int equals = 1;
            int bestEquals = 1;
            int bestStart = 0;
            int lastElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                // int.parse може да се премахне за да работи и със стрингове
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    equals++;
                    if (equals > bestEquals)
                    {
                        bestEquals = equals;
                        lastElement = i + 1;
                        bestStart = lastElement - bestEquals + 1;
                    }
                }
                else
                {
                    equals = 1;
                }
            }
            for (int i = bestStart; i < bestEquals + bestStart; i++)
            {
                System.Console.WriteLine($"{arr[i]}");
            }
        }
    }
}