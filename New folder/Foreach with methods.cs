using System.Globalization;
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
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);
        }

        public static void GetEven(int[] Array)
        {
            foreach (int element in Array)
            {
                if (element % 2 == 0)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public static void GetOdd(int[] Array)
        {
            foreach (int element in Array)
            {
                if (element % 2 != 0)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}