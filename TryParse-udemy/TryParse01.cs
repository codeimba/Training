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
            string numberAsText = Console.ReadLine();
            float parsedValue;

            bool success = float.TryParse(numberAsText, out parsedValue);

            try
            {
                parsedValue = float.Parse(numberAsText);
            }
            catch (System.Exception error)
            {
                System.Console.WriteLine($"Invalid type entered {error.Message}.");
                throw;
            }

            if (success)
            {
                System.Console.WriteLine($"Parsing successful : {parsedValue}");
            }
            else
            {
                System.Console.WriteLine("Parsing failed");
            }
            Console.ReadKey();
        }
    }
}