using System.Collections;
using System.Numerics;
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
            System.Console.WriteLine(Solution());
            Console.ReadKey();
        }

        public static string Solution()
        {
            int number = 170;
            List<int> numberList = new List<int>();
            for (int i = 100; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    numberList.Add(i);
                }
            }
            return string.Join(" ", numberList);
        }
    }
}