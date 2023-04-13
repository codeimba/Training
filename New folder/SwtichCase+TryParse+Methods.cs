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
            bool valid = false;
            string inputValueTypes;

            System.Console.WriteLine("Enter a value :");
            string inputValue = Console.ReadLine();

            System.Console.WriteLine("Select the Data type to validate the input you have entered");
            System.Console.WriteLine("Press 1 for String");
            System.Console.WriteLine("Press 2 for Integer");
            System.Console.WriteLine("Press 3 for Boolean");

            System.Console.Write("Enter :");
            int inputType = int.Parse(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    valid = isAllAlphabetic(inputValue);
                    inputValueTypes = "String";
                    break;
                case 2:
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueTypes = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueTypes = "Boolean";
                    break;
                default:
                    inputValueTypes = "unknown";
                    System.Console.WriteLine("Not able to detect the input type, something went wrong");
                    break;
            }
            System.Console.WriteLine($"You have entered a value: {inputValue}");
            if (valid)
            {
                System.Console.WriteLine($"It is valid. Type: {inputValueTypes}");
            }
            else
            {
                System.Console.WriteLine($"It is invalid. Type: {inputValueTypes}");
            }
        }

        static bool isAllAlphabetic(string value)
        {
            foreach (char item in value)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }

    }
}