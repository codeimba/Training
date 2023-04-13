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
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int number);

            var result = success ? number <= 15 ? "It is too cold here" : number >= 16 && number <= 28 ? "it is ok" : "it is too hot here" : "Not a valid temperature";

            System.Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}