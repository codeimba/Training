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
            int arrLenght = int.Parse(Console.ReadLine());
            int arrLenght2 = int.Parse(Console.ReadLine());
            string[] arr1 = new string[arrLenght];
            string[] arr2 = new string[arrLenght2];

            bool equal = arr1.SequenceEqual(arr2);

            Console.WriteLine(
            "The lists {0} equal.",
            equal ? "are" : "are not");
        }

    }
}