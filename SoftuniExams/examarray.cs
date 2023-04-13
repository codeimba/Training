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
            int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            string input = string.Empty;
            int indexOne = 0;
            int indexTwo = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                string exercise = command[0];
                if (command.Length > 1)
                {
                    indexOne = int.Parse(command[1]);
                    indexTwo = int.Parse(command[2]);
                };
                if (exercise == "swap")
                {
                    (arrayOne[indexOne], arrayOne[indexTwo]) = (arrayOne[indexTwo], arrayOne[indexOne]);
                }
                else if (exercise == "multiply")
                {
                    arrayOne[indexOne] = arrayOne[indexOne] * arrayOne[indexTwo];
                }
                else if (exercise == "decrease")
                {
                    for (var i = 0; i < arrayOne.Length; i++)
                    {
                        arrayOne[i] -= 1;
                    }
                }
                else
                {
                    System.Console.WriteLine("Wrong command! Try again.");
                }
            }
            System.Console.WriteLine(string.Join(", ", arrayOne));
        }
    }
}