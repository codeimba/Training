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
            int[] arr1 = new int[20];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i * 5;
            }
            System.Console.WriteLine(string.Join(" ", arr1));
        }

    }
}